namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create the list of video games type string
            List<string> videoGames = new List<string>
        {
            "NBA 2K",
            "Super Mario",
            "World of Warcraft",
            "Red Dead Redemption",
            "Fortnite",
            "Minecraft",
            "Overwatch",
            "COD",
            "Halo",
            "SSS Tricky"
        };

            // Order the list by the length of the game name using LINQ
            var orderedGames = videoGames.OrderBy(game => game.Length);

            // Print the list of video game names
            Console.WriteLine("An Ordered List of Video Game Names:");
            foreach (string game in orderedGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
