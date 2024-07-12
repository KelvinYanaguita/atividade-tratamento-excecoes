namespace ConsoleApp1
{
    public class Average
    {
        public double CalcularMedia(double[] numeros)
        {
            if (numeros == null || numeros.Length == 0)
            {
                throw new ArgumentException("O array de números não pode ser nulo ou vazio.");
            }

            double soma = 0;
            foreach (var numero in numeros)
            {
                soma += numero;
            }

            return soma / numeros.Length;
        }
    }
}
