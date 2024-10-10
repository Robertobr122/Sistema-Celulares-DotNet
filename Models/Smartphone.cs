using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOONet.Models
{
    public abstract class Smartphone
    {
        public string Numero {get; set;}
        private string Modelo {get; set;}
        private string IMEI {get; set;}
        private int Memoria {get; set;}

        public Smartphone (string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(){
            Console.WriteLine("Fazendo ligação... tum... tum... tum...");
        }

        public void ReceberLigação(){
            Console.WriteLine("Recebendo ligação... trim... trim... trim...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
       

    }
}