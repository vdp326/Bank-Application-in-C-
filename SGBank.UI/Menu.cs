using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGBank.UI.Workflows;

namespace SGBank.UI
{
    public static class Menu
    {
        public static object AccountLookupWorkflow { get; private set; }

        public static void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("SG Bank Application");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Lookup an Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3.Withdraw");

                Console.WriteLine("\nQ to quit");
                Console.Write("\nEnter Selection: ");

                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "1":
                        AccountLookUpWorkflow lookupWorkflow = new AccountLookUpWorkflow();
                        lookupWorkflow.Execute();
                        break;
                    case "2":
                        DepositWorkflow depositWorkflow = new DepositWorkflow();
                        depositWorkflow.Execute();
                        break;
                    case "3":
                        break;
                    case "Q":
                        return;
                
                }

            }
        }
    }
}
