using System;

namespace Problema_do_número_espelho
{
    class Program
    {
        public static int hexaToDecimal(string numero)
        {
            return Convert.ToInt32(numero, 16);
        }
        public static bool verificarCapicua(string numero)
        {
            string invertida = "";
            numero = hexaToDecimal(numero).ToString();
            for(int cont=numero.Length-1;cont>=0; cont--)
            {
                invertida += numero.Substring(cont, 1);
            }
            return (invertida.Equals(numero)) ? true : false;

        }
        static void Main(string[] args)
        {
            string numero =Console.ReadLine();
            Console.WriteLine((verificarCapicua(numero)) ? "S" : "N");
        }
    }
}
