using Abp.EntityFramework;
using DemoForBoilerplate.MyTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DemoForBoilerplate.EntityFramework.Repositories
{
	public class MyTaskRepository :	DemoForBoilerplateRepositoryBase<MyTask, int> , IMyTaskRepository
	{
		public MyTaskRepository(IDbContextProvider<DemoForBoilerplateDbContext> dbContextProvider)
			: base(dbContextProvider)
		{
		}

		public List<MyTask> GetAllWithPeople(int ? assignedPeopleId, MyTaskState ? state)
		{
			IQueryable<MyTask> query = (IQueryable < MyTask >) GetAll();
			if (assignedPeopleId.HasValue)
			{
				query = query.Where(myTask => myTask.AssignedPerson.Id == assignedPeopleId.Value);
			}
			if (state.HasValue)
			{
				query = query.Where(myTask => myTask.State == state.Value);
			}

			return query
				.OrderByDescending(t => t.CreationTime)
				.Include(t => t.AssignedPerson)	
				.ToList();
		}
	}
}
