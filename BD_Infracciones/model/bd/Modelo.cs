using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model {
    public class Modelo {
        private int id;
        private String nombre;
        private int marca;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Marca { get => marca; set => marca = value; }
    }
}
