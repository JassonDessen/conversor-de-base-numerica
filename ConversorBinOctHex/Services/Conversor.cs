using System;

namespace ConversorBinOctHex.Services
{
    public static class Conversor
    {
        public static string Binary(int num)
        {
            string bin = "";

            // Guardado os restos das divisões
            do
            {
                // Pegando o resto da divisão
                bin += (num % 2).ToString();
                num = num / 2;
            } while (num >= 1);

            return Format(bin);
        }

        public static string Octal(int num)
        {
            string octal = "";

            do
            {
                octal += (num % 8).ToString();
                num = num / 8;
            } while (num >= 1);

            return Format(octal);
        }

        public static string Hex(int num)
        {
            string hex = "";

            do
            {
                hex += NumberToLetters((num % 16).ToString());
                num = num / 16;
            } while (num >= 1);

            return Format(hex);
        }

        private static string NumberToLetters(string currentNumber)
        {
            string number = "";
            switch (currentNumber)
            {
                case "10":
                    number = "A";
                    break;
                case "11":
                    number = "B";
                    break;
                case "12":
                    number = "C";
                    break;
                case "13":
                    number = "D";
                    break;
                case "14":
                    number = "E";
                    break;
                case "15":
                    number += "F";
                    break;
                default:
                    number = currentNumber;
                    break;
            }

            return number;
        }

        private static string Format(string num)
        {
            string formatted = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                formatted += num[i];
            }

            return formatted;
        }
    }
}
