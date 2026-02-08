using EInvoice.Xsd.Invoice.DocumentReference;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class SignatureType {        

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }

        [XmlElement(Order = 1)]
        public PartyType SignatoryParty { get; set; }

        [XmlElement(Order = 2)]
        public AttachmentType DigitalSignatureAttachment { get; set; }
    }
}
