namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var exPupil = new ExcelentPupil();
            var badPupil = new BadPupil();
            var goodPupil = new GoodPupil();

            var clasroom = new ClassRoom(exPupil, badPupil, goodPupil);
            clasroom.PrintInfo();
        }
    }
}
