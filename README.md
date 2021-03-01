[![Build Status](https://dev.azure.com/cincimehmet/EInvoice/_apis/build/status/mehmetcinci.EInvoice?branchName=main)](https://dev.azure.com/cincimehmet/EInvoice/_build/latest?definitionId=1&branchName=main)

# EInvoice.Xsd.Envelope
EInvoice.Xsd.Envelope

[![EInvoice.Xsd.Envelope on fuget.org](https://www.fuget.org/packages/EInvoice.Xsd.Envelope/badge.svg)](https://www.fuget.org/packages/EInvoice.Xsd.Envelope) [![NuGet Downloads](https://img.shields.io/nuget/dt/EInvoice.Xsd.Envelope?label=Downloads)](https://www.nuget.org/packages/EInvoice.Xsd.Envelope/) [![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/majorimi/blazor-components/blob/master/LICENSE)

# EInvoice.Xsd.Invoice
A simple C# code for EInvoice.Xsd.Invoice

[![EInvoice.Xsd.Invoice on fuget.org](https://www.fuget.org/packages/EInvoice.Xsd.Invoice/badge.svg)](https://www.fuget.org/packages/EInvoice.Xsd.Invoice) [![NuGet Downloads](https://img.shields.io/nuget/dt/EInvoice.Xsd.Invoice?label=Downloads)](https://www.nuget.org/packages/EInvoice.Xsd.Invoice/) [![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/majorimi/blazor-components/blob/master/LICENSE)

```c#
InvoiceType invoiceType = new InvoiceType();
invoiceType.UBLVersionID = GetUBLVersionID();
invoiceType.CustomizationID = GetCustomizationID();
invoiceType.ProfileID = GetProfileID();
invoiceType.ID = GetID();
invoiceType.CopyIndicator = GetCopyIndicator();
invoiceType.UUID = GetUUID();
invoiceType.IssueDate = GetIssueDate();
invoiceType.InvoiceTypeCode = GetInvoiceTypeCode();
invoiceType.Note = GetNote();
invoiceType.DocumentCurrencyCode = GetDocumentCurrencyCode();
invoiceType.LineCountNumeric = GetLineCountNumeric();
invoiceType.AdditionalDocumentReference = GetAdditionalDocumentReference(invoiceType);
invoiceType.Signature = GetSignature(invoiceType);
invoiceType.AccountingSupplierParty = GetAccountingSupplierParty();
invoiceType.AccountingCustomerParty = GetAccountingCustomerParty();
invoiceType.PaymentMeans = GetPaymentMeans();
invoiceType.PricingExchangeRate = GetPricingExchangeRate();
invoiceType.TaxTotal = GetTaxTotal();
invoiceType.LegalMonetaryTotal = GetLegalMonetaryTotal();
invoiceType.InvoiceLine = GetInvoiceLine();            
invoiceType.SaveToFile("InvoiceTypeSerialize.xml", out Exception exception);

private MonetaryTotalType GetLegalMonetaryTotal() {
    return new MonetaryTotalType {
	LineExtensionAmount = new MonetaryTotal.LineExtensionAmountType { currencyID = "EUR", Value = 2207.09M },
	TaxExclusiveAmount = new MonetaryTotal.TaxExclusiveAmountType { currencyID = "EUR", Value = 2207.09M },
	TaxInclusiveAmount = new MonetaryTotal.TaxInclusiveAmountType { currencyID = "EUR", Value = 2207.09M },
	AllowanceTotalAmount = new MonetaryTotal.AllowanceTotalAmountType { currencyID = "EUR", Value = 0.00M },
	PayableRoundingAmount = new PayableRoundingAmountType { currencyID = "EUR", Value = 0.00M },
	PayableAmount = new PayableAmountType { currencyID = "EUR", Value = 2207.09M }
    };
}
```

A sample XML data.

```xml
<Invoice xmlns:ds="http://www.w3.org/2000/09/xmldsig#" xmlns:xades="http://uri.etsi.org/01903/v1.3.2#" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2">
  <cbc:UBLVersionID>2.1</cbc:UBLVersionID>
  <cbc:CustomizationID>TR1.2</cbc:CustomizationID>
  <cbc:ProfileID>IHRACAT</cbc:ProfileID>
  <cbc:ID>BGL2021000000001</cbc:ID>
  <cbc:CopyIndicator>false</cbc:CopyIndicator>
  <cbc:UUID>D9A37D80-6523-11EB-AE93-0242AC130002</cbc:UUID>
  <cbc:IssueDate>2021-02-02</cbc:IssueDate>
  <cbc:InvoiceTypeCode>ISTISNA</cbc:InvoiceTypeCode>
  <cbc:Note>Sicil No: 1 İşletme Merkezi: 1</cbc:Note>
  <cbc:DocumentCurrencyCode>TRY</cbc:DocumentCurrencyCode>
  <cbc:LineCountNumeric>1</cbc:LineCountNumeric>
  <cac:AdditionalDocumentReference>
    <cbc:ID>852D34D85AD149</cbc:ID>
    <cbc:IssueDate>2021-02-02</cbc:IssueDate>
    <cbc:DocumentType>XSLT</cbc:DocumentType>
    <cac:Attachment>
      <cbc:EmbeddedDocumentBinaryObject mimeCode="application/xml" encodingCode="Base64" characterSetCode="UTF-8" filename="BGL2021000000001.xslt" />
    </cac:Attachment>
  </cac:AdditionalDocumentReference>
</Invoice>
```

[![EInvoice.Xsd.NewUserList on fuget.org](https://www.fuget.org/packages/EInvoice.Xsd.NewUserList/badge.svg)](https://www.fuget.org/packages/EInvoice.Xsd.NewUserList) [![NuGet Downloads](https://img.shields.io/nuget/dt/EInvoice.Xsd.NewUserList?label=Downloads)](https://www.nuget.org/packages/EInvoice.Xsd.NewUserList/) [![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/majorimi/blazor-components/blob/master/LICENSE)

# EInvoice.Xsd.NewUserList
A simple C# code for EInvoice.Xsd.NewUserList

```c#
string fileNameXml = "newUserPkList.xml";
UserList.LoadFromFile(fileNameXml, out UserList userList, out Exception exception);
if (exception == null) {
    if (userList.User.Count == 335553)
        Assert.True(true);
    else
        Assert.False(true);
}
else {
    Assert.False(true, $"Exception: {exception.Message}");
}
```
A sample XML data.

```xml
<UserList>
	<User>
		<Identifier>0010030481</Identifier>
		<Alias>urn:mail:defaultpk@abalioglu.com.tr</Alias>
		<Title>ABALIOĞLU HOLDİNG ANONİM ŞİRKETİ</Title>
		<Type>Özel</Type>
		<FirstCreationTime>2015-09-29T11:34:24</FirstCreationTime>
		<AliasCreationTime>2020-03-12T15:41:37</AliasCreationTime>
		<AccountType>1</AccountType>
	</User>
</UserList>
```
