using System.Globalization;
using System.Runtime.CompilerServices;
using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];
empleados[0] = new Empleado("Juan", "Perez", new DateTime(1990, 4, 15), 'S', new DateTime(2015, 6, 1), 500000, Empleado.Cargos.Ingeniero);
empleados[1] = new Empleado("Maria", "Gomez", new DateTime(1985, 9, 22), 'C', new DateTime(2010, 3, 10), 600000, Empleado.Cargos.Especialista);
empleados[2] = new Empleado("Pedro", "Lopez", new DateTime(1992, 12, 20), 'D', new DateTime(2018, 11, 20), 450000, Empleado.Cargos.Auxiliar);

double total = empleados[0].Salario() + empleados[1].Salario() + empleados[2].Salario();
Console.WriteLine($"Monto total en concepto de salarios: {total.ToString("C")}");

int mayor = 0, edadMayor = 0, i;
for (i = 0; i < 3; i++)
{
    int edad = empleados[i].Edad();
    if (edad > edadMayor)
    {
        edadMayor = edad;
        mayor = i;
    }
}
Console.WriteLine($"Nombre: {empleados[mayor].Nombre} {empleados[mayor].Apellido}");
Console.WriteLine($"Fecha de Nacimiento: {empleados[mayor].FechaNac.ToString("MMMM d, yyyy")}");
string estado = "";
switch (empleados[mayor].EstadoCiv)
{
    case 'C':
        estado = "Casado";
        break;
    case 'S':
        estado = "Soltero";
        break;
    case 'D':
        estado = "Divorciado";
        break;
}
Console.WriteLine($"Estado civil: {estado}");
Console.WriteLine($"Fecha de Ingreso: {empleados[mayor].FechaIngreso.ToString("MMMM d, yyyy")}");
Console.WriteLine($"Sueldo Basico: {empleados[mayor].Basico.ToString("C")}");
Console.WriteLine($"Cargo: {empleados[mayor].Cargo}");
Console.WriteLine($"Antiguedad: {empleados[mayor].Antiguedad()}");
Console.WriteLine($"Edad: {empleados[mayor].Edad()}");
Console.WriteLine($"Años para retirarse: {empleados[mayor].AniosRestantes()}");
Console.WriteLine($"Salario Total: {empleados[mayor].Salario().ToString("C")}");