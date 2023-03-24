
using MicroRabbit.Banking.Domian.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Domian.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAcccounts();
    }
}
