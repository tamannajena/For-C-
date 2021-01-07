using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRFND_Project
{
    class Clients
    {
        private string _clientID;
        private string _firstName;
        private string _lastName;
        private decimal _purchaseAmount;



        public Clients(string id, string fname, string lname, decimal pAmount)
        {
            _clientID = id;
            _firstName = fname;
            _lastName = lname;
            _purchaseAmount = pAmount;
        }
        public string _ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }
        public string _Fname
        {
            get { return _firstName; }
            set { _firstName = value; }

        }
        public string _Lname
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public decimal _PurchaseAmount
        {
            get { return _purchaseAmount; }
            set { _purchaseAmount = value; }
        }
        public static bool DisplayAclient(List<Clients> client)
        {
            Console.WriteLine("Enter client ID to find");
            string searchVal = Console.ReadLine();
            foreach (Clients c in client)
            {
                if (searchVal == c._clientID)
                {
                    Console.WriteLine(c._clientID);
                    Console.WriteLine(c._firstName);
                    Console.WriteLine(c._lastName);
                    Console.WriteLine(c._purchaseAmount);
                }



            }
            bool menuOn = true;
            return menuOn;

        }
        public static bool createNewClient(List<Clients> client)
        {

            Console.WriteLine("Enter the client id number");
            string id = Console.ReadLine();
            id = CheckClientID(client, id);
            Console.WriteLine("Enter the client First name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the client Last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the clients purchase amount");
            decimal pAmount = Convert.ToDecimal(Console.ReadLine());
            client.Add(new Clients(id, fname, lname, pAmount));
            bool menuOn = true;
            return menuOn;
        }

        public static List<Clients> clientList()
        {
            List<Clients> client = new List<Clients>();
            //populate list
            client.Add(new Clients("001", "John", "Smith", Convert.ToDecimal(495.88)));
            return client;
        }
        public static string CheckClientID(List<Clients> client, string id)
        {
            foreach (Clients c in client)
            {
                while (c._clientID == id || id.Length > 3 || !id.All(char.IsDigit))
                {
                    
                    Console.WriteLine("Invalid entry client id is the same as a previous entry/n Is not numeric/n" +
                        "Or is larger then 3 characters.");
                    id = Console.ReadLine();
                    

       
                }
                
            }
            return id;
        }
        public static bool DisplayAllClients(List<Clients> client)
        {
                bool menuOn = true;
                foreach (Clients c in client)
            {
                    Console.WriteLine(c._clientID);
                    Console.WriteLine(c._firstName);
                    Console.WriteLine(c._lastName);
                    Console.WriteLine(c._purchaseAmount);
            }
           return menuOn;
        }
    }

}

