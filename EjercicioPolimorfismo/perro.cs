

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }

        public override void Accion()
        {
            Console.WriteLine("El perro mueve la cola.");
        }
    }
}
