using Abp.EntityFramework;
using DemoForBoilerplate.Students;
using System;
using System.Collections.Generic;

namespace DemoForBoilerplate.EntityFramework.Repositories
{
	public class StudentRepository : DemoForBoilerplateRepositoryBase<Student, int>,IStudentRepository
	{
		public StudentRepository(IDbContextProvider<DemoForBoilerplateDbContext> dbContextProvider)
			: base(dbContextProvider)
		{
		}
		public List<Student> GetAllStudent(int num)
		{
			GaussianRNG rand = new GaussianRNG();
			List<Student> st = new List<Student>();
			for (int i = 0; i < num; i++)
			{
				st.Add(new Student(rand));
			}
			return st;
		}
	}
}
