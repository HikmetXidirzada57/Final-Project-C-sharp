using Business.Abstract;
using Business.Concrete;
using Core.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
  .AddJsonOptions(opt => opt.JsonSerializerOptions.WriteIndented = true);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LexiconDBContext>();
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<LexiconDBContext>();
builder.Services.AddScoped<IProductDal, EFProductDal>();
builder.Services.AddScoped<IProductManager, ProductManager>();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<ICategoryManager, CategoryManager>();

builder.Services.AddScoped<ITagDal, EFTagDal>();
builder.Services.AddScoped<ITagManager, TagManager>();
builder.Services.AddScoped<ITagToProductDal, EFTagToProduct>();
builder.Services.AddScoped<ITagToProductManager, TagToProductManager>();
builder.Services.AddScoped<ISpecificationDal, EFSpecificationDal>();
builder.Services.AddScoped<ISpecificationService, SpecificationManager>();
builder.Services.AddScoped<IProductSpecificationDal, EFProductSpecificationDal>();
builder.Services.AddScoped<IProductSpecificationService,ProductSpecificationManager>();
builder.Services.AddScoped<ITeamMemberDal, EFTeamMemberDal>();
builder.Services.AddScoped<ITeamMemeberService, TeamMemberManager>();
builder.Services.AddScoped<ICommentDal, EFCommentDal>();
builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ISocialPlatformDal, EFSocialPlatformDal>();
builder.Services.AddScoped<ISocialPlatformService, SocialPlatformManager>();
builder.Services.AddScoped<ITeamMemToPlatformDal, EFTeamMemToPlatformDal>();
builder.Services.AddScoped<ITeamSocialPlatformService, TeamMemToPlatformManager>();
builder.Services.AddScoped<IBlogDal, EFBlogDal>();
builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogCategoryDal, EFBlogCategoryDal>();
builder.Services.AddScoped<IBlogCategoryService, BlogCategoryManager>();






builder.Services.AddScoped<TokenManager>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "_myAllowOrigins",
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithMethods("PUT", "DELETE", "GET");
        }
     );
});



builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.SaveToken = true;
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.UseCors("_myAllowOrigins");

app.MapControllers();

app.Run();
