using System;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook System Problem");

            while (true)
            {
                Console.WriteLine("\nEnter 1 \tAdd New Contact ");
                Console.WriteLine("\nEnter 2 \tEdit Existing Contact");
                Console.WriteLine("\nEnter 3 \tDelete Contact");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook.AddNewContact(); //Adding the new contact
                        break;
                    case 2:
                        AddressBook.EditExistingContact(); //Edit existing contact
                        break;
                    case 3:
                        AddressBook.deleteContact(); //Delete contact
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;
                }
            }
        }
    }
}
