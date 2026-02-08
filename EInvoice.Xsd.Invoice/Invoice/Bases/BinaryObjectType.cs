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
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class BinaryObjectType {        

        [XmlAttribute("format")]
        public string Format { get; set; }

        [XmlAttribute("mimeCode", DataType = "normalizedString")]
        public string MimeCode { get; set; }

        [XmlAttribute("encodingCode", DataType = "normalizedString")]
        public string EncodingCode { get; set; }

        [XmlAttribute("characterSetCode", DataType = "normalizedString")]
        public string CharacterSetCode { get; set; }

        [XmlAttribute("uri", DataType = "anyURI")]
        public string Uri { get; set; }

        [XmlAttribute("filename")]
        public string Filename { get; set; }

        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }
}
