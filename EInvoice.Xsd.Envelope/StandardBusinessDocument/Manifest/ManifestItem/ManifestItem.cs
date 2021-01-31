using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public partial class ManifestItem: Bases.XmlSerializerBase<ManifestItem> {        
        [XmlElement(Order = 0)]
        public string MimeTypeQualifierCode { get; set; }

        [XmlElement(DataType = "anyURI", Order = 1)]
        public string UniformResourceIdentifier { get; set; }

        [XmlElement(Order = 2)]
        public string Description { get; set; }

        [XmlElement(Order = 3)]
        public string LanguageCode { get; set; }        
    }
}
