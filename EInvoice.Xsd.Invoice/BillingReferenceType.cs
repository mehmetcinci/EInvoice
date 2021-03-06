﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class BillingReferenceType {                
        [XmlElement(Order = 0)]
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
