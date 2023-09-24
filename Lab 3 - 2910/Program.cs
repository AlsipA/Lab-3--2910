using Lab_3___2910;

string Root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
string root = Root;
string dbPath = root + "\\Data\\data.db";
string connectionString = $"Data Source={dbPath}";


List<Pokemon> pokemonList = new List<Pokemon>();
List<BannedGame> gameList = new List<BannedGame>();


Pokemon tester  = new Pokemon(1, 1, "Bulbasaur", "", "Grass", "Posion", 318, 45, 49, 49, 65, 65, 45, 1);

QueryBuilder query = new QueryBuilder(dbPath);

Console.WriteLine("Removing Bulbasaur:");
query.Delete(tester);
Console.WriteLine("He's gone!!");
Console.WriteLine("\n");
Console.WriteLine("Adding him back:");
query.Create(tester);
Console.WriteLine("He's not back bc I couldn't get this to work :(");

Console.WriteLine("Hey Will, I really tried to complete this lab but clearly I failed. " +
    "Myself and others cannot figure out why my create doesn't work for the freaking life of me. " +
    "For my sanity I quit working on it after 5 days. If I did anything that is worth partial credit " +
    "I would appreciate it, but if not then that's okay to. Hope you've had a good day whenever you're grading this.");