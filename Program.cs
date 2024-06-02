using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNr1_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {/* deklaracja zmiennej dla przechowania kodu wciśniętego klawisza 
            przez Użytkownika programu */
            ConsoleKeyInfo WybranaFunkcjonalność;
            // wypisanie Tytułu Projektu Nr 1 i ogólnego zakresu jego funkcjonalności
            Console.WriteLine("\n\n\n\t\t\t\t\t\tProjekt_Nr1_Console_App");
            Console.WriteLine("\n\t\tumożliwia wielokrotne obliczanie(może być powtarzane!) " +
                                          "wartości wybranych wielkości matematycznych");
            // chwilowe zatrzymanie wykonywania programu
            Console.Write("\n\t\tDla kontynuacji dalszego działania programu naciśnij " +
                                                                          "dowolny klawisz . . . ");
            Console.ReadKey();

            //  MENU Projektu Nr 1
            do // powtarzaj aż do naciśnięcia klawisza 'X'
            {   // zresetowanie (wyczyszczenie) okna konsoli
                Console.Clear(); // czyszczenie okna konsoli z poprzednich obliczeń
                // wypisanie MENU Projektu Nr 1
                Console.WriteLine("\n\tMenu funkcjonalne Projektu Nr 1: \n");
                Console.WriteLine("\t\tA. Kalkulator laboratoryjny");
                Console.WriteLine("\t\tB. Kalkulator indywidualny");
                Console.WriteLine("\t\tX. Zakończenie (Wyjście z ) programu");
                // podpowiedź dla Użytkownika
                Console.Write("\n\n\t\tNaciśnięciem odpowiedniego klawisza (A lub B lub X) wybierz  " +
                    "\n\t\t jedną z funkcjonalnośći: ");

                // wczytanie "wyboru" Użytkownika
                WybranaFunkcjonalność = Console.ReadKey();
                // rozpoznaie wybranej funkcjonalności z zastosowaniem instrukcji 'if-else'
                if (WybranaFunkcjonalność.Key == ConsoleKey.A)
                    // wywołanie Kalkulatora laboratoryjnego
                    KalkulatorLaboratoryjny();
                else
                    if (WybranaFunkcjonalność.Key == ConsoleKey.B)
                    // wywołanie Kalkulatora indywidualnego
                    KalkulatorIndywidualny();
                else
                  if (WybranaFunkcjonalność.Key != ConsoleKey.X)
                { // jest błąd, to go sygnalizujemy
                    Console.WriteLine("\n\n\t\tERROR: nacisnąłeś niedozwolony klawisz (znak)!!!!");
                    // chwilowe zatrzymanie wykonywania programu
                    Console.Write("\n\t\tDla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                    Console.ReadKey();

                }
                // "zamknięcie" instrukcji 'do'
            } while (WybranaFunkcjonalność.Key != ConsoleKey.X);
            // będziemy tutaj, gdy Użytkownika wybierze funkcjonalnoś (nacisnął klawisz) 'X'
            Console.WriteLine("\n\n\t\tAutor Projektu Nr 1 : Jung 7777");
            // data uruchomienia i testowanai programu
            Console.WriteLine("\n\t\tDzisiejsza data : {0}", DateTime.Now);
            // chwilowe zatrzymanie wykonywania programu
            Console.Write("\n\t\tDla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
            Console.ReadKey();
        }

        // deklaracje metod implementacji Kalkulatorów
        static void KalkulatorLaboratoryjny()
        {
            // Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorLaboratoryjny");

            // deklaracja zmiennej dla przechowania kodu wciśniętego klawisza przez Użytkownika programu
            ConsoleKeyInfo WybranaFunkcjonalność;
            // powtarzanie obliczeń Kalkulatora laboratoryjnego
            do
            {
                // czyszczenie konsoli
                Console.Clear();
                Console.WriteLine("\n\t\t MENU Kalkulatora laboratoryjnego:");
                Console.WriteLine("\t\tA. Obliczenie sumy wyrazów ciągu liczbowego");
                Console.WriteLine("\t\tB. Obliczenie iloczynu wyrazów ciągu liczbowego");
                Console.WriteLine("\t\tC. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego");
                Console.WriteLine("\t\tD. Obliczenie pierwiastków równania kwadratowego");
                Console.WriteLine("\t\tE. Obliczenie wartości wielomianu n-tego stopnia");
                Console.WriteLine("\t\tF. Konwersja znakowego zapisu liczby naturalnej na wartość");
                Console.WriteLine("\t\tX. Zakończenie działania (wyjście z ) Kalkulatora laboratoryjnego");
                // podpowiedź dla Użytkownika
                Console.Write("\n\n\t\tNaciśnięciem odpowiedniego klawisza (A lub B . . . X) wybierz  " +
                    "\n\t\t jedną z funkcjonalnośći: ");
                // wczytanie "wyboru" Użytkownika
                WybranaFunkcjonalność = Console.ReadKey();
                // rozpoznaie wybranej funkcjonalności z zastosowaniem instrukcji 'switch'
                switch (WybranaFunkcjonalność.Key)
                {
                    case ConsoleKey.A: //A. Obliczenie sumy wyrazów ciągu liczbowego
                        // potwierdzenie wybrania danej funkcjonalności 
                        Console.WriteLine("\n\n\t\tWYBRANO: A. Obliczenie sumy arytmetycznej wyrazów " +
                                                                                  "ciągu liczbowego");
                        // deklaracja zmiennych dla przechowania czytanych danych wejściowych
                        ushort n;
                        float a;
                        // deklaracja zmiennej S dla przechowania wyniku obliczeń 
                        float S;

                        // wypisanie zaproszenia do podania 'n'
                        Console.Write("\n\tPodaj liczność ciągu liczbowego 'n' = ");
                        while (!ushort.TryParse(Console.ReadLine(), out n))
                        {// był bład , to go sygnalizujemy
                            Console.WriteLine("\n\tError: w zapisie podanej licznośći ciągu liczbowego" +
                                                                "wystąpił niedozwolony znak!");
                            //Wypisanie zaproszenia do podania 'n'
                            Console.Write("\n\tPodaj ponownie liczność ciągu liczbowego 'n' = ");
                        }

                        //sprawdzanie warunku wejsciowego
                        if (n == 0)
                            //sygnalizujemy bład
                            Console.WriteLine("\n\tError: w zapisie podanej licznośći ciągu liczbowego" +
                                                          "'n' nie spełnia waurnku wejsciowego:  n > 0");
                        // tu jakiś nawias!!!! 
                        while (n == 0) ;
                        // gdy bedziemy tutaj, to na pewno: n> 0
                        // ustaleni początkowego stanu obliczeń 
                        S = 0;
                        // interacyjne obliczenie sumy wyrazów ciagu liczbowego 
                        for (int i = 1; i <= n; i++)  //i++ odpowiada: i = i +1;
                        {//wczytanie i-tej wartości wyrazu ciągu liczbowego 
                            Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);
                            while (!float.TryParse(Console.ReadLine(), out a))
                            {// był błą, to go synchronizujemy 
                                Console.WriteLine("\n\tERROR: w podanej wartości wyrazu ciagu " +
                                    "Liczbowego wystąpił niedozwolony znak");
                                //wczytanie i-tej wartości wyrazu ciągu liczbowego 
                                Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);

                            }
                            // iteracyjne obliczanie sumy wyrazów ciagu liczbowego
                            S = S + a;

                        }

                        // wypisanie wyniku obliczeń
                        // format stało pozycyjny
                        Console.WriteLine("n\n\tWynik obliczęń: obliczona suma(0) wyrazów ciagu liczbowego jest  " +
                                                "równa: S = (1, 8:F3)", n, S);
                        // format wykładniczy (naukowy)
                        Console.WriteLine("n\n\tWynik obliczęń: obliczona suma(0) wyrazów ciagu liczbowego jest  " +
                                                "równa: S = (1, 8:E3)", n, S);
                        // format najlepiej "dopasowany" do wypisanej wartości 
                        Console.WriteLine("n\n\tWynik obliczęń: obliczona suma(0) wyrazów ciagu liczbowego jest  " +
                                                "równa: S = (1, 8:G3)", n, S);


                        //  .   .   . tutaj będą obliczenia .  .   .
                        Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorIndywidualny");
                        // chwilowe zatrzymanie wykonywania programu
                        Console.Write("\n\t\tWYJŚCIE z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B: //B. Obliczenie iloczynu wyrazów ciągu liczbowego
                                       // potwierdzenie wybrania danej funkcjonalności 
                        Console.WriteLine("\n\n\t\tWYBRANO: B. Obliczenie iloczynu wyrazów " +
                                                                                  "ciągu liczbowego");
                        //ushort n;  juz jest zadeklarowana w case ConsolKey.A
                        //float a;  juz jest zadeklarowana w case ConsolKey.A
                        // deklaracja zmiennej dla przechowywania wyniku iloczynu 
                        float Iloczyn;


                        // wczytanie liczności  'n' oraz sprawdzenie warunku wejsciowego
                        do
                        {
                            // wczytanie liczności wyrazów ciągu liczbowego  'n'
                            n = WczytajLiczbęNaturlana("Podaj licznosć ciągu liczbowego 'n'");
                            // sprawdzenie warunku wejsciowego 
                            if (n == 0)
                                //sygnalizujemy bład
                                Console.WriteLine("\n\tError: w zapisie podanej licznośći ciągu liczbowego" +
                                                              "'n' nie spełnia waurnku wejsciowego:  n > 0");

                        } while (n == 8);
                        // obliczanie iloczynu wyraznów cagu iloczynowego
                        Iloczyn = 1.0F;
                        // deklaracja zmiennej typu 'string' dla zredagowania Zaproszenia
                        string TextZaproszenia;

                        // iteracyjnie obliczanie iloczynu 

                        for (int i = 1; i <= n; i++)
                        {// przygotowani aktualnego tekstu zaproszenia 
                            TextZaproszenia = string.Format("Podaj wartość {0}-tego wyrazu ciągu liczbowego", i);

                            //wczytanie i-tego  wyrazu ciągu liczbowego 'a'
                            WczytajLiczbęRzeczywistą(TextZaproszenie, out a);
                            // iteracyjny obliczenie iloczynu
                            Iloczyn = Iloczyn * a;

                        }
                        // Wypisani wyniku obliczeñ 
                        // format stało pozycyjny
                        Console.WriteLine("n\n\tWynik obliczęń: obliczona iloczyn(0) wyrazów ciagu liczbowego jest  " +
                                                "równa: S = (1, 8:F3)", n, Iloczyn);
                        // format wykładniczy (naukowy)
                        Console.WriteLine("n\n\tWynik obliczęń: obliczona iloczyn(0) wyrazów ciagu liczbowego jest  " +
                                                "równa: S = (1, 8:E3)", n, Iloczyn);
                        // format najlepiej "dopasowany" do wypisanej wartości 
                        Console.WriteLine("n\n\tWynik obliczęń: obliczona iloczyn(0) wyrazów ciagu liczbowego jest  " +
                                                "równa: S = (1, 8:G3)", n, Iloczyn);
                }
                // wypisanie wyników obliczęń 



                //  .   .   . tutaj będą obliczenia .  .   .
                Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorIndywidualny");
                // chwilowe zatrzymanie wykonywania programu
                Console.Write("\n\t\tWYJŚCIE z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                Console.ReadKey();
                break;
                    case ConsoleKey.C: //C. Obliczenie średniej arytmetycznej wyrazów ciągu liczbowego
                                       // potwierdzenie wybrania danej funkcjonalności 
                    Console.WriteLine("\n\n\t\tWYBRANO: C. Obliczenie średniej arytmetycznej wyrazów " +
                                                                              "ciągu liczbowego");
                    //  .   .   . tutaj będą obliczenia .  .   .
                    Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorIndywidualny");
                    // chwilowe zatrzymanie wykonywania programu
                    Console.Write("\n\t\tWYJŚCIE z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                    Console.ReadKey();
                    break;
                case ConsoleKey.D: //D. Obliczenie pierwiastków równania kwadratowego
                                   // potwierdzenie wybrania danej funkcjonalności 
                    Console.WriteLine("\n\n\tWYBRANO: D. Obliczenie pierwiastków równania kwadratowego");
                    //  .   .   . tutaj będą obliczenia .  .   .
                    Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorIndywidualny");
                    // chwilowe zatrzymanie wykonywania programu
                    Console.Write("\n\t\tWYJŚCIE z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                    Console.ReadKey();
                    break;
                case ConsoleKey.E: //E. Obliczenie wartości wielomianu n-tego stopnia
                                   // potwierdzenie wybrania danej funkcjonalności 
                    Console.WriteLine("\n\n\tWYBRANO: E. Obliczenie wartości wielomianu n-tego stopnia");

                    //  .   .   . tutaj będą obliczenia .  .   .
                    Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorIndywidualny");
                    // chwilowe zatrzymanie wykonywania programu
                    Console.Write("\n\t\tWYJŚCIE z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                    Console.ReadKey();
                    break;
                case ConsoleKey.F: //F. Konwersja znakowego zapisu liczby naturalnej na wartość binarną
                                   // potwierdzenie wybrania danej funkcjonalności 
                    Console.WriteLine("\n\n\tWYBRANO: F. Konwersja znakowego zapisu liczby naturalnej na wartość");

                    //  .   .   . tutaj będą obliczenia .  .   .
                    Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorIndywidualny");
                    // chwilowe zatrzymanie wykonywania programu
                    Console.Write("\n\t\tWYJŚCIE z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                    Console.ReadKey();
                    break;
                case ConsoleKey.X: //poprawne zakończenie działani kalkulatora
                                   // nie wykonujemy żanych dodatkowych działań             
                    break;
                default:
                    // jest błąd, to go sygnalizujemy
                    Console.WriteLine("\n\n\t\tERROR: nacisnąłeś niedozwolony klawisz (znak)!!!!");

                    break;
                }
                // chwilowe zatrzymanie wykonywania programu
                Console.Write("\n\t\tSprawdź wyniki i dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
                Console.ReadKey();

            } while (WybranaFunkcjonalność.Key != ConsoleKey.X);

            // chwilowe zatrzymanie wykonywania programu
            Console.Write("\n\t\tWYJŚCIE z KALKULATORA LBORATORYJNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
            Console.ReadKey();
        }
        static void KalkulatorIndywidualny()
        {
            Console.WriteLine("\n\n\t\tPRZEPRASZAMY,  ake jestem w trakcie projektowania: nazywam się: KalkulatorIndywidualny");
            // chwilowe zatrzymanie wykonywania programu
            Console.Write("\n\t\tWYJŚCIE z KALKULATORA INDYWIDUALNEGO: dla kontynuacji dalszego działania programu naciśnij dowolny klawisz: ");
            Console.ReadKey();
        }// koniec kalkulatora
        #region Metody kalkulatora laboratoryjnego 
        // deklaracja metody WczytajLiczbęNaturlana( . . )
        static ushort WczytajLiczbęNaturlana(string TextZaproszenia)
        {  // deklaracja pomocnicza na przechowywanie wczytanej liczności ciągu liczbowego 
            ushort N;


            // pomocnicza deklaracja  dla zredagowania pełnego Zaproszenia
            string Zaproszenie = "\n\t" + TextZaproszenia + "\n:";   // tu mi podpowiedziało innaczej zapisane + ":";

            // wypisanie zaproszenia
            Console.Write(Zaproszenie);
            while (ushort.TryParse(Console.ReadLine(), out )) ;
            {// był bład , to go sygnalizujemy
                Console.WriteLine("\n\tError: w zapisie podanej wartości liczby" +
                                                    "wystąpił niedozwolony znak!");
                //Wypisanie zaproszenia na ponownego  podania liczby 'n'
                Console.Write(Zaproszenie);
            }

            // zwrotne przekazanie wczytanej liczby  naturalnej 
            return N;

        }
        //deklaracja dla wczytania  liczby typu 'float'

        static void WczytajLiczbęRzeczywistą(string TextZaproszenia, out float L)
        {
            // deklaracja pomocnicza dla pełnego zredagowania Zaproszenia
            string Zaproszenie = "\n\t" + ": ";
            //wczytanie wartości liczby rzeczywistej  
            Console.Write(Zaproszenie);
            while (!float.TryParse(Console.ReadLine(), out a))
            {// był błąd, to go sygnalizujemy 
                Console.WriteLine("\n\tERROR: w podanej wartości liczby rzeczywistej " +
                    "Liczbowego wystąpił niedozwolony znak !");
                // ponownie zaproszenia
                Console.Write("\n\tPodaj wartość  tej liczby ponownie ");
                Console.Write(Zaproszenie);
            }



            //wczytanie i-tej wartości wyrazu ciągu liczbowego 
            Console.Write("\n\tPodaj wartość {0} -ego wyrazu ciągu liczbowego: ", i);

        }
        // iteracyjne obliczanie sumy wyrazów ciagu liczbowego
        S = S + a;




       }
    #region 
}
}
