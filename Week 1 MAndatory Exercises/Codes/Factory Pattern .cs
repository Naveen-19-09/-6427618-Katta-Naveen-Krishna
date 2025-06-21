using System;
namespace FactoryExample
{
    public abstract class Document
    {
        public abstract void Open();
    }
    public class WordDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Word document...");
        }
    }
    public class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening PDF document...");
        }
    }
    public class ExcelDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening Excel document...");
        }
    }
    public abstract class DocumentFactory
    {
        public abstract Document CreateDocument();
    }
    public class WordFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
    public class PdfFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PdfDocument();
        }
    }
    public class ExcelFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ExcelDocument();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter document type(word/pdf/excel): ");
            string input = Console.ReadLine().ToLower();

            DocumentFactory factory;

            switch (input)
            {
                case "word":
                    factory = new WordFactory();
                    break;
                case "pdf":
                    factory = new PdfFactory();
                    break;
                case "excel":
                    factory = new ExcelFactory();
                    break;
                default:
                    Console.WriteLine("Unknown document type.");
                    return;
            }

            Document document = factory.CreateDocument();
            document.Open();
        }
    }
}