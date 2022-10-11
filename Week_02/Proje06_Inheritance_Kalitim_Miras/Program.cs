namespace Proje06_Inheritance_Kalitim_Miras
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void Intro()//metod "public void Intro()"bu şekilde ezilmez
                                   //public virtual void Intro() bu şekilde override edilmesine izin verir
        {
            Console.WriteLine($"FirstName: {this.FirstName}, LastName: {this.LastName}");

        }
    }
    class Writer:Person
    {
        public string BookName { get; set; }
    }
    class Teacher:Person
    {
        public string Branch { get; set; }
    }

    class Student: Person//başka bir sınıfta olan bilgileri almak için Student:Person bu şekilde yazıyoruz.
                        //Bir class sadece bir klastan miras alabilir.
                        //Bir class istenildiği kadar başka class a miras verebilir.
    {
        public int StudentNumber { get; set; }
        public override void Intro()//Bu metodun miras alınan sınıftaki versiyonu ezip, yok edip bu metodu kabul eder.
        {
            Console.WriteLine($"FirstName: {this.FirstName}, LastName: {this.LastName}, Student Number: {this.StudentNumber}");

        }

    }
    class a
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
    }
    class b:a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }
    }
    class c:b
    {
        public int MyProperty5 { get; set; }
        public int MyProperty6 { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();   
            Student student = new Student();
            student.FirstName = "Kemal";
            student.LastName = "Kapıcı";
            student.StudentNumber = 125;
            student.Intro();

            //Bir teacher tanımlayın içini doldurun ekrana yazdırın

            Teacher teacher = new Teacher();
            teacher.FirstName = "Erdal";
            teacher.LastName = "Deveci";
            teacher.Branch = "Elektronik";
            teacher.Intro();

            Person person1 = new Student();
            //Student student1 = new Person(); yanlış kullanım
            

            Console.ReadLine();

        }
    }
}