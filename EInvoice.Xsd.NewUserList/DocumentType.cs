using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

using EInvoice.Xsd.NewUserList.Bases;
using EInvoice.Xsd.NewUserList.Enums;

namespace EInvoice.Xsd.NewUserList {

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class DocumentType : XmlSerializerBase<DocumentType> {

        [XmlElement("Alias", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public List<AliasType> Alias { get; set; }

        [XmlAttribute]
        public DocType type { get; set; }
    }
}