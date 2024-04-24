﻿using System;

namespace PeopleManagement
{
    class Program
    {
        public static void Main(string[] args)
        {   
            string filePath =@"D:\Traineeship\NETSDKandCSharp\Day8-9\NETStarter\NETBasics\PeopleManagement\People.csv";
            var parser = new CSVParser();
            parser.Parse(filePath);
            parser.PrintNames();
        }
    }
}

