﻿using EInvoice.Xsd.Invoice.Party;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PartyType {               

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 0)]
        public WebsiteURIType WebsiteURI { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 1)]
        public EndpointIDType EndpointID { get; set; }

        [XmlElement(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order = 2)]
        public IndustryClassificationCodeType IndustryClassificationCode { get; set; }

        [XmlElement("PartyIdentification", Order = 3)]
        public List<PartyIdentificationType> PartyIdentification { get; set; }

        [XmlElement(Order = 4)]
        public PartyNameType PartyName { get; set; }

        [XmlElement(Order = 5)]
        public AddressType PostalAddress { get; set; }

        [XmlElement(Order = 6)]
        public LocationType1 PhysicalLocation { get; set; }

        [XmlElement(Order = 7)]
        public PartyTaxSchemeType PartyTaxScheme { get; set; }

        [XmlElement("PartyLegalEntity", Order = 8)]
        public List<PartyLegalEntityType> PartyLegalEntity { get; set; }

        [XmlElement(Order = 9)]
        public ContactType Contact { get; set; }

        [XmlElement(Order = 10)]
        public PersonType Person { get; set; }

        [XmlElement(Order = 11)]
        public PartyType AgentParty { get; set; }
    }
}
