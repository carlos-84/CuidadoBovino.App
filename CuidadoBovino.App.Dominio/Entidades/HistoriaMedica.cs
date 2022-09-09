using System;
namespace CuidadoBovino.App.Dominio
{
   
    public class HistoriaMedica
    {
        public int Id {get;set;}
        public string FechaApertura {get;set;}
        public string FechaVisita {get;set;}
        public float Temperatura {get;set;}
        public float Peso {get;set;}
        public float FrecuCardiaca {get;set;}
        public float FrecuRespiratoria {get;set;}
        public string EstadoAnimo {get; set;}


       
    }
}