//See https://aka.ms/new-console-template for more information

// Sintaxis 1: Sintaxis de métodos
// int[] numeros = { 1, 2, 3, 4, 5 };
// var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

// // Sintaxis 2: Sintaxis de Queries
// var numerosPares2 = (from n in numeros
//                     where n % 2 == 0
//                     select n).ToList();

// // O también puede ser
// int[] numeros2 = Enumerable.Range(0, 5).ToArray();
// var numerosParess = numeros.Where(n => n % 2 == 0).ToList();

// // Sintaxis 2: Sintaxis de Queries
// var numerosParess2 = (from n in numeros
//                     where n % 2 == 0
//                      select n).ToList();

// Console.WriteLine("Hello World");


//-----------------------VIDEO 02----------------------\\

// int[] numeros2 = Enumerable.Range(0, 5).ToArray();

// //sintaxis: sintaxis de metodos
// var numerosPares = numeros2.Where(n =>
// {
//     Console.WriteLine($"Evaluando si {n} es par");
//     return n % 2 == 0;
// }).ToList();

// foreach (var numero in numerosPares)
// {
//     Console.WriteLine($"Si, el {numero} es par.");
// }

// Console.WriteLine("Hello world");


//Ejercicio Hecho por mi a base del codigo
// Lista de animales
// string[] animales = { "Perro", "Gato", "Elefante", "Cebra", "Caballo", "Pato" };

// // Filtramos los animales cuyos nombres empiezan con la letra 'P'
// var animalesConP = animales.Where(animal =>
// {
//     Console.WriteLine($"Evaluando si {animal} empieza con 'P'");
//     return animal.StartsWith("P");
// }).ToList();

// // Mostramos los animales que cumplen la condición
// foreach (var animal in animalesConP)
// {
//     Console.WriteLine($"Sí, el {animal} empieza con 'P'.");
// }

// Console.WriteLine("Hello world");



//------------------Video 03 ---------------\\

// int[] numeros = Enumerable.Range(1, 20).ToArray();

// var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

// // Console.WriteLine("Los numeros impares son: ");
// // foreach (var numero in numerosImpares)
// // {
// //     Console.WriteLine(numero);
// // }

// var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

// // Console.WriteLine("Los numeros impares mayores que 10 son:");
// // foreach (var numero in numerosImparesMayoresQue10)
// // {
// //     Console.WriteLine(numero);
// // }



// // Sintaxis de query
// var numerosImparesMayoresQue10_2 = from n in numeros
//                                      where n % 2 != 1 && n > 10
//                                      select n;

// Console.WriteLine("Los números impares mayores que 10 son:");
// foreach (var numero in numerosImparesMayoresQue10)
// {
//     Console.WriteLine(numero);
// }






// ---------------------VIDEO 04----------------\\


//using EjerciciosLINQ;

// var personas = new List<Persona>() {
//         new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//         new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//         new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//         new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
//         new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
// };

// // var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();

// // foreach (var persona in personasDe25AñosOMenos)
// // {
// //     Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");
// // }

// // var solteros = personas.Where(p => p.Soltero ).ToList();

// // foreach (var persona in solteros)
// // {
// //     Console.WriteLine($"{persona.Nombre} es soltero/a");
// // }

// var personasConMenosDe3MesesEnLaEmpresa = personas
//     .Where(p => p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)) .ToList();

// foreach (var persona in personasConMenosDe3MesesEnLaEmpresa)
// {
//     Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa.");
// }

// EJERCICIO HECHO POR MI \\\\\\\

// using EjerciciosLINQ;


//  var animales = new List<Animal>()
//         {
//             new Animal { Nombre = "Fido", Peso = 25.5, Edad = 4, Raza = "Labrador" },
//             new Animal { Nombre = "Miau", Peso = 3.2, Edad = 2, Raza = "Siamés" },
//             new Animal { Nombre = "Rex", Peso = 30.0, Edad = 6, Raza = "Pastor Alemán" },
//             new Animal { Nombre = "Bunny", Peso = 1.5, Edad = 1, Raza = "Conejo" },
//             new Animal { Nombre = "Ginger", Peso = 4.5, Edad = 3, Raza = "Golden Retriever" }
//         };

//         var animalesMenoresDe5Años = animales.Where(a => a.Edad <= 5).ToList();

//         Console.WriteLine("Los animales con 5 años o menos son:");
//         foreach (var animal in animalesMenoresDe5Años)
//         {
//             Console.WriteLine($"{animal.Nombre}, un {animal.Raza} de {animal.Edad} años y {animal.Peso} kg.");
//         }




//-----------------------------------------VIDEO 05-------------------------------------------------------------------\\

// using EjerciciosLINQ;

// var personas = new List<Persona>() {
//         new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//         new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//         new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//         new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
//         new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
// };

// var primeraPersona = personas.First();
// var primeraPersona2 = personas.FirstOrDefault();
// var paises = new List<string>();
// try
// {
//     var primerPais = paises.First();
// }
// catch (Exception ex)
// {
//     Console.WriteLine("ha ocurrido un error");
// }
// var primerPais2 = paises.FirstOrDefault();

