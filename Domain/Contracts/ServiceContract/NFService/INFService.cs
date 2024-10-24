using System;
using System.Collections.Generic;
using System.Text;
using Inversão.Domain.Entities;

namespace Inversão.Domain.Contracts.ServiceContract.NFService
{
    internal interface INFService
    {
        public void EnviarNF(Cliente cliente);
    }
}
