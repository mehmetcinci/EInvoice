using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public class PartnerIdentification: Bases.XmlSerializerBase<PartnerIdentification> {        
        [XmlAttribute]
        public string Authority { get; set; }

        [XmlTextAttribute]
        public string Value { get; set; }        
    }
}
