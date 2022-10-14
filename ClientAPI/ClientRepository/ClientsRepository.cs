using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientAPI.Models;
using ClientAPI.ClientContext;
using Microsoft.EntityFrameworkCore;

namespace ClientAPI.ClientRepository
{
	public class ClientsRepository : IClientRepository
	{
		private readonly ClientsContext _context;

		public ClientsRepository(ClientsContext context)
		{
			_context = context;
		}
		public async Task<Client> Create(Client client)
		{
			_context.clients.Add(client);
			await _context.SaveChangesAsync();
			return client;
		}

		public async Task<Client> Delete(int Id)
		{
			var clientToDelete = await _context.clients.FindAsync(Id);
			_context.clients.Remove(clientToDelete);
			await _context.SaveChangesAsync();
			return null;
		}

		public async Task<List<Client>> Get()
		{
			return await _context.clients.ToListAsync();
		}

		public async Task<Client> Get(int Id)
		{
			return await _context.clients.FindAsync(Id);
		}

		public async Task<Client> Update(Client client)
		{
			_context.Entry(client).State = EntityState.Modified;
			await _context.SaveChangesAsync();
			return null;
		}
	}
}
