using HackerMan.Data;
using HackerMan.Models;

namespace HackerMan.Services
{
    public class AccountService
    {
        private readonly List<Account> _accounts;

        public AccountService()
        {
            _accounts = SeedData.GetTestAccounts(); // Initialize with seed data
        }

        public List<Account> GetAccounts()
        {
            return _accounts;
        }

        public Account GetAccountById(int id)
        {
            return _accounts.FirstOrDefault(a => a.Id == id);
        }

        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }
    }
}