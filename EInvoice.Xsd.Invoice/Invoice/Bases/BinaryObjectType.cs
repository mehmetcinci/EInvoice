using EInvoice.Xsd.Invoice.DocumentReference.Attachment;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.Bases {
    [XmlInclude(typeof(VideoType))]
    [XmlInclude(typeof(SoundType))]
    [XmlInclude(typeof(PictureType))]
    [XmlInclude(typeof(GraphicType))]
    [XmlInclude(typeof(BinaryObjectType1))]
    [XmlInclude(typeof(EmbeddedDocumentBinaryObjectType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class BinaryObjectType {        

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
