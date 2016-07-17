using Abp.Domain.Repositories;
namespace DemoForBoilerplate.MyPeople
{
	public interface IMyPersonRepository : IRepository<MyPerson, int>
	{

	}
}
