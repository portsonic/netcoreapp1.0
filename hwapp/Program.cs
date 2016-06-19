using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string choice;
                do 
                {
                    var m_Employee = new Employee();
                    m_Employee.EmployeeKey = 1;
                    m_Employee.EmployeeCode = "EMP";
                    m_Employee.FirstName = "Greg";
                    m_Employee.LastName = "LaPorta";

                    Console.WriteLine("Welcome, " + m_Employee.FirstName + " " + m_Employee.LastName);
                    Console.WriteLine("");
                    Console.WriteLine("A - Add Site");
                    Console.WriteLine("S - Sort List");
                    Console.WriteLine("R - Show Report\n");

                    Console.WriteLine("Q - Quit\n");

                    Console.Write("Please Choose (A/S/R/Q): ");

                    choice = Console.ReadLine();

                    switch (choice)
                    {
                    case "a":
                    case "A":
                    Console.WriteLine("Add Site");
                    break;
                    case "s":
                    case "S":
                    Console.WriteLine("Sort List");
                    break;
                    case "r":
                    case "R":
                    Console.WriteLine("Show Report");
                    break;
                    case "q":
                    case "Q":
                    Console.WriteLine("GoodBye");
                    break;
                    default:
                    Console.WriteLine("Huh??");
                    break;
                    }
                } while ((choice = choice.ToUpper()) != "Q"); 
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
