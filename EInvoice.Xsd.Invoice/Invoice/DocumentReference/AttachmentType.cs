﻿using EInvoice.Xsd.Invoice.DocumentReference.Attachment;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.DocumentReference {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class AttachmentType {

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public EmbeddedDocumentBinaryObjectType EmbeddedDocumentBinaryObject { get; set; }

        [XmlElement(Order = 1)]
        public ExternalReferenceType ExternalReference { get; set; }
    }
}
