using System;
using System.Collections.Generic;
using System.Text;
using Inversão.Domain.Contracts.RepositoryContract;
using Inversão.Domain.Entities;

namespace Inversão.Repository
{
    internal class ClienteRepository : IClienteRepository
    {
        private static List<Cliente> clientes = new List<Cliente>();
        private static int id = 0;
        public void Add(Cliente cliente)
        {
            cliente.ID = id++;
            clientes.Add(cliente);
        }
    }
}
