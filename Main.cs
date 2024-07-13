namespace Grades
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Student student1 = new Student("Patrick", 42);
            Student student2 = new Student("Spongebob", 97);

            Console.WriteLine(student1.PassedTest());
            Console.WriteLine(student2.PassedTest());
        }

    }

}
