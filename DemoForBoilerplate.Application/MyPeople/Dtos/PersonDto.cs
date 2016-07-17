using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyPeople.Dtos
{
	[AutoMapFrom(typeof(MyPerson))]
	public class PersonDto
	{
		public string Name { get; set; }
	}
}
