using System;
namespace Consolepractice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int ID;
            char gender;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter ID");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Empolyee Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Empolyee Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ID : \t" + ID  + "\n Employee Name: \t" + name + "\n Empolyee Gender: \t"
                + gender + "\n Empolee Salary: \t  " + salary + "\n DOJ: \t " + doj);
            Console.ReadKey();
            if (salary > 90000)
            {
                Console.WriteLine("you have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("you have to pay 15% tax");
            }
        }
    }
}