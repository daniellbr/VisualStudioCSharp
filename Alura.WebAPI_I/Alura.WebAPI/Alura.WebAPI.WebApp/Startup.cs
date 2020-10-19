﻿using Alura.ListaLeitura.Persistencia;
using Alura.ListaLeitura.Seguranca;
using Alura.ListaLeitura.Modelos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Alura.WebAPI.WebApp.Formatters;
using Microsoft.IdentityModel.Tokens;
using System;

namespace Alura.ListaLeitura.WebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LeituraContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("ListaLeitura"));
            });

            services.AddDbContext<AuthDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("AuthDB"));
            });

            services.AddIdentity<Usuario, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<AuthDbContext>();

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/Usuario/Login";
            });

            services.AddTransient<IRepository<Livro>, RepositorioBaseEF<Livro>>();

            services.AddMvc(options =>
            {
                options.OutputFormatters.Add(new LivroCsvFormatter()); //sobrecarga no metodo para configurar a opcao para criar uma lista nova de tipo de formatação
            }).AddXmlDataContractSerializerFormatters(); //Alem de Json ele irá entregar XML também

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer"; //Criando as configurações do "Portador" Quem solicita
                options.DefaultChallengeScheme = "JwtBearer"; 
            }).AddJwtBearer("JwtBearer", optins => {
                optins.TokenValidationParameters = new TokenValidationParameters //Para validação do token são necessários os parametros abaixo
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8
                                                                .GetBytes("alura-webapi-authentication-valid")), //chave para validar no Emitente ou o dono da informação
                    ClockSkew = TimeSpan.FromMinutes(5), //tempo para expirar esta chave em caso de não utilização
                    ValidIssuer = "Alura.WebApp", //Aplicação que pode acessar a "aplicação"
                    ValidAudience = "Postaman",
                };
            });
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
