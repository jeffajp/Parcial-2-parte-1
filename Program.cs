Dictionary<int, Equipo> equipos = new Dictionary<int, Equipo>();
int opcion = 0;
do
{
    Console.WriteLine("1. Registrar equipo");
    Console.WriteLine("2. modificar equipo");
    Console.WriteLine("3. eliminar equipo: ");
    Console.WriteLine("4. buscar equipo: ");
    Console.WriteLine("5. mostrar todos los equipos: ");
    Console.WriteLine("6. registrar prestamo de equipo: ");
    Console.WriteLine("7. registrar devolucion: ");
    Console.WriteLine("8. mostrar resumen general: ");
    Console.WriteLine("9. mostrar equipos por estado: ");
    Console.WriteLine("10. mostrar equipos por tipo: ");
    Console.WriteLine("11. salir: ");

    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("ingrese el codigo del equipo a registrar: ");
            int codigo = int.Parse(Console.ReadLine());
            if (!equipos.ContainsKey(codigo))
            {
                Equipo e = new Equipo();
                Console.WriteLine("ingrese el nombre del equipo: "); e.Nombre = Console.ReadLine();
                Console.WriteLine("ingrese el tipo de equipo: "); e.Tipo = Console.ReadLine();
                Console.WriteLine("ingrese el costo de uso por hora: "); e.CostoHora = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese las horas que utilizara el equipo: "); e.Hora = double.Parse(Console.ReadLine());
                Console.WriteLine("Equipo registrado correctamente: ");
                equipos.Add(codigo, e);

            }
            else
            {
                Console.WriteLine("el equipo ya existe: ");
            }
            Console.ReadLine();
            Console.Clear();

            break;
        case 2:
            Console.WriteLine("ingrese el codigo del equipo que desea modificar: ");
            codigo = int.Parse(Console.ReadLine());
            if (equipos.ContainsKey(codigo))
            {
                Equipo e = new Equipo();
                Console.WriteLine("ingrese el nuevo nombre: "); e.Nombre = Console.ReadLine();
                Console.WriteLine("ingrese el tipo: "); e.Tipo = Console.ReadLine();
                Console.WriteLine("ingrese costo por hora: "); e.CostoHora = double.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el estado: "); e.Estado = Console.ReadLine();
                equipos[codigo] = e;

            }
            else
            {
                Console.WriteLine("el equipo no existe no se puede modificar: ");
            }
            Console.ReadLine();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine("ingrese el codigo del equipo que desea eliminar: ");
            codigo = int.Parse(Console.ReadLine());
            if (equipos.Remove(codigo))
            {
                Console.WriteLine("equipo eliminado: ");

            }
            else
            {
                Console.WriteLine("equipo no existe: ");
            }
            Console.ReadLine();
            Console.Clear();
            break;
        case 4:
            Console.WriteLine("ingrese el codigo del equipo que desea buscar: ");
            codigo = int.Parse(Console.ReadLine());
            if(equipos.ContainsKey(codigo))
            {
                Console.WriteLine("el equipo es: ");
                
                
            }
            else
            {
                Console.WriteLine("el equipo no existe: ");
            }
            Console.ReadLine();
            Console.Clear();
            break;
        case 5:
            Console.WriteLine("los equipos registrados son: ");
            foreach(var item in equipos)
            {
                Console.Write($"{item.Key} + {item.Value}");
            }
            Console.ReadLine();
            Console.Clear();
            break;
        case 6:
            Console.WriteLine("ingrese el codigo del equipo: ");
            Console.ReadLine();
            Console.Clear();
            break;
        case 7:
            Console.WriteLine("ingrese el codigo del equipo a devolver: ");
            Console.ReadLine();
            Console.Clear();
            break;
        case 8:
            Console.WriteLine("el total de equipos registrados son: ");
            Console.ReadLine();
            Console.Clear();
            break;
        case 9:
            Console.WriteLine("los estados de los equipos son: ");
            Console.ReadLine();
            Console.Clear();
            break;
        case 10:
            Console.WriteLine("los tipos de equipo son: ");
            Console.ReadLine();
            Console.Clear();
            break;
        case 11:
            Console.WriteLine("gracias por utilizar el sistema: ");
            Console.ReadLine();
            Console.Clear();
            break;
        default:
            Console.WriteLine("selecciono una opcion incorrecta: ");
            break;

    }

} while(opcion != 0);



class Equipo
{
    public int Codigo;
    public string Nombre;
    public string Tipo;
    public double CostoHora;
    public double Hora;
    public string Estado;

    public double HorasPrestada()
    {
        return Hora * CostoHora;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($" codigo: {Codigo}--nombre: {Nombre}--Tipo: {Tipo}--costo por hora: {Hora}--Horas prestadas: {HorasPrestada()}--estado: {Estado}");
    }
    /*public string Estado()
    {
        if (Hora > 0)
        {
            return "Prestado: ";
        }
        else if(Hora ==0)
        {
            return "Disponible: ";
        }
        else
        {
            return "Mantenimiento ";
        }
    
    }
    */
   
   
}
