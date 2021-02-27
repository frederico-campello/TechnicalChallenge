using System;
using System.Collections.Generic;
using API.Models;

namespace API.Services
{
    public class DivisorsService
    {
        public List<int> ListDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int div = 1; div <= Math.Abs(number); div++)
            {
                if (Math.Abs(number) % div == 0)
                {
                    divisors.Add(div);
                }
            }

            return divisors;
        }

        public string GetDivisors(int number)
        {
            return string.Join(", ", ListDivisors(number));
        }

        public bool IsPrime(int number)
        {
            if (number == 1) return false;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return number > 1;
        }

        public string GetPrimeDivisors(int number)
        {
            List<int> divisors = ListDivisors(number);

            List<int> primeNumbers = new List<int>();

            foreach (int div in divisors)
            {
                if (IsPrime(div)) primeNumbers.Add(div);
            }

            return primeNumbers.Count == 0 ? "Não há divisores primos" : string.Join(", ", primeNumbers);
        }

        public DivisorsModel Result(int number)
        {
            return new DivisorsModel
            {
                InputNumber = number,
                Divisors = GetDivisors(number),
                PrimeDivisors = GetPrimeDivisors(number)
            };
        }
    }
}
