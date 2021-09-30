using System;

namespace ZEPGinterview
{
    class Program
    {
        static void Main(string[] args)
        {

            FileReaderClass c = new FileReaderClass("C:/Users/Brandon-PC/Desktop/otest.txt");
            c.fileread();
            c.printOutput();


        }
    }
}
