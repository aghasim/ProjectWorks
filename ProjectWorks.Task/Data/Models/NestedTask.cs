using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectWorks.Data.Abstractions;

namespace ProjectWorks.Task.Data.Models
{
    [Table("ProjectWorks_NestedTask")]
    public class NestedTask : EntityBase
    {
        #region Properties

        // Название задачи
        [Required]
        [DataType(DataType.Text)]
        public string TaskName { get; set; }

        // ответственный, если это юсер из А2, тогда надо будет int
        [Required]
        public int ResponsibleId { get; set; }

        // ответственный  
        [DataType(DataType.Text)]
        public string ResponsibleName { get; set; }

        // дата начало
        [DataType(DataType.DateTime)]
        public DateTime TimeStart { get; set; }

        // Время выполнения
        [DataType(DataType.DateTime)]
        public DateTime TimeExecution { get; set; }

        // Дата завершение
        [DataType(DataType.DateTime)]
        public DateTime TimeCompletion { get; set; }

        // Сколько денег на выполнение
        [Required]
        [Range(0, double.MaxValue)]
        public double ManyForTask { get; set; }

        [Required]
        [ForeignKey(nameof(MainTask))]
        public Guid MainTaskId { get; set; }

        public virtual MainTask MainTask { get; set; } 

        #endregion
    }
}
