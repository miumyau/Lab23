namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n=Convert.ToInt32(Console.ReadLine());
            GetFactAsync(n);
            Hello(n);//создала метод чтобы проверить асинхронность
            Console.ReadKey();
             
        }

        static int GetFact (int n)
        {
            int nfact = 1;
            for (int i = 2; i <= n; i++) 
            {
                nfact*= i;
                Thread.Sleep(15);
            }
            Console.WriteLine("n!={0}",nfact);
            return nfact;
        }

        static async Task<int> GetFactAsync(int n)
        {
            int result=await Task.Run(() => GetFact(n));
            return result;
        }

        static void Hello(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hello", i);
            }
        }
    }
        
}
