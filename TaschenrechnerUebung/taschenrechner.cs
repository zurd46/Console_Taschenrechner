using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Einfacher Taschenrechner");

            while (true)
            {
                Console.Write("Geben Sie den erste Zahl ein: ");
                if (!double.TryParse(Console.ReadLine(), out double operand1))
                {
                    Console.WriteLine("Ungültige Eingabe für den erste Zahl.");
                    continue;
                }

                Console.Write("Geben Sie die zweite Zahl ein: ");
                if (!double.TryParse(Console.ReadLine(), out double operand2))
                {
                    Console.WriteLine("Ungültige Eingabe für die zweite Zahl.");
                    continue;
                }

                Console.WriteLine("Welche Operation möchten Sie genau? (Zahl wählen)");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraktion");
                Console.WriteLine("3 - Multiplikation");
                Console.WriteLine("4 - Division");

                int operationChoice;
                if (!int.TryParse(Console.ReadLine(), out operationChoice) || operationChoice < 1 || operationChoice > 4)
                {
                    Console.WriteLine("Ungültige Operation ausgewählt.");
                    continue;
                }

                double result = 0.0;

                switch (operationChoice)
                {
                    case 1:
                        result = operand1 + operand2;
                        break;
                    case 2:
                        result = operand1 - operand2;
                        break;
                    case 3:
                        result = operand1 * operand2;
                        break;
                    case 4:
                        if (operand2 != 0)
                        {
                            result = operand1 / operand2;
                        }
                        else
                        {
                            Console.WriteLine("\nDivision durch Null ist nicht erlaubt.");
                            continue;
                        }
                        break;
                }

                Console.WriteLine($"\nErgebnis: {result:F2}");

                Console.Write("Möchten Sie eine weitere Berechnung durchführen? (J/N): ");
                char response = Console.ReadKey().KeyChar;
                if (response != 'J' && response != 'j')
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
