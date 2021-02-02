using System;
using System.Collections.Generic;
using Xunit;

namespace EInvoice.Xsd.Invoice.XUnitTest {
    public class InvoiceXUnitTest {
        [Fact]
        public void InvoiceTypeSerialize() {
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
            invoiceType.AdditionalDocumentReference = GetAdditionalDocumentReference();
            invoiceType.SaveToFile("InvoiceTypeSerialize.xml", out Exception exception);                
        }        

        private InvoiceTypeCodeType GetInvoiceTypeCode() {
            return new InvoiceTypeCodeType() { Value = "ISTISNA" };
        }

        private UBLVersionIDType GetUBLVersionID() {
            return new UBLVersionIDType() { Value = "2.1" };
        }

        private CustomizationIDType GetCustomizationID() {
            return new CustomizationIDType() { Value = "TR1.2" };
        }

        private ProfileIDType GetProfileID() {
            return new ProfileIDType() { Value = "IHRACAT" };
        }

        private IDType GetID() {
            return new IDType() { Value = "BGL2021000000001" };
        }

        private CopyIndicatorType GetCopyIndicator() {
            return new CopyIndicatorType() { Value = false };
        }

        private UUIDType GetUUID() {
            return new UUIDType() { Value = "D9A37D80-6523-11EB-AE93-0242AC130002" };
        }

        private IssueDateType GetIssueDate() {
            return new IssueDateType() { Value = new DateTime(2021, 02, 02) };
        }

        private List<NoteType> GetNote() {
            List<NoteType> Notes = new List<NoteType>();
            Notes.Add(new NoteType() { Value = "Sicil No: 1 Ýþletme Merkezi: 1" });
            return Notes;                
        }

        private DocumentCurrencyCodeType GetDocumentCurrencyCode() {
            return new DocumentCurrencyCodeType() { Value = "TRY" };
        }

        private LineCountNumericType GetLineCountNumeric() {
            return new LineCountNumericType() { Value = 1 };
        }

        private List<DocumentReferenceType> GetAdditionalDocumentReference() {
            List<DocumentReferenceType> DocumentReferences = new List<DocumentReferenceType>();
            
            return DocumentReferences;
        }
    }
}
