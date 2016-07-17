﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyPeople
{
	public class MyPerson : Entity, IHasCreationTime
	{
		public string Name { get; set; }
		public DateTime CreationTime { get; set; }
	}
}
