using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;

class Basic
{
    public static void Main()
    {
        //DATA type and variable declartion

        //string name;
        //int age;
        //char section;
        //float percentage;
        //double Percentage;
        //bool isthat; // it could be yes or no

        //name = "Siva";
        //age = 21;
        //section = 'A'; // chara declare the single word with single qoutes
        //Percentage = 90.1;
        //percentage = 95.25f;



        //Console.WriteLine("Hii there i am "+name);
        //Console.WriteLine("My age is " +age);
        //Console.WriteLine("and My section is "+ section);
        //Console.WriteLine("My school cutoff is "+ Percentage);
        //Console.WriteLine("And my college cutoff is "+ percentage);


        //TYPE CASTING 

        //EXPLICT CONVERTIONS

        int age, year ;
        int cyear =2025;
        Console.Write("Enter you date of year :");
        year=Convert.ToInt32 (Console.ReadLine()); //we can use Convert.TO
        //year = int.Parse(Console.ReadLine()); can we use parse for string
        age = cyear - year;
        Console.WriteLine("Your current age is " + age);
       

    }
}