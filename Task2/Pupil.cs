using System;

namespace Task2
{
    class Pupil
    {
        public virtual void Study()
        {
        }
        public virtual void Read()
        {
        }
        public virtual void Write()
        {
        }
        public virtual void Relax()
        {
        }
        public void PrintInfo()
        {
            Console.WriteLine(this.GetType());
            Read();
            Relax();
            Study();
            Write();
        }
    }
}
