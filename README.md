[![Build Status](https://dev.azure.com/cincimehmet/EInvoice/_apis/build/status/mehmetcinci.EInvoice?branchName=main)](https://dev.azure.com/cincimehmet/EInvoice/_build/latest?definitionId=1&branchName=main)

# EInvoice.Xsd.Invoice
EInvoice.Xsd.Invoice

# EInvoice.Xsd.Envelope
EInvoice.Xsd.Envelope

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
