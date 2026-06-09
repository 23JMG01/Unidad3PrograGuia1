internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Datos academicos\nNombre: Javier Murillo"+
            "\nGrado: IV C"+ 
            "\nClave: 25");
        int[] edadPersonas=new int[7];
        int cantidadPersonasMayores = 0;
        int cantidadPersonasMenores = 0; 


        //llenar el arreglo
        for (int i = 0; i < edadPersonas.Length; i++) 
        {
            Console.Write("Ingrese la edad de la persona " +(i+1)+ ":");
            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());
            
            if (edadPersonas[i] >=18)
            {
                cantidadPersonasMayores++;

            }
           else
            {
                cantidadPersonasMenores++;
            }

        }
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas mayores de edad: " +
            cantidadPersonasMayores);
        Console.WriteLine("Cantidad de personas menores de edad: " +
            cantidadPersonasMenores);
    }
}
