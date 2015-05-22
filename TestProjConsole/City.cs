using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjConsole
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public E_State State { get; set; }
        public bool IsCapitol { get; set; }
        public string FootballTeam { get; set; }
        public int FootballTeamLeague { get; set; }
        public double Longitute { get; set; }
        public double Latitude { get; set; }
    }

    public class State
    {
        public E_State Code { get; set; }
        public string Name { get; set; }
    }

    public enum E_State 
    {
        BW = 1,
        BY,
        BE,
        BB,
        HB,
        HH,
        HE,
        MV,
        NI,
        NW,
        RP,
        SL,
        SC,
        SA,
        SH,
        TH
    }
}
