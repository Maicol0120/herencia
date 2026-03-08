using System;

namespace TallerHerencia
{
    public class Rectangulo : Figura
    {
        private double baseRect;
        private double altura;

        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseRect * altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }
}
