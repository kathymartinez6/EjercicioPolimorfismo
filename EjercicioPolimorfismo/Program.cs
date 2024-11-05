
namespace EjercicioPolimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Animal miPerro = new Perro();
            Animal miGato = new Gato();
            Animal miAnimal = new Animal();

            
            Console.WriteLine("Demostración de polimorfismo en C#:\n");

            miAnimal.EmitirSonido();
            miAnimal.Accion();

            miPerro.EmitirSonido();
            miPerro.Accion();

            miGato.EmitirSonido();
            miGato.Accion();
        }
    }
}
    