using DemoForBoilerplate.EntityFramework.Repositories;
using DemoForBoilerplate.Students.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForBoilerplate.Students
{
	public class StudentApplicationService : IStudentApplicationService
	{
		private IStudentRepository _studentResopitory;
		public StudentApplicationService(IStudentRepository studentRepository)
		{
			_studentResopitory = studentRepository;
		}

		public int getClassNum(int stuentsInClass)
		{
			int total = _studentResopitory.GetAll().Count();
			int minResidue= total;
			int classNum = 0;
			for(int i = 0; i < 5; i++)
			{
				if (minResidue > total % (stuentsInClass + i))
				{
					minResidue = total % (stuentsInClass + i);
					classNum = total / (stuentsInClass + i);
				}
			}
			return classNum;
		}

		public void CreateStudent(int num)
		{
			List<Student> res = _studentResopitory.GetAllStudent(num);

			foreach (var item in res)
			{
				_studentResopitory.Insert(item);
			}
		}

		public AllClassInfo initClasses(int classNum)
		{
			AllClassInfo allClass = new AllClassInfo(classNum);
			var res = _studentResopitory.GetAll().OrderBy(s => s.origin).ThenBy(s => s.sex).ThenBy(s => s.score).ToList();
			for(int i = 0; i < res.Count; i++)
			{
				allClass.allClass[i % classNum].Add(res[i]);
			}
			return FixClass(allClass);
		}

		public AllClassInfo FixClass(AllClassInfo allClass)
		{
			return allClass;
		}

	}
}
