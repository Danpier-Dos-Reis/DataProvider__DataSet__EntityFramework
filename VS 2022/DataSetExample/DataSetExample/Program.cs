// See https://aka.ms/new-console-template for more information

//Forma ADO.NET DataSet

using DataSetExample;
using DataSetExample.DataSet1TableAdapters;

var tableadapter = new AreasTableAdapter();
var datatable = tableadapter.GetDataBy(3);

foreach (DataSet1.AreasRow row in datatable.Rows){
    Console.WriteLine("{0}--{1}--{2}", row.Id, row.Area, row.Fecha);
}
datatable.Dispose(); //Borramos los objetos de la mamoria Ram
tableadapter.Dispose();
