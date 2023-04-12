// See https://aka.ms/new-console-template for more information
using JURNAL8_KPL_1302213003;
using System.Security.Cryptography.X509Certificates;

BankTransferConfig tfConfig = new BankTransferConfig();
readJson read = new readJson();



Console.WriteLine("Please insert the amount of money to transfer:");
int mon = int.Parse(Console.ReadLine());

int sum = 0;
if (mon <= read.bankTfCon.threshold)
{
    sum = mon + read.bankTfCon.low_fee;
    Console.WriteLine("Transfer fee = Rp " + read.bankTfCon.low_fee);
    Console.WriteLine("Total amount = Rp " + sum);
}
else
{
    sum = mon + read.bankTfCon.high_fee;
    Console.WriteLine("Transfer fee = Rp " + read.bankTfCon.high_fee);
    Console.WriteLine("Total amount = Rp " + sum);
}


Console.WriteLine("\nSelect transfer method: ");
Console.WriteLine(read.bankTfCon.meth1);
Console.WriteLine(read.bankTfCon.meth2);
Console.WriteLine(read.bankTfCon.meth3);
Console.WriteLine(read.bankTfCon.meth4);
string meth = Console.ReadLine();


Console.WriteLine("\nPlease type " + read.bankTfCon.en + " to confirm the transaction");
string confirm = Console.ReadLine();

if (confirm == read.bankTfCon.en)
{
    Console.WriteLine("The transfer is completed");
}
else
{
    Console.WriteLine("Transfer is cancelled");
}