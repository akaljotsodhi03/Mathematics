namespace Gates_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for Top input (0 or 1): ");
            int top = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value for Middle input (0 or 1): ");
            int middle = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value for Bottom input (0 or 1): ");
            int bottom = Convert.ToInt32(Console.ReadLine());

            // First OR gate: top OR middle
            int or1 = top | middle;

            // Second OR gate: middle OR bottom
            int or2 = middle | bottom;

            // NOT gate: invert or2
            int notOr2;
            if (or2 == 0)
                notOr2 = 1;
            else
                notOr2 = 0;

            // AND gate: or1 AND notOr2
            int x = or1 & notOr2;

            Console.WriteLine("X = " + x);
        }
    }
}
