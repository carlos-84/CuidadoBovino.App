// See https://aka.ms/new-console-template for more information
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
            BuscarBovino(4);
        }
        private static void AddBovino()
    {
      var bovino=new Bovino()
      {
        // IdPersona=11,
         IdVeterinario=1,
         IdVisita=1,
         NombreBovino="Margaret",
         Color="Gris",
         Raza="Criollo",
         Edad=2
      };  
      _repoBovino.AddBovino(bovino);
    }
    private static void BuscarBovino(int idbovino)
      {
        var bovino=_repoBovino.GetBovino(idbovino);
        Console.WriteLine(bovino.NombreBovino);
 
     }

    }
    
}