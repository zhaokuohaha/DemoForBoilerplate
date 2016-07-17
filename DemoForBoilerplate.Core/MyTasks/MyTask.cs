using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoForBoilerplate.MyPeople;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoForBoilerplate.MyTasks
{
	public class MyTask : Entity, IHasCreationTime
	{
		[ForeignKey("AssignedPersonId")]
		public MyPerson AssignedPerson { get; set; }
		public int? AssignedPersonId { get; set; }
		public string Description { get; set; }
		public MyTaskState State { get; set; }
		public DateTime CreationTime { get; set; }
		public MyTask()
		{
			State = MyTaskState.Active;
		}
	}
}
