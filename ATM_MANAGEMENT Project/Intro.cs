using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_MANAGEMENT_Project
{
    class Intro:ATM
    {
        public void intro()
        {
            
            string ls = "\n\n\n\n";
            string ts = "\t\t\t\t\t";

            Console.WriteLine(ls+ts+"==========================================");
            Console.WriteLine(ts+"\tWELCOME to MY BANK of OOP LAB");
            Console.WriteLine(ts+ "==========================================");
            Console.Write(ts+"Press <ENTER> to continue:");

            Console.ReadKey();
            Console.Clear();

        }
    }
}
