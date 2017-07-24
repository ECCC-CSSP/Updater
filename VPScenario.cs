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
    
    public partial class VPScenario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VPScenario()
        {
            this.VPAmbients = new HashSet<VPAmbient>();
            this.VPResults = new HashSet<VPResult>();
            this.VPScenarioLanguages = new HashSet<VPScenarioLanguage>();
        }
    
        public int VPScenarioID { get; set; }
        public int InfrastructureTVItemID { get; set; }
        public int VPScenarioStatus { get; set; }
        public bool UseAsBestEstimate { get; set; }
        public double EffluentFlow_m3_s { get; set; }
        public int EffluentConcentration_MPN_100ml { get; set; }
        public double FroudeNumber { get; set; }
        public double PortDiameter_m { get; set; }
        public double PortDepth_m { get; set; }
        public double PortElevation_m { get; set; }
        public double VerticalAngle_deg { get; set; }
        public double HorizontalAngle_deg { get; set; }
        public int NumberOfPorts { get; set; }
        public double PortSpacing_m { get; set; }
        public double AcuteMixZone_m { get; set; }
        public double ChronicMixZone_m { get; set; }
        public double EffluentSalinity_PSU { get; set; }
        public double EffluentTemperature_C { get; set; }
        public double EffluentVelocity_m_s { get; set; }
        public string RawResults { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual TVItem TVItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VPAmbient> VPAmbients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VPResult> VPResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VPScenarioLanguage> VPScenarioLanguages { get; set; }
    }
}
