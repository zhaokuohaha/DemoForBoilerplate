using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.Students.Dtos
{
	public class AllClassInfo
	{
		public List<List<Student>> allClass { get; set; }
		public AllClassInfo(int ClassNum)
		{
			allClass = new List<List<Student>>();
			for(int i=0; i<ClassNum; i++)
			{
				allClass.Add(new List<Student>());
			}
		}
	}
}
