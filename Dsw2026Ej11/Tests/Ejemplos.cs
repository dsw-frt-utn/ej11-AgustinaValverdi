namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var casoList = new CasoList();

        var a1 = new Alumno(1, "Agustina Valverdi", 8.5);
        var a2 = new Alumno(2, "Matias Autino", 7.2);
        var a3 = new Alumno(3, "Joaquin Perez", 9.1);
        casoList.Agregar(a1);
        casoList.Agregar(a2);
        casoList.Agregar(a3);

        Console.WriteLine("Listar por consola los alumnos");
        foreach (var a in casoList.GetAlumnos())
            Console.WriteLine(a);

        Console.WriteLine("Buscar por nombre un alumno que exista");
        var encontrado = casoList.BuscarPorNombre("Agustina Valverdi");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("Buscar por nombre un alumno que no exista");
        var noEncontrado = casoList.BuscarPorNombre("Matias Autino");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        casoList.Eliminar(a2);
        Console.WriteLine("Eliminar un alumno y listar");
        foreach (var a in casoList.GetAlumnos())
            Console.WriteLine(a);

        casoList.EliminarEnPosicion(0);
        Console.WriteLine("Eliminar el primer elemento y listar");
        foreach (var a in casoList.GetAlumnos())
            Console.WriteLine(a);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var casoDic = new CasoDictionary();

        casoDic.Agregar(new Alumno(10, "Agustina Valverdi", 8.0));
        casoDic.Agregar(new Alumno(20, "Matias Autino", 6.5));
        casoDic.Agregar(new Alumno(30, "Joaquin Perez", 9.4));

        Console.WriteLine("Listar por consola los alumnos");
        foreach (var par in casoDic.GetAlumnos())
            Console.WriteLine($"Clave: {par.Key} -> {par.Value}");

        Console.WriteLine("\nBuscar un alumno por clave que exista");
        var encontrado = casoDic.BuscarPorClave(20);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\nBuscar un alumno por clave que no exista");
        var noEncontrado = casoDic.BuscarPorClave(99);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        casoDic.Eliminar(10);
        Console.WriteLine("\nEliminar un alumno por clave y listar");
        foreach (var par in casoDic.GetAlumnos())
            Console.WriteLine($"Clave: {par.Key} -> {par.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var linq = new CasoLinq();

        Console.WriteLine("Primer libro");
        var primero = linq.GetPrimero();
        Console.WriteLine($"{primero.Titulo} - {primero.Precio:C}");

        Console.WriteLine("Último libro");
        var ultimo = linq.GetUltimo();
        Console.WriteLine($"{ultimo.Titulo} - {ultimo.Precio:C}");

        Console.WriteLine("Suma de precios");
        Console.WriteLine(linq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("Promedio de precios");
        Console.WriteLine(linq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("Libros con Id > 15");
        foreach (var l in linq.GetListById())
            Console.WriteLine($"{l.Id} - {l.Titulo}");

        Console.WriteLine("Título y precio en formato moneda");
        foreach (var s in linq.GetLibros())
            Console.WriteLine(s);

        Console.WriteLine("Libro con mayor precio");
        var mayor = linq.GetMayorPrecio();
        Console.WriteLine($"{mayor.Titulo} - {mayor.Precio:C}");

        Console.WriteLine("Libro con menor precio");
        var menor = linq.GetMenorPrecio();
        Console.WriteLine($"{menor.Titulo} - {menor.Precio:C}");

        Console.WriteLine("Libros con precio mayor al promedio");
        foreach (var l in linq.GetMayorPromedio())
            Console.WriteLine($"{l.Titulo} - {l.Precio:C}");

        Console.WriteLine("Libros ordenados por título");
        foreach (var l in linq.GetOrdenadosPorTituloDesc())
            Console.WriteLine(l.Titulo);
    }
}