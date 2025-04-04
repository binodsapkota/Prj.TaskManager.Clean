
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Core.Entities
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isCompleted { get; set; }
    }
}
