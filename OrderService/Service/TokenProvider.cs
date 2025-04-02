using OrderService.Service.IService;
using OrderService.Utility;

namespace OrderService.Service
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }


        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Response.Cookies.Delete(SD.TokenCookie);
        }

        //public string? GetToken()
        //{
        //    string? token = null;
        //    bool? hasToken = _contextAccessor.HttpContext?.Request.Cookies.TryGetValue(SD.TokenCookie, out token);
        //    return hasToken is true ? token : null;
        //}

        public string? GetToken()
        {
            // Try to get the token from cookies first
            string? token = null;
            bool? hasToken = _contextAccessor.HttpContext?.Request.Cookies.TryGetValue(SD.TokenCookie, out token);

            if (hasToken == true)
            {
                return token;
            }

            // If token is not found in cookies, check the Authorization header
            var authHeader = _contextAccessor.HttpContext?.Request.Headers["Authorization"].ToString();
            if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer "))
            {
                return authHeader.Replace("Bearer ", "").Trim();
            }

            return null;
        }


        public void SetToken(string token)
        {
           _contextAccessor.HttpContext?.Response.Cookies.Append(SD.TokenCookie, token);
        }
    }
}
