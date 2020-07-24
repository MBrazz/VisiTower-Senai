using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace VisiTower.Models
{
    public class Times
    {
        [PrimaryKey, AutoIncrement]
        public int idVisita { get; set; }
        public string Nome { get; set; }
        public string Estadio { get; set; }
        public string ImagemUrl { get; set; }
        public string DataVisita { get; set; }
        public string PrecoVisita { get; set; }
        public string Local { get; set; }
    }
}
