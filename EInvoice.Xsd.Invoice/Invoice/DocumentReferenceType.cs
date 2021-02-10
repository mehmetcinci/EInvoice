using EInvoice.Xsd.Invoice.DocumentReference;
using EInvoice.Xsd.Invoice.Party.Address;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class DocumentReferenceType {
        
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public IssueDateType IssueDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public DocumentTypeCodeType DocumentTypeCode { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public DocumentTypeType DocumentType { get; set; }

        [XmlElement("DocumentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public List<DocumentDescriptionType> DocumentDescription { get; set; }

        [XmlElement(Order = 5)]
        public AttachmentType Attachment { get; set; }

        [XmlElement(Order = 6)]
        public PeriodType ValidityPeriod { get; set; }

        [XmlElement(Order = 7)]
        public PartyType IssuerParty { get; set; }
    }
}
