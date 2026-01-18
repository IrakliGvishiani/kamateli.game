namespace kamateli.game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] player1Roll = new int[10];

            int[] player2Roll = new int[10];

            int sum = 0;
            int sum2 = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                player1Roll[i] = random.Next(1, 7);
                player2Roll[i] = random.Next(1, 7);

                /// shortcut  რო ლუპი ორჯერ არ დატრიალდეს
                sum += player1Roll[i];
                sum2+= player2Roll[i];
            }
           
            ///მეორე ვარიანტი
            //foreach (int roll in player1Roll)
            //{
            //    //Console.WriteLine("Player 1 Roll: " + roll);
            //    sum += roll;
            //}
            //foreach (int roll in player2Roll)
            //{
            //    //Console.WriteLine("Player 1 Roll: " + roll);
            //    sum2 += roll;
            //}

            Console.WriteLine($"Player 1 Final Score : {sum}");
            Console.WriteLine($"Player 2 Final Score : {sum2}");



            if (sum > sum2)
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else if(sum2 > sum)
            {
                Console.WriteLine("Player 2 Wins!");
            }
            else
            {
             Console.WriteLine("It's a Tie!");
            }

        }
    }
}
