using Abp.EntityFramework;
using DemoForBoilerplate.MyPeople;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.EntityFramework.Repositories
{
	public class MyPersonRopository : DemoForBoilerplateRepositoryBase<MyPerson, int>, IMyPersonRepository
	{
		public MyPersonRopository(IDbContextProvider<DemoForBoilerplateDbContext> dbContextProvider) : base(dbContextProvider)
		{

		}
	}
}
