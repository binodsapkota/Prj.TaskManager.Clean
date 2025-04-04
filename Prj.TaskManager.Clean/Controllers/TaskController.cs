using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Services;
using TaskManager.Core.Entities;

namespace Prj.TaskManager.Clean.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskService _taskService;
        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _taskService.GetTasksAsync();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskItem model)
        {
            if (ModelState.IsValid)
            {
               var task=await _taskService.AddTaskAsync(model);
            }
            return View(model);
        }

    }
}
