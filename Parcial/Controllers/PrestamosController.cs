using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Parcial.DAL;
using Parcial.Entidades;

namespace Parcial.Controllers
{
    public class PrestamosController
    {
        public bool Guardar(Prestamos Prestamo)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Prestamos.Add(Prestamo);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }
    }
}