namespace EInvoice.Xsd.Envelope {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Xml;
    using System.Xml.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.efatura.gov.tr/package-namespace")]
    [XmlRootAttribute(Namespace = "http://www.efatura.gov.tr/package-namespace", IsNullable = false)]
    public partial class Package : Bases.XmlSerializerBase<Package> {        
        [XmlElement("Elements", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public List<PackageElements> Elements {
            get;
            set;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.efatura.gov.tr/package-namespace")]
    public partial class PackageElements : Bases.XmlSerializerBase<PackageElements> {
        #region Private fields
        private string _elementType;
        private int _elementCount;
        private PackageElementsElementList _elementList;
        #endregion

        public PackageElements() {
            _elementList = new PackageElementsElementList();
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string ElementType {
            get {
                return _elementType;
            }
            set {
                _elementType = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public int ElementCount {
            get {
                return _elementCount;
            }
            set {
                _elementCount = value;
            }
        }

        [XmlElement(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public PackageElementsElementList ElementList {
            get {
                return _elementList;
            }
            set {
                _elementList = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.efatura.gov.tr/package-namespace")]
    public partial class PackageElementsElementList : Bases.XmlSerializerBase<PackageElementsElementList> {        

        [XmlAnyElementAttribute(Order = 0)]
        public List<System.Xml.XmlElement> Any { get; set; }
    }
}
