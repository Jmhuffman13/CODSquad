using CODSquadConsole.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace CODSquadConsole
{
    public class GamerRepository : Program
    {
        public static IRestResponse CallOfDuty(string gamerTag)
        {
            var client = new RestClient($"https://call-of-duty-modern-warfare.p.rapidapi.com/warzone/{gamerTag}/xbl");

            var request = new RestRequest(Method.GET);

            request.AddHeader("x-rapidapi-host", "call-of-duty-modern-warfare.p.rapidapi.com");

            request.AddHeader("x-rapidapi-key", "6fe327d691msh48b2cd98d9f2720p129e7ejsn2df97d3651f4");

            IRestResponse response = client.Execute(request);

            return response;
        }

        public static Gamer BRCODParse(IRestResponse response)
        {
            var brObj = JObject.Parse(response.Content).GetValue("br");

            var gamerWins = brObj["wins"];
            var gamerKills = brObj["kills"];
            var gamerKDRatio = brObj["kdRatio"];
            var gamerTopTwentyFive = brObj["topTwentyFive"];
            var gamerTopTen = brObj["topTen"];
            var gamerTopFive = brObj["topFive"];
            var gamerScore = brObj["score"];
            var gamerScorePerMinute = brObj["scorePerMinute"];
            var gamerDeaths = brObj["deaths"];


            var gamer = new Gamer()
            {
                Wins = (double)brObj["wins"],
                Kills = (double)brObj["kills"],
                KDRatio = (double)brObj["kdRatio"],
                TopTwentyFive = (double)brObj["topTwentyFive"],
                TopTen = (double)brObj["topTen"],
                TopFive = (double)brObj["topFive"],
                Score = (double)brObj["score"],
                ScorePerMinute = (double)brObj["scorePerMinute"],
                Deaths = (double)brObj["deaths"]

            };

            return gamer;
        }
    }
}
