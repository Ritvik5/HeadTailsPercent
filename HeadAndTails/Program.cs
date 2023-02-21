namespace HeadAndTails
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFlips = 10;
            int numHead = 0;
            int numTail = 0;
            Random random = new Random();

            for(int i = 0;i< numFlips;i++)
            { 
                int result=random.Next(0,2);
                if (result == 0)
                {
                    numHead++;
                }
                else
                { 
                    numTail++;
                }
            }
            double percentHead = (double)numHead / numFlips * 100;
            double percentTail = (double)numTail / numFlips * 100;

            Console.WriteLine("Heads " + numHead + " (" + percentHead.ToString("0.00") + "%)");
            Console.WriteLine("Tails " + numTail + " (" + percentTail.ToString("0.00") + "%)");
        }
    }
}