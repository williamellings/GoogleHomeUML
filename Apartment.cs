using System.Collections.Generic;

namespace GoogleHomeUML
{
    public class Lampor //klass apart ärver av 
    {
        public string Location { get; set; }
        public int LjusStyrka { get; set; }
        public string LampNamn { get; set; }

        public string CamName { get; set; }

        public List<string> locationList = new List<string>() { "Vardagsrum", "Hall", "Kitchen", "Toilet", "Tv-rum"};
        public List<Lampor> lamporList = new List<Lampor>();


        


        
    }
}
