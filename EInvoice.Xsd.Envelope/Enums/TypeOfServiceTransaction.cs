using System;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Envelope.Enums {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [XmlTypeAttribute(Namespace = "http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader")]
    public enum TypeOfServiceTransaction {
        RequestingServiceTransaction,
        RespondingServiceTransaction,
    }
}
