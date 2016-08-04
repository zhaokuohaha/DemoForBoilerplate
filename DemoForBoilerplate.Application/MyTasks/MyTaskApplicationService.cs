using System;
using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using DemoForBoilerplate.MyTasks.Dtos;
using DemoForBoilerplate.MyPeople;
using AutoMapper;


namespace DemoForBoilerplate.MyTasks
{
	/// <summary>
	/// 构造性注入
	/// </summary>
	public class MyTaskApplicationService : ApplicationService, IMyTaskApplicationService
	{
		
		private readonly IMyTaskRepository _myTaskRepository;
		private readonly IMyPersonRepository _myPersonRepository;

		public MyTaskApplicationService(IMyTaskRepository myTaskRepository, IMyPersonRepository myPersonRepository)
		{
			_myTaskRepository = myTaskRepository;
			_myPersonRepository = myPersonRepository;
		}

		public void CreateMyTask(CreattMyTaskInput input)
		{
			Logger.Info("Creating a task for input" + input);
			var myTask = new MyTask { Description = input.Description };
			if (input.AssignedPersonId.HasValue)
			{
				myTask.AssignedPerson = _myPersonRepository.Load(input.AssignedPersonId.Value);
			}
			_myTaskRepository.Insert(myTask);
		}
		
		public GetMyTaskOutput GetMyTask(GetMyTaskInput input)
		{
			Logger.Info("Get Tasl for input: input: " + input);
			var myTasks = _myTaskRepository.GetAllWithPeople(input.AssignedPersonId, input.state);
			return new GetMyTaskOutput
			{
				Tasks = Mapper.Map<List<MyTaskDto>>(myTasks)
			};
		}

		public void DeleteMyTask(DeleteMyTaskInput input)
		{	
			_myTaskRepository.Delete(input.Id);
		}

		public void UpdateMyTask(UpdateMyTaskInput input)
		{
			Logger.Info("Updating a task for input: " + input);
			var myTask = _myTaskRepository.Get(input.TaskId);
			if (input.State.HasValue)
			{
				myTask.State = input.State.Value;
			}
			if (input.AssignedPersonId.HasValue)
			{
				myTask.AssignedPerson = _myPersonRepository.Load(input.AssignedPersonId.Value);
			}
			if (!String.IsNullOrEmpty(input.Decription))
			{
				myTask.Description = input.Decription;
			}
			//我们都不需要调用Update方法
			//因为应用服务层的方法默认开启了工作单元模式（Unit of Work）
			//ABP框架会工作单元完成时自动保存对实体的所有更改，除非有异常抛出。有异常时会自动回滚，因为工作单元默认开启数据库事务。
		}

		public string Test()
		{
			return "Api Test Success!";
		}
	}
}

