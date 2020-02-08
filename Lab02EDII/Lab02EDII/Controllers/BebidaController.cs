﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab02EDII.BTree;
using Lab02EDII.Models;

namespace Lab02EDII.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BebidaController : ControllerBase
    {
        // GET: api/Bebida
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };                  
        }

        // GET: api/Bebida/5
        [HttpGet("{id}", Name = "Get")]
        public Bebida Get(string id)
        {            
            return Data.Instance.myTree.ViewData(Data.Instance.myTree.root, id);
        }

        // POST: api/Bebida
        [HttpPost]
        public void Post([FromBody] Bebida value)
        {
            Data.Instance.myTree.Add(value);
        }

        // PUT: api/Bebida/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
