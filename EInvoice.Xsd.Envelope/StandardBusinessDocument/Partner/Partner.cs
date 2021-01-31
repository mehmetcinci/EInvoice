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
    public class Partner: Bases.XmlSerializerBase<Partner> {        
        [XmlElement(Order = 0)]
        public PartnerIdentification Identifier { get; set; }

        [XmlElement("ContactInformation", Order = 1)]
        public List<ContactInformation> ContactInformation { get; set; }
    }
}