namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************Welcome To Sanke and Ladder Game**********************");

            SnakeLadderGame game = new SnakeLadderGame();
            game.SnakeLadder();
        }
    }
}