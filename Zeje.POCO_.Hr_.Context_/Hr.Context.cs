﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HrEntities : DbContext
    {
        public HrEntities()
            : base("name=HrEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HrOrg> HrOrg { get; set; }
        public virtual DbSet<HrOrgHStaff> HrOrgHStaff { get; set; }
        public virtual DbSet<HrPosition> HrPosition { get; set; }
        public virtual DbSet<HrPositionLevel> HrPositionLevel { get; set; }
        public virtual DbSet<HrStaff> HrStaff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
