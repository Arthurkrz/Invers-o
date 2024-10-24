using System;
using System.Collections.Generic;
using System.Text;
using Inversão.Domain.Entities;

namespace Inversão.Domain.Contracts.RepositoryContract
{
    internal interface IClienteRepository
    {
        public void Add(Cliente cliente);
    }
}
