namespace TestesEficientesParte1Demo
{
    public class Demo1Service
    {
        public bool IsPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                int resto = number % i;
                if (resto == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
