namespace TriangulosBxH
{
    public class TrianguloBaseAltura
    {
        public void CalcularSuperficieTriangulo()
        {
            try
            {
                int cantidad = 0;
                double MedidaBase = 0;
                double altura = 0;
                double superficie = 0;
                int superficieMayor = 0;
                int superficieMenor = 0;


                Console.WriteLine("Ingrese la cantidad de triangulos que desea calcular.");
                cantidad = int.Parse(Console.ReadLine());

                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"Ingrese la base de su triangulo {i + 1}.");
                    MedidaBase = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Ingrese la altura de su triangulo. {i + 1}");
                    altura = double.Parse(Console.ReadLine());

                    superficie = MedidaBase * altura / 2;

                    if (superficie > 12)
                    {
                        superficieMayor++;
                    }
                    else
                    {
                        superficieMenor++;
                    }

                    Console.WriteLine($"La base de su triangulo fue {MedidaBase}. \nLa altura de su triangulo fue {altura}. \nLa superficie de su triangulo fue {superficie}");
                }

                Console.WriteLine($"La cantidad de triangulos con superficie mayores a 12 fueron: {superficieMayor}.");
                Console.WriteLine($"La cantidad de triangulos con superficie menores a 12 fueron: {superficieMenor}.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ingresar caracter, prueba usando numeros.");
            }
        }
    }
}
