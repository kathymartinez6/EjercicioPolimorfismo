
namespace EjercicioPolimorfismo
{
    public class Gato: Animal
    {
        public override void EmitirSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau miau!");
        }

        public override void Accion()
        {
            Console.WriteLine("El gato se acurruca.");
        }
    }
}
