using AutoMapper;
using IdentityServerAspNetIdentity.Contracts;
using IdentityServerAspNetIdentity.Dto;
using IdentityServerAspNetIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace IdentityServerAspNetIdentity.Implements
{
    public class AuthenticationService: IAuthenticationService
    {
        //private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        public AuthenticationService(IMapper mapper,
        UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
        _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<ApplicationUser>(userForRegistration);
            var result = await _userManager.CreateAsync(user,
            userForRegistration.Password);
            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            return result;
        }
    }
}