// var numeros = new List<int>();

// var primerNumero = numeros.FirstOrDefault();

// var primeraPersonaNoSoltera = personas.FirstOrDefault(p => !p.Soltero);

// // Sintaxis de queries
// var primeraPersonaNoSoltera_2 = (from p in personas
//                                   where !p.Soltero
//                                   select p).FirstOrDefault();
// var a = 1;




//------------------------------------------------------------------VIDEO 06 ----------------------------------------------------------\\

//using EjerciciosLINQ;

// var personas = new List<Persona>() {
//         new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//         new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//         new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//         new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
//         new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
// };

// var ultimaPersona = personas.Last();
// var ultimaPersona2 = personas.LastOrDefault();
// var ultimaPersonaSoltera = personas.Last(p => p.Soltero);

// // Sintaxis de queries
// var ultimaPersonaSoltera_2 = (from p in personas
//                              where p.Soltero
//                              select p).Last();

//EJERCICIO HECHO POR MI\\

// var animales = new List<Animal>()
//         {
//             new Animal { Nombre = "Max", Peso = 15.5, Edad = 3, Raza = "Labrador" },
//             new Animal { Nombre = "Luna", Peso = 5.2, Edad = 2, Raza = "Siamesa" },
//             new Animal { Nombre = "Tigre", Peso = 150, Edad = 8, Raza = "Bengala" },
//             new Animal { Nombre = "Simba", Peso = 25, Edad = 1, Raza = "León" },
//             new Animal { Nombre = "Nala", Peso = 23, Edad = 5, Raza = "Persa" },
//         };

//         var ultimoAnimal = animales.Last();
//         var ultimoAnimal2 = animales.LastOrDefault();
//         var ultimoAnimalMayorA20Kg = animales.Last(a => a.Peso > 20);

//         // Sintaxis de queries
//         var ultimoAnimalMayorA20Kg_2 = (from p in animales
//                                         where p.Peso > 20
//                                         select p).Last();

// var a=1;




//---------------------------------------------------------------------VIDEO 07-----------------------------------------------------------\\


// using EjerciciosLINQ;

// var personas = new List<Persona>() {
//         new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//         new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//         new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//         new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
//         new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
// };

// var terceraPersona = personas.ElementAt(2);
// var sextaPersona = personas.ElementAtOrDefault(5);

// // Sintaxis de queries
// var sextaPersona_2 = (from p in personas
// select p).ElementAtOrDefault(5);

// var a = 1;




//-------------------------------------------------------------------------VIDEO 08----------------------------------------------------------\\

// using EjerciciosLINQ;

// var personas = new List<Persona>() {
//         new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//         new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//         new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//         new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
//         new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
// };

// var personaMayorDe60 = personas.Single(p => p.Edad > 60);
// try
// {
//     var personaMayorA100 = personas.Single(p => p.Edad > 100);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Hubo un error, arreglo vacío");
// }
// try
// {
//     var personaMayorA5 = personas.Single(p => p.Edad > 5);
// }
// catch(Exception ex)
// {
//     Console.WriteLine("Hubo otro error, arreglo con mas de un elemento");
// }
// var a = 1;

// // Sintaxis de queries
// var personaMayorDe60_2 = (from p in personas
//                          where p.Edad > 60
//                          select p).Single();


//----------------------------------------------------------------VIDEO 09---------------------------------------------------------------------------\\

// var listado = new List<object>() { "Felipe", 1, 2, "Claudia", true };

// var strings = listado.OfType<string>();
// var numeros = listado.OfType<int>();

// // sintaxis de queries
// var strings_2 = from s in listado.OfType<string>()
//                 select s;

// // Ejemplo 2: herencia
// var listadoAnimales = new List<Animal>()
// {
//     new Perro(){Nombre = "Firulais"},
//     new Gato(){Nombre = "Félix"}
// };
// var perros = listadoAnimales.OfType<Perro>();
// var a = 1;
// public abstract class Animal
// {
//     public abstract string? Nombre { get; set; }
// }
// public class Perro : Animal
// {
//     public override string? Nombre { get; set; }
// }
// public class Gato : Animal
// {
//     public override string? Nombre { get; set; }
// }


//-------------------------------------------------------------------VIDEO 10---------------------------------------------\\


using EjerciciosLINQ;

var personas = new List<Persona>() {
        new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
        new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
        new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
        new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2022, 11, 8), Soltero = false },
        new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

var personasOrdenadasPorEdad = personas.OrderByDescending(x => x.Edad);

foreach (var persona in personasOrdenadasPorEdad)
{
    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
}

int[] numeros = { 1, 5, 12, 2, 3, 111, 6 };

foreach (var numero in numeros.OrderBy(x => x))
{
    Console.WriteLine(numero);
}

// Sintaxis de queries
var numeros_2 = from n in numeros
                orderby n
                select n;
var personasOrdenadasPorEdad_2 = from p in personas
                                 orderby p.Edad descending
                                 select p;