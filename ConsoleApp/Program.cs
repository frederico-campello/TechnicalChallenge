using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {
            try
            {
                Console.Write("Digite um número: ");
                int inputNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("=====================");
                HttpResponseMessage response = await client.GetAsync($"https://localhost:44334/Divisors?number={inputNumber}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
