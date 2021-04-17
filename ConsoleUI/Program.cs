﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal() );

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }

            carManager.Delete(2);

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }

            carManager.Deneme();

        }
    }
}
