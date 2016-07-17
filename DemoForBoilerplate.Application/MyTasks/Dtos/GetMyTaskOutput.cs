using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyTasks.Dtos
{
	public class GetMyTaskOutput : IOutputDto
	{
		public List<MyTaskDto> Tasks { get; set; }
	}
}
