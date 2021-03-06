using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Address Book System ADO.NET");

            AddressBookManagement addressBookManagement = new AddressBookManagement();

            //addressBookManagement.DataBaseConnection(); //UC1
            //addressBookManagement.GetAllContact(); //UC2
            //AddNewContactDetails(); //UC3
            //Console.WriteLine(addressBookManagement.EditContactUsingName("442207", "Himanshu", "Kholiya") ? "Update Record successfully\n" : "Update failed"); //UC4
            Console.WriteLine(addressBookManagement.DeleteContactUsingName("Himanshu", "Kholiya") ? "Delete Record successfully\n" : "Delete failed"); //UC5
            addressBookManagement.RetrieveContactFromCityOrStateName(); //UC6
            addressBookManagement.CountByCityOrState(); //UC7
            Console.ReadLine();
        }
        // UC3:- Ability to insert new Contacts to Address Book 
        public static void AddNewContactDetails()
        {
            AddressBookManagement repository = new AddressBookManagement();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Himanshu";
            model.LastName = "Kholiya";
            model.Address = "Wakad";
            model.City = "Pune";
            model.State = "Maharashtra";
            model.Zip = "412105";
            model.PhoneNumber = "1234567891";
            model.EmailId = "himanshu@gmail.com";
            model.AddressBookType = "Friend";
            model.AddressBookName = "Himanshu";

            Console.WriteLine(repository.AddDataToTable(model) ? "Record inserted successfully\n" : "Record inserted Failed");
        }
    }

}