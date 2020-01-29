using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentIdDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string name = "";
            int id = 0;
            string strId = "";
            do
            {
                bool validId = true;
                Console.Write("Enter Student ID: ");
                strId = Console.ReadLine();
                if (strId == "" || strId == null)
                {
                    validId = false;
                }
                else
                {
                    try
                    {
                        id = int.Parse(strId);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Invalid Id. Please enter ID again.");
                        validId = false;
                    }
                }
                if (validId)
                {
                    Console.Write("Enter Student Name: ");
                    name = Console.ReadLine();
                    Console.Write("Do you want to Add more Students( enter 'y' or 'n') : ");
                    students.Add(id, name);
                    string confirm = Console.ReadLine();
                    confirm = confirm.ToLower();
                    if (confirm != "y" && confirm != "yes")
                    {
                        strId = "";
                    }
                }

            } while (strId != "");

            Console.WriteLine("\nClass roster: \n");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(" ID: {0} ,  Name: {1}", student.Key, student.Value);
            }
            Console.ReadLine();
        }
    }
}
