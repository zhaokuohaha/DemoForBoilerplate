using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoForBoilerplate.MyPeople.Dtos;
using Abp.Domain.Repositories;
using Abp.AutoMapper;

namespace DemoForBoilerplate.MyPeople
{
	public class MyPersonAppService : IMyPersonAppService
	{
		private readonly IRepository<MyPerson> _personRepository;
		public MyPersonAppService(IRepository<MyPerson> personRepository)
		{
			_personRepository = personRepository;
		}
		public async Task<CetAllPeopleOutput> GetAllPeople()
		{
			var people = await _personRepository.GetAllListAsync();
			return new CetAllPeopleOutput
			{
				People = people.MapTo<List<PersonDto>>()
			};
		}
	}
}
