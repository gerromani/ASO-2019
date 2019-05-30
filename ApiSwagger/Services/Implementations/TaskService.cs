﻿using Repositories.Entities;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
    public class TaskService : Service<Task>, ITaskService
    {
        public TaskService(ITaskRepository taskRepository) : 
            base(taskRepository)
        {

        }
    }
}
