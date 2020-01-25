using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCRUD.Models;

namespace WebAppCRUD.Data
{
    public class IniciarDB
    {
        public static void Iniciar(WebAppCRUDContext context)
        {
            context.Database.EnsureCreated();
            if (context.Alumnos.Any())
            {
                return;
            }
            var alumno = new Alumnos[]
                {
                    new Alumnos{Nombre = "Enrique", ApeMat = "Hdez", ApePat = "Tepe", Carrera = "Sistemas Computacionales", Semestre = 8 },
                    new Alumnos{Nombre = "Marcos", ApeMat = "algo", ApePat = "Algo", Carrera = "Sistemas Computacionales", Semestre = 4 }
                };

            foreach (Alumnos a in alumno)
            {
                context.Alumnos.Add(a);
            }
            context.SaveChanges();
        }
    }
}
