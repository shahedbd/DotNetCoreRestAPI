namespace DotNetCoreRestAPI.LIB
{
    public interface IAuth
    {
        string GenerateJSONWebToken(int ExpireIn);
        string GenerateRefreshToken();
    }
}
