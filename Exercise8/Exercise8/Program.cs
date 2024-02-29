namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            Console.WriteLine("How many even number?");
            int maxNumber = int.Parse(Console.ReadLine());
            int loopCounter;
            //print even numbers up to requested max
            for (loopCounter = 0; loopCounter < maxNumber; loopCounter += 2)
            {
                Console.WriteLine(loopCounter);
            }
            //Problem 2
            Console.Write("How wide?");
            int maxWidth = int.Parse(Console.ReadLine());
            for (int i = 0; i < maxWidth; i++)
            {
                //if user enters 5, should print *****
                Console.Write("*");
            }

        }
    }
}

