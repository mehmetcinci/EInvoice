[![Build Status](https://dev.azure.com/cincimehmet/EInvoice/_apis/build/status/mehmetcinci.EInvoice?branchName=main)](https://dev.azure.com/cincimehmet/EInvoice/_build/latest?definitionId=1&branchName=main)

# EInvoice.Xsd.Envelope
EInvoice.Xsd.Envelope

# EInvoice.Xsd.Invoice
A simple C# code for EInvoice.Xsd.Invoice

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
