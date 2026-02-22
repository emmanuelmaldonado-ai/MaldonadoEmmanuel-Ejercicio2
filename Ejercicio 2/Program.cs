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
}
else if (usb == "n" && usb == "N")
{
    Console.WriteLine("Ingresa solo");
}

if (hora < 0 && hora > 23)
{
    Console.WriteLine("fuera de rango");
}
else if (dia < 1 && dia > 7)
{
    Console.WriteLine("Dias fuera de rango");
}
else if (carnet == "n" || carnet == "N")
{
    Console.WriteLine("No puede entrarsin carnet");
}
else if (autori == "n" || autori == "N")
{
    Console.WriteLine("No puede entrar sin autorización");
}
else if (usb == "n" || usb == "N")
{
    string acompañado = "n";
    if (usb == "s")
    {
        Console.WriteLine("Esta acompañado (s/n)");
        acompañado = Console.ReadLine();
    }
}
string resultadoacceso = "denegado";
string nivelpermiso = "Ninguno";


switch (rol)
{
  
    case 1:
        int estudiante = int.Parse(Console.ReadLine());
        if (estudiante == 1)
        {
            if (dia >=1 && dia <= 5 && hora >= 7 && hora <= 18 && carnet == "s")
            {
                Console.WriteLine("Horario habil");
                resultadoacceso = "permitido";
                nivelpermiso = "estudiante";
            }
            else
            {
                Console.WriteLine("Dia y horario no permitido para estudiante");
            }
        }
        break;
    case 2:
        int docente = int.Parse(Console.ReadLine());
        {
            if (carnet == "s")
            {
                resultadoacceso = "permitido";
                nivelpermiso = "docente";
            }
        }
        break;
    case 3:
        int tecnico = int.Parse(Console.ReadLine());
        if (carnet == "s")
        {
            if (hora >= 7 && hora <= 18 && dia <= 5)
            {
                resultadoacceso = "permirido";
                nivelpermiso = "Tecnico";
            }
            else if (autori == "s")
            {
                resultadoacceso = "permitido";
                nivelpermiso = "Tecnico";
            }
        }
        else if (autori == "s")
        {
            resultadoacceso = "permitido";
            nivelpermiso = "Tecnico";
        }
        break;
    case 4:
        if (autori == "s")
        {
            if (acompañado == "s")
            {
                resultadoacceso == "permitido";
                nivelpermiso = "visitante";
            }
        }
        break; 
}

