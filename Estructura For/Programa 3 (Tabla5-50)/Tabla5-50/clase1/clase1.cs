namespace Tabla50
{
    public class Tabla550()
    {
        public void MostrarTabla5al50()
        {
            try
            {

                int numero = 5;
                int cantidad = 50;
                int resultado = 0;

                Console.WriteLine("Presiona cualquier tecla para mostrar la tabla del 5 al 50.");
                Console.ReadKey();

                for (int i = 0; i <= cantidad; i++)
                {
                    resultado = (numero * i);
                    Console.WriteLine($"{5} x {i} = {resultado}");
                    Thread.Sleep(270);

                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el programa.");
            }
        }
    }
}