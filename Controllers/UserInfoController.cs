using ApiLibrary.Responses;
using Microsoft.AspNetCore.Mvc;
using ThirdEndPoint.Models;
using ThirdEndPoint.Services;

namespace ThirdEndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : ControllerBase
    {
        private readonly UserInfoService _userService;

        public UserInfoController(UserInfoService userService)
        {
            _userService = userService;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponse<bool>>> Delete(Guid id)
        {
            var response = await _userService.DeleteAsync(id);
            if (response.Data is false)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<UserRegisterInfo>>> Insert(UserRegisterInfo newUser)
        {
            // return Ok(await _userService.InsertAsync(newUser));
            var response = await _userService.InsertAsync(newUser);
            return response;
        }
    }
}