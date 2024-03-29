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
    
    public partial class PolSourceObservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PolSourceObservation()
        {
            this.PolSourceObservationIssues = new HashSet<PolSourceObservationIssue>();
        }
    
        public int PolSourceObservationID { get; set; }
        public int PolSourceSiteID { get; set; }
        public System.DateTime ObservationDate_Local { get; set; }
        public int ContactTVItemID { get; set; }
        public bool DesktopReviewed { get; set; }
        public string Observation_ToBeDeleted { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceObservationIssue> PolSourceObservationIssues { get; set; }
        public virtual PolSourceSite PolSourceSite { get; set; }
        public virtual TVItem TVItem { get; set; }
    }
}
