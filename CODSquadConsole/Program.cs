using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CODSquadConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            var response = GamerRepository.CallOfDuty(Console.ReadLine());

            var player = GamerRepository.BRCODParse(response);


            Console.WriteLine($"");
            Console.WriteLine($"Wins: {player.Wins}, Top 25 Finishes: {player.TopTwentyFive}, Top 10 Finishes: {player.TopTen}, Top 5 Finishes: {player.TopFive}");
            Console.WriteLine($"Kills: {player.Kills}, Deaths: {player.Deaths}, KD Ratio: {player.KDRatio}");
            Console.WriteLine($"Overall Score: {player.Score}, Score Per Minute: {player.ScorePerMinute}");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
