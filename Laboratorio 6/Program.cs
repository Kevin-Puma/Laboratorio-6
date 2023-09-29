Console.Write("Ingrese un número máximo de personas: ");
int maximoPersonas = int.Parse(Console.ReadLine());
int asistenciaActuales = 0;
int totalPersonasIngresaron = 0;
int totalPersonasSalieron = 0;
int vecesLleno = 0;
int vecesVacio = 0;

Console.WriteLine("========================================");
Console.Write("El número máximo establecido es de " + maximoPersonas + " personas, presione una tecla para comenzar a contar");

Console.ReadKey();
Console.Clear();

Console.WriteLine("======================================");
Console.WriteLine("| Asistencia actuales | " + asistenciaActuales);
Console.WriteLine("| Aforo               | " + ((asistenciaActuales * 100) / maximoPersonas) + "%");
Console.WriteLine("| Máximo              | " + maximoPersonas + " personas");
Console.WriteLine("======================================");
Console.WriteLine("Presione");
Console.WriteLine("[ i ] si ingresa una persona");
Console.WriteLine("[ s ] si sale una persona");
Console.WriteLine("[ x ] para terminar ");

char opcion;
while ((opcion = Console.ReadKey().KeyChar) != 'x')
{
    Console.Clear();
    if (opcion == 'i')
    {
        if (asistenciaActuales < maximoPersonas)
        {
            asistenciaActuales++;
            totalPersonasIngresaron++;
        }
    }
    else if (opcion == 's')
    {
        if (asistenciaActuales > 0)
        {
            asistenciaActuales--;
            totalPersonasSalieron++;
        }
    }
    if (asistenciaActuales == maximoPersonas)
    {
        vecesLleno++;
    }
    else if (asistenciaActuales == 0)
    {
        vecesVacio++;
    }

    Console.WriteLine("======================================");
    Console.WriteLine("| Asistencia actuales | " + asistenciaActuales);
    Console.WriteLine("| Aforo               | " + ((asistenciaActuales * 100) / maximoPersonas) + "%");
    Console.WriteLine("| Máximo              | " + maximoPersonas + " personas");
    Console.WriteLine("======================================");
    Console.WriteLine("Presione");
    Console.WriteLine("[ i ] si ingresa una persona");
    Console.WriteLine("[ s ] si sale una persona");
    Console.WriteLine("[ x ] para terminar(presiona 2 veces para confirmar) ");
}

Console.ReadKey();
Console.Clear();
Console.WriteLine("==============================");
Console.WriteLine("El programa ha terminado.");
Console.WriteLine("==============================");
Console.WriteLine("Estadísticas:");
Console.WriteLine("------------------------------");
Console.WriteLine(+totalPersonasIngresaron + " personas ingresaron");
Console.WriteLine(+totalPersonasSalieron + " personas salieron");
Console.WriteLine(+vecesLleno + " veces se llenó el local");
Console.WriteLine("Estuvo vacio " + vecesVacio + " veces");
Console.ReadKey();
