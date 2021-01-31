using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public partial class DocumentIdentification: Bases.XmlSerializerBase<DocumentIdentification> {        

        [XmlElement(Order = 0)]
        public string Standard { get; set; }

        [XmlElement(Order = 1)]
        public string TypeVersion { get; set; }

        [XmlElement(Order = 2)]
        public string InstanceIdentifier { get; set; }

        [XmlElement(Order = 3)]
        public string Type { get; set; }

        [XmlElement(Order = 4)]
        public bool MultipleType { get; set; }

        [XmlElement(Order = 5)]
        public System.DateTime CreationDateAndTime { get; set; }        
    }
}
