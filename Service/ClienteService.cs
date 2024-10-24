using System;
using System.Collections.Generic;
using System.Text;
using Inversão.Domain.Contracts.ServiceContract.ClienteContract;
using Inversão.Domain.Contracts.ServiceContract.CobrancaService;
using Inversão.Domain.Contracts.ServiceContract.NFService;
using Inversão.Domain.Entities;
using Inversão.Repository;

namespace Inversão.Service
{
    internal class ClienteService : IClienteService, ICobrancaService, INFService
    {
        private readonly ClienteRepository _clienteRepository;
        public void Add(Cliente cliente)
        {
            if (cliente.Idade >= 18)
            {
                cliente.ID++;
                _clienteRepository.Add(cliente);
            }
            else
            {
                Console.WriteLine("O cliente deve ter mais que 18 anos.");
            }
        }
        public void Cobranca(Cliente cliente)
        {
            
        }
        public void EnviarNF(Cliente cliente)
        {

        }
    }
}
