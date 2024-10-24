using System;
using System.Collections.Generic;
using System.Text;
using Inversão.Service;
using Inversão.Domain.Entities;
using Inversão.Repository;

namespace Inversão.Controller
{
    internal class ClienteController
    {
        private readonly ClienteService _clienteService;
        public void AddCliente(string nome, string email, string cpf, int idade)
        {
            if (BaseValid(nome, email, cpf, idade))
            {
                Cliente cliente = new Cliente(nome, email, cpf, idade);
                _clienteService = new ClienteService(new ClienteRepository());
                _clienteService.Add(cliente);
                _clienteService.EnviarNF(cliente);
                _clienteService.Cobranca(cliente);
            }
        }
        public void EnviarNF(Cliente cliente)
        {
            _clienteService.EnviarNF(cliente);
        }
        public void Cobranca(Cliente cliente)
        {
            _clienteService.Cobranca(cliente);
        }
        public bool BaseValid(string nome, string email, string cpf, int idade)
        {
            if (nome != null && email != null && cpf != null && idade > 0)
            {
                return true;
            }
            return false;
        }
    }
}
