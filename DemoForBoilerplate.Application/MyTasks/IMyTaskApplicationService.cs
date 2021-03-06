﻿using Abp.Application.Services;
using DemoForBoilerplate.MyTasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyTasks
{
	public interface IMyTaskApplicationService : IApplicationService
	{
		GetMyTaskOutput GetMyTask(GetMyTaskInput input);
		GetMyTaskForBtTableOutput GetMyTaskForBtTable();
		void UpdateMyTask(UpdateMyTaskInput input);
		void CreateMyTask(CreattMyTaskInput input);
		void DeleteMyTask(DeleteMyTaskInput input);
		string Test();

	}
}
