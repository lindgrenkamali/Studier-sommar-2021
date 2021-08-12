using System;
using System.IO; //Typer för att hantera filsystemet
using System.Xml;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using System.IO.Compression;

namespace WorkingWithStreams
{
    class Program
    {
        //Definera en array av League of Legends karaktärer
        static string[] champions = new string[]
         {
                 "Draven", "Lulu", "Riven", "Rek'Sai", "Garen", "Rammus", "Zac"
         };

        static void Main(string[] args)
        {
            // WorkWithText();
            //WorkWithXml();

            //WorkWithCompression();

            WorkWithBrotli(true);

        }

        private static void WorkWithBrotli(bool useBrotli)
        {
            string fileExt = useBrotli ? "brotli" : "gzip";

            //Komprimerar xml utmatningen
            string filePath = Combine(CurrentDirectory, $"streams.{fileExt}");

            FileStream file = File.Create(filePath);

            Stream compressor;

            if (useBrotli)
            {
                compressor = new BrotliStream(file, CompressionMode.Compress);
            }
            else
            {
                compressor = new GZipStream(file, CompressionMode.Compress);
            }

            using(compressor)
            {
                using (XmlWriter writer = XmlWriter.Create(compressor))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Champions");
                    foreach (var champ in champions)
                    {
                        writer.WriteElementString("Champion", champ);
                    }
                }
            }//Stänger strömmen

            //Skriver ut allt innehåll från den komprimerade filen
            Console.WriteLine($"{filePath} {new FileInfo(filePath).Length}");

            Console.WriteLine(File.ReadAllText(filePath));

            //Läser en komprimerad fil
            WriteLine($"Läser den komprimerade XML filen:");
            file = File.Open(filePath, FileMode.Open);

            Stream decompressor;

            if (useBrotli)
            {
                decompressor = new BrotliStream(file, CompressionMode.Decompress);
            }
            else
            {
                decompressor = new GZipStream(file, CompressionMode.Decompress);
            }

            using (decompressor)
            {
                using(XmlReader reader = XmlReader.Create(decompressor))
                {
                    while(reader.Read())
                    {
                        //Kolla om vi har en element node döpt till Champion
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Champion"))
                        {
                            reader.Read();//Gå till nästa element
                            Console.WriteLine($"{reader.Value}"); //Läser dess värde
                        }
                    }
                }
            }

        }

        private static void WorkWithCompression()
        {
            string gzipFilePath = Combine(CurrentDirectory, "Strömmar.gzip");

            FileStream gzipFile = File.Create(gzipFilePath);

            using (GZipStream compressor = new GZipStream(gzipFile, CompressionMode.Compress))
            {
                using (XmlWriter xmlGzip = XmlWriter.Create(compressor))
                {
                    xmlGzip.WriteStartDocument();
                    xmlGzip.WriteStartElement("Champions");
                    foreach (string champ in champions)
                    {
                        xmlGzip.WriteStartElement("Champion", champ);


                    }

                    //Den normala kallningen till WriteEndElement är inte nödvändig
                    //För när XMLWriter frigörs
                    //Tar den automatiskt bort elements of any depths
                }
            }//Stänger av den underliggande strömmen

            //Skriver ut allt innehåll av den komprimerade filen
            Console.WriteLine($"{gzipFilePath} innehåller {new FileInfo(gzipFilePath).Length}");

            Console.WriteLine($"Det komprimerade innehållet:");
            Console.WriteLine($"{File.ReadAllText(gzipFilePath)}");

            //Läs en komprimerad fil
            Console.WriteLine("Läser den komprimerade XML filen:");
            gzipFile = File.Open(gzipFilePath, FileMode.Open);

            using (GZipStream decompress = new GZipStream(gzipFile, CompressionMode.Decompress))
            {
                using(XmlReader reader = XmlReader.Create(decompress))
                {
                    while (reader.Read()) //läser nästa xml node
                    {
                        //Kollar om element noden har namnet champion
                        if((reader.NodeType == XmlNodeType.Element) && reader.Name == "Champion")
                        {
                            reader.Read(); //Går till nästa element
                                Console.WriteLine($"{reader.Value}"); //läser värdet
                        }
                    }
                }
            }
        }

        private static void WorkWithXml()
        {
            FileStream xmlStream = null;

            XmlWriter xml = null;

            try
            {

            string xmlFile = Combine(CurrentDirectory, "Champtions.xml");

             xmlStream = File.Create(xmlFile);

            //Linda in filströmmen i en XML skrivarhjälpare och automatiskt någonting blablabla
            xml = XmlWriter.Create(xmlStream, new XmlWriterSettings { Indent = true });

            //Skriv XML deklareringen
            xml.WriteStartDocument();

            //Skriv ett root element
            xml.WriteStartElement("Champions");

            foreach (var champ in champions)
            {
                xml.WriteElementString("Champions", champ);
            }

            //Skriv slut root elementet
            xml.WriteEndElement();

            xml.Close();

            xmlStream.Close();

            //Skriver ut allt innehåll av filen
            WriteLine($"{xmlFile} innehåller {new FileInfo(xmlFile).Length}");

            Console.WriteLine(File.ReadAllText(xmlFile));

            }
            catch(Exception ex)
            {
                //Om filvägen ej existerar
                Console.WriteLine($"{ex.GetType()} säger {ex.Message}");


            }
            finally
            {
                if (xml != null)
                {
                    xml.Dispose();
                    
                    Console.WriteLine("Xml disposed");

                   
                }

                if (xmlStream != null)
                {
                    xmlStream.Dispose();
                    Console.WriteLine("Xmlstream disposed");
                }
            }

        }

        private static void WorkWithText()
        {
            //Definera en fil att skriva till

            string textFile = Combine(CurrentDirectory, "Champions.txt");

            //Skapar en fil och returerar en hjälpskrivare
            StreamWriter text = File.CreateText(textFile);

            //Enumerera strängarna, skriv varje till en stream på en separat rad
            foreach (string champ in champions)
            {

                text.WriteLine(champ);
            }

            text.Close();//Frigör resurser

            //Skriver ut innehållet av filen
            Console.WriteLine($"{textFile} innehåller {new FileInfo(textFile).Length}");

            WriteLine(File.ReadAllText(textFile));
        }
    }
}
