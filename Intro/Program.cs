// See https://aka.ms/new-console-template for more information
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

Course course1= new Course();
course1.Id= 1;
course1.Name = "c#";
course1.Description = ".8 ve vs..";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "java 17...";
course2.Description = ".8 ve vs..";
course2.Price =10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "phyton";
course3.Description = "phyton 3.12...";
course3.Price =20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("Buton--> Kod Bitti");