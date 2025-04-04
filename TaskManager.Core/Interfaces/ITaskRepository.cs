using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Entities;

namespace TaskManager.Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task<TaskItem> GetAsync(int id);
        Task<TaskItem> AddAsync(TaskItem item);
        Task<TaskItem> UpdateAsync(TaskItem item);
        Task<bool> DeleteAsync(int id);
    }
}
