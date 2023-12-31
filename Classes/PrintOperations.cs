using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Globalization;

namespace POS_System.Classes
{
    internal class PrintOperations
    {
        public static string centeringText(string text, int spaceLenght)
        {
            string result = "";
            if (text.Length % 2 == 1)
            {
                for (int i = 0; i < (int)((spaceLenght - text.Length) / 2); i++)
                    result += " ";
                result += text;
                for (int i = 0; i < (int)((spaceLenght - text.Length) / 2); i++)
                    result += " ";
            }
            else
            {
                for (int i = 0; i < (int)((spaceLenght - text.Length) / 2); i++)
                    result += " ";
                result += text;
                for (int i = 0; i < (int)((spaceLenght - text.Length) / 2) + 1; i++)
                    result += " ";
            }
            return result;
        }

        public static string TextAlignLeft(string text, int spaceLenght)
        {
            string result = "";
                result += text;
                for (int i = 0; i < (spaceLenght - text.Length); i++)
                    result += " ";
            return result;
        }
        public static string TextAlignRight(string text, int spaceLenght)
        {
            string result = "";
            for (int i = 0; i < (spaceLenght - text.Length); i++)
                result += " ";
            result += text;
            return result;
        }
        public static string printCharacterAtLenght(char character, int lenght)
        {
            string result = "";
            for (int i = 0; i < lenght; i++)
                result += character;
            return result;
        }

        public static string PrintDataTable(int weight, string[] headers, string qry, SQLiteConnection con)
        {
            SQLiteCommand cmd = new SQLiteCommand(qry, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int totalHeadersLenght = 0;

            for (int i = 0; i < headers.Length; i++)
                totalHeadersLenght += headers[i].Length;

            if (weight < totalHeadersLenght)
                return "The width value must be greater than the length of all headings.\n";

            if (weight % headers.Length != 0)
                return "The width value must be exactly divided by the number of headers.\n";

            string result = "";
            int columnWeight = (int)(weight / headers.Length);
            foreach (string header in headers)
            {
                result += centeringText(header, columnWeight);
            }
            result += "\n" + printCharacterAtLenght('‾', weight) + "\n";

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if (dt.Rows[r][c].ToString().Length > columnWeight)
                    {
                        dt.Rows[r][c] = dt.Rows[r][c].ToString().Substring(0, columnWeight - 3) + "...";
                    }
                    result += centeringText(dt.Rows[r][c].ToString(), columnWeight);
                }
                result += "\n";
            }

            return result;
        }

        public static string PrintSaledProduct(int weight, string[] headers, string fromThisDate, string toThisDate, string currency, string qry, SQLiteConnection con)
        {
            SQLiteCommand cmd = new SQLiteCommand(qry, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int totalHeadersLenght = 0;

            for (int i = 0; i < headers.Length; i++)
                totalHeadersLenght += headers[i].Length;

            if (weight < totalHeadersLenght)
                return "The width value must be greater than the length of all headings.\n";

            if (weight % headers.Length != 0)
                return "The width value must be exactly divided by the number of headers.\n";

            string result = "";
            int columnWeight = (int)(weight / headers.Length);
            foreach (string header in headers)
            {
                if (header == "Product")
                    columnWeight = 25;
                result += centeringText(header, columnWeight);
                columnWeight = (int)(weight / headers.Length);
            }
            result += "\n" + printCharacterAtLenght('─', weight+25-columnWeight) + "\n";

            double totalEarnings = 0;
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    if(c == 3) // product name column
                        columnWeight = 25;

                    if (c == 6) // amount column
                        totalEarnings += double.Parse(dt.Rows[r][c].ToString());

                    if (dt.Rows[r][c].ToString().Length > columnWeight)
                        dt.Rows[r][c] = dt.Rows[r][c].ToString().Substring(0, columnWeight - 3) + "...";

                    if(c == 5 || c == 6 || c == 7 || c == 8 || c == 9)
                        result += centeringText(dt.Rows[r][c].ToString() + currency, columnWeight);
                    else
                        result += centeringText(dt.Rows[r][c].ToString(), columnWeight);

                    columnWeight = (int)(weight / headers.Length);
                }
                result += "\n";
            }
            result += "\n"+TextAlignRight($"FROM THIS DATE: {fromThisDate}, TO THIS DATE: {toThisDate}, TOTAL EARNINGS: {totalEarnings}{currency}", weight+25-columnWeight) + "\n";
            return result;
        }

        public static string generateReceipt(string companyName, string currency, string qry, SQLiteConnection con)
        {
            int weight = 47;
            string result = "";
            SQLiteCommand cmd = new SQLiteCommand(qry, con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string date = DateTime.ParseExact(dt.Rows[0]["date"].ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture).ToString("ddd dd.MM.yyyy", new CultureInfo("en-US"));
            result += "|" + printCharacterAtLenght('‾', weight - 2) + "|\n";
            result += "|" + centeringText(companyName, weight - 2) + "|\n";
            result += "|" + centeringText("RECEIPT", weight - 2) + "|\n";
            result += "|" + printCharacterAtLenght('─', weight - 2) + "|\n";
            result += "|" + centeringText($"{date} / {dt.Rows[0]["time"]}", weight - 2) + "|\n";
            result += "|" + centeringText($"Order Type: {dt.Rows[0]["orderType"]}", weight - 2) + "|\n";
            result += "|" + printCharacterAtLenght('─', weight - 2) + "|\n";
            result += "|Product               Qty    Price    Amount |\n";
            result += "|────────────────────  ─────  ───────  ───────|\n";
            foreach (DataRow row in dt.Rows)
            {
                string productName = row["pName"].ToString();
                string qty = row["qty"].ToString();
                string price = row["price"].ToString();
                string amount = row["amount"].ToString();

                if (productName.Length > 20)
                {
                    productName = productName.Substring(0, 17) + "...";
                }

                result += $"|{productName,-20}  {qty,-6} {price + currency,-8} {amount + currency,-7}|\n";
            }
            result += "|" + printCharacterAtLenght('─', weight - 2) + "|\n";
            result += "|           Received    Change      Total     |\n";
            result += "|           ──────────  ──────────  ──────────|\n";
            result += $"|           {dt.Rows[0]["received"].ToString() + currency,-10}  {dt.Rows[0]["change"].ToString() + currency,-10}  {dt.Rows[0]["total"].ToString() + currency,-10}|\n";
            result += "|" + printCharacterAtLenght('_', weight - 2) + "|";
            return result;
        }
    }
}
