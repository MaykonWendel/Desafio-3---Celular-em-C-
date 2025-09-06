using Desafio3.Models;

public class Program
{
    public static void Main()
    {
        Smartphone nokia = new Nokia("123456", "Nokia 1100", "123456789012345", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new Iphone("987654", "iPhone 13", "987654321098765", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}