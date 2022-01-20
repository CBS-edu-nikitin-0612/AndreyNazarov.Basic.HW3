﻿using System;

namespace Task4
{
    partial class Program
    {
        internal class DocumentWorker
        {
            public virtual void OpenDocument()
            {
                Console.WriteLine("Документ открыт");
            }
            public virtual void EditDocument()
            {
                Console.WriteLine("Редактирование документа доступно в версии Про");
            }
            public virtual void SaveDocument()
            {
                Console.WriteLine("Сохранение документа доступно в версии Про");
            }
        }
    }
}
