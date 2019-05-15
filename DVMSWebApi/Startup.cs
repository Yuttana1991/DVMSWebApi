using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DVMSWebApi.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OData.Edm;

namespace DVMSWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<DVMSContext>(opt => opt.UseInMemoryDatabase("BookLists"));
            services.AddDbContext<DVMSContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddOData();
            services.AddODataQueryFilter();

            

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvc();
            app.UseMvc(b =>
            {
                //b.Select().Expand().Filter().OrderBy().MaxTop(100).Count();
                b.MapODataServiceRoute("odata", "odata", GetEdmModel(app.ApplicationServices));
            });
        
        }
        private static IEdmModel GetEdmModel(IServiceProvider serviceProvider)
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder(serviceProvider);

            //builder.EntitySet<visitorCarType>("visitorCarType")
            //    .EntityType
            //    .Filter()
            //    .Count()
            //    .Expand()
            //    .OrderBy()
            //    .Page()
            //    .Select();


            builder.EntitySet<vtran>("Vtrans")
              .EntityType
              .Filter()
              .Count()
              .Expand()
              .OrderBy()
              .Page()
              .Select();
            //EntitySetConfiguration<ContactType> contactType = builder.EntitySet<ContactType>("ContactType");
            //var actionY = contactType.EntityType.Action("ChangePersonStatus");
            //actionY.Parameter<string>("Level");
            //actionY.Returns<bool>();

            //var changePersonStatusAction = contactType.EntityType.Collection.Action("ChangePersonStatus");
            //changePersonStatusAction.Parameter<string>("Level");
            //changePersonStatusAction.Returns<bool>();

            //EntitySetConfiguration<visitorCarType> persons = builder.EntitySet<visitorCarType>("visitorCarType");
            //FunctionConfiguration myFirstFunction = persons.EntityType.Collection.Function("MyFirstFunction");
            //myFirstFunction.ReturnsCollectionFromEntitySet<visitorCarType>("visitorCarType");

            EntitySetConfiguration<vtran> vtran = builder.EntitySet<vtran>("vtran");
            FunctionConfiguration myFirstFunctiontrans = vtran.EntityType.Collection.Function("MyFirstFunctiontrans");
            myFirstFunctiontrans.ReturnsCollectionFromEntitySet<vtran>("vtran");



            //EntitySetConfiguration<EntityWithEnum> entitesWithEnum = builder.EntitySet<EntityWithEnum>("EntityWithEnum");
            //FunctionConfiguration functionEntitesWithEnum = entitesWithEnum.EntityType.Collection.Function("PersonSearchPerPhoneType");
            //functionEntitesWithEnum.Parameter<PhoneNumberTypeEnum>("PhoneNumberTypeEnum");
            //functionEntitesWithEnum.ReturnsCollectionFromEntitySet<EntityWithEnum>("EntityWithEnum");

            return builder.GetEdmModel();
        }
    }
}
