using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace DemoForBoilerplate.MyTasks.Dtos
{
	public class GetMyTaskInput : IInputDto
	{
		public MyTaskState ? state { get; set; }
		public int ? AssignedPersonId { get; set; }
	}
}
