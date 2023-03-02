
using Laboratoria1StevenOmarAlfaroVillanueva.Entidades;
using Laboratoria1StevenOmarAlfaroVillanueva.Negocios;

Persona personas = new Persona();
ClsPersona clspersona = new ClsPersona();

Console.WriteLine("Dame tu nombre: ");
personas.Nombre = Console.ReadLine();

Console.WriteLine("Dame tu edad: ");
personas.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dame tu tipo de sexo: ");
personas.Sexo = Console.ReadLine();

Console.WriteLine("Ingresa tu peso en Kg: ");
personas.Peso= float.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu Altura: ");
personas.Altura = float.Parse(Console.ReadLine());

Console.WriteLine($"La persona:{personas.Nombre} de edad: {personas.Edad} de sexo: {personas.Sexo}  tiene un peso: {clspersona.CalcularIMC(personas)} y una altura: {clspersona.esMayorDeEdad(personas)}");