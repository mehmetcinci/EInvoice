using EInvoice.Xsd.Invoice.Bases.Code;
using EInvoice.Xsd.Invoice.Bases.Identifier;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.InvoiceLine.OrderLineReference {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class OrderReferenceType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public SalesOrderIDType SalesOrderID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public IssueDateType IssueDate { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public OrderTypeCodeType OrderTypeCode { get; set; }

        [XmlElement(Order = 4)]
        public DocumentReferenceType DocumentReference { get; set; }
    }

    
}
