using System;

namespace Desafio3.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Emei { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string emei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Emei = emei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando do número {Numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no número {Numero}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}