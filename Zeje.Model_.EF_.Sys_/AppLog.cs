//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zeje.Model_.EF_.Sys_
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppLog
    {
        public int id { get; set; }
        public string ip { get; set; }
        public Nullable<int> appId { get; set; }
        public System.DateTime logDate { get; set; }
        public string thread { get; set; }
        public string logLevel { get; set; }
        public string logger { get; set; }
        public string message { get; set; }
        public string exception { get; set; }
    }
}
