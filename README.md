# .Net Core Rest API
ASP.NET Core Rest API Example

### Enable CORS
```C#
services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
```

### JWT Setup
```C#
{
  "ConnectionStrings": {
    "MSSQLConn": "Server=DEVSTATION\\MSSQLSERVER2014;Database=DevTest;User ID=dev;Password=dev123456;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "Jwt": {
    "Key": "mysuperSecretKey@mydomain.com",
    "issuer": "http://localhost:28005",
    "audience": "http://localhost:28005"
  },
  "AllowedHosts": "*"
}
```

### Postman Collection
* https://www.getpostman.com/collections/c9ed33e885ea7e6a6c08
