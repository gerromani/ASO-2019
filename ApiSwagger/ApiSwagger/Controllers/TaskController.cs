using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using TaskEntity = Repositories.Entities.Task;

namespace ApiSwagger.Controllers
{
    /// <summary>
    /// This class will manage all the task asociated to a person
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : BaseController<TaskEntity>
    {

        public TaskController(ITaskService taskService) : base(taskService)
        {
        }
        
    }
}