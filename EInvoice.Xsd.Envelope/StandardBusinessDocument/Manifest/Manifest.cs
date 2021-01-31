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
    public partial class Manifest: Bases.XmlSerializerBase<Manifest> {

        [XmlElement(DataType = "integer", Order = 0)]
        public string NumberOfItems { get; set; }

        [XmlElement("ManifestItem", Order = 1)]
        public List<ManifestItem> ManifestItem { get; set; }        
    }
}
