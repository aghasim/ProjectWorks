using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectWorks.Data.Abstractions
{
    public abstract class EntityBase
    {
        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        public bool IsDeleted { get; set; }

        #endregion
    }
}