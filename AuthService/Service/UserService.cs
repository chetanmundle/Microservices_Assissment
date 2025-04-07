using App.Common.Constants;
using App.Common.Models;
using AuthService.Data;
using AuthService.Entities;
using AuthService.Model;
using AuthService.Model.validator;
using AuthService.Service.IService;
using AuthService.Utility;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Service
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _appDbcontext;
        private readonly IJwtService _jwtService;

        public UserService(AppDbContext appDbcontext, IJwtService jwtService )
        {
            _appDbcontext = appDbcontext;  
            _jwtService = jwtService;   
        }

        public async Task<AppResponse<LoginResDto>> Login(LoginReq req)
        {
            try
            {
                var user = await _appDbcontext.Users
                    .AsNoTracking()
                    .FirstOrDefaultAsync(u => u.Email == req.Email && u.Password == req.Password);

                if (user == null) return AppResponse.Fail<LoginResDto>(null, "Invalid Email or Password", HttpStatusCodes.NotFound);

                string Token = _jwtService.Authenticate(user.UserId, user.Name, user.Email, user.Role);
                var userDto = user.Adapt<UserDto>();

                var LoginRes = new LoginResDto
                {
                    Token = Token,
                    user = userDto,
                };
                return AppResponse.Success(LoginRes);

            }
            catch (Exception ex)
            {
                return AppResponse.Fail<LoginResDto>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse> Register(UserDto userDto)
        {
            try
            {
                var validator = new UserDtoValidotor();
                var validate = validator.Validate(userDto);

                if (!validate.IsValid)
                {
                    var errorMessage = validate.Errors[0].ErrorMessage;
                    return AppResponse.Response(false, errorMessage, HttpStatusCodes.BadRequest);
                }
                var isExist = await _appDbcontext.Users.AnyAsync(x => x.Email.ToLower() == userDto.Email.ToLower());
                if (isExist) return AppResponse.Response(false, "User with this Email is already Exist", HttpStatusCodes.Conflict);

                var user = userDto.Adapt<User>();
                await _appDbcontext.Users.AddAsync(user);

                await _appDbcontext.SaveChangesAsync();
                return AppResponse.Response(true, "User Registered Successfully", HttpStatusCodes.Created);
                
            }catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse<UserDto>> BookAndGetAvailablePartenerAsync()
        {
            try
            {
                var availablePartner = await _appDbcontext.Users
                    .FirstOrDefaultAsync(u => u.Role == SD.DeliveryPartnerRole &&
                                                u.IsAvailble == true && u.IsDeleted == false && u.IsActive == true);

                if (availablePartner == null) 
                    return AppResponse.Fail<UserDto>(null, "No Delivery Partner Available", HttpStatusCodes.NotFound);

                availablePartner.IsAvailble = false;
                await _appDbcontext.SaveChangesAsync();

                var userDto = availablePartner.Adapt<UserDto>();
                return AppResponse.Success(userDto);
            }
            catch (Exception ex)
            {
                return AppResponse.Fail<UserDto>(null, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }

        public async Task<AppResponse> ChangeAvailabilityStatusAsync(ChangeAvailabilityReqDto req)
        {
            try
            {
                var user = await _appDbcontext.Users
                    .FirstOrDefaultAsync(u => u.UserId == req.UserId && u.Role == SD.DeliveryPartnerRole);

                if(user is null)
                    return AppResponse.Response(false, "Not found", HttpStatusCodes.NotFound);

                user.IsAvailble = req.IsAvailable;

                await _appDbcontext.SaveChangesAsync();
                return AppResponse.Response(true, "User Availability Change Successfully", HttpStatusCodes.OK);
            }
            catch (Exception ex)
            {
                return AppResponse.Response(false, ex.Message, HttpStatusCodes.InternalServerError);
            }
        }
    }
}
