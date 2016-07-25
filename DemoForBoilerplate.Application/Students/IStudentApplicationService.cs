using Abp.Application.Services;
using DemoForBoilerplate.Students.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.Students
{
	public interface IStudentApplicationService : IApplicationService
	{
		int getClassNum(int stuentsInClass);
		AllClassInfo initClasses(int classNum);
	}
}
