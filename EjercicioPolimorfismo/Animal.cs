
namespace EjercicioPolimorfismo
{
    public class Animal
    {
        public virtual void EmitirSonido()
        {
            Console.WriteLine("El animal emite un sonido.");
        }

        public virtual void Accion()
        {
            Console.WriteLine("El animal realiza una acción.");
        }
    }
}
