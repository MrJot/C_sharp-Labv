using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juszkiew_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> rawList = new List<int>();
            List<int> conditionalList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj liczbe:");
                rawList.Add(int.Parse(Console.ReadLine()));
            }
            rawList.ForEach(Console.Write);

            foreach(var i in rawList){
                if (i <= 2)
                {
                    rawList.Remove(i);
                }
            }

            rawList.ForEach(Console.Write);
       
            Console.ReadKey();
        }

        private static void SortowanieWstawianieCalosc()
        {
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy:");
                int rozmiarTablicy = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj gorny limit tablicy:");
                int gornyLimit = int.Parse(Console.ReadLine());

                int[] table = inicializacjaTablicy(rozmiarTablicy, gornyLimit);
                drukowanieTablicy(table);
                Console.WriteLine("Po sortowaniu....\n");
                drukowanieTablicy(sortowanieWstawianie(table));
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Nieprawidlowy format danych !");
                Console.ReadKey();
            }
        }

        public static int[] sortowanieWstawianie(int[] tableToSort)
        {
            {
                for (int i = 0; i < tableToSort.Length - 1; i++)
                {
                    int j = i + 1;

                    while (j > 0)
                    {
                        if (tableToSort[j - 1] > tableToSort[j])
                        {
                            int temp = tableToSort[j - 1];
                            tableToSort[j - 1] = tableToSort[j];
                            tableToSort[j] = temp;

                        }
                        j--;
                    }
                }
                return tableToSort;
            }


        }


        private static void Cwiczenie7SortowanieBabelkowe()
        {
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy:");
                int rozmiarTablicy = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj gorny limit tablicy:");
                int gornyLimit = int.Parse(Console.ReadLine());

                int[] table = inicializacjaTablicy(rozmiarTablicy, gornyLimit);
                drukowanieTablicy(table);
                Console.WriteLine("Po sortowaniu....\n");
                drukowanieTablicy(sortowanieBabelkowe(table));
                Console.ReadKey();
            }
            catch (Exception)
            {

                Console.WriteLine("Nieprawidlowy format danych !");
                Console.ReadKey();
            }
        }

        public static int[] sortowanieBabelkowe(int[] tableToSort)
        {
            for (int i = 0; i < tableToSort.Length; i++)
            {
                for (int j = 0; j < tableToSort.Length - 1; j++)
                {
                    if (tableToSort[j] > tableToSort[j + 1])
                    {
                        int temp;
                        temp = tableToSort[j + 1];
                        tableToSort[j + 1] = tableToSort[j];
                        tableToSort[j] = temp;
                    }
                }
            }

            return tableToSort;

        }

        public static void drukowanieTablicy(int[] table)
        {
            foreach (var i in table)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("\n");
        }

        public static int[] inicializacjaTablicy(int rozmiarTablicy, int gornyLimit)
        {
      
                int[] table = new int[rozmiarTablicy];
                Random rand = new Random();
                for (int i = 0; i < table.Length; i++)
                {
                    table[i] = rand.Next(1, gornyLimit);
                }
                return table;
        
        }

        private static void CwiczenieNr6()
        {
            Console.WriteLine("Podaj rozmiar tablicy");
            int rozmiarTablicy = int.Parse(Console.ReadLine());
            int[] table = new int[rozmiarTablicy];
            Console.WriteLine("Podaj gorny limit wartości w tablicy ");
            int gornyLimit = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = rand.Next(1, gornyLimit);
            }


            Console.WriteLine("Twoja tablica: ");

            foreach (var i in table)
            {
                Console.Write(i + ",");
            }


            Console.ReadKey();
        }

        private static void CwiczeniePiatePunktTrzeci()
        {
            Console.WriteLine("Obliczenie silni metoda rekurencyjna \n");
            Console.WriteLine("Podaj liczbe: ");
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine("Twoj wynik wyonsi: " + silniaRekurencyjnie(liczba));
            Console.ReadKey();
        }

        private static int silniaRekurencyjnie(int liczba)
        {
            if (liczba == 1)
                return 1;
            else
                return liczba * silniaRekurencyjnie(liczba - 1);
        }

        private static void Cwiczenie5PunktBSilnia()
        {
            Console.WriteLine("Podaj liczbe dla której chcesz policzyc silnie");
            int liczba = int.Parse(Console.ReadLine());
            for (int i = liczba - 1; i >= 1; i--)
            {
                liczba = liczba * i;
            }

            Console.WriteLine("Twoj wynik wynosi: " + liczba);
            Console.ReadKey();
        }

        private static void CwiczeniePiatePunktPierwszy()
        {
            while (true)
            {
                Console.WriteLine("Napisz cos");
                string userInput = Console.ReadLine();
                if (userInput == "q")
                {

                    break;
                }
                else
                {
                    Console.WriteLine(userInput);
                }
            }

            Console.WriteLine("Do widzenia");
        }

        private static void Cwiczenie4Switch()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            double pierwszaLiczba = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            double drugaLiczba = Double.Parse(Console.ReadLine());
            Console.Write("Podaj typ operacji, który chcesz wykonać");
            string operacja = Console.ReadLine();
            switch (operacja)
            {
                case ":":
                    Console.WriteLine("Wynik dzielenia: " + (pierwszaLiczba / drugaLiczba));
                    break;
                case "*":
                    Console.WriteLine("Wynik mnozenia: " + (pierwszaLiczba * drugaLiczba));
                    break;
                case "+":
                    Console.WriteLine("Wynik dodawania: " + (pierwszaLiczba + drugaLiczba));
                    break;
                case "-":
                    Console.WriteLine("Wynik odejmowania: " + (pierwszaLiczba - drugaLiczba));
                    break;
                default:
                    Console.WriteLine("Nie wiem co chciales zrobic");
                    break;

            }

            Console.ReadKey();
        }

        private static void CwiczenieDrugieTrzecie()
        {
            Console.WriteLine("Podaj imie: \n");
            Console.WriteLine("Imie:");
            string Imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: \n");
            Console.WriteLine("Imie:");
            string Nazwisko = Console.ReadLine();
            Console.WriteLine("Twoje imie i nazwisko to: " + Imie + " " + Nazwisko);

            try
            {
                Console.WriteLine("Podaj rok urodzenia:");
                int dataUrodzenia = int.Parse(Console.ReadLine());
                int rok = 2018;
                Console.WriteLine("Twoj aktualny wiek: " + (rok - dataUrodzenia));
                Console.WriteLine("Podaj swoj wzrost w cm");
                double wysokos = Double.Parse(Console.ReadLine());
                Console.WriteLine("Twoja wysokos w metrach wynosi: " + (wysokos / 100) + " m");

            }
            catch (Exception)
            {

                Console.WriteLine("Niepoprawna liczba.");
            }


            Console.ReadKey();
        }

        private static void CwiczeniePierwsze()
        {
            Console.WriteLine("Hello World");

            double a = 23.43;
            decimal b = 15;
            int c = 5;
            char d = 'a';
            string e = "Grzegorz";
            long f = 23;

            Console.WriteLine("Wartosc zmiennej int: " + c + " wartosc minimalna: " + int.MinValue);
            Console.WriteLine("Wartosc zmiennej int: " + c + " wartosc maksymalna: " + int.MaxValue);
            Console.WriteLine("Wartosc zmiennej int: " + b + " wartosc minimalna: " + decimal.MinValue);
            Console.WriteLine("Wartosc zmiennej int: " + b + " wartosc maksymalna: " + decimal.MaxValue);
            Console.WriteLine("Wartosc zmiennej int: " + a + " wartosc minimalna: " + double.MinValue);
            Console.WriteLine("Wartosc zmiennej int: " + a + " wartosc maksymalna: " + double.MaxValue);
            Console.WriteLine("Wartosc zmiennej int: " + d + " wartosc minimalna: " + char.MinValue);
            Console.WriteLine("Wartosc zmiennej int: " + d + " wartosc maksymalna: " + char.MaxValue);
            Console.WriteLine("Wartosc zmiennej int: " + f + " wartosc minimalna: " + long.MinValue);
            Console.WriteLine("Wartosc zmiennej int: " + f + " wartosc maksymalna: " + long.MaxValue);
            Console.WriteLine("Wartosc zmiennej int: " + e + " Brak rozmiaru dla stringa");
            Console.ReadKey();
        }
    }
}
