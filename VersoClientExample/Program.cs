using System;


namespace VersoClientExample
{
    class Program
    {
        static void Main(string[] args)
        {
            VersoClient.GetInstance().GetOutboundAlertLogs();
            Console.ReadLine();
        }
    }
}
