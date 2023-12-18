using $safeprojectname$.Core;
using Microsoft.OpenApi.Models;
using SqlSugar;

namespace $safeprojectname$
{
    /// <summary>
    /// ����:$username$
    /// ʱ��:$time$
    /// ������:$machinename$
    /// ��Ŀ��:$projectname$
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //ע��Swagger������������һ���Ͷ��Swagger �ĵ�
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1", 
                    Title = "$projectname$ API�ĵ�",
                    Description = "by ����,tel:15250790091",
                    TermsOfService = new Uri("https://github.com/CalacalaBoom"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://github.com/CalacalaBoom")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://github.com/CalacalaBoom")
                    }
                });
            });
            //ע��ִ�
            builder.Services.AddScoped(typeof(Repository<>));
            //ע�������ģ�AOP������Ի�ȡIOC����������ֳɿ�ܱ���Furion���Բ�д��һ��
            builder.Services.AddHttpContextAccessor();
            //ע��SqlSugar
            builder.Services.AddSingleton<ISqlSugarClient>(s =>
            {
                SqlSugarScope sqlSugar = new SqlSugarScope(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.Sqlite,
                    ConnectionString = $"DataSource=./test.db",
                    IsAutoCloseConnection = true,
                },
               db =>
               {
                   //ÿ�������Ķ���ִ��

                   //��ȡIOC����Ҫ����һ��������
                   //vra log=s.GetService<Log>()

                   //��ȡIOC����Ҫ����һ��������
                   //var appServive = s.GetService<IHttpContextAccessor>();
                   //var log= appServive?.HttpContext?.RequestServices.GetService<Log>();

                   db.Aop.OnLogExecuting = (sql, pars) =>
                   {
                       Console.WriteLine(sql);//���sql,�鿴ִ��sql ������Ӱ��
                   };
               });
                return sqlSugar;
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.RoutePrefix = "";
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");

                });
            //}

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
