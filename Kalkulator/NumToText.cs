using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class NumToText
    {
        private static String[] imebr = new String[] { "nula", "jedan", "dva", "tri", "četiri", "pet", "šest", "sedam", "osam", " devet" };



        public static string NumberToText(long num)
        {
            string text = "";
            long dekada = 1000000000;
            long suma = 0;
            long[] cifre = new long[10];
            long temp = 0;
            for (int i = 0; i < 10; i++)
            {
                //generisi niz cifara od broja
                cifre[i] = (num - suma) / dekada;
                suma = suma + dekada * cifre[i];
                dekada /= 10;
            }

            text += SingleNumber(cifre[0], 0);

            temp += cifre[1] * 100 + cifre[2] * 10 + cifre[3];
            text += SingleNumber(temp, 1);
            temp = 0;

            temp += cifre[4] * 100 + cifre[5] * 10 + cifre[6];
            text += SingleNumber(temp, 2);
            temp = 0;

            temp += cifre[7];
            text += SingleNumber(temp, 3);
            temp = 0;

            temp += cifre[8];
            text += SingleNumber(temp, 4);
            temp = 0;

            temp += cifre[9];
            text += SingleNumber(temp, 5);
            temp = 0;

            return text;

        }

        private static string SingleNumber(long num, int dekada)
        {
            string a = "";
            string cifra = SingleNumber(num);
            if (dekada == 0 && cifra != "0")
                a += cifra + " milijardi ";
            if (dekada == 1 && cifra != "0")
                a += cifra + " miliona ";
            if (dekada == 2 && cifra != "0")
                a += cifra + " hiljada ";
            if (dekada == 3 && cifra != "0")
                a += cifra + " stotina ";
            if (dekada == 4 && cifra != "0")
                a += cifra + " ";
            if (dekada == 5 && cifra != "0")
                a += cifra + " ";

            return a;

        }

        private static string SingleNumber(long num)
        {

            return imebr[num];
        }

    }
}

   
