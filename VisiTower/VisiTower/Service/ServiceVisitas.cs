using System;
using System.Collections.Generic;
using System.Text;
using VisiTower.Models;

namespace VisiTower.Service
{
    public class ServiceVisitas
    {
        private List<Visitas> visitas = new List<Visitas>
        {
            new Visitas {data = "25/07/2020", situacao = "Aberta" , time = "Barcelona" },
            new Visitas {data = "30/07/2020", situacao = "Aberta" , time = "Juventus" },
            new Visitas {data = "01/08/2020", situacao = "Aberta" , time = "Barcelona" }

        };

        public IEnumerable<Visitas> GetVisitas()
        {
            return visitas;
        }
    }
}
