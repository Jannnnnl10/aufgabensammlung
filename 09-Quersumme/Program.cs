using System;

class Program
{
    static void Main(string[] args)
    {
        // Der Benutzer wird aufgefordert eine Zahl einzugeben
        Console.Write("Bitte geben Sie eine Zahl ein: ");
        string input = Console.ReadLine();

        // Der Befehl überprüft ob die eingegebene Zahl (input) gültig ist.
        if (int.TryParse(input, out int number))
        {
            // Die Quersumme wird berechnet
            int sum = CalculateDigitSum(number);
            // Das Ergebnis wird hier ausgegeben
            Console.WriteLine("Die Quersumme von" + number + "ist:" + sum);
        }
        else
        {
            //Im Falle einer ungültigen Zahl (Kommazahlen)
            Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
        }
        Console.ReadKey();
    }

    // Methode mit der die Quersumme berechnet wird
    static int CalculateDigitSum(int number)
    {
        int sum = 0;
        // Absoluten Wert verwenden, um mit negativen Zahlen umzugehen
        number = Math.Abs(number);

        while (number > 0)
        {
            sum += number % 10; // Die letzte Ziffer zur Summe hinzufügen
            number /= 10; // Die letzte Ziffer entfernen
        }

        return sum;
        Console.ReadKey();
    }
}
