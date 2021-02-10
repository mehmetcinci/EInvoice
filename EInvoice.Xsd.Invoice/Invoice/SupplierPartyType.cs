using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
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
