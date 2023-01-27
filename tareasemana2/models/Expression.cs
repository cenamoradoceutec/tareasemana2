namespace tareasemana2.models
{
    public class Expresion
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }



        public decimal Suma()
        {
            return Numero1 + Numero2;
        }

        public decimal Resta()
        {
            return Numero1 - Numero2;
        }

        public decimal Division()
        {
            return Numero1 / Numero2;
        }

        public decimal Multiplicacion()
        {
            return Numero1 * Numero2;
        }

        public decimal Maximo()
        {
            return Math.Max(Numero1, Numero2);
        }

        public decimal Minimo()
        {
            return Math.Min(Numero1, Numero2);
        }





    }
}