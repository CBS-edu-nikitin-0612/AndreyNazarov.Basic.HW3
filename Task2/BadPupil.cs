using System;

namespace Task2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad study");
        }
        public override void Read()
        {
            Console.WriteLine("Bad read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad write");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad relax");
        }
    }
}
