//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zeje.POCO_.Hr_
{
    using System;
    using System.Collections.Generic;
    
    public partial class HrPosition
    {
        public HrPosition()
        {
            this.HrStaff = new HashSet<HrStaff>();
        }
    
        public int id { get; set; }
        public string levelCode { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> sortId { get; set; }
        public string addPerson { get; set; }
        public System.DateTime addTime { get; set; }
        public string updatePerson { get; set; }
        public System.DateTime updateTime { get; set; }
        public string deletePerson { get; set; }
        public Nullable<System.DateTime> deleteTime { get; set; }
    
        public virtual HrPositionLevel HrPositionLevel { get; set; }
        public virtual ICollection<HrStaff> HrStaff { get; set; }
    }
}
