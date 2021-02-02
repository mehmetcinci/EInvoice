using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeliveryType {        
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public QuantityType2 Quantity { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public ActualDeliveryDateType ActualDeliveryDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public ActualDeliveryTimeType ActualDeliveryTime { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public LatestDeliveryDateType LatestDeliveryDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 5)]
        public LatestDeliveryTimeType LatestDeliveryTime { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 6)]
        public TrackingIDType TrackingID { get; set; }

        [XmlElement(Order = 7)]
        public AddressType DeliveryAddress { get; set; }

        [XmlElement(Order = 8)]
        public LocationType1 AlternativeDeliveryLocation { get; set; }

        [XmlElement(Order = 9)]
        public PeriodType EstimatedDeliveryPeriod { get; set; }

        [XmlElement(Order = 10)]
        public PartyType CarrierParty { get; set; }

        [XmlElement(Order = 11)]
        public PartyType DeliveryParty { get; set; }

        [XmlElement(Order = 12)]
        public DespatchType Despatch { get; set; }

        [XmlElement("DeliveryTerms", Order = 13)]
        public List<DeliveryTermsType> DeliveryTerms { get; set; }

        [XmlElement(Order = 14)]
        public ShipmentType Shipment { get; set; }
    }
}
