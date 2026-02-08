using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class SupplierPartyType {        

        [XmlElement(Order = 0)]
        public PartyType Party { get; set; }

        [XmlElement(Order = 1)]
        public ContactType DespatchContact { get; set; }
    }
}
