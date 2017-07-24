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
    
    public partial class MWQMSubsector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MWQMSubsector()
        {
            this.MWQMSubsectorLanguages = new HashSet<MWQMSubsectorLanguage>();
        }
    
        public int MWQMSubsectorID { get; set; }
        public int MWQMSubsectorTVItemID { get; set; }
        public string SubsectorHistoricKey { get; set; }
        public string TideLocationSIDText { get; set; }
        public Nullable<double> RainDay0Limit { get; set; }
        public Nullable<double> RainDay1Limit { get; set; }
        public Nullable<double> RainDay2Limit { get; set; }
        public Nullable<double> RainDay3Limit { get; set; }
        public Nullable<double> RainDay4Limit { get; set; }
        public Nullable<double> RainDay5Limit { get; set; }
        public Nullable<double> RainDay6Limit { get; set; }
        public Nullable<double> RainDay7Limit { get; set; }
        public Nullable<double> RainDay8Limit { get; set; }
        public Nullable<double> RainDay9Limit { get; set; }
        public Nullable<double> RainDay10Limit { get; set; }
        public Nullable<System.DateTime> IncludeRainStartDate { get; set; }
        public Nullable<System.DateTime> IncludeRainEndDate { get; set; }
        public Nullable<int> IncludeRainRunCount { get; set; }
        public Nullable<bool> IncludeRainSelectFullYear { get; set; }
        public Nullable<System.DateTime> NoRainStartDate { get; set; }
        public Nullable<System.DateTime> NoRainEndDate { get; set; }
        public Nullable<int> NoRainRunCount { get; set; }
        public Nullable<bool> NoRainSelectFullYear { get; set; }
        public Nullable<System.DateTime> OnlyRainStartDate { get; set; }
        public Nullable<System.DateTime> OnlyRainEndDate { get; set; }
        public Nullable<int> OnlyRainRunCount { get; set; }
        public Nullable<bool> OnlyRainSelectFullYear { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMSubsectorLanguage> MWQMSubsectorLanguages { get; set; }
        public virtual TVItem TVItem { get; set; }
    }
}
