using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model {
    public class Policia {
        private int id;
        private String rut;
        private String nombre;
        private int sexo;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Sexo { get => sexo; set => sexo = value; }
    }
}
