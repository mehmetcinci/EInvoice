using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [XmlRootAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
    public partial class StandardBusinessDocumentHeader: Bases.XmlSerializerBase<StandardBusinessDocumentHeader> {                

        [XmlElement(Order = 0)]
        public string HeaderVersion { get; set; }

        [XmlElement("Sender", Order = 1)]
        public List<Partner> Sender { get; set; }

        [XmlElement("Receiver", Order = 2)]
        public List<Partner> Receiver { get; set; }

        [XmlElement(Order = 3)]
        public DocumentIdentification DocumentIdentification { get; set; }

        [XmlElement(Order = 4)]
        public Manifest Manifest { get; set; }

        [XmlArrayAttribute(Order = 5)]
        [XmlArrayItemAttribute(IsNullable = false)]
        public List<Scope> BusinessScope { get; set; }        
    }
}
