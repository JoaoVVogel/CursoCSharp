using System;
using System.Globalization;

namespace ExercicioTriangulo {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os lados do Triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os lados do Triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.perimetro = (x.A + x.B + x.C) / 2.0;
            x.area = Math.Sqrt(x.perimetro * (x.perimetro - x.A) * (x.perimetro - x.B) * (x.perimetro - x.C));

            y.perimetro = (y.A + y.B + y.C) / 2.0;
            y.area = Math.Sqrt(y.perimetro * (y.perimetro - y.A) * (y.perimetro - y.B) * (y.perimetro - y.C));

            Console.WriteLine("Area de X: " + x.area);
            Console.WriteLine("Area de Y: " + y.area);

            string maiorOuMenor(double x, double y) => x > y ? "A area de X é maior..." : "A area de Y é maior...";

            Console.WriteLine(maiorOuMenor(x.area, y.area));
        }
    }
}