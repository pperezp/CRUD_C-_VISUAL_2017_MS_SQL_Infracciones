using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model {
    public class Data {
        private Conexion con;

        public Data() {
            con = new Conexion("bd_infracciones");
        }

        public void crearInfraccion(Infraccion i) {
            con.ejecutar("INSERT INTO infraccion VALUES("+i.Policia+","+i.Automovil+",'"+i.Detalle+"',"+i.Multa+");");
        }

        public void crearMarca(String nombre) {
            con.ejecutar("INSERT INTO marca VALUES('"+nombre+"');");
        }

        public void crearModelo(Modelo m) {
            con.ejecutar("INSERT INTO modelo VALUES('"+m.Nombre+"','"+m.Marca+"');");
        }

        public void crearAutomovil(Automovil a) {
            con.ejecutar("INSERT INTO automovil VALUES('"+a.Patente+"','"+a.Modelo+"');");
        }

        public void crearPolicia(Policia p) {
            con.ejecutar("INSERT INTO policia VALUES('"+p.Rut+"','"+p.Nombre+"',"+p.Sexo+");");
        }

        public DataTable getMarcas() {
            return con.ejecutar("SELECT * FROM marca ORDER BY nombre ASC");
        }

        public DataTable getPolicias() {
            return con.ejecutar("SELECT * FROM listadoPolicias");
        }

        public DataTable getPolicias(String filtro) {
            return con.ejecutar("SELECT * FROM listadoPolicias " +
                "WHERE Rut LIKE '%"+filtro+ "%' " +
                "OR Nombre LIKE '%" + filtro + "%' " +
                "OR Sexo LIKE '%" + filtro + "%'");
        }

        public DataTable getModelos() {
            return con.ejecutar("SELECT * FROM listadoModelos;");
        }

        public DataTable getAutomoviles() {
            return con.ejecutar("SELECT * FROM listadoAutomoviles;");
        }

        public DataTable getInfracciones() {
            return con.ejecutar("SELECT * FROM listadoInfracciones;");
        }
    }
}
