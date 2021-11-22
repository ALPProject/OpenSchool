using OpenSchool.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenSchool.Abstract
{
    public abstract class AuditTable : IAuditTable
    {
        public DateTime CreateDate { get; set; }
        [MaxLength(256)]
        public string CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        [MaxLength(256)]
        public string Updateby { get; set; }
        [MaxLength(500)]
        public string MetaKeyWork { get; set; }
        [MaxLength(500)]
        public string Discription { get; set; }
        public bool Actives { get; set; }
        [MaxLength(50)]
        public string Statust { get; set; }
    }
}
