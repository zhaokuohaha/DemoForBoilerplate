using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DemoForBoilerplate.MyTasks.Dtos
{
	
	public class UpdateMyTaskInput : IInputDto, ICustomValidate
	{
		[Range(1, int.MaxValue)]
		public int TaskId { get; set; }
		public	int ? AssignedPersonId { get; set; }
		public MyTaskState ? State { get; set; }

		//自定义验证，实现ICustomValidate 接口
		public void AddValidationErrors(List<ValidationResult> results)
		{
			if(AssignedPersonId==null || State == null)
			{
				results.Add(new ValidationResult("Both of AssignedPersonId and State can not be null in order to update a Task!", new[] { "AssignedPersonId", "State" }));
			}
		}

		public override string ToString()
		{
			return string.Format("[UpdateTaskInput > TaskId = {0}, AssignedPersonId = {1}, State = {2}]", TaskId, AssignedPersonId, State);
		}
	}
}
