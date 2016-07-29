using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione seu numero em decimal");
            ulong numero = ulong.Parse((Console.ReadLine()));
            Console.WriteLine("Hexadecimal: " + NumericBases.decimalToHexadecimal(numero));
            Console.WriteLine("Binario: " + NumericBases.decimalToBinary(numero));


             Console.WriteLine("Selecione seu numero em binario");
             string bin = (Console.ReadLine());
             Console.WriteLine("Decimal: " + NumericBases.binaryToDecimal(bin));
             
            ulong convert = NumericBases.binaryToDecimal(bin);
            string otro = NumericBases.decimalToHexadecimal(convert);
            Console.WriteLine("Hexadecimal: " + otro);


             Console.WriteLine("Selecione seu numero em hexadecimal");
             string hexa = Console.ReadLine();
             Console.WriteLine("Decimal: " + NumericBases.hexadecimalToDecimal(hexa));

             ulong converter = NumericBases.hexadecimalToDecimal(hexa);
             string outro = NumericBases.decimalToBinary(converter);
             Console.WriteLine("Binario: " + outro);
             Console.ReadKey();
        }
    }
}
