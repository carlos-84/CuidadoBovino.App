// See https://aka.ms/new-console-template for more information
using System;
using CuidadoBovino.App.Dominio;
using CuidadoBovino.App.Persistencia;
namespace CuidadoBovino.App.Consola
{
    class Program
    {
        private static IntBovino _repoBovino =  new RepBovino(new CuidadoBovino.App.Persistencia.AppContext());
        private static IntDuenoBovino _repoDuenoBovino = new RepDuenoBovino(new CuidadoBovino.App.Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddDuenoBovino();
            //AddBovino();
            //BuscarBovino(2);
        }
        private static void AddDuenoBovino()
        {
          var duenobovino = new DuenoBovino()
          {
            Nombre = "Fabio",
            Apellido = "Galan",
            Direccion = "Finca Mi Terruño",
            Telefono = "32222255",
            CorreoE = "fgalan@e-mail.com"
          };
          _repoDuenoBovino.AddDuenoBovino(duenobovino);
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
      private static void BuscarBovino(int idbovino)
        {
          var bovino=_repoBovino.GetBovino(idbovino);
          Console.WriteLine(bovino.NombreBovino);
      }

    }
    
}