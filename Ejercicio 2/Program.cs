// control de acceso al laboratorio universitario 

Console.WriteLine("Determinar si una persona puede ingresar al laboratorio");
Console.WriteLine("Rol: 1 estudiante, 2 docente, 3 Técnico IT, 4 Visitante");
int rol = int.Parse(Console.ReadLine());

Console.WriteLine("Hora (0-23)");
double hora = double.Parse(Console.ReadLine());
Console.WriteLine("Dia (1-7)");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Carnet vigente (s/n)");
string carnet = Console.ReadLine();
Console.WriteLine("Autorización escrita (s/n)");
string autori = Console.ReadLine();
Console.WriteLine("Trae USB (s/n)");
string usb = Console.ReadLine();
if (usb == "s")
{
    Console.WriteLine("Está acompañado (s/n)");
}
else
{
    Console.WriteLine("Ingrese");
}

