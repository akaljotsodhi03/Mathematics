namespace Gates1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get inputs for the first NAND gate
            int a1 = GetValidInput("First input for top NAND gate");
            int b1 = GetValidInput("Second input for top NAND gate");

            // Get inputs for the second NAND gate
            int a2 = GetValidInput("First input for bottom NAND gate");
            int b2 = GetValidInput("Second input for bottom NAND gate");

            // Compute NAND outputs
            int topNand = Nand(a1, b1);
            int bottomNand = Nand(a2, b2);

            // Final AND gate
            int finalOutput = topNand & bottomNand;

            Console.WriteLine("Circuit Output: " + finalOutput);
        }

        static int GetValidInput(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write($"{prompt} (0 or 1): ");
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

        static int Nand(int x, int y)
        {
            int andResult = x & y;
            if (andResult == 0)
                return 1;
            else
                return 0;
        }
    }
}
