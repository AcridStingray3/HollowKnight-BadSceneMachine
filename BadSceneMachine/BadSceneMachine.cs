using System.Collections.Generic;
using Modding;
using System.Linq;

namespace BadSceneMachine
{
    public class BadSceneMachine : Mod
    {
        
        public override List<(string, string)> GetPreloadNames() =>
            new List<string>
            {
                "Crossroads_47",
                "Fungus2_15",
                "Fungus1_Slug",
                "Room_Final_Boss_Core",
                "Fungus1_37",
                "Dream_Final_Boss",
                "Fungus1_08",
                "Room_Queen",
                "Room_Colosseum_Bronze",
                "Room_Colosseum_Silver",
                "Room_Colosseum_Gold",
                "Dream_Mighty_Zote",
                "Room_Charm_Shop",
                "Waterways_05"
                
                
            }.Select(x => (x, ".")).ToList();


        public override string GetVersion() => "1.0";
    }
}