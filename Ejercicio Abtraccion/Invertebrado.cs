
namespace Ejercicio_Abtraccion
{
    internal class Invertebrado : Animal
    {
        public string Tipo { get; set; }
        public bool TienePatas { get; set; }
        public int NumeroPatas { get; set; }
        public bool TieneConcha { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene patas: {ValidarAtributo(TienePatas)}");
            Console.WriteLine($"Número de patas: {NumeroPatas}");
            Console.WriteLine($"Concha: {ValidarAtributo(TieneConcha)}");
        }

        public override string ValidarAtributo(bool Valor)
        {
            return Valor ? "Si" : "No";
        }
    }
}
