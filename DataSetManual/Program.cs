using DataSetManual.Datos;
using System;
using System.Data;

namespace DataSetManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new Rows().TableWithValues();

            //Imprimos primero los nombres de las columnas
            foreach(DataColumn column in ds.Tables["Paises"].Columns){
                Console.Write($"|   {column.ColumnName} |");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            foreach (DataRow row in ds.Tables["Paises"].Rows)
            {
                foreach (DataColumn column in ds.Tables["Paises"].Columns)
                {
                    Console.Write($"|   {row[column]}   | ");
                }
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadKey();
        }
    }
}
