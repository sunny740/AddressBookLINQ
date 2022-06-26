using System;
namespace AddressBookLINQ
{
    public class  Program
    {
        public static void Main(string[] args)
        {
            Ccontacts contactData = new Ccontacts();
            Ccontacts contactData2 = new Ccontacts();
            AddressBook addressBook = new AddressBook();

            addressBook.CreateTableUsingLinq();
            contactData.ID = 1;
            contactData.FirstName = "sunny";
            contactData.LastName = "Sej";
            contactData.PhoneNumber = 8589657412;
            contactData.Email = "sunny.27@gmail.com";
            contactData.Address = "Nilaya Colony";
            contactData.City = "gwa";
            contactData.State = "MP";
            contactData.zip = 476763;
            addressBook.InsertintoDataTable(contactData);

            contactData2.ID = 2;
            contactData2.FirstName = "Kushal";
            contactData2.LastName = "pandit";
            contactData2.PhoneNumber = 9874256310;
            contactData2.Email = "kushpandit@gmail.com";
            contactData2.Address = "Atal Road";
            contactData2.City = "Gwa";
            contactData2.State = "MP";
            contactData2.zip = 247001;
            addressBook.InsertintoDataTable(contactData2);

            addressBook.Display();
        }
    }
}