using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MagnoliaEntitiy
{
	public class MagnoliaEntity : FullAuditedEntity
	{

		public virtual int Number { get; set; }
		public virtual string Intro { get; set; }
		public virtual List<string> Tags { get; set; }

	}
}
