using MediatR;
using RetoSisteBack.Infraestructure;
using RetoSisteBack.Infraestructure.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RetoSisteBack.Application.Handler
{
    public class DeleteCreditHandler : IRequestHandler<deleteCredit, string>
    {

        private readonly ICreditsRepository _CreditsRepository;

        public DeleteCreditHandler(ICreditsRepository CreditsRepository)
        {
            _CreditsRepository = CreditsRepository ?? throw new ArgumentNullException(nameof(CreditsRepository));
        }

        public async Task<string> Handle(deleteCredit request, CancellationToken cancellationToken)
        {
            string CreditData = await _CreditsRepository.deleteCredit(request);

            if (CreditData != null)
                return CreditData;

            throw new NotImplementedException();
        }

    }
}
