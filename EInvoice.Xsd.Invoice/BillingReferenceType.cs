using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BillingReferenceType {                
        [XmlElement(Order = 0a)]
        public DocumentReferenceType InvoiceDocumentReference { get; set; }

        [XmlElement(Order = 1)]
        public DocumentReferenceType SelfBilledInvoiceDocumentReference { get; set; }

        [XmlElement(Order = 2)]
        public DocumentReferenceType CreditNoteDocumentReference { get; set; }

        [XmlElement(Order = 3)]
        public DocumentReferenceType SelfBilledCreditNoteDocumentReference { get; set; }

        [XmlElement(Order = 4)]
        public DocumentReferenceType DebitNoteDocumentReference { get; set; }

        [XmlElement(Order = 5)]
        public DocumentReferenceType ReminderDocumentReference { get; set; }

        [XmlElement(Order = 6)]
        public DocumentReferenceType AdditionalDocumentReference { get; set; }

        [XmlElement("BillingReferenceLine", Order = 7)]
        public List<BillingReferenceLineType> BillingReferenceLine { get; set; }
    }
}
