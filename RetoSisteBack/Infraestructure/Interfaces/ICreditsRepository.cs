using RetoSisteBack.Infraestructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoSisteBack.Infraestructure
{
    public interface ICreditsRepository
    {
        Task<List<CreditDataEntity>> GetCredits(string platform);
        Task<string> createCredit(createCredit objCredit);
        Task<string> updateCredit(updateCredit objCredit);
        Task<string> deleteCredit(deleteCredit id);
    }
}
