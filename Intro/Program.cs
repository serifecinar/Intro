// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

Console.WriteLine("Hello, World!");
string message1 = "krediler";
int term = 12;
double amount = 100000.5;

//variable - camelCase
bool isAuthenticated = true;

Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton--> Hoşgeldin Şerife");
}
else
{
    Console.WriteLine("Buton--> Sisteme giriş yap");
}

//string kredi1 = "Kredi 1";
//string kredi2 = "Kredi 2";
//string kredi3 = "Kredi 3";
//string kredi4= "Kredi 4";
//string kredi5= "Kredi 5";

//Console.WriteLine(kredi1);
//Console.WriteLine(kredi2);
//Console.WriteLine(kredi3);
//Console.WriteLine(kredi4);
//Console.WriteLine(kredi5);

string[] loans = { "KREDİ1", "KREDİ2", "KREDİ3", "KREDİ4", "KREDİ5", "KREDİ6" }; //db den gelecek
//Console.WriteLine(loans[2]);

        //start   condition increment
for (int i = 0; i < loans.Length;i++)
{
    Console.WriteLine(loans[i]);
}

//Course course1= new Course();
//course1.Id= 1;
//course1.Name = "c#";
//course1.Description = ".8 ve vs..";
//course1.Price = 0;

//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "java 17...";
//course2.Description = ".8 ve vs..";
//course2.Price =10;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "phyton";
//course3.Description = "phyton 3.12...";
//course3.Price =20;

//Course[] courses = { course1, course2, course3 };

//for (int i = 0; i < courses.Length; i++)
//{
//    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
//}

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses2=courseManager.GetAll();

for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("Buton--> Kod Bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 1;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

