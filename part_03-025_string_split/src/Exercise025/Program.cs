﻿namespace Exercise025
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {

                string text = Console.ReadLine();
                if (text == "")
                {
                    break;
                }
                string[] pieces = text.Split(" ");




                for (int i = 0; i < pieces.Length; i++)
                {
                    Console.WriteLine(pieces[i]);
                }
            }
        }
    }
}
