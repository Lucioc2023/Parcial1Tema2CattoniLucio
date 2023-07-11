namespace Parcial1Tema2CattoniLucio.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, volumen;
            double ladoDeLaBase, altura;
            
            Console.WriteLine("ESTE PROGRAMA SE EJECUTARA MIENTRAS INGRESE VALORES DISTINTO DE 0 (cero) ");

            
            do
            {
                int contador;
                contador = 0;
                Console.WriteLine("Ingrese la base de la piramide");
                ladoDeLaBase = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la altura de la piramide");
                altura = double.Parse(Console.ReadLine());
                area = CalcularArea(ladoDeLaBase, altura);
                volumen = CalcularVolumen(ladoDeLaBase, altura);
                if (ladoDeLaBase != 0 || altura != 0)
                {
                    
                    Console.WriteLine($" Area {area} Volumen {volumen}");

                }
                else
                {
                    break;
                }

            } while (true);
           

        }

        private static double CalcularVolumen(double ladoDeLaBase, double altura)
        {
            return  ((ladoDeLaBase * ladoDeLaBase) * altura) / 3;
        }

        private static double CalcularArea(double ladoDeLaBase, double altura)
        {
            return ladoDeLaBase * (ladoDeLaBase + Math.Sqrt(4 * (altura * altura) + (ladoDeLaBase * ladoDeLaBase)));
        }


    }
}