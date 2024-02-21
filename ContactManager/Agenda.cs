using System;
using System.Collections.Generic;


namespace ContactManager
{

    
    class Agenda
    {
        private List<Contacts> contactList;
        public Agenda()
        {
            contactList = new List<Contacts>();
        }

        public void AddContact(Contacts contact)
        {
            contactList.Add(contact);
            Console.WriteLine("Contact added!");
        }
        
        public void FindAllContacts()
        {
            if (contactList.Count > 0)
            {
                Console.WriteLine("All contacts:");
                foreach(Contacts contact in contactList)
                {
                    Console.WriteLine($"Name: {contact.name}, Number: {contact.number}, Email: {contact.email}");
                }
            } else
            {
                Console.WriteLine("No contacts");
            }
        }

        public void RemoveContact(string name)
        {
            Contacts contactToRemove = contactList.Find(c => c.name == name);
            if(contactToRemove != null)
            {
                contactList.Remove(contactToRemove);
                Console.WriteLine($"Contact {name} has been successfully removed.");
            } else
            {
                Console.WriteLine($"No contact with the name {name} found.");
            }
        }

        public void FindContact(string name)
        {
            Contacts contactToFind = contactList.Find(c => c.name == name);
            if(contactToFind != null)
            {
                Console.WriteLine($"Name: {contactToFind.name}, Number: {contactToFind.number}, Email: {contactToFind.email}");
            } else
            {
                Console.WriteLine($"No contact with the name {name} found.");
            }
        }

    }
}
