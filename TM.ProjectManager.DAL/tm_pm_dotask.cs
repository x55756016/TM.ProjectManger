//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tm_pm_dotask
    {
        public string TASKID { get; set; }
        public string TITLE { get; set; }
        public string MODELCODE { get; set; }
        public string MODELID { get; set; }
        public Nullable<System.DateTime> ARRIVEDATE { get; set; }
        public Nullable<System.DateTime> EXPIREDTIME { get; set; }
        public string ISCLOSED { get; set; }
        public string CLOSEDTIME { get; set; }
        public string OWENRID { get; set; }
        public string OWNERDEPARTMENTID { get; set; }
        public string OWNERCOMPANYID { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEUSER { get; set; }
        public Nullable<System.DateTime> EDITTIME { get; set; }
        public string EDITUSER { get; set; }
        public string OWNERPOSTID { get; set; }
    }
}
