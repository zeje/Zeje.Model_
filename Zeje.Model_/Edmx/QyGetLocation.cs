//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zeje.Model_.Edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class QyGetLocation
    {
        public int ID { get; set; }
        public string ToUserName { get; set; }
        public string FromUserName { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string MsgType { get; set; }
        public Nullable<decimal> Location_X { get; set; }
        public Nullable<decimal> Location_Y { get; set; }
        public Nullable<int> Scale { get; set; }
        public string Label { get; set; }
        public Nullable<long> MsgId { get; set; }
        public int AgentID { get; set; }
        public System.DateTime AddTime { get; set; }
    }
}
