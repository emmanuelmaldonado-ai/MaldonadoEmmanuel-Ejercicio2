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
if (usb == "s" || usb == "S")
{
    Console.WriteLine("Está acompañado (s/n)");
    string acompañado = Console.ReadLine();
}
int acceso = int.Parse(Console.ReadLine());

if (rol < 1 || rol > 4)
{
    Console.WriteLine("Tipo de rol no válido");
}
else if (hora < 0 || hora > 23)
{
    Console.WriteLine("Horas fuera de rango");
}
else if (dia < 1 || dia > 7)
{
    Console.WriteLine("Dias no validos");
}
else if (carnet != "s" && carnet != "S" && carnet != "n" && carnet != "N")
{
    Console.WriteLine("Carnet debe ser s o n");
}
else if (autori != "s" && autori != "S" && autori != "n" && autori != "N ")
{
    Console.WriteLine("La autorización debe ser s o n");
}
else if (usb != "s" && usb != "S" && usb != "n" && usb != "N")
{
    Console.WriteLine("USB tiene que ser s o n");
}

