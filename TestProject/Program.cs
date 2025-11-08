using ThirdPractical_StudentLibrary;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        Student student2 = new Student("Jane Doe", 18);

        student1.DisplayInfo();
        student2.DisplayInfo();

        student1.GetOlder();
        student2.GetOlder();

        student1.DisplayInfo();
        student2.DisplayInfo();
    }
}