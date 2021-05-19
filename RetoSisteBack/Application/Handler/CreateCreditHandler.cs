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
    public class CreateCreditHandler : IRequestHandler<createCredit, string>
    {
            private readonly ICreditsRepository _CreditsRepository;

            public CreateCreditHandler(ICreditsRepository CreditsRepository)
            {
                _CreditsRepository = CreditsRepository ?? throw new ArgumentNullException(nameof(CreditsRepository));
            }

            public async Task<string> Handle(createCredit request, CancellationToken cancellationToken)
            {
                string result = await this._CreditsRepository.createCredit(request);

                return result;
            }
    }
 }

