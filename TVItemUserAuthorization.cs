//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Updater
{
    using System;
    using System.Collections.Generic;
    
    public partial class TVItemUserAuthorization
    {
        public int TVItemUserAuthorizationID { get; set; }
        public int ContactTVItemID { get; set; }
        public int TVItemID1 { get; set; }
        public Nullable<int> TVItemID2 { get; set; }
        public Nullable<int> TVItemID3 { get; set; }
        public Nullable<int> TVItemID4 { get; set; }
        public int TVAuth { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual TVItem TVItem { get; set; }
        public virtual TVItem TVItem1 { get; set; }
    }
}
