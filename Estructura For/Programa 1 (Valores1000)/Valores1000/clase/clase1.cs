namespace MayoresIgualesMil; 

public class MayoresIgualMil()
{
    public void MayoresIgualesMill()
    {
       try
        {
            int cantidad = 0;
            int mayores = 0;
            int menores = 0;
            int valores = 0;

            Console.WriteLine("Ingrese la cantidad de valores que desea medir.");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese sus valores a medir.");
                valores = int.Parse(Console.ReadLine());


                if (valores >= 1000)
                {
                    //Console.WriteLine("Es mayor o igual a 1000.");
                    mayores++;
                }

                else
                {
                    //Console.WriteLine("Es menor a 1000.");
                    menores++;
                }
            }

            Console.WriteLine($"Usted ingreso {mayores} numeros mayores. \nUsted ingreso {menores} numeros menores.");

        }

        catch (Exception ex) 
        {
            Console.WriteLine("Error al ingresar caracter, prueba usando numeros.");
        }


    }
}