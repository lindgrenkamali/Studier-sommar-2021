using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv till en text fil in projet mappen
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            

            //Textskrivaren är buffrad, så den här inställningen kallar FLush() på alla lyssnare efter skrivning
            Trace.AutoFlush = true;

            Debug.WriteLine("Debuggen säger att jag kollar");
            Trace.WriteLine("Trace säger att jag kollar");

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Console.WriteLine(Directory.GetCurrentDirectory());

            IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(displayName: "PacktSwitch", description: "This switch is set via a JSON config.");

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError, "Trace fel");
            Trace.WriteLineIf(ts.TraceWarning, "Trace varning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace info");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

        }
    }
}
