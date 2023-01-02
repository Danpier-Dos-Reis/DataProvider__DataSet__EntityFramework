using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataSetManual.Datos;

namespace DataSetManual.Datos
{
    internal class Rows
    {
        Random random = new Random();
        public DataSet TableWithValues() {

            DataSet ds = new TableCountry().GetTable();

            //Creamos las rows/filas
            DataRow rCanada = ds.Tables["Paises"].NewRow();
            DataRow rUSA = ds.Tables["Paises"].NewRow();
            DataRow rArgentina = ds.Tables["Paises"].NewRow();
            DataRow rChile = ds.Tables["Paises"].NewRow();
            DataRow rMexico = ds.Tables["Paises"].NewRow();

            //Canada
            rCanada["Nombre"] = "Canadá";
            rCanada["Presidentes"] = "Justin Trudeo";
            rCanada["Gentilisio"] = "Canadiense";
            rCanada["Fundacion"] = random.Next(1800, 2000);
            //Usa
            rUSA["Nombre"] = "Estados Unidos";
            rUSA["Presidentes"] = "Joe Biden";
            rUSA["Gentilisio"] = "Estadounidense";
            rUSA["Fundacion"] = random.Next(1800,2000);
            //Argentina
            rArgentina["Nombre"] = "Argentina";
            rArgentina["Presidentes"] = "Alberto Fernandez";
            rArgentina["Gentilisio"] = "Argentino";
            rArgentina["Fundacion"] = random.Next(1800, 2000);
            //Chile
            rChile["Nombre"] = "Chile";
            rChile["Presidentes"] = "Gabriel Borics";
            rChile["Gentilisio"] = "Chileno";
            rChile["Fundacion"] = random.Next(1800, 2000);
            //Mexico
            rMexico["Nombre"] = "México";
            rMexico["Presidentes"] = "Andrés Manuel Lopez Obrador";
            rMexico["Gentilisio"] = "Mexicano";
            rMexico["Fundacion"] = random.Next(1800, 2000);

            //Añadir a la tabla
            ds.Tables["Paises"].Rows.Add(rCanada);
            ds.Tables["Paises"].Rows.Add(rUSA);
            ds.Tables["Paises"].Rows.Add(rArgentina);
            ds.Tables["Paises"].Rows.Add(rChile);
            ds.Tables["Paises"].Rows.Add(rMexico);

            return ds;
        }
    }
}
