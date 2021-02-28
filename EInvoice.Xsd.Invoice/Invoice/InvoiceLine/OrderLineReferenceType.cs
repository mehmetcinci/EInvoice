using EInvoice.Xsd.Invoice.Bases.Code;
using EInvoice.Xsd.Invoice.Bases.Identifier;
using EInvoice.Xsd.Invoice.InvoiceLine.OrderLineReference;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.Invoice.InvoiceLine {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class OrderLineReferenceType {
        [XmlElement(Order = 2)]
        public UUIDType UUID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LineStatusCodeType LineStatusCode { get; set; }

        [XmlElement(Order = 4)]
        public OrderReferenceType OrderReference { get; set; }
    }
    
}
