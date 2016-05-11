using System.Collections.Generic;

namespace AbbreviationProject.Models
{
    public class AbbreviationModel
    {
        public int ID { get; set; }
        public string Abbr { get; set; }
        public string Title { get; set; }

        public static AbbreviationModel CreateExample() => new AbbreviationModel { Abbr = "RTFM", Title = "Read the fucking manual" };
        public static List<AbbreviationModel> CreateDummyList() => new List<AbbreviationModel>
        {
            new AbbreviationModel { ID = 1, Abbr = "AFK", Title = "Away from keyboard" },
            new AbbreviationModel { ID = 2, Abbr = "BRB", Title = "Be right back" },
            new AbbreviationModel { ID = 3, Abbr = "WTF", Title = "What the fuck" }
        };
    }
}