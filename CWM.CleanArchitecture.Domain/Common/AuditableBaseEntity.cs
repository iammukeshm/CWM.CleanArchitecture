using System;
using System.Collections.Generic;
using System.Text;

namespace CWM.CleanArchitecture.Domain.Common
{
    public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; protected set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
