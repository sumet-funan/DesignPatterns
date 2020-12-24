using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        private static string[] operations = { "=", "<>", "!=", ">", "<" };
        private static string _column = "siteBuId";
        private static string _parameterName = "@siteBuId";
        private static string _condition = $"{_column} = {_parameterName}";
        private static string _query = @"SELECT * FROM Product p
        WHERE p.name = @name
        AND p.price = @price";

        private static string _queryAdvance = @"SELECT * FROM Product p
        INNER JOIN Order o ON o.productId = p.productId
        INNER JOIN Customer c ON c.customerId = o.customerId
        WHERE p.productId = @productId
        AND c.customerId = @customerId";

        static void Main(string[] args)
        {
            string result = InsertConditionV1(_query);
            string resultAdvance = InsertConditionV1(_queryAdvance);
            Console.WriteLine(result);
        }

        private static string InsertConditionV1(string queryString)
        {
            StringBuilder sb = new StringBuilder();

            Query query = new Query();

            string previousWord = string.Empty;

            string[] splitQuery = queryString.Replace(" ", "|").Split('|');
            for (int i = 0; i < splitQuery.Length; i++)
            {
                if (string.IsNullOrEmpty(splitQuery[i]))
                {
                    continue;
                }

                if (previousWord.ToUpper() == "FROM")
                {
                    if (query != null)
                    {
                        if (string.IsNullOrEmpty(query.TableName))
                        {
                            query.TableName = splitQuery[i];
                            sb.Append(splitQuery[i]);
                            sb.Append(" ");
                        }
                        else
                        {
                            query.AliasName = splitQuery[i];
                            sb.Append(query.AliasName.Trim().Replace(" ", ""));
                            sb.Append(Environment.NewLine);
                            previousWord = "";
                        }
                    }
                    continue;
                }

                if (previousWord.ToUpper() == "WHERE")
                {
                    string mergeCondition = $"{query.AliasName.Trim().Replace(" ", "")}.{_condition}";
                    sb.Append(mergeCondition);
                    sb.Append(Environment.NewLine);
                    sb.Append($"AND {splitQuery[i]}");
                    previousWord = "";
                    continue;
                }

                if (previousWord.ToUpper() == "AND")
                {
                    sb.Append(splitQuery[i]);
                    sb.Append(" ");
                    previousWord = "";
                    continue;
                }

                if (splitQuery[i].ToUpper() == "SELECT")
                {
                    sb.Append(splitQuery[i].ToUpper());
                    sb.Append(Environment.NewLine);
                    continue;
                }
                else if (splitQuery[i].ToUpper() == "FROM")
                {
                    previousWord = splitQuery[i].ToUpper();
                    sb.Append(splitQuery[i].ToUpper());
                    sb.Append(" ");
                    continue;
                }
                else if (splitQuery[i].ToUpper() == "WHERE")
                {
                    previousWord = splitQuery[i].ToUpper();
                    sb.Append(splitQuery[i].ToUpper());
                    sb.Append(" ");
                    continue;
                }
                else if (splitQuery[i].ToUpper() == "AND")
                {
                    previousWord = splitQuery[i].ToUpper();
                    sb.Append(splitQuery[i].ToUpper());
                    sb.Append(" ");
                    continue;
                }
                else if (operations.Contains(splitQuery[i]))
                {
                    previousWord = splitQuery[i];
                    sb.Append(splitQuery[i]);
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(splitQuery[i].Trim().Replace(" ", ""));
                    sb.Append(Environment.NewLine);
                    previousWord = "";
                }
            }

            return sb.ToString();
        }
    }

    public class Query
    {
        public string AliasName { get; set; }
        public string TableName { get; set; }
    }
}
