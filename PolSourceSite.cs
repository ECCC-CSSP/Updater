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
    
    public partial class PolSourceSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolSourceSite()
        {
            this.PolSourceObservations = new HashSet<PolSourceObservation>();
        }
    
        public int PolSourceSiteID { get; set; }
        public int PolSourceSiteTVItemID { get; set; }
        public string Temp_Locator_CanDelete { get; set; }
        public Nullable<int> Oldsiteid { get; set; }
        public Nullable<int> Site { get; set; }
        public Nullable<int> SiteID { get; set; }
        public bool IsPointSource { get; set; }
        public Nullable<int> InactiveReason { get; set; }
        public Nullable<int> CivicAddressTVItemID { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceObservation> PolSourceObservations { get; set; }
        public virtual TVItem TVItem { get; set; }
    }
}
