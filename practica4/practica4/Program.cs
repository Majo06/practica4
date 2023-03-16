using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Catálogo de Prendas: \n ");
            Camiseta camiseta1 = new Camiseta();
            camiseta1.Nombre = "Camiseta básica";
            camiseta1.Categoria = "Camisetas";
            camiseta1.Calidad = "Regular";
            camiseta1.Material = "Algodón";
            camiseta1.Color = "Negra";
            camiseta1.Tallas = new List<string> { "S", "M", "L", "XL" };

            Pantalones pantalones1 = new Pantalones();
            pantalones1.Nombre = "Pantalones con cargo";
            pantalones1.Categoria = "Pantalones";
            pantalones1.Calidad = "Premium";
            pantalones1.Material = "microfibra";
            pantalones1.Estilo = "Recto";
            pantalones1.Tallas = new List<string> { "28", "30", "32", "34", "36" };

            Chaqueta chaqueta1 = new Chaqueta();
            chaqueta1.Nombre = "Chaqueta de cuero";
            chaqueta1.Categoria = "Chaquetas";
            chaqueta1.Calidad = "Alta";
            chaqueta1.Material = "Cuero";
            chaqueta1.Color = "verde";
            chaqueta1.Estilo = "Motociclista";
            chaqueta1.Tallas = new List<string> { "S", "M", "L", "XL", "XXL" };

            Catalogo catalogo = new Catalogo();
            catalogo.AgregarPrenda(camiseta1);
            catalogo.AgregarPrenda(pantalones1);
            catalogo.AgregarPrenda(chaqueta1);

            catalogo.MostrarCatalogo();
            Console.ReadLine();
        }

        abstract class Prenda
        {
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public string Calidad { get; set; }
            public List<string> Tallas { get; set; }

          
            public abstract void MostrarInfo();
        }

        
        class Camiseta : Prenda
        {
            public string Material { get; set; }
            public string Color { get; set; }

           
            public override void MostrarInfo()
            {
                Console.WriteLine("Camiseta: {0}", Nombre);
                Console.WriteLine("Material: {0}", Material);
                Console.WriteLine("Color: {0}", Color);
                Console.WriteLine("Tallas disponibles: {0}", string.Join(", ", Tallas));
            }
        }

       
        class Pantalones : Prenda
        {
            public string Material { get; set; }
            public string Estilo { get; set; }

         
            public override void MostrarInfo()
            {
                Console.WriteLine("Pantalones: {0}", Nombre);
                Console.WriteLine("Material: {0}", Material);
                Console.WriteLine("Estilo: {0}", Estilo);
                Console.WriteLine("Tallas disponibles: {0}", string.Join(", ", Tallas));
            }
        }

        class Chaqueta : Prenda
        {
            public string Material { get; set; }
            public string Color { get; set; }
            public string Estilo { get; set; }

            
            public override void MostrarInfo()
            {
                Console.WriteLine("Chaqueta: {0}", Nombre);
                Console.WriteLine("Material: {0}", Material);
                Console.WriteLine("Color: {0}", Color);
                Console.WriteLine("Estilo: {0}", Estilo);
                Console.WriteLine("Tallas disponibles: {0}", string.Join(", ", Tallas));
            }
        }

   
        class Catalogo
        {
            private List<Prenda> prendas;

            public Catalogo()
            {
                prendas = new List<Prenda>();
            }

            
            public void AgregarPrenda(Prenda prenda)
            {
                prendas.Add(prenda);
            }

            
            public void MostrarCatalogo()
            {
                foreach (Prenda prenda in prendas)
                {
                    prenda.MostrarInfo();
                    Console.WriteLine();
                }
            }
        }

    }
}
