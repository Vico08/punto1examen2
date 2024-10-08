

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
            int numeroAleatorio = random.Next(0, maximo + 1);


            bool ganador = false;
            int turno = 1;

            while (!ganador)
            {
                Console.WriteLine($"Jugador {turno}, ingrese su número:");
                int numeroIngresado;
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado) || numeroIngresado < 0 || numeroIngresado > maximo)
                {
                    Console.WriteLine("Ingrese un número válido entre 0 y " + maximo + ":");
                }

                if (numeroIngresado > numeroAleatorio)
                {
                    Console.WriteLine("MENOR");
                }
                else if (numeroIngresado < numeroAleatorio)
                {
                    Console.WriteLine("MAYOR");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    ganador = true;
                }

                turno = (turno % numJugadores) + 1;
            }


            Console.WriteLine("¿Desean jugar de nuevo? (s/n):");
            char respuesta = Console.ReadKey().KeyChar;
            jugarDeNuevo = respuesta == 's' || respuesta == 'S';
            Console.WriteLine();
        }
    }
}



