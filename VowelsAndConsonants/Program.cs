using System;

namespace VowelsAndConsonants
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsi kasutajal sisestada tähte
            //programm kontrollib,kas sisestatud täht on
            //täishäälik või kaashäälik
            //kui siestatud täht on täishäälik - programm kuvab
            //"täishäälik"
            //kui sisestatud täht on kaashäälik
            //programm kuvab "kaashäälik"
            //kasutame switchi'i

            Console.WriteLine("Sisesta täht:");
            char usercharacter = Convert.ToChar(Console.ReadLine().ToLower());

            switch (usercharacter)
            { 
              case 'a':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'e':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'i':
                    Console.WriteLine("Täishäälik");
                    break;
                case 'o':
                Console.WriteLine("Täishäälik");
                    break;
                case 'u':
                    Console.WriteLine("Täishäälik");
                break;

                default:
                    Console.WriteLine("Kaashäälik");
                break;

            }
            Console.WriteLine("Kena päeva");



















        }
    }
  }