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
    public class User: XmlSerializerBase<User> {

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string Identifier { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string Title { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public UsrType Type { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public string FirstCreationTime { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public AccType AccountType { get; set; }

        [XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        [XmlArrayItemAttribute("Document", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<DocumentType> Documents { get; set; }
    }
}