using OCP.Services;
using System;
using System.Text;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IDocument document = new JsonDocument();
            string resultReadDocument = ReadAllTextFromFile(document);
            Console.WriteLine(resultReadDocument);
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
    }
}
