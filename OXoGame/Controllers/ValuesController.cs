//-----------------------------------------------------------------------
// <copyright file="ValuesController.cs" company="DevBatch Ltd">
// Copyright (c) DevBatch Ltd. All rights reserved.
// </copyright>
// <summary>ValuesController class.</summary>
//-----------------------------------------------------------------------
using System.Collections.Generic;
using System.Web.Http;
using Oxo.Entities.Modals;
using Oxo.Services.Services;

namespace OXoGame.Controllers
{
    /// <summary>
    /// ValuesController class.
    /// </summary>
    /// <seealso cref="ValuesController" />
    public class ValuesController : ApiController
    {
        private DataLoaderService dataLoaderService;
        public ValuesController()
        {
            this.dataLoaderService = new DataLoaderService();
        }
        // GET api/values
        public IEnumerable<Record> Get()
        {
            DataLoaderService a = new DataLoaderService();
           return this.dataLoaderService.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
           
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
