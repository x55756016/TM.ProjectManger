﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TM.ProjectManager.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tmpmEntities : DbContext
    {
        public tmpmEntities()
            : base("name=tmpmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tm_pm_company> tm_pm_company { get; set; }
        public DbSet<tm_pm_department> tm_pm_department { get; set; }
        public DbSet<tm_pm_dotask> tm_pm_dotask { get; set; }
        public DbSet<tm_pm_itemreport> tm_pm_itemreport { get; set; }
        public DbSet<tm_pm_post> tm_pm_post { get; set; }
        public DbSet<tm_pm_project> tm_pm_project { get; set; }
        public DbSet<tm_pm_task> tm_pm_task { get; set; }
        public DbSet<tm_pm_user> tm_pm_user { get; set; }
    }
}
