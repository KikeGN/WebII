using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS.MODELO;
using DATOS.DAOs;

namespace DATOS.DAOs
{
    public class ComputadoraDao
    {
        public List<Computadora> getAll()
        {
            List<Computadora> lista;
            lista = new List<Computadora>();
            lista.Add(new Computadora() { clave =1, modelo="Dell T1700", memoria="16GB RAM 1TB "});
            lista.Add(new Computadora() { clave = 2, modelo = "Acer ASPIRE", memoria = "4GB RAM 1TB " });
            lista.Add(new Computadora() { clave = 3, modelo = "HP 3865", memoria = "8GB RAM 1TB " });
            return lista;
        }
           
    }
}
