namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>) - listo
//Incluir un método para agregar alumnos a la lista - listo
//Incluir un método para retornar la lista - listo
//Incluir un método para buscar un alumno por nombre - listo
//Incluir un método para eliminar un alumno (debe recibir un alumno) -listo
//Incluir un método para eliminar un alumno en una determinada posición de la lista - listo
public class CasoList
{
        private List<Alumno> _alumnos = new List<Alumno>();

        public void AgregarAlumno(Alumno alumno)
        {
            _alumnos.Add(alumno);
        }

        public List<Alumno> ObtenerAlumnos()
        {
            return _alumnos;
        }

        public Alumno BuscarAlumnoPorNombre(string nombre)
        {
            return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
        }

        public void EliminarAlumno(Alumno alumno)
        {
            _alumnos.Remove(alumno);
        }

        public void EliminarAlumnoEnPosicion(int posicion)
        {
            _alumnos.RemoveAt(posicion);
        }