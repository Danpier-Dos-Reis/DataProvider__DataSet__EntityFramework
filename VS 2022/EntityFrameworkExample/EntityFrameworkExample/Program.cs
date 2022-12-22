using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new TaskyAppEntities()){

                                                                                     //Le puse 'hola' pero
                                                                                     //puede ser cualquier
                                                                                     //nombre
                var listadatos = contexto.Areas.Where(hola =>hola.Id>4);
                                                                                //Donde Id sea mayor a 4
                foreach (var ormEntidad in listadatos){

                    Console.WriteLine("{0}--{1}--{2}",
                        ormEntidad.Id, ormEntidad.Area1, ormEntidad.Fecha);
                    Console.ReadKey();

                }

            }
        }
    }
}
