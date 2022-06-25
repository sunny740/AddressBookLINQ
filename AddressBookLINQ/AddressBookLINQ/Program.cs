using System;
namespace AddressBookLINQ
{
    public class  Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Using LINQ");
            AddressBook addressBook = new AddressBook();
            addressBook.CreateDataTable();

        }
    }
}