using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace VisiTower.Models
{
    public class Cadastrar
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string telefone { get; set; }


    }
}
