using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime? CreationDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModificationDate { get; set; }

        public Guid? ModifiedBy { get; set; }

        public DateTime? DeleteDate { get; set; }

        public Guid? DeletedBy { get; set; }

        public bool IsDeleted { get; set; }

    }
}
