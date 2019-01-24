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



### Postman Collection
* https://www.getpostman.com/collections/c9ed33e885ea7e6a6c08
