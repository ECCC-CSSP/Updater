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
    
    public partial class EmailDistributionListLanguage
    {
        public int EmailDistributionListLanguageID { get; set; }
        public int EmailDistributionListID { get; set; }
        public int Language { get; set; }
        public string EmailListName { get; set; }
        public int TranslationStatus { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual EmailDistributionList EmailDistributionList { get; set; }
    }
}
