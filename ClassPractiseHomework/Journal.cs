using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractiseHomework
{
    internal class Journal
    {
        private string journal_name;
        private string address;
        private string description;
        private string phone;
        private string email;

        public Journal()
        {
            journal_name= string.Empty;
            address= string.Empty;
            description= string.Empty;
            phone= string.Empty;
            email= string.Empty;
        }
       public Journal(string journal_name, string address, string description, string phone, string email)
        {
            this.journal_name = journal_name;
            this.address = address;
            this.description = description;
            this.phone = phone;
            this.email = email;
          
        }

        public void Print() => Console.WriteLine("Journal name - " + journal_name + "\nAddress - " + address + "\nPhone number - " + phone + "\nDescription - " + description + "\nEmail - " + email);
        public void Input()
        {
            Console.Write("Enter Journal name: ");
            journal_name = Console.ReadLine();
            Console.Write("Enter Address: ");
            address = Console.ReadLine();
            Console.Write("Enter Description: ");
            description = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            phone = Console.ReadLine();
            Console.Write("Enter Email: ");
            email = Console.ReadLine();

        }
        public string Journal_Name
        {
            get { return journal_name; }
            set { journal_name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public override string ToString()
        {
            return "Journal name - " + journal_name + "\nAddress - " + address + "\nPhone number - " + phone + "\nDescription - " + description + "\nEmail - " + email;
        }
    }
}
