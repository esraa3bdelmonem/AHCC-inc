using System.Diagnostics;

namespace IEnumerable_and_IQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new InMemoryBankAccountRepository();
            var stopwatch = new Stopwatch();

            // Query using IEnumerable
            stopwatch.Start();
            var accountsEnumerable = repository.GetAllAccounts().GetAccountsByBalance(1000);
            stopwatch.Stop();
            Console.WriteLine($"IEnumerable query took {stopwatch.ElapsedMilliseconds} ms");

            // Query using IQueryable
            stopwatch.Reset();
            stopwatch.Start();
            var accountsQueryable = repository.GetQueryableAccounts().GetAccountsByBalance(1000);
            stopwatch.Stop();
            Console.WriteLine($"IQueryable query took {stopwatch.ElapsedMilliseconds} ms");

            // Output the results
            Console.WriteLine("Accounts with a balance :");
            foreach (var account in accountsQueryable)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}, Owner Name: {account.OwnerName}, Is Closed: {account.IsClosed}");
            }

            Console.ReadLine();
        }
    }
}