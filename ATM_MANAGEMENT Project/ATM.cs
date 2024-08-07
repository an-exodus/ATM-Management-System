using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_MANAGEMENT_Project
{
    class ATM
    {
        
        private string acc_pin;
        private int pin_len = 0;
        private int ran_acc_num;
        private int ran_stan_num;
        private int deposit;
        private int choice;
        private int w;
        private int d;
        
        private string recv_card_num;
        public int rec_num_len = 0;
        private int amt_transfer;
        static public DateTime dt = DateTime.Now;

        public void Card() // get Card from user
        {
            string ls = "\n\n\n";
            string ts = "\t\t\t\t\t";
            

            Console.WriteLine(ls+ts+"==================================");
            Console.WriteLine(ts+"*\tMY BANK of OOP LAB\t*");
            Console.WriteLine(ts+"==================================");

            Console.WriteLine("\n\n"+ts+"Press <Enter> to Insert your Card: ");
            
        }
        public void cardPin() // get Card Pin from user
        {
            ConsoleKeyInfo c = Console.ReadKey();
            if (c.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\n\n\t\t\t\t\tEnter your Pin: ");
                acc_pin = Console.ReadLine();


                Console.Clear();

                foreach (int nums in acc_pin)
                {
                    pin_len += 1;
                }
            }
            else
            {
                Console.WriteLine("\n\n\tYour Card is Not Insert!");
                throw new Exception();

            }

        }

        // Items of Main Menu
        public void balanceEnquiry()
        {
            
            Console.WriteLine("\n\t\t\t\t```Your Current balance is: {0}```", deposit);         
            if(deposit==0)
            {
                Console.WriteLine("\n\t\t\t```You have no Balance! Please Deposit some Amount``` ");
            }
        }
        public void Withdraw()
        {

            Console.WriteLine("\n\t\t\tEnter Amount you want to Withdraw: ");
            w = int.Parse(Console.ReadLine());
            
            
        }
        public void WithdrawTranscript()
        {

            Console.Clear();
            Console.WriteLine("\t\t\t\t\t===============================");
            Console.WriteLine("\t\t\t\t\t\tMY BANK LIMITED");
            Console.WriteLine("\t\t\t\t\t=================================");
            Console.WriteLine("\n\t\t\t\t\t\tCash Withdrawal");
            Console.WriteLine("\t\t\t\t\t\t***************");
            
            Console.WriteLine("\n\t\t\t\t\tYour Card Number is: " + Random_Card_Num());
            Random_Acc_Num();
            Random_STAN_Num();
            Console.WriteLine("\n\t\t\t\t\tTransaction Amount: PKR " + w);
            Console.WriteLine("\n\t\t\t\t\tYour Current Balance is: PKR " + deposit);

            Console.WriteLine("\n\t\t\t\t\t=================================");
            Console.WriteLine("\t\t\t\t\t=================================");
        }
        public void Deposit()
        {
            
            Console.WriteLine("\n\t\t\tEnter Amount you want to Deposit: ");
            d = int.Parse(Console.ReadLine());

            deposit = deposit + d;
        }
        public void DepositTranscript()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t===============================");
            Console.WriteLine("\t\t\t\t\t\tMY BANK LIMITED");
            Console.WriteLine("\t\t\t\t\t=================================");
            Console.WriteLine("\n\t\t\t\t\t\tCash Deposit");
            Console.WriteLine("\t\t\t\t\t\t***************");

            Console.WriteLine("\n\t\t\t\t\tDATE\t\tTIME");      // To print Date & Time
            Console.WriteLine("\t\t\t\t\t" + dt.ToString("d") + "\t" + dt.ToString("H:mmtt"));

            Console.WriteLine("\n\n\t\t\t\t\tYour Card Number is: " + Random_Card_Num());
            Random_Acc_Num();
            Random_STAN_Num();
            Console.WriteLine("\n\t\t\t\t\tTransaction Amount: PKR " + d);
            Console.WriteLine("\n\t\t\t\t\tYour Current Balance is: PKR " + deposit);

            Console.WriteLine("\n\t\t\t\t\t=================================");
            Console.WriteLine("\t\t\t\t\t=================================");
        }
        public void Mini_Statement()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t===============================");
            Console.WriteLine("\t\t\t\t\t\tMY BANK LIMITED");
            Console.WriteLine("\t\t\t\t\t=================================");   
            Console.WriteLine("\n\t\t\t\t\t\tMINI STATEMENT");
            Console.WriteLine("\t\t\t\t\t\t***************");

            Console.WriteLine("\n\t\t\t\t\tDATE\t\tTIME");      // To print Date & Time
            Console.WriteLine("\t\t\t\t\t" + dt.ToString("d") + "\t" + dt.ToString("H:mmtt"));

            Console.WriteLine("\n\t\t\t\t\tYour Card Number is: " + Random_Card_Num());
            Random_Acc_Num();
            Random_STAN_Num();
            Console.WriteLine("\n\t\t\t\t\tFirst Last Transaction: PKR " + d);
            Console.WriteLine("\n\t\t\t\t\tLast Transaction: PKR " + w);
            Console.WriteLine("\n\t\t\t\t\tYour Current Balance is: PKR " + deposit);

            Console.WriteLine("\n\t\t\t\t\t=================================");
            Console.WriteLine("\t\t\t\t\t=================================");
        }
        public void Transfer_Balance()
        {
            Console.WriteLine("\n\t\t\tEnter Receiver's Card Number:");
            recv_card_num = Console.ReadLine();
            foreach (char ch in recv_card_num)
            {
                rec_num_len += 1;
            }
            if(rec_num_len==9)
            {
                Console.WriteLine("\n\t\t\tEnter Amount to transfer: ");
                amt_transfer = int.Parse(Console.ReadLine());

                if (amt_transfer > deposit)
                {
                    Console.WriteLine("\n\t\t\tYou don't have Sufficient balance to Transfer");
                }
                if(amt_transfer<=deposit)
                {
                    Console.WriteLine("\n\t\t\tAmount Transfer Successfully!");
                    deposit = deposit - amt_transfer;
                }
            }
            
            else
            {
                Console.WriteLine("\n\t\t\tCard Number is Not Correct!");
                throw new Exception();
            }
        }
        // Random Card, Account and STAN number Generator
        public string Random_Card_Num()
        {
            Random RNG = new Random();
            var builder = new StringBuilder();
            while (builder.Length < 16)
            {
                builder.Append(RNG.Next(10).ToString());
            }
            return builder.ToString();
        }
        public void Random_Acc_Num()
        {
            Random ran_acc = new Random();
            ran_acc_num = ran_acc.Next(111111111, 999999999);
            Console.WriteLine("\n\t\t\t\t\tAccount Number is: {0}", ran_acc_num);


        }
        public void Random_STAN_Num()
        {
            Random ran_stan = new Random();
            ran_stan_num = ran_stan.Next(111111, 999999);
            Console.WriteLine("\n\t\t\t\t\tSTAN Number is: {0}", ran_stan_num);
        }



        // Main Menu Print
        public void mainMenu()
        {
            if (pin_len == 4)
            {

                Console.WriteLine("\n\t\t\t---------------------------------------------------------------");
                Console.WriteLine("\n\n\t\t\t\t\t||* WELCOME TO `MY-BANK` *||");
                Console.WriteLine("\n\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~  \n");
                Console.WriteLine("\t\t\t\t\t1. For Balance Enquiry-P(1)\n");
                Console.WriteLine("\t\t\t\t\t2. For Cash Withdraw-P(2) \n");
                Console.WriteLine("\t\t\t\t\t3. For Cash Deposit-P(3)\n");
                Console.WriteLine("\t\t\t\t\t4. For Mini Statement-P(4)\n");
                Console.WriteLine("\t\t\t\t\t5. For Transfer balance-P(5)\n");
                Console.WriteLine("\t\t\t\t\t6. Exit-P(6)\n");
                Console.WriteLine("\t\t\t\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~ \n");
                Console.WriteLine("\t\t\t\t\tPlease ENTER YOUR CHOICE : ");


            }
            else
            {
                Console.WriteLine("\n\n\tYour Card Pin is Not Correct!");
                throw new Exception();
            }
            choice = int.Parse(Console.ReadLine());


            do
            {
                switch (choice)
                {

                    case 1:
                        {

                            Console.Clear();
                            balanceEnquiry();
                            mainMenu();
                            break;
                        }

                        
                    case 2:
                        {
                            Withdraw();
                            if (w % 100 != 0)
                            {
                                Console.WriteLine("\n\t\t\t\t\tPlease Enter Amount `above or equal` to 100");
                                
                            }
                            else if( w > deposit)
                            {
                                Console.WriteLine("\n\t\t\t\t\tYour Account Balance is Insufficient !");
                            }
                            else
                            {
                                deposit = deposit - w;
                                WithdrawTranscript();
                            }
                            
                            mainMenu();
                            break;
                        }
                    case 3:
                        {
                            Deposit();
                            DepositTranscript();
                            mainMenu();
                            break;
                        }
                    case 4:
                        {
                            Mini_Statement();
                            mainMenu();
                            break;
                        }
                    case 5:
                        {
                            Transfer_Balance();
                            mainMenu();
                            break;
                        }


                }
            } while (choice != 6);
        }
    }

}

