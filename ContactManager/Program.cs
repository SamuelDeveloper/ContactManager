using System;



namespace ContactManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            bool app = true;
            Console.WriteLine("Welcome to your ContactManager! What would you like to do?");
            while (app)
            {
                
                Console.WriteLine("1. See all contacts");
                Console.WriteLine("2. Add contact");
                Console.WriteLine("3. Find contact");
                Console.WriteLine("4. Remove contact");
                Console.WriteLine("5. Terminate the application");
                string resp = Console.ReadLine();
                if(resp == "1")
                {
                    agenda.FindAllContacts();
                } else if(resp == "2")
                {
                    
                    Console.Write("Contact name: ");
                    string name = Console.ReadLine();
                    Console.Write("Contact number: ");
                    string number = Console.ReadLine();
                    Console.Write("Contact email: ");
                    string email = Console.ReadLine();
                    Contacts newContact = new Contacts { name = name, number = number, email = email };
                    agenda.AddContact(newContact);
                }   else if(resp == "3")
                {
                    Console.Write("Type contact name: ");
                    string name = Console.ReadLine();
                    agenda.FindContact(name);
                } else if (resp == "4")
                {
                    Console.Write("Type contact name of contact to remove: ");
                    string name = Console.ReadLine();
                    agenda.RemoveContact(name);
                } else if (resp == "5")
                {
                    app = false;
                }
            }
        }
    }
}
