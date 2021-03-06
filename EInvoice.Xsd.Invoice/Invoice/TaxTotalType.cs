﻿using EInvoice.Xsd.Invoice.TaxTotal;
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
    public class TaxTotalType {        
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public TaxAmountType TaxAmount { get; set; }

        [XmlElement("TaxSubtotal", Order = 1)]
        public List<TaxSubtotalType> TaxSubtotal { get; set; }
    }

    
}
