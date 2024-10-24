using System;
using System.Collections.Generic;
using System.Text;
using Inversão.Domain.Entities;

namespace Inversão.Domain.Contracts.ServiceContract.ClienteContract
{
    internal interface IClienteService
    {
        public void Add(Cliente cliente);
    }
}
