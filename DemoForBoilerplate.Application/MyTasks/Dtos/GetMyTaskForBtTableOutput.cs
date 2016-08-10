using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyTasks.Dtos
{
	public class GetMyTaskForBtTableOutput
	{
		public bool Status { get; set; }
		public string Message { get; set; }
		public List<MyTaskDto> data { get; set; }
	}
}
