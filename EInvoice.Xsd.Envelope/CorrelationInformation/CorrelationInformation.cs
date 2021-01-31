using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    [XmlRootAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader", IsNullable = false)]
    public class CorrelationInformation: Bases.XmlSerializerBase<CorrelationInformation> {        
        [XmlElement(Order = 0)]
        public System.DateTime RequestingDocumentCreationDateTime { get; set; }

        [XmlElement(Order = 1)]
        public string RequestingDocumentInstanceIdentifier { get; set; }

        [XmlElement(Order = 2)]
        public System.DateTime ExpectedResponseDateTime { get; set; }
    }
}
