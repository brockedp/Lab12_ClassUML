using System;
using System.Collections.Generic;

namespace Lab12_ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> humanList = new List<Person>
            {
                new Student("CS", 2, 1000.00, "Mario", "1111 25 Mile Rd, Macomb MI"),
                new Staff("Macomb CC",50000.00,"Tamara","1345 Martin Rd, Warren MI"),
                new Student("Criminal Justice",3,3000.00,"Henry","5467 Vanderbelt Ave, Oak Park MI"),
                new Staff("Wayne State University",60000.00,"Beth","915 Thompson Rd, Redford MI"),
                new Student("Health Sciences",1,2000.00,"Jessica","432 Greenfield Rd, Southfield MI")

            };
            bool again = true;
            while (again)
            {
                humanList = AddPerson(humanList);
                Console.WriteLine("---------");
                foreach (var item in humanList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("---------");
                again = Repeat("Would you like to add another member?(y/n): ");
                Console.Clear();
            }
            Console.WriteLine("Good Bye");
            
        }
        public static List<Person> AddPerson(List<Person> inputList)
        {
            string input = "";
            Console.WriteLine("Would you like to add a member to staff or a student?");
            while(input!= "staff" && input != "student")
            {
                input = GetInput("Please enter student or staff?: ").ToLower();
            }
            if(input == "staff")
            {
                string staffMember = GetInput("Please enter the staff member's name: ");
                string address = GetInput("Please enter the staff member's address: ");
                string school = GetInput("Please enter the school the staff member works for: ");
                double pay = Validator.TryParseDouble("Please enter the staff member's salary: ");
                inputList.Add(new Staff(school, pay, staffMember, address));
                int index = (inputList.Count) - 1;
                Console.WriteLine(inputList[index]);
            }
            else
            {
                string student = GetInput("Please enter the student's name: ");
                string address = GetInput("Please enter the staff member's address: ");
                string major = GetInput("Please enter the student's major: ");
                double fee = Validator.TryParseDouble("Please enter the student's fee: ");
                int year = Validator.TryParseInt("Please enter the student's year: ");
                inputList.Add(new Student(major,year, fee, student, address));
                int index = (inputList.Count) - 1;
                Console.WriteLine(inputList[index]);
            }
            return inputList;
        }
        public static string GetInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static bool Repeat(string message)
        {
            string input = "";
            while (input != "y" && input != "n")
            {
                Console.Write(message);
                input = Console.ReadLine();
            }
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
