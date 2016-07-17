using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyTasks
{
	public interface IMyTaskRepository : IRepository<MyTask,int>
	{
		List<MyTask> GetAllWithPeople(int? assignedPersonId, MyTaskState ? state);
	}
}
