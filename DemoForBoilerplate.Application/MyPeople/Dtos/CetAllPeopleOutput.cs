using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyPeople.Dtos
{
	public class CetAllPeopleOutput : IOutputDto
	{
		public List<PersonDto> People { get; set; }
	}
}
