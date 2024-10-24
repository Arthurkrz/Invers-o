using System;
using System.Collections.Generic;
using System.Text;
using Inversão.Domain.Entities;

namespace Inversão.Domain.Contracts.ServiceContract.CobrancaService
{
    internal interface ICobrancaService
    {
        public void Cobranca(Cliente cliente);
    }
}
