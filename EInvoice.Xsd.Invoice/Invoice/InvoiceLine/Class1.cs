using EInvoice.Xsd.Invoice.Bases.Name;
using EInvoice.Xsd.Invoice.Bases.Text;
using EInvoice.Xsd.Invoice.Invoice.InvoiceLine.Item;
using EInvoice.Xsd.Invoice.InvoiceLine.Item;
using EInvoice.Xsd.Invoice.Party.Address;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice.Invoice.InvoiceLine {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ItemType {        
        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public DescriptionType Description { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public NameType1 Name { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public KeywordType Keyword { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 3)]
        public BrandNameType BrandName { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 4)]
        public ModelNameType ModelName { get; set; }

        [XmlElement(Order = 5)]
        public ItemIdentificationType BuyersItemIdentification { get; set; }

        [XmlElement(Order = 6)]
        public ItemIdentificationType SellersItemIdentification { get; set; }

        [XmlElement(Order = 7)]
        public ItemIdentificationType ManufacturersItemIdentification { get; set; }

        [XmlElement("AdditionalItemIdentification", Order = 8)]
        public List<ItemIdentificationType> AdditionalItemIdentification { get; set; }

        [XmlElement(Order = 9)]
        public CountryType OriginCountry { get; set; }

        [XmlElement("CommodityClassification", Order = 10)]
        public List<CommodityClassificationType> CommodityClassification { get; set; }

        [XmlElement("ItemInstance", Order = 11)]
        public List<ItemInstanceType> ItemInstance { get; set; }
    }
}
