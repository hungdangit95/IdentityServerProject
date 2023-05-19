using IdentityServerAspNetIdentity.Dto;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace IdentityServerAspNetIdentity.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
    }
}
