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
    public class GetCreditsHandler : IRequestHandler<CreditsPlatform, List<CreditDataEntity>>
    {
        private readonly ICreditsRepository _CreditsRepository;

        public GetCreditsHandler(ICreditsRepository CreditsRepository)
        {
            _CreditsRepository = CreditsRepository ?? throw new ArgumentNullException(nameof(CreditsRepository));
        }

        public async Task<List<CreditDataEntity>> Handle(CreditsPlatform request, CancellationToken cancellationToken)
        {
            List<CreditDataEntity> CreditData = await _CreditsRepository.GetCredits(request.Platform);

            if (CreditData.Count > 0)
                return CreditData;

            throw new NotImplementedException();
        }
    }
}
