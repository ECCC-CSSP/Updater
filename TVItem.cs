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
    
    public partial class TVItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TVItem()
        {
            this.Addresses = new HashSet<Address>();
            this.Addresses1 = new HashSet<Address>();
            this.Addresses2 = new HashSet<Address>();
            this.Addresses3 = new HashSet<Address>();
            this.AppTasks = new HashSet<AppTask>();
            this.AppTasks1 = new HashSet<AppTask>();
            this.BoxModels = new HashSet<BoxModel>();
            this.Classifications = new HashSet<Classification>();
            this.ClimateSites = new HashSet<ClimateSite>();
            this.Contacts = new HashSet<Contact>();
            this.DocTemplates = new HashSet<DocTemplate>();
            this.DrogueRuns = new HashSet<DrogueRun>();
            this.EmailDistributionLists = new HashSet<EmailDistributionList>();
            this.Emails = new HashSet<Email>();
            this.HydrometricSites = new HashSet<HydrometricSite>();
            this.Infrastructures = new HashSet<Infrastructure>();
            this.Infrastructures1 = new HashSet<Infrastructure>();
            this.Infrastructures2 = new HashSet<Infrastructure>();
            this.LabSheetDetails = new HashSet<LabSheetDetail>();
            this.LabSheets = new HashSet<LabSheet>();
            this.LabSheets1 = new HashSet<LabSheet>();
            this.LabSheets2 = new HashSet<LabSheet>();
            this.LabSheetTubeMPNDetails = new HashSet<LabSheetTubeMPNDetail>();
            this.MapInfos = new HashSet<MapInfo>();
            this.MikeBoundaryConditions = new HashSet<MikeBoundaryCondition>();
            this.MikeScenarioResults = new HashSet<MikeScenarioResult>();
            this.MikeScenarios = new HashSet<MikeScenario>();
            this.MikeSources = new HashSet<MikeSource>();
            this.MikeSources1 = new HashSet<MikeSource>();
            this.MWQMAnalysisReportParameters = new HashSet<MWQMAnalysisReportParameter>();
            this.MWQMAnalysisReportParameters1 = new HashSet<MWQMAnalysisReportParameter>();
            this.MWQMRuns = new HashSet<MWQMRun>();
            this.MWQMRuns1 = new HashSet<MWQMRun>();
            this.MWQMRuns2 = new HashSet<MWQMRun>();
            this.MWQMSamples = new HashSet<MWQMSample>();
            this.MWQMSamples1 = new HashSet<MWQMSample>();
            this.MWQMSites = new HashSet<MWQMSite>();
            this.MWQMSiteStartEndDates = new HashSet<MWQMSiteStartEndDate>();
            this.MWQMSubsectors = new HashSet<MWQMSubsector>();
            this.PolSourceObservations = new HashSet<PolSourceObservation>();
            this.PolSourceSiteEffects = new HashSet<PolSourceSiteEffect>();
            this.PolSourceSiteEffects1 = new HashSet<PolSourceSiteEffect>();
            this.PolSourceSiteEffects2 = new HashSet<PolSourceSiteEffect>();
            this.PolSourceSites = new HashSet<PolSourceSite>();
            this.PolSourceSites1 = new HashSet<PolSourceSite>();
            this.RainExceedanceClimateSites = new HashSet<RainExceedanceClimateSite>();
            this.RainExceedanceClimateSites1 = new HashSet<RainExceedanceClimateSite>();
            this.RainExceedances = new HashSet<RainExceedance>();
            this.ReportSections = new HashSet<ReportSection>();
            this.SamplingPlans = new HashSet<SamplingPlan>();
            this.SamplingPlans1 = new HashSet<SamplingPlan>();
            this.SamplingPlans2 = new HashSet<SamplingPlan>();
            this.SamplingPlanSubsectors = new HashSet<SamplingPlanSubsector>();
            this.SamplingPlanSubsectorSites = new HashSet<SamplingPlanSubsectorSite>();
            this.Spills = new HashSet<Spill>();
            this.Spills1 = new HashSet<Spill>();
            this.Tels = new HashSet<Tel>();
            this.TideDataValues = new HashSet<TideDataValue>();
            this.TideSites = new HashSet<TideSite>();
            this.TVFiles = new HashSet<TVFile>();
            this.TVItemLanguages = new HashSet<TVItemLanguage>();
            this.TVItemLinks = new HashSet<TVItemLink>();
            this.TVItemLinks1 = new HashSet<TVItemLink>();
            this.TVItems1 = new HashSet<TVItem>();
            this.TVItemStats = new HashSet<TVItemStat>();
            this.TVItemUserAuthorizations = new HashSet<TVItemUserAuthorization>();
            this.TVItemUserAuthorizations1 = new HashSet<TVItemUserAuthorization>();
            this.TVTypeUserAuthorizations = new HashSet<TVTypeUserAuthorization>();
            this.UseOfSites = new HashSet<UseOfSite>();
            this.UseOfSites1 = new HashSet<UseOfSite>();
            this.VPScenarios = new HashSet<VPScenario>();
        }
    
        public int TVItemID { get; set; }
        public int TVLevel { get; set; }
        public string TVPath { get; set; }
        public int TVType { get; set; }
        public int ParentID { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Addresses3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppTask> AppTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AppTask> AppTasks1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoxModel> BoxModels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Classification> Classifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClimateSite> ClimateSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contact> Contacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocTemplate> DocTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DrogueRun> DrogueRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailDistributionList> EmailDistributionLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HydrometricSite> HydrometricSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Infrastructure> Infrastructures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Infrastructure> Infrastructures1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Infrastructure> Infrastructures2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabSheetDetail> LabSheetDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabSheet> LabSheets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabSheet> LabSheets1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabSheet> LabSheets2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabSheetTubeMPNDetail> LabSheetTubeMPNDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MapInfo> MapInfos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MikeBoundaryCondition> MikeBoundaryConditions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MikeScenarioResult> MikeScenarioResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MikeScenario> MikeScenarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MikeSource> MikeSources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MikeSource> MikeSources1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMAnalysisReportParameter> MWQMAnalysisReportParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMAnalysisReportParameter> MWQMAnalysisReportParameters1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMRun> MWQMRuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMRun> MWQMRuns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMRun> MWQMRuns2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMSample> MWQMSamples { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMSample> MWQMSamples1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMSite> MWQMSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMSiteStartEndDate> MWQMSiteStartEndDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MWQMSubsector> MWQMSubsectors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceObservation> PolSourceObservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceSiteEffect> PolSourceSiteEffects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceSiteEffect> PolSourceSiteEffects1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceSiteEffect> PolSourceSiteEffects2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceSite> PolSourceSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PolSourceSite> PolSourceSites1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RainExceedanceClimateSite> RainExceedanceClimateSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RainExceedanceClimateSite> RainExceedanceClimateSites1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RainExceedance> RainExceedances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportSection> ReportSections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SamplingPlan> SamplingPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SamplingPlan> SamplingPlans1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SamplingPlan> SamplingPlans2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SamplingPlanSubsector> SamplingPlanSubsectors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SamplingPlanSubsectorSite> SamplingPlanSubsectorSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spill> Spills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spill> Spills1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tel> Tels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TideDataValue> TideDataValues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TideSite> TideSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVFile> TVFiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVItemLanguage> TVItemLanguages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVItemLink> TVItemLinks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVItemLink> TVItemLinks1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVItem> TVItems1 { get; set; }
        public virtual TVItem TVItem1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVItemStat> TVItemStats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVItemUserAuthorization> TVItemUserAuthorizations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVItemUserAuthorization> TVItemUserAuthorizations1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVTypeUserAuthorization> TVTypeUserAuthorizations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UseOfSite> UseOfSites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UseOfSite> UseOfSites1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VPScenario> VPScenarios { get; set; }
    }
}
