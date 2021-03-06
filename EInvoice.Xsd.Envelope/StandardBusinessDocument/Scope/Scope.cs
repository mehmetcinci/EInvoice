﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public partial class Scope: Bases.XmlSerializerBase<Scope> {        
        [XmlElement(Order = 0)]
        public string Type { get; set; }

        [XmlElement(Order = 1)]
        public string InstanceIdentifier { get; set; }

        [XmlElement(Order = 2)]
        public string Identifier { get; set; }

        [XmlElement("ScopeInformation", Order = 3)]
        public List<object> ScopeInformation { get; set; }        
    }
}
