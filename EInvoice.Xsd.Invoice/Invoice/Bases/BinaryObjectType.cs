using EInvoice.Xsd.Invoice.DocumentReference.Attachment;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.Bases {
    [XmlIncludeAttribute(typeof(VideoType))]
    [XmlIncludeAttribute(typeof(SoundType))]
    [XmlIncludeAttribute(typeof(PictureType))]
    [XmlIncludeAttribute(typeof(GraphicType))]
    [XmlIncludeAttribute(typeof(BinaryObjectType1))]
    [XmlIncludeAttribute(typeof(EmbeddedDocumentBinaryObjectType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class BinaryObjectType {        

        [XmlAttribute]
        public string format { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string mimeCode { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string encodingCode { get; set; }

        [XmlAttribute(DataType = "normalizedString")]
        public string characterSetCode { get; set; }

        [XmlAttribute(DataType = "anyURI")]
        public string uri { get; set; }

        [XmlAttribute]
        public string filename { get; set; }

        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }
}
