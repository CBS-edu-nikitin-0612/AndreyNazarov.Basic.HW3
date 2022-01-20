using System;

namespace Task4
{
    partial class Program
    {
        internal class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в новом формате");
            }
        }
    }
}
