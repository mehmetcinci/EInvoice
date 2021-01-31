using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public partial class ContactInformation: Bases.XmlSerializerBase<ContactInformation> {        
        [XmlElement(Order = 0)]
        public string Contact { get; set; }

        [XmlElement(Order = 1)]
        public string EmailAddress { get; set; }

        [XmlElement(Order = 2)]
        public string FaxNumber { get; set; }

        [XmlElement(Order = 3)]
        public string TelephoneNumber { get; set; }

        [XmlElement(Order = 4)]
        public string ContactTypeIdentifier { get; set; }        
    }
}
