namespace Proje07_Constructer_Methods
{
    class Person
    {
        public Person()//Method, Constructer Method TİPİ olmaz!
        {
            //Her class ın default olarak boş bir constructer methodu vardır, ama implicittir, yani örtülü , gizlidir. Şu anda biz kendimiz bir constructer method yazdık!
            //constructer methodi, ilgili classtan new new ketywordu ile yeni bir nesne yaratıldığı zaman çalışacak kodları barındırır.
            //yani bu classtan bir nesne üretildiği anda buradaki kodlar çalışır.
            //Her claasın boş bir constructerı vardır ama biz içi dolu yazarsak o ortadan kalkar.
            Console.WriteLine("Merhaba, ben Person, şu anda yaratıldım!");
        }
        public Person(string firstName, string lastName)//Tanımlandığı sınıftan nesne üretilirken kullanılır.
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; } 
        public string LastName { get; set; }

    }
    class Student : Person
    {
        public Student(string firstName,string lastName,int studentNumber):base(firstName,lastName)//ctor+tab+tab---base bizi miras aldığımız class a gönderir. İstenilene göre .
        {
            
            StudentNumber = studentNumber;
        }
        public int StudentNumber { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //Person person2=new Person("İsmet","Okumuş");
            //Console.WriteLine($"{person2.FirstName} {person2.LastName}");

            Student student1 = new Student("Ahmet","Can",345);
            Console.WriteLine($"{student1.FirstName} {student1.LastName} {student1.StudentNumber}");
            Console.ReadLine();

        }
    }
}