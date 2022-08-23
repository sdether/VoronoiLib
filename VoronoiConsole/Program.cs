using System.Collections.Generic;
using System.Diagnostics;
using VoronoiLib;
using VoronoiLib.Structures;

namespace VoronoiConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var points = new List<FortuneSite>
            {
                new FortuneSite(0, 0),
                new FortuneSite(200, 200),
                new FortuneSite(200, -200),
                new FortuneSite(-200, 200),
                new FortuneSite(-200, -200)
            };
//FortunesAlgorithm.Run(points, min x, min y, max x, max y)
            var edges = FortunesAlgorithm.Run(points, -800, -800, 800, 800);
            Debug.WriteLine($"{edges.Count}");
        }
    }
}