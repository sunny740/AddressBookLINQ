using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    public class AddressBook
    {
        DataTable dataTable;
        public void CreateTableUsingLinq()
        {
            dataTable = new DataTable("AddressBook");
            DataColumn dtCol;

            dtCol = new DataColumn();
            dtCol.DataType = typeof(Int32);
            dtCol.ColumnName = "Id";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(String);
            dtCol.ColumnName = "FirstName";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(String);
            dtCol.ColumnName = "LastName";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(String);
            dtCol.ColumnName = "Address";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(String);
            dtCol.ColumnName = "City";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(String);
            dtCol.ColumnName = "State";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(String);
            dtCol.ColumnName = "Email";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(Int64);
            dtCol.ColumnName = "PhoneNumber";
            dataTable.Columns.Add(dtCol);

            dtCol = new DataColumn();
            dtCol.DataType = typeof(Int64);
            dtCol.ColumnName = "Zip";
            dataTable.Columns.Add(dtCol);

        }

        public int AddValues()
        {
            CreateTableUsingLinq();
            Ccontacts contact = new Ccontacts();
            Ccontacts contacts = new Ccontacts();
            contact.ID = 1;
            contact.FirstName = "Rajvardhan";
            contact.LastName = "Singh";
            contact.PhoneNumber = 8439560765;
            contact.Email = "rajvardhan.2627@gmail.com";
            contact.Address = "Himalayan Colony";
            contact.City = "Najibabad";
            contact.State = "UP";
            contact.zip = 246763;
            InsertintoDataTable(contact);

            contacts.ID = 2;
            contacts.FirstName = "Kshitij";
            contacts.LastName = "Puri";
            contacts.PhoneNumber = 7012657852;
            contacts.Email = "puri.kshitij@gmail.com";
            contacts.Address = "IIT Road";
            contacts.City = "Roorke";
            contacts.State = "UK";
            contacts.zip = 247001;
            InsertintoDataTable(contacts);

            return dataTable.Rows.Count;
        }

        public void InsertintoDataTable(Contacts contact)
        {
            DataRow dtRow = dataTable.NewRow();
            dtRow["ID"] = contact.ID;
            dtRow["FirstName"] = contact.FirstName;
            dtRow["LastName"] = contact.LastName;
            dtRow["Address"] = contact.Address;
            dtRow["City"] = contact.City;
            dtRow["State"] = contact.State;
            dtRow["Zip"] = contact.zip;
            dtRow["PhoneNumber"] = contact.PhoneNumber;
            dtRow["Email"] = contact.Email;
            dataTable.Rows.Add(dtRow);
        }
        public void Display()
        {
            foreach (DataRow dtRows in dataTable.Rows)
            {
                Console.WriteLine(" ID: {0} \n First Name: {1} \n Last Name: {2} \n Address: {3} \n City: {4} \n State: {5} \n Zip: {6} \n Phone Number: {7} \n Email: {8} \n", dtRows["ID"], dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"]);
            }
        }
    }
    }
}
