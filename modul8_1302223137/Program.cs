using System;
using System.Collections.Generic;
using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        BankConfig config = new BankConfig();   

        if (config.confirmation == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ” );
            int nominalTransfer;
            nominalTransfer = int.Parse(Console.ReadLine());
            if (nominalTransfer <= config.transfer.threshold)
            {
                Console.WriteLine(config.transfer.low_fee);
            }
            else
            {
                Console.WriteLine(config.transfer.high_fee);
            }
            Console.WriteLine("Transfer fee: " + config.transfer + "Total Amount: " + nominalTransfer + config.transfer );

            Console.WriteLine("Select transfer method: ");
            Console.WriteLine("1. RTO (real-time)");
            Console.WriteLine("2. SKN");
            Console.WriteLine("3. RTGS");
            Console.WriteLine("4. BI FAST");
        } else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
            nominalTransfer = int.Parse(Console.ReadLine());
            if (nominalTransfer <= config.transfer.threshold)
            {
                Console.WriteLine(config.transfer.low_fee);
            }
            else
            {
                Console.WriteLine(config.transfer.high_fee);
            }
            Console.WriteLine("Biaya transfer: " + config.transfer + "Total Biaya: " + nominalTransfer + config.transfer);
            
            Console.WriteLine("Pilih Metode Transfer: ");
            Console.WriteLine("1. RTO (real-time)");
            Console.WriteLine("2. SKN");
            Console.WriteLine("3. RTGS");
            Console.WriteLine("4. BI FAST");
            string Metodetransfer;
            Metodetransfer = Console.ReadLine();

        }

       


        

    }
}