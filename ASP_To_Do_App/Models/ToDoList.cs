using System.ComponentModel.DataAnnotations;

namespace ASP_To_Do_App.Models
{
    public class ToDoList
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public Boolean IsComplete { get; set; }


    }
}
