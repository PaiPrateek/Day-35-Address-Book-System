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

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook.AddNewContact(); //Adding the new contact
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;
                }
            }
        }
    }
}
