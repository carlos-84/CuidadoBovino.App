// See https://aka.ms/new-console-template for more information
using System;
using CuidadoBovino.App.Dominio;
namespace CuidadoBovino.App.Consola
{
    class Program
    {
        private static IntBovino _repoBivno =  new RepBovino(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddBovino();
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
      _repoBivno.AddBovino(bovino);
    }
    //  private static void BuscarPropietario(int idcliente)
    // {
    //   var propietario=_repoPropietario.GetPropietario(idcliente);
    //   Console.WriteLine(propietario.Nombres);
 
    // }

    }
    
}