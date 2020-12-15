using OCP.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //IDocument document = new JsonDocument();
            //string resultReadDocument = ReadAllTextFromFile(document);
            //Console.WriteLine(resultReadDocument);
            string result = GenerateQuery();
        }

        private static string ReadAllTextFromFile(IDocument doc)
        {
            var sbd = new StringBuilder();
            for (int i = 0; i < doc.TotalPages(); i++)
            {
                sbd.Append(doc.ReadAllText(i));
            }
            return sbd.ToString();
        }

        private static string GenerateQuery()
        {
            QueryBuilder qb = new QueryBuilder();
            string query = qb.Select("id, name")
            .From("Product")
            .Where("price > 100")
            .And("isActive = 1")
            .And("isDeleted = 0")
            .GetQuery();

            return query;
        }
    }

    class QueryBuilder
    {
        private string Fields;
        private string TableName;
        private string Condition;
        private List<string> Conditions = new List<string>();
        private List<string> JoinConditions = new List<string>();
        private List<string> Joins = new List<string>();
        private string JoinCondition;

    public QueryBuilder Select(string fields)
        {
            Fields = fields;
            return this;
        }

        public QueryBuilder From(string tableName)
        {
            TableName = tableName;
            return this;
        }

        public QueryBuilder InnerJoin(string tableName)
        {
            Joins.Add(tableName);
            return this;
        }

        public QueryBuilder JoinOn(string condition)
        {
            JoinCondition = condition;
            return this;
        }

        public QueryBuilder JoinAnd(string condition)
        {
            JoinConditions.Add(condition);
            return this;
        }

        public QueryBuilder Where(string condition)
        {
            Condition = condition;
            return this;
        }

        public QueryBuilder And(string condition)
        {
            Conditions.Add(condition);
            return this;
        }

        public string GetQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT ");
            sb.Append(Fields);
            sb.Append(Environment.NewLine);
            sb.Append("FROM ");
            sb.Append(TableName);
            sb.Append(Environment.NewLine);
            sb.Append($"WHERE ");
            sb.Append(Condition);
            sb.Append(Environment.NewLine);
            foreach (var condition in Conditions)
            {
                sb.Append("AND ");
                sb.Append(condition);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    } 
}
