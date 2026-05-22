namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero) - listo
 * 2. Obtener el último libro (GetUltimo) listo
 * 3. Obtener la suma de precios (GetTotalPrecios) listo
 * 4. Obtener el promedio de precios (GetPromedioPrecios)listo
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)listo
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string) listo
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio) listo
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)listo
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)listo
 * 10. Obtener los libros ordenados por título de forma descendente listo
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public class CasoLibros
    {
        private List<Libro> _libros = new List<Libro>();
        public Libro GetPrimero()
        {
            return _libros.FirstOrDefault();
        }

        public Libro GetUltimo()
        {
            return _libros.LastOrDefault();
        }

        public decimal GetTotalPrecios()
        {
            return _libros.Sum(libro => libro.Precio);
        }
        public double GetPromedioPrecios()
        {
            return _libros.Average(libro => libro.Precio);
        }

        public List<Libro> GetListById()
        {
            return _libros.Where(libro => libro.Id > 15).ToList();
        }
        public List<string> GetLibros()
        {
            return _libros
                .Select(libro => $"{libro.Titulo} - {libro.Precio:C}")
                .ToList();
        }
        public Libro GetMayorPrecio()
        {
            return _libros.MaxBy(libro => libro.Precio);
        }

        public Libro GetMenorPrecio()
        {
            return _libros.MinBy(libro => libro.Precio);
        }
        public List<Libro> GetMayorPromedio()
        {
            double promedio = GetPromedioPrecios();
            return _libros.Where(libro => libro.Precio > (decimal)promedio).ToList();
        }
        public List<Libro> GetOrdenadosPorTitulo()
        {
            return _libros.OrderByDescending(libro => libro.Titulo).ToList();
        }
    }
}
