using System;

namespace Labb_01_Hitta_tal_i_sträng_med_tecken
{
    class Program
    {
        static void Main(string[] args)
        {
            string search = "29535123p48723487597645723645"; //Sträng för att leta efter tecken.
            SearchNumberInString(search);
            Console.Read();
        }

        static void SearchNumberInString(string input) //Skapa en method som hittar tal från start index till stop index.
        {
            long sum = 0;
            long totalSum = 0;
            for (int i = 0; i < input.Length; i++) 
            {
                if (Char.IsDigit(input[i])) //Se till att vår input[j] ej tar med bokstäver.
                {
                    for (int j = i + 1; j < input.Length; j++) 
                    {
                        if (input[i] == input[j])
                        {
                            sum = Convert.ToInt64(input.Substring(i, j - i + 1)); //Konvertera vår sträng till en long för uträkning.
                            totalSum += sum; 
                            ColorizedText(input, i, j); 
                            break;//Bryter när vi hittar i == j iställer för att fortsätta leta efter fler i == j
                        }
                        else if (!Char.IsDigit(input[j])) 
                        {
                            break;
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nTotal sum of highlighted text added together is: {0}", totalSum); 
        }

        static void ColorizedText(string input, int i, int j) //Skapa en method för att skriva ut hela strängen samt markera(med färg) start[i] och stop[j]
        {
            Console.Write(input.Substring(0, i)); 

            Console.ForegroundColor = ConsoleColor.DarkCyan; 
            Console.Write(input.Substring(i, j - i + 1));
            Console.ForegroundColor = ConsoleColor.Gray; 

            if (j < input.Length) //Skriv ut resterande text EFTER hittad index[j]
            {
                Console.Write(input.Substring(j + 1));
            }
            Console.WriteLine();
        }
    }
}

