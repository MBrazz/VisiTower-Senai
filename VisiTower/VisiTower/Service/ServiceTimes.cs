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
            

            new Times {Nome = "Barcelona", Estadio = "Camp Nou" , ImagemUrl = "Barcelona.png",
                       DataVisita = "Data da Visita: 25/07/2020", PrecoVisita = "Preço: 125 €", Local = "Local: Av. José da Cocada, Espanha" },
            new Times {Nome = "Juventus", Estadio = "Allianz Stadium" , ImagemUrl = "JuventusCerto.png",
                       DataVisita = "Data da Visita: 22/10/2020", PrecoVisita = "Preço: 110 €", Local = "Local: Av. Craudéte II, Itália" },
            new Times {Nome = "Manchester City", Estadio = "Etihad Stadium" , ImagemUrl = "ManchesterCity.png",
                        DataVisita = "Data da Visita: 30/07/2020", PrecoVisita = "Preço: 75 €", Local = "Local: Av. Ulisses Paçoca, Inglaterra" },
            new Times {Nome = "Liverpool", Estadio = "Anfield" , ImagemUrl = "Liverpool.png", 
                       DataVisita = "Data da Visita: 12/10/2020", PrecoVisita = "Preço: 140 €", Local = "Local: Av. Maria da Água, Inglaterra" },
            new Times {Nome = "Real Madrid", Estadio = "Santiago Bernabéu Stadium" , ImagemUrl = "RealMadrid.png",
                       DataVisita = "Data da Visita: 10/09/2020", PrecoVisita = "Preço: 150 €", Local = "Local: Av. Careca, Espanha" }

        };

        public IEnumerable<Times> GetTimes()
        {
            return times;
        }
    }
}
