using GVP.Models;
using GVP.Repositories;
using GVP.Data;
using System.Collections.Generic;

namespace GVP.Controllers
{
    public class ClientController
    {
        private readonly ClientRepository _repository;

        public ClientController()
        {
            var context = new AppDbContext();
            _repository = new ClientRepository(context);
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _repository.GetAll();
        }

        public Client? GetClientById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddClient(Client client)
        {
            _repository.Add(client);
        }

        public void UpdateClient(Client client)
        {
            _repository.Update(client);
        }

        public void DeleteClient(int id)
        {
            _repository.Delete(id);
        }
    }
}
