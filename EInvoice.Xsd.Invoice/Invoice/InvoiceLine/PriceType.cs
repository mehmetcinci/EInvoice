﻿using EInvoice.Xsd.Invoice.Bases.Amount;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.InvoiceLine {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PriceType {
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public PriceAmountType PriceAmount { get; set; }
    }
}