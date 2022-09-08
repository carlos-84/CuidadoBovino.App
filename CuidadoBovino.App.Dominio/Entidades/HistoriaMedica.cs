using System;
namespace CuidadoBovino.App.Dominio
{
   
    public class HistoriaMedica
    {
        public int IdVisita {get;set;}
        public DataTime FechaApertura {get;set;}
        public DataTime FechaVisita {get;set;}
        public float Temperatura {get;set;}
        public float Peso {get;set;}
        public float FrecuCardiaca {get;set;}
        public float FrecuRespiratoria {get;set;}
        public string EstadoAnimo {get; set;}


       
    }
}