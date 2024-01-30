
namespace Ejercicio_Abtraccion
{
    internal abstract class Animal
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Tamano { get; set; }
        public string Familia { get; set; }

        public abstract void Imprimir();

        public abstract string ValidarAtributo(bool Valor);
    }
}
