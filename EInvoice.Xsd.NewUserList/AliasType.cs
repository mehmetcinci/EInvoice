using EInvoice.Xsd.NewUserList.Bases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace EInvoice.Xsd.NewUserList {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class AliasType : XmlSerializerBase<AliasType> {                
        [XmlElement("Name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public List<string> Name { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string CreationTime { get; set; }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public string DeletionTime { get; set; }        
    }
}