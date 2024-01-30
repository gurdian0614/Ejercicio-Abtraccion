
namespace Ejercicio_Abtraccion
{
    internal class Vertebrado : Animal
    {
        public string Tipo { get; set; }
        public bool TienePatas { get; set; }
        public bool EsDomestico { get; set; }
        public bool EsHerbivoro { get; set; }
        public bool EsCarnivoro { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene patas: {ValidarAtributo(TienePatas)}");
            Console.WriteLine($"Doméstico: {ValidarAtributo(EsDomestico)}");
            Console.WriteLine($"Herbívoro: {ValidarAtributo(EsHerbivoro)}");
            Console.WriteLine($"Carnívoro: {ValidarAtributo(EsCarnivoro)}");
        }

        public override string ValidarAtributo(bool Valor)
        {
            return Valor ? "Si" : "No";
        }
    }
}
