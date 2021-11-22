using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSchool.Abstract
{
    public interface IAuditTable
    {
        DateTime CreateDate { set; get; }
        string CreateBy {set;get;}
        DateTime? UpdateTime { set; get; }
        string Updateby { set; get; }
        string MetaKeyWork { set; get; }
        string Discription { set; get; }
        bool Actives { set; get; }
        string Statust { set; get; }

    }
}
