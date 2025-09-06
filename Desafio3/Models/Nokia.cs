using System;

namespace Desafio3.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string emei, int memoria)
            : base(numero, modelo, emei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia\n");
        }
    }
}