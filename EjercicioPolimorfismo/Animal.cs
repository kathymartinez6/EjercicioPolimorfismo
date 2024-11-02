
namespace EjercicioPolimorfismo
{
    public abstract class Animal
    {
        public abstract void Mover();

        // Método virtual que puede ser sobrescrito en las clases derivadas
        public virtual void Hablar()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }
}
