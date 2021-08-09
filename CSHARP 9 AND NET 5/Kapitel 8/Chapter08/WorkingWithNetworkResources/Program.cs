using System;
using System.Net;
using System.Net.NetworkInformation;

namespace WorkingWithNetworkResources
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingResources();

        }

        private static void WorkingResources()
        {
            Console.Write("Skriv in en gitlig webbadress: ");
            string url = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(url))
            {
                url = "https://facebook.com";
            }
            var uri = new Uri(url);
            Console.WriteLine($"URL: {url}");
            Console.WriteLine($"Scheme: {uri.Scheme}");
            Console.WriteLine($"Port: {uri.Port}");
            Console.WriteLine($"Host: {uri.Host}");
            Console.WriteLine($"Path: {uri.AbsolutePath}");
            Console.WriteLine($"Query: {uri.Query}");

            IPHostEntry entry = Dns.GetHostEntry(uri.Host);
            Console.WriteLine($"{entry.HostName} har följande ip-adresser:");
            foreach (IPAddress adress in entry.AddressList)
            {
                Console.WriteLine(adress);
            }
            try
            {
                var ping = new Ping();
                Console.WriteLine("Pingar servern, var snäll och vänta...");
                PingReply reply = ping.Send(uri.Host);
                Console.WriteLine($"{uri.Host} blev pingad och svarade med {reply.Status}");

                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Svaret från {reply.Address} tog {reply.RoundtripTime} ms");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.GetType()} säger {ex.Message}");
            }
            
        }
    }
}
