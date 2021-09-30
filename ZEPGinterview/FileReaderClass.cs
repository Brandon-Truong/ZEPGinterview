using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ZEPGinterview
{
    class FileReaderClass
    {

        String filename;
        String output;

        public FileReaderClass(string fn)
        {
            filename = fn;
            output = "";
        }
        public void fileread()
        {
            try
            {
                using (var sr = new StreamReader(filename))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        output += line + "\n\r";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something went wrong");
                Console.WriteLine(e.Message);
            }
        }
        public void printOutput()
        {
            Console.WriteLine(output);
        }
    }
 }

