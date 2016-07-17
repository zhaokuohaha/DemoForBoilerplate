using Abp.Application.Services;
using DemoForBoilerplate.MyPeople.Dtos;
using System.Threading.Tasks;

namespace DemoForBoilerplate.MyPeople
{
	public interface IMyPersonAppService : IApplicationService
	{
		Task<CetAllPeopleOutput> GetAllPeople();
	}
}
