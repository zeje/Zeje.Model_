//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zeje.POCO_.Sys_
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysOperation
    {
        public SysOperation()
        {
            this.SysAuthority = new HashSet<SysAuthority>();
        }
    
        public long id { get; set; }
        public string key_ { get; set; }
        public string name { get; set; }
        public string remark { get; set; }
        public string icon { get; set; }
        public Nullable<int> sort { get; set; }
        public string addPerson { get; set; }
        public System.DateTime addTime { get; set; }
        public string updatePerson { get; set; }
        public System.DateTime updateTime { get; set; }
        public string deletePerson { get; set; }
        public Nullable<System.DateTime> deleteTime { get; set; }
    
        public virtual ICollection<SysAuthority> SysAuthority { get; set; }
    }
}
