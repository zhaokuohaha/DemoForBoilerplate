using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyTasks.Dtos
{
	[AutoMapFrom(typeof(MyTask))]
	public class MyTaskDto : Entity<int>
	{
		public int ? AssignedPersonId { get; set; }
		public string AssignedPersonName { get; set; }
		public string Description { get; set; }
		public DateTime CreationTime { get; set; }
		public byte State { get; set; }

		public override string ToString()
		{
			return string.Format(
				"[Task Id={0}, Description={1}, CreationTime={2}, AssignedPersonName={3}, State={4}]",
				Id,
				Description,
				CreationTime,
				AssignedPersonId,
				(MyTaskState)State
				);
		}
	}
}
