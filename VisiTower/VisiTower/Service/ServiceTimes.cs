using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisiTower.Models;

namespace VisiTower.Service
{
    public class ServiceTimes
    {
        private List<Times> times = new List<Times>
        {
            new Times {Nome = "Barcelona", Estadio = "Camp Nou" , ImagemUrl = "Barcelona.png" },
            new Times {Nome = "Juventus", Estadio = "Allianz Stadium" , ImagemUrl = "JuventusCerto.png" },
            new Times {Nome = "Manchester City", Estadio = "Etihad Stadium" , ImagemUrl = "ManchesterCity.png" },
            new Times {Nome = "Liverpool", Estadio = "Anfield" , ImagemUrl = "Liverpool.png" },
            new Times {Nome = "Real Madrid", Estadio = "Santiago Bernabéu Stadium" , ImagemUrl = "RealMadrid.png" }
        };

        public IEnumerable<Times> GetTimes()
        {
            return times;
        }
    }
}
