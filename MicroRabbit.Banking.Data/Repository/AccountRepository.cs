using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domian.Interfaces;
using MicroRabbit.Banking.Domian.Model;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
           _ctx = ctx;
        }
        public IEnumerable<Account> GetAcccounts()
        {
            return _ctx.Accounts;
        }
    }
}
