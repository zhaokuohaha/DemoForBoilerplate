using Abp.EntityFramework;
using DemoForBoilerplate.MyPeople;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.EntityFramework.Repositories
{
	public class MyPersonRepository : DemoForBoilerplateRepositoryBase<MyPerson, int>, IMyPersonRepository
	{
		public MyPersonRepository(IDbContextProvider<DemoForBoilerplateDbContext> dbContextProvider) : base(dbContextProvider)
		{

		}
	}
}
