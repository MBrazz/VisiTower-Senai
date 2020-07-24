using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace VisiTower.Models
{
    public class Visitas
    {
        [PrimaryKey, AutoIncrement]
        public int idVisita { get; set; }
        public string data { get; set; }
        public string situacao { get; set; }
        public string time { get; set; }


    }
}
