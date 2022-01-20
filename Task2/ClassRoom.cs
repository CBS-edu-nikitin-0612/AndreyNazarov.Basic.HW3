namespace Task2
{
    class ClassRoom
    {
        Pupil pupil1;
        Pupil pupil2;
        Pupil pupil3;
        Pupil pupil4;
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3) : this(pupil1, pupil2)
        {
            this.pupil3 = pupil3;
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4) : this(pupil1, pupil2, pupil3)
        {
            this.pupil4 = pupil4;
        }

        public void PrintInfo()
        {
            if (pupil1 != null)
            {
                pupil1.PrintInfo();

            }
            if (pupil2 != null)
            {
                pupil2.PrintInfo();
            }
            if (pupil3 != null)
            {
                pupil3.PrintInfo();
            }
            if (pupil4 != null)
            {
                pupil4.PrintInfo();
            }
        }
    }
}
