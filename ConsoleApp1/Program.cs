﻿using System;
using System.Security.Cryptography.X509Certificates;

public class Suerte
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Juego();
        }
    }
    static void Juego()
    {
        int ciclos = 1;
        int randomnum = -1;
        Console.WriteLine("Introduce un numero del 1 al 1000");
        int suerte = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            Thread.Sleep(1);
            Random random = new Random();
            randomnum = random.Next(1, 1001);
            Console.WriteLine(ciclos + ": " + randomnum);
            ciclos = ciclos + 1;
            if (randomnum == suerte)
            {
                break;
            }
        }
        Console.WriteLine("\n\nHas generado " + (ciclos - 1) + " numeros aleatorios para conseguir el " + suerte + ".\n\n");
        Thread.Sleep(500);
    }
}