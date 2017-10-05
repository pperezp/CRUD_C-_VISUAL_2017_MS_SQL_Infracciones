using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model {
    public class Automovil {
        private int id;
        private String patente;
        private String modelo;

        public int Id { get => id; set => id = value; }
        public string Patente { get => patente; set => patente = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
