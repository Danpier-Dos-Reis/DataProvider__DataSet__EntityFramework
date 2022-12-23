// See https://aka.ms/new-console-template for more information
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        DataSet dataSet = new DataSet(); //Creamos DataSet

        dataSet.Tables.Add("MyTablePersonas"); //Creamos un Tabla
        dataSet.Tables.Add("Presidentes");

        //Creamos y seteamos columnas en la Presidentes
        DataColumn cNombre = new DataColumn("Nombre",typeof(string));
        DataColumn cPais = new DataColumn("Pais",typeof(string));
        dataSet.Tables["Presidentes"]?.Columns.Add(cNombre);
        dataSet.Tables["Presidentes"]?.Columns.Add(cPais);

        DataColumn cEdad = new DataColumn("Edad",typeof(string));
        DataColumn cCiudad = new DataColumn("Ciudad",typeof(string));
        DataColumn cTelefono = new DataColumn("Telefono",typeof(string));

        //Podemos pasar un array de columnas
        dataSet.Tables["MyTablePersonas"]?.Columns.AddRange(new[]{
            cEdad,cCiudad,cTelefono
        });

        //Creamos Filas/Rows que se insertan en las columnas
        DataRow rowsTablePersonas = dataSet.Tables["MyTablePersonas"].NewRow();
        //rowsTablePersonas["Nombre"] = "Maximiliano";
        rowsTablePersonas["Edad"] = 1;
        rowsTablePersonas["Ciudad"] = "Caracas";
        rowsTablePersonas["Telefono"] = 0;
        dataSet.Tables["MyTablePersonas"]?.Rows.Add(rowsTablePersonas);

        /* *Ejemplo de como añadir varios valores a la vez*
        foreach (var persona in listaPersonas)
        {
            DataRow row = dataSet.Tables["MyTablePersonas"].NewRow();
            row["Nombre"] = persona.Nombre;
            row["Apellido"] = persona.Apellido;
            row["Edad"] = persona.Edad;
            dataSet.Tables["MyTablePersonas"].Rows.Add(row);
        }
        */

        //Imprimimos los datasets
        foreach(DataColumn columna in dataSet.Tables["MyTablePersonas"]?.Columns){
            Console.WriteLine(rowsTablePersonas[columna]);
            Console.ReadKey();
        }

        /* *Ejemplo Bucle FOR*
        for (int i = 0; i < dataSet.Tables["MyTablePersonas"].Columns.Count; i++)
        {
            Console.WriteLine(row[i]);
        }
        */
    }
}