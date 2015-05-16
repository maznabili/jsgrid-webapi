﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JSGridWebAPISample.Controllers {

    public class DataController: ApiController {

        // GET api/values
        public IEnumerable<object> Get() {
            return new[] { 
                new { Name = "value1" }, 
                new { Name = "value2" }
            };
        }

        // GET api/values/5
        public object Get(int id) {
            return new { Name = "value1" };
        }

        // POST api/values
        public void Post([FromBody]string value) {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE api/values/5
        public void Delete(int id) {
        }

    }

}