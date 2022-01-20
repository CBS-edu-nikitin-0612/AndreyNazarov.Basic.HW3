using System;

namespace Task4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input KEY");
            var key = Console.ReadLine();
            DocumentWorker documentWorker;

            switch (key)
            {
                case "pro":
                    documentWorker = new ProDocumentWorker();
                    break;
                case "exp":
                    documentWorker = new ExpertDocumentWorker();
                    break;
                default:
                    documentWorker = new DocumentWorker();
                    break;
            }
            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
