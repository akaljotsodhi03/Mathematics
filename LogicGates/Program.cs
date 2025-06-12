using System;

namespace Logic_Gates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a logic gate:");
            Console.WriteLine("1. AND");
            Console.WriteLine("2. OR");
            Console.WriteLine("3. NOT (only A)");
            Console.WriteLine("4. NAND");
            Console.WriteLine("5. NOR");
            Console.WriteLine("6. XOR");
            Console.WriteLine("7. XNOR");
            Console.Write("Enter your choice (1-7): ");
            int choice = GetValidGateChoice();

            int a = GetValidInput("A");
            int b = 0, result = 0;

            // NOT only needs one input
            if (choice != 3)
                b = GetValidInput("B");

            switch (choice)
            {
                case 1:
                    result = AndGate(a, b);
                    Console.WriteLine($"AND: {result}");
                    break;
                case 2:
                    result = OrGate(a, b);
                    Console.WriteLine($"OR: {result}");
                    break;
                case 3:
                    result = NotGate(a);
                    Console.WriteLine($"NOT: {result}");
                    break;
                case 4:
                    result = NandGate(a, b);
                    Console.WriteLine($"NAND: {result}");
                    break;
                case 5:
                    result = NorGate(a, b);
                    Console.WriteLine($"NOR: {result}");
                    break;
                case 6:
                    result = XorGate(a, b);
                    Console.WriteLine($"XOR: {result}");
                    break;
                case 7:
                    result = XnorGate(a, b);
                    Console.WriteLine($"XNOR: {result}");
                    break;
            }
        }

        static int GetValidInput(string variableName)
        {
            int value;
            while (true)
            {
                Console.Write($"Enter value for {variableName} (0 or 1): ");
                string input = Console.ReadLine();
                if (input == "0" || input == "1")
                {
                    value = Convert.ToInt32(input);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter 0 or 1.");
                }
            }
            return value;
        }

        static int GetValidGateChoice()
        {
            int value;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out value) && value >= 1 && value <= 7)
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid choice! Please enter a number between 1 and 7: ");
                }
            }
            return value;
        }

        // Logic gate methods
        static int AndGate(int a, int b) => a & b;
        static int OrGate(int a, int b) => a | b;
        static int NotGate(int a)
        {
            if (a == 0)
                return 1;
            else
                return 0;
        }
        static int NandGate(int a, int b)
        {
            if ((a & b) == 0)
                return 1;
            else
                return 0;
        }
        static int NorGate(int a, int b)
        {
            if ((a | b) == 0)
                return 1;
            else
                return 0;
        }
        static int XorGate (int a , int b)
        {
            int or = a | b;         // A OR B
            int and = a & b;        // A AND B
            int notAnd;
            if (and == 0)
                notAnd = 1;
            else
                notAnd = 0;
            return or & notAnd;
        }
        static int XnorGate(int a, int b)
        {
            if ((a ^ b) == 0)
                return 1;
            else
                return 0;
        }

        static void SolveOrXorCircuit(int a, int b)
        {
            Console.Write("Enter value for C (0 or 1): ");
            int c = Convert.ToInt32(Console.ReadLine());

            int orResult = a | b; // (A OR B)
            int andResult = orResult & c; // (A OR B) AND C

            int notAndResult;
            if (andResult == 0)
                notAndResult = 1;
            else
                notAndResult = 0;

            int finalOutput = (orResult | c) & notAndResult; // (A OR B OR C) AND NOT[(A OR B) AND C]

            Console.WriteLine("Circuit Output: " + finalOutput);
        }
    }
}
