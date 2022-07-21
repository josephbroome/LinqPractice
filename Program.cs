using System.Linq;

var videogames= new List<string>() {"Halo","Mario Kart", "Mortal Combat", "Pokemon","GTA", "Elden Ring" };

//videogames.OrderBy(games => games).ToList().ForEach(game => Console.WriteLine(game));

videogames.OrderByDescending(games=> games.Length).ToList().ForEach(game => Console.WriteLine(game));