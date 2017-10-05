using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model {
    public class Infraccion {
        private int id;
        private int policia;
        private int automovil;
        private String detalle;
        private int multa;

        public int Id { get => id; set => id = value; }
        public int Policia { get => policia; set => policia = value; }
        public int Automovil { get => automovil; set => automovil = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public int Multa { get => multa; set => multa = value; }
    }
}
