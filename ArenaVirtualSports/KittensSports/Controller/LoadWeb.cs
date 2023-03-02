using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaVirtual.Controller
{
    public class LoadWeb
    {
        public string SiteLink { get; set; }
        public LoadWeb(string link) {
           
            //SiteLink = link;
            SiteLink= "https://stats.cyberarena.live/schedule.aspx?lang=en&dscID=19&divID=0&date=Mon Oct 31 2022";
        }
        public override string ToString()
        {
            return SiteLink;
        }
    }
}
