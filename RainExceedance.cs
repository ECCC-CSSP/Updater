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
    
    public partial class RainExceedance
    {
        public int RainExceedanceID { get; set; }
        public bool YearRound { get; set; }
        public Nullable<System.DateTime> StartDate_Local { get; set; }
        public Nullable<System.DateTime> EndDate_Local { get; set; }
        public Nullable<double> RainMaximum_mm { get; set; }
        public Nullable<double> RainExtreme_mm { get; set; }
        public int DaysPriorToStart { get; set; }
        public bool RepeatEveryYear { get; set; }
        public string ProvinceTVItemIDs { get; set; }
        public string SubsectorTVItemIDs { get; set; }
        public string ClimateSiteTVItemIDs { get; set; }
        public string EmailDistributionListIDs { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    }
}
