using Parcial1_Ap2_Fermin.DAL;
using Parcial1_Ap2_Fermin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Fermin.BLL
{
    public class ArticulosBLL
    {
        public static bool Existe(int id)
        {
            Contexto db = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = db.Articulos.Any(a => a.ArticuloId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return encontrado;
        }
        public static bool Insertar(Articulos articulos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Articulos.Add(articulos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool Modificar(Articulos articulos)
        {

            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Entry(articulos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static bool Guardar(Articulos articulos)
        {
            if (!Existe(articulos.ArticuloId))
                return Insertar(articulos);
            else
                return Modificar(articulos);
        }
        public static Articulos Buscar(int id)
        {
            Contexto db = new Contexto();
            Articulos articulos = new Articulos();

            try
            {
                articulos = db.Articulos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return articulos;
        }
        public static bool Eliminar(int id)
        {

            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                var encontrado = db.Articulos.Find(id);
                db.Articulos.Remove(encontrado);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
        public static List<Articulos> GetArticulos(Expression<Func<Articulos,bool>>expression)
        {

            Contexto db = new Contexto();
            List<Articulos> lista = new List<Articulos>();

            try
            {
                lista = db.Articulos.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }
    }
}
