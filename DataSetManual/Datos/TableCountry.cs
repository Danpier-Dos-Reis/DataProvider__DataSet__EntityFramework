using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetManual.Datos
{
    internal class TableCountry
    {
        public DataSet GetTable(){

            DataSet ds = new DataSet();

            //Crear Trabla
            DataTable paises= new DataTable("Paises");

            //Columnas
            DataColumn cnombre= new DataColumn("Nombre",typeof(string));
            DataColumn cpresidentes = new DataColumn("Presidentes", typeof(string));
            DataColumn cgentilisio = new DataColumn("Gentilisio", typeof(string));
            DataColumn cfundacion = new DataColumn("Fundacion", typeof(int));

            //Metemos todo en el dataset
            ds.Tables.Add(paises);
            ds.Tables[$"{paises}"].Columns.AddRange(new[]{cnombre,cpresidentes,cgentilisio,cfundacion});

            return ds;
        }
    }
}
