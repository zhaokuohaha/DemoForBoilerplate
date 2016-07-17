using System.Threading.Tasks;
using Abp.Application.Services;
using DemoForBoilerplate.Roles.Dto;

namespace DemoForBoilerplate.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
