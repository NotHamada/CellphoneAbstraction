using CellphoneAbstraction.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

namespace CellphoneAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789", 100);
            Iphone iphone = new Iphone("987654321", "Iphone 12", "987654321", 100);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");
        }
    }
}