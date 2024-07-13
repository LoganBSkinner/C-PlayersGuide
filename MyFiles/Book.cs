using System.Xml.Linq;

namespace Grades
{
    class Student
    {
        public string Name;
        public double Score;

        public Student(string aName, double aScore)
        {
            Name = aName;
            Score = aScore;
        }

        public bool PassedTest()
        {
            if (Score > 70)
            {
                return true;
            }

            else
            {
                return false;
            }
        }



    }
}