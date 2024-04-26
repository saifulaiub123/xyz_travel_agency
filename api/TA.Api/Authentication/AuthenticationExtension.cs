﻿using System.IdentityModel.Tokens.Jwt;
using System.Text;
using TA.Application.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using TA.Domain.Constant;
using TA.Domain.DBModel;
using TA.Infrastructure.DBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace TA.Api.Authentication
{
    public static class AuthenticationExtension
    {
        public static IServiceCollection TokenAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection(ConfigOptions.JWT).Get<JWTSettings>();
            services.AddIdentity<ApplicationUser, Role>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 4;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;

                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 0;
            });

            services.AddAuthentication(option =>
                {
                    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(option =>
                {
                    option.SaveToken = true;
                    option.RequireHttpsMetadata = false;
                    option.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateAudience = true,
                        ValidateIssuer = true,
                        ValidAudience = jwtSettings.ValidAudience,
                        ValidIssuer = jwtSettings.ValidIssuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret)),

                        RequireExpirationTime = false,
                        ValidateIssuerSigningKey = false,
                        RequireSignedTokens = false,
                        SignatureValidator = delegate (string token, TokenValidationParameters parameters)
                        {
                            var jwt = new JwtSecurityToken(token);
                            return jwt;
                        },
                        ValidateLifetime = true
                    };
                });

                //services.AddIdentity<ApplicationUser, Role>(options =>
                //{
                //    options.Password.RequiredLength = 4;
                //    options.Password.RequireDigit = false;
                //    options.Password.RequireUppercase = false;

                //    options.Password.RequireLowercase = false;
                //    options.Password.RequireNonAlphanumeric = false;
                //    options.Password.RequiredUniqueChars = 0;
                //})
                //.AddEntityFrameworkStores<ApplicationDbContext>()
                //.AddDefaultTokenProviders();
            return services;
        }
    }
}
