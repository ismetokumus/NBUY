namespace Proje08_Abstract
{
    abstract class Person//Eğer bir sınıf abstract ise yeni bir person oluşturamazsın.
    {
        public Person(string firstname,string lastName )
        {
            FirstName = firstname;  
            LastName = lastName;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Greeting()
        {
            Console.WriteLine("I am a person");
        }
        public abstract void Intro();//Soyut metod bu şekilde olur
        
    }
    class Student:Person
    {
        public Student(string firstname, string lastName,int studentNumber):base(firstname,lastName)
        {
            StudentNumber=studentNumber;
            Console.WriteLine("Student is created!");
        }
        public int StudentNumber { get; set; }
       
        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Student Number: {StudentNumber}");
        }
    }
    class Teacher:Person
    {
        public Teacher(string firstName,string lastName,string branch):base (firstName,lastName)
        {
            FirstName=firstName;   
            LastName=lastName;
            Branch = branch;
            Console.WriteLine("Teacher is created!");
        }
        public string Branch { get; set; }
        public void Teach()
        {
            Console.WriteLine("Hi, I am teaching!");

        }
        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Branch: {Branch}");
        }
    }
    class Writter:Person
    {
        public Writter(string firstName,string lastName ,string bookName):base(firstName,lastName)
        {
            BookName = bookName;
            Console.WriteLine("Writter is created!");
        }

        public string BookName { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Book Name: {BookName}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ayşen Umay", "Ergül", 101);
            student1.Greeting();
            student1.Intro();//İstemediğimiz halde Person daki ıntro çalışıyor

            Console.WriteLine();

            Teacher teacher1 = new Teacher("Maria","Cana","Fizik");
            teacher1.Greeting();
            teacher1.Intro();

            Console.WriteLine();

            Writter writter1 = new Writter("Math", "Haig", "Gece Yarısı Kütüphanesi");
            writter1.Greeting();
            writter1.Intro();
            
            Console.ReadLine();
        }
    }
}