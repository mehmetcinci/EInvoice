using EInvoice.Xsd.Invoice.Invoice.Bases.Quantity;
using EInvoice.Xsd.Invoice.Invoice.InvoiceLine;
using EInvoice.Xsd.Invoice.InvoiceLine;
using EInvoice.Xsd.Invoice.MonetaryTotal;
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
    public class InvoiceLineType {        

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public IDType ID { get; set; }

        [XmlElement("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public List<NoteType> Note { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public InvoicedQuantityType InvoicedQuantity { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public LineExtensionAmountType LineExtensionAmount { get; set; }

        [XmlElement("OrderLineReference", Order = 4)]
        public List<OrderLineReferenceType> OrderLineReference { get; set; }

        [XmlElement("DespatchLineReference", Order = 5)]
        public List<LineReferenceType> DespatchLineReference { get; set; }

        [XmlElement("ReceiptLineReference", Order = 6)]
        public List<LineReferenceType> ReceiptLineReference { get; set; }

        [XmlElement("Delivery", Order = 7)]
        public List<DeliveryType> Delivery { get; set; }

        [XmlElement("AllowanceCharge", Order = 8)]
        public List<AllowanceChargeType> AllowanceCharge { get; set; }

        [XmlElement(Order = 9)]
        public TaxTotalType TaxTotal { get; set; }

        [XmlElement("WithholdingTaxTotal", Order = 10)]
        public List<TaxTotalType> WithholdingTaxTotal { get; set; }

        [XmlElement(Order = 11)]
        public ItemType Item { get; set; }

        [XmlElement(Order = 12)]
        public PriceType Price { get; set; }

        [XmlElement("SubInvoiceLine", Order = 13)]
        public List<InvoiceLineType> SubInvoiceLine { get; set; }
    }  
}
