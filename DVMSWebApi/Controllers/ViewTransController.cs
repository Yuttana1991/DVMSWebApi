using DVMSWebApi.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DVMSWebApi.Controllers
{ 
        // This is removed so that the demo service works in the browser without authorization. Not recommended
        //[Authorize(Policy = "ODataServiceApiPolicy", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [ODataRoutePrefix("View_TransAuto")]
        public class ViewTransController: ODataController
        {
       
            private DVMSContext _db;

            public ViewTransController(DVMSContext DVMSContext)
            {
                _db = DVMSContext;
            }

            [ODataRoute]
            [EnableQuery(PageSize = 20, AllowedQueryOptions = AllowedQueryOptions.All)]
            public IActionResult Get()
            {
                return Ok(_db.View_TransAuto.AsQueryable());
            }

            [ODataRoute("({key})")]
            [EnableQuery(PageSize = 20, AllowedQueryOptions = AllowedQueryOptions.All)]
            public IActionResult Get([FromODataUri] int key)
            {
                return Ok(_db.View_TransAuto.Find(key));
            }

            [EnableQuery(PageSize = 20, AllowedQueryOptions = AllowedQueryOptions.All)]
            [ODataRoute("Default.MyFirstFunction")]
            [HttpGet]
            public IActionResult MyFirstFunction()
            {
                return Ok(_db.View_TransAuto.Where(t => t.visitorcarbrand_Name.StartsWith("A")));
            }
        }
}
