using System.Diagnostics.Contracts;

namespace Day_23_Practice_AddressBook_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to Day 23 AddressBook problem using Collection");

            Records records = new Records();



            //Infinite Loop
            while (true)
            {
                Console.WriteLine("Enter 1 to Add person in AddressBook");
                Console.WriteLine("Enter 2 to Display all Contacts AdressBook");
                Console.WriteLine("Enter 3 to Display the Sorted List");
                int choice =Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        records.AddRecord();
                        break;
                    case 2:
                        records.ToPrint();
                        break;
                    case 3:
                        records.SortContacts();
                        break;
                    default:
                        Console.WriteLine("Please Enter valid input");
                        break;

                }

            }
        }
    }
}
