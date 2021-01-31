using EInvoice.Xsd.Envelope.Enums;
using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public partial class ServiceTransaction : Bases.XmlSerializerBase<ServiceTransaction> {

        [XmlAttribute]
        public TypeOfServiceTransaction TypeOfServiceTransaction { get; set; }

        [XmlAttribute]
        public string IsNonRepudiationRequired { get; set; }

        [XmlAttribute]
        public string IsAuthenticationRequired { get; set; }

        [XmlAttribute]
        public string IsNonRepudiationOfReceiptRequired { get; set; }

        [XmlAttribute]
        public string IsIntelligibleCheckRequired { get; set; }

        [XmlAttribute]
        public string IsApplicationErrorResponseRequested { get; set; }

        [XmlAttribute]
        public string TimeToAcknowledgeReceipt { get; set; }

        [XmlAttribute]
        public string TimeToAcknowledgeAcceptance { get; set; }

        [XmlAttribute]
        public string TimeToPerform { get; set; }

        [XmlAttribute]
        public string Recurrence { get; set; }        
    }
}
