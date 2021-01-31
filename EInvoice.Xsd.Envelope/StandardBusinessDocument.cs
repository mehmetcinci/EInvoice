using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [XmlRootAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
    public partial class StandardBusinessDocument : Bases.XmlSerializerBase<StandardBusinessDocument> {
        [XmlElement(Order = 0)]
        public StandardBusinessDocumentHeader StandardBusinessDocumentHeader { get; set; }

        [XmlAnyElementAttribute(Order = 1a)]
        public System.Xml.XmlElement Any { get; set; }
    }
}