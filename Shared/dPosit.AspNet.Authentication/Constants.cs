namespace dPosit.AspNet.Authentication;

public static class Constants
{
    public static class ClaimType
    {
        public const string USERNAME = "username";
        public const string EMAIL = "email";
    }

    public static class TokenType
    {
        public const string ACCESS_TOKEN_TYPE = "accessToken";
        public const string REFRESH_TOKEN_TYPE = "refreshToken";
    }
}
