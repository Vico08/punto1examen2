

public class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool jugarDeNuevo = true;
        while (jugarDeNuevo)
        {
            Console.Clear();
            Console.WriteLine("Bienvenidos al Juego Adivina el número");


            int numJugadores = 0;
            while (numJugadores < 2 || numJugadores > 4)
            {
                Console.WriteLine("Ingrese el número de jugadores (2-4):");
                numJugadores = Convert.ToInt32(Console.ReadLine());
                if (numJugadores < 2 || numJugadores > 4)
                {
                    Console.WriteLine("Número de jugadores inválido. Por favor, ingrese un número entre 2 y 4:");
                }
            }

            int maximo = 0;
            switch (numJugadores)
            {
                case 2:
                    maximo = 50;
                    break;
                case 3:
                    maximo = 100;
                    break;
                case 4:
                    maximo = 200;
                    break;
            }
           

