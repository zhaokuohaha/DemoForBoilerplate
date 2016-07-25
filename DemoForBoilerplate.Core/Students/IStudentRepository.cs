using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.Students
{
	public interface IStudentRepository: IRepository<Student,int>
	{
		List<Student> GetAllStudent(int num);
	}
}
