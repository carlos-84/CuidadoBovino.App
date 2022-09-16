﻿// See https://aka.ms/new-console-template for more information
using System;
using CuidadoBovino.App.Dominio;
using CuidadoBovino.App.Persistencia;
namespace CuidadoBovino.App.Consola
{
    class Program
    {
        private static IntBovino _repoBovino =  new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //AddBovino();
            BuscarBovino(1);
        }
        private static void AddBovino()
    {
      var bovino=new Bovino()
      {
        // IdPersona=11,
         IdVeterinario=2,
         IdVisita=5,
         NombreBovino="Jacinta",
         Color="Cafe",
         Raza="Angus",
         Edad=6
      };  
      _repoBovino.AddBovino(bovino);
    }
    private static void BuscarBovino(int Idbovino)
      {
        var bovino=_repoBovino.GetBovino(Idbovino);
        Console.WriteLine(bovino.NombreBovino);
 
     }

    }
    
}