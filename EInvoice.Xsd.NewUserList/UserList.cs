using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

using EInvoice.Xsd.NewUserList.Bases;

namespace EInvoice.Xsd.NewUserList {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class UserList: XmlSerializerBase<UserList> {     
        
        [XmlElement("User", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public List<User> User { get; set; }        
    }
}