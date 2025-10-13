using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Persona
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        // --- NUEVO: LISTA DE PRÉSTAMOS ---
        // Cada persona tendrá su propia lista de préstamos.
        public List<Prestamo> Prestamos { get; set; }

        public Persona()
        {
            // Inicializamos la lista aquí para que nunca esté vacía (null)
            Prestamos = new List<Prestamo>();
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            // También inicializamos la lista aquí
            Prestamos = new List<Prestamo>();
        }
        public string getNombre()
        {
            return nombre;
        }

        public override string ToString()
        {
            return $"{nombre} {apellido}";
        }
    }
}