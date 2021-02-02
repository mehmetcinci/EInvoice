using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.Bases {
    [XmlIncludeAttribute(typeof(ValidationTimeType))]
    [XmlIncludeAttribute(typeof(StartTimeType))]
    [XmlIncludeAttribute(typeof(SourceForecastIssueTimeType))]
    [XmlIncludeAttribute(typeof(RevisionTimeType))]
    [XmlIncludeAttribute(typeof(ResponseTimeType))]
    [XmlIncludeAttribute(typeof(ResolutionTimeType))]
    [XmlIncludeAttribute(typeof(RequiredDeliveryTimeType))]
    [XmlIncludeAttribute(typeof(RequestedDespatchTimeType))]
    [XmlIncludeAttribute(typeof(RegisteredTimeType))]
    [XmlIncludeAttribute(typeof(ReferenceTimeType))]
    [XmlIncludeAttribute(typeof(PaidTimeType))]
    [XmlIncludeAttribute(typeof(OccurrenceTimeType))]
    [XmlIncludeAttribute(typeof(NominationTimeType))]
    [XmlIncludeAttribute(typeof(ManufactureTimeType))]
    [XmlIncludeAttribute(typeof(LatestPickupTimeType))]
    [XmlIncludeAttribute(typeof(LatestDeliveryTimeType))]
    [XmlIncludeAttribute(typeof(LastRevisionTimeType))]
    [XmlIncludeAttribute(typeof(IssueTimeType))]
    [XmlIncludeAttribute(typeof(GuaranteedDespatchTimeType))]
    [XmlIncludeAttribute(typeof(ExpiryTimeType))]
    [XmlIncludeAttribute(typeof(EstimatedDespatchTimeType))]
    [XmlIncludeAttribute(typeof(EstimatedDeliveryTimeType))]
    [XmlIncludeAttribute(typeof(EndTimeType))]
    [XmlIncludeAttribute(typeof(EffectiveTimeType))]
    [XmlIncludeAttribute(typeof(EarliestPickupTimeType))]
    [XmlIncludeAttribute(typeof(ComparisonForecastIssueTimeType))]
    [XmlIncludeAttribute(typeof(CallTimeType))]
    [XmlIncludeAttribute(typeof(AwardTimeType))]
    [XmlIncludeAttribute(typeof(ActualPickupTimeType))]
    [XmlIncludeAttribute(typeof(ActualDespatchTimeType))]
    [XmlIncludeAttribute(typeof(ActualDeliveryTimeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class TimeType {        
        [XmlTextAttribute(DataType = "time")]
        public System.DateTime Value { get; set; }
    }
}
