using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace InsuranceDetailsExtractor
{

    [XmlRoot("INFORMATION")]
    public class InsuranceList
    {
        [XmlElement("ADDITIONAL_FIELDS")]
        public List<InsuranceListExtract> InsuranceLists { get; set; }
    }

    [XmlRoot("ADDITIONAL_FIELDS")]
    public class InsuranceListExtract
    {
        [XmlElement("ZPRDTYP")]
        public string ProductType { get; set; }
        [XmlElement("RSTERM")]
        public int RiskTerm { get; set; }
        [XmlElement("PMTERM>")]
        public long PremiumTerm { get; set; }
        [XmlElement("PAYMMETH")]
        public string PaymentMethod { get; set; }
        [XmlElement("PAYFREQ")]
        public int PaymentFreq { get; set; }
        [XmlElement("RCDDATE")]
        public string RiskCommencementDate { get; set; }
        [XmlElement("LASEX")]
        public string LifeAssuredGender { get; set; }
        [XmlElement("LADOB")]
        public string LifeAssuredDOB { get; set; }
        [XmlElement("LACRTBL")]
        public string LifeAssuredCompCode { get; set; }
        [XmlElement("LAINSPR")]
        public int LifeAssuredInstallmentPremium { get; set; }

    }

}