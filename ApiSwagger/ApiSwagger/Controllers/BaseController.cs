using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Entities;
using Services.Interfaces;
using Task = System.Threading.Tasks.Task;

namespace ApiSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseEntity
    {
        protected IService<T> service;

        public BaseController(IService<T> service)
        {
            this.service = service;
        }

        [HttpGet("list")]
        public virtual async Task<IEnumerable<T>> Get()
        {
            return this.service.GetAll();
        }

        [HttpGet("get/{id}")]
        public virtual async Task<T> Get(Guid id)
        {
            return this.service.GetById(id);
        }

        [HttpDelete("delete/{id}")]
        public virtual async Task Delete(Guid id)
        {
            this.service.Delete(id);
        }

        [HttpPost("update")]
        public virtual async Task Update([FromBody]T entity)
        {
            this.service.Update(entity);
        }

        [HttpPut("add")]
        public virtual async Task Insert([FromBody]T entity)
        {
            this.service.Create(entity);
        }
    }
}