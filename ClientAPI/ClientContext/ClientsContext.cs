using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientAPI.ClientContext
{
	public class ClientsContext : DbContext
	{
		public ClientsContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Client> clients { get; set; }

	}
}
