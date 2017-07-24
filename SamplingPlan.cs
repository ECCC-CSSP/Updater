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
    
    public partial class SamplingPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SamplingPlan()
        {
            this.LabSheetDetails = new HashSet<LabSheetDetail>();
            this.LabSheets = new HashSet<LabSheet>();
            this.SamplingPlanSubsectors = new HashSet<SamplingPlanSubsector>();
        }
    
        public int SamplingPlanID { get; set; }
        public string SamplingPlanName { get; set; }
        public string ForGroupName { get; set; }
        public int SampleType { get; set; }
        public int SamplingPlanType { get; set; }
        public int LabSheetType { get; set; }
        public int ProvinceTVItemID { get; set; }
        public int CreatorTVItemID { get; set; }
        public int Year { get; set; }
        public string AccessCode { get; set; }
        public double DailyDuplicatePrecisionCriteria { get; set; }
        public double IntertechDuplicatePrecisionCriteria { get; set; }
        public bool IncludeLaboratoryQAQC { get; set; }
        public string ApprovalCode { get; set; }
        public Nullable<int> SamplingPlanFileTVItemID { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabSheetDetail> LabSheetDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabSheet> LabSheets { get; set; }
        public virtual TVItem TVItem { get; set; }
        public virtual TVItem TVItem1 { get; set; }
        public virtual TVItem TVItem2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SamplingPlanSubsector> SamplingPlanSubsectors { get; set; }
    }
}
