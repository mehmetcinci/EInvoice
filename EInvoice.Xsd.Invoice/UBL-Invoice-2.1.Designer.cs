using EInvoice.Xsd.Invoice.Bases;
using EInvoice.Xsd.Invoice.Bases.Amount;
using EInvoice.Xsd.Invoice.Bases.Code;
using EInvoice.Xsd.Invoice.Bases.Identifier;
using EInvoice.Xsd.Invoice.Invoice.Bases.Quantity;
using EInvoice.Xsd.Invoice.MonetaryTotal;
using EInvoice.Xsd.Invoice.Party;
using EInvoice.Xsd.Invoice.Party.Address;
using EInvoice.Xsd.Invoice.PartyTaxScheme;
using EInvoice.Xsd.Invoice.PaymentMeans;
using EInvoice.Xsd.Invoice.TaxTotal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [XmlInclude(typeof(ValueAmountType))]
    [XmlInclude(typeof(TransactionCurrencyTaxAmountType))]
    [XmlInclude(typeof(TotalTaxAmountType))]
    [XmlInclude(typeof(TotalTaskAmountType))]
    [XmlInclude(typeof(TotalPaymentAmountType))]
    [XmlInclude(typeof(TotalInvoiceAmountType))]
    [XmlInclude(typeof(TotalDebitAmountType))]
    [XmlInclude(typeof(TotalCreditAmountType))]
    [XmlInclude(typeof(TotalBalanceAmountType))]
    [XmlInclude(typeof(TotalAmountType))]
    [XmlInclude(typeof(ThresholdAmountType))]
    [XmlInclude(typeof(TaxableAmountType))]
    [XmlInclude(typeof(TaxInclusiveAmountType))]
    [XmlInclude(typeof(TaxExclusiveAmountType))]
    [XmlInclude(typeof(TaxEnergyOnAccountAmountType))]
    [XmlInclude(typeof(TaxEnergyBalanceAmountType))]
    [XmlInclude(typeof(TaxEnergyAmountType))]
    [XmlInclude(typeof(TaxAmountType))]
    [XmlInclude(typeof(SettlementDiscountAmountType))]
    [XmlInclude(typeof(RoundingAmountType))]
    [XmlInclude(typeof(RequiredFeeAmountType))]
    [XmlInclude(typeof(PriceAmountType))]
    [XmlInclude(typeof(PrepaidAmountType))]
    [XmlInclude(typeof(PerUnitAmountType))]
    [XmlInclude(typeof(PenaltyAmountType))]
    [XmlInclude(typeof(PayableRoundingAmountType))]
    [XmlInclude(typeof(PayableAmountType))]
    [XmlInclude(typeof(PayableAlternativeAmountType))]
    [XmlInclude(typeof(PartyCapacityAmountType))]
    [XmlInclude(typeof(PaidAmountType))]
    [XmlInclude(typeof(MinimumAmountType))]
    [XmlInclude(typeof(MaximumPaidAmountType))]
    [XmlInclude(typeof(MaximumAmountType))]
    [XmlInclude(typeof(MaximumAdvertisementAmountType))]
    [XmlInclude(typeof(MarketValueAmountType))]
    [XmlInclude(typeof(LowerTenderAmountType))]
    [XmlInclude(typeof(LineExtensionAmountType))]
    [XmlInclude(typeof(LiabilityAmountType))]
    [XmlInclude(typeof(InventoryValueAmountType))]
    [XmlInclude(typeof(InsuranceValueAmountType))]
    [XmlInclude(typeof(InsurancePremiumAmountType))]
    [XmlInclude(typeof(HigherTenderAmountType))]
    [XmlInclude(typeof(FreeOnBoardValueAmountType))]
    [XmlInclude(typeof(FeeAmountType))]
    [XmlInclude(typeof(FaceValueAmountType))]
    [XmlInclude(typeof(EstimatedOverallContractAmountType))]
    [XmlInclude(typeof(EstimatedAmountType))]
    [XmlInclude(typeof(DocumentationFeeAmountType))]
    [XmlInclude(typeof(DeclaredStatisticsValueAmountType))]
    [XmlInclude(typeof(DeclaredForCarriageValueAmountType))]
    [XmlInclude(typeof(DeclaredCustomsValueAmountType))]
    [XmlInclude(typeof(DeclaredCarriageValueAmountType))]
    [XmlInclude(typeof(DebitLineAmountType))]
    [XmlInclude(typeof(CreditLineAmountType))]
    [XmlInclude(typeof(CorrectionUnitAmountType))]
    [XmlInclude(typeof(CorrectionAmountType))]
    [XmlInclude(typeof(CorporateStockAmountType))]
    [XmlInclude(typeof(ChargeTotalAmountType))]
    [XmlInclude(typeof(CallExtensionAmountType))]
    [XmlInclude(typeof(CallBaseAmountType))]
    [XmlInclude(typeof(BaseAmountType))]
    [XmlInclude(typeof(BalanceAmountType))]
    [XmlInclude(typeof(AverageSubsequentContractAmountType))]
    [XmlInclude(typeof(AverageAmountType))]
    [XmlInclude(typeof(AnnualAverageAmountType))]
    [XmlInclude(typeof(AmountType2))]
    [XmlInclude(typeof(AllowanceTotalAmountType))]
    [XmlInclude(typeof(AdvertisementAmountType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="AmountType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class AmountType1 : AmountType
    {
    }
    
    [XmlInclude(typeof(AmountType1))]
    [XmlInclude(typeof(ValueAmountType))]
    [XmlInclude(typeof(TransactionCurrencyTaxAmountType))]
    [XmlInclude(typeof(TotalTaxAmountType))]
    [XmlInclude(typeof(TotalTaskAmountType))]
    [XmlInclude(typeof(TotalPaymentAmountType))]
    [XmlInclude(typeof(TotalInvoiceAmountType))]
    [XmlInclude(typeof(TotalDebitAmountType))]
    [XmlInclude(typeof(TotalCreditAmountType))]
    [XmlInclude(typeof(TotalBalanceAmountType))]
    [XmlInclude(typeof(TotalAmountType))]
    [XmlInclude(typeof(ThresholdAmountType))]
    [XmlInclude(typeof(TaxableAmountType))]
    [XmlInclude(typeof(TaxInclusiveAmountType))]
    [XmlInclude(typeof(TaxExclusiveAmountType))]
    [XmlInclude(typeof(TaxEnergyOnAccountAmountType))]
    [XmlInclude(typeof(TaxEnergyBalanceAmountType))]
    [XmlInclude(typeof(TaxEnergyAmountType))]
    [XmlInclude(typeof(TaxAmountType))]
    [XmlInclude(typeof(SettlementDiscountAmountType))]
    [XmlInclude(typeof(RoundingAmountType))]
    [XmlInclude(typeof(RequiredFeeAmountType))]
    [XmlInclude(typeof(PriceAmountType))]
    [XmlInclude(typeof(PrepaidAmountType))]
    [XmlInclude(typeof(PerUnitAmountType))]
    [XmlInclude(typeof(PenaltyAmountType))]
    [XmlInclude(typeof(PayableRoundingAmountType))]
    [XmlInclude(typeof(PayableAmountType))]
    [XmlInclude(typeof(PayableAlternativeAmountType))]
    [XmlInclude(typeof(PartyCapacityAmountType))]
    [XmlInclude(typeof(PaidAmountType))]
    [XmlInclude(typeof(MinimumAmountType))]
    [XmlInclude(typeof(MaximumPaidAmountType))]
    [XmlInclude(typeof(MaximumAmountType))]
    [XmlInclude(typeof(MaximumAdvertisementAmountType))]
    [XmlInclude(typeof(MarketValueAmountType))]
    [XmlInclude(typeof(LowerTenderAmountType))]
    [XmlInclude(typeof(LineExtensionAmountType))]
    [XmlInclude(typeof(LiabilityAmountType))]
    [XmlInclude(typeof(InventoryValueAmountType))]
    [XmlInclude(typeof(InsuranceValueAmountType))]
    [XmlInclude(typeof(InsurancePremiumAmountType))]
    [XmlInclude(typeof(HigherTenderAmountType))]
    [XmlInclude(typeof(FreeOnBoardValueAmountType))]
    [XmlInclude(typeof(FeeAmountType))]
    [XmlInclude(typeof(FaceValueAmountType))]
    [XmlInclude(typeof(EstimatedOverallContractAmountType))]
    [XmlInclude(typeof(EstimatedAmountType))]
    [XmlInclude(typeof(DocumentationFeeAmountType))]
    [XmlInclude(typeof(DeclaredStatisticsValueAmountType))]
    [XmlInclude(typeof(DeclaredForCarriageValueAmountType))]
    [XmlInclude(typeof(DeclaredCustomsValueAmountType))]
    [XmlInclude(typeof(DeclaredCarriageValueAmountType))]
    [XmlInclude(typeof(DebitLineAmountType))]
    [XmlInclude(typeof(CreditLineAmountType))]
    [XmlInclude(typeof(CorrectionUnitAmountType))]
    [XmlInclude(typeof(CorrectionAmountType))]
    [XmlInclude(typeof(CorporateStockAmountType))]
    [XmlInclude(typeof(ChargeTotalAmountType))]
    [XmlInclude(typeof(CallExtensionAmountType))]
    [XmlInclude(typeof(CallBaseAmountType))]
    [XmlInclude(typeof(BaseAmountType))]
    [XmlInclude(typeof(BalanceAmountType))]
    [XmlInclude(typeof(AverageSubsequentContractAmountType))]
    [XmlInclude(typeof(AverageAmountType))]
    [XmlInclude(typeof(AnnualAverageAmountType))]
    [XmlInclude(typeof(AmountType2))]
    [XmlInclude(typeof(AllowanceTotalAmountType))]
    [XmlInclude(typeof(AdvertisementAmountType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class AmountType
    {
        #region Private fields
        private string _currencyID;
        private string _currencyCodeListVersionID;
        private decimal _value;
        #endregion
        
        [XmlAttribute(DataType="normalizedString")]
        public string currencyID
        {
            get
            {
                return _currencyID;
            }
            set
            {
                _currencyID = value;
            }
        }
        
        [XmlAttribute(DataType="normalizedString")]
        public string currencyCodeListVersionID
        {
            get
            {
                return _currencyCodeListVersionID;
            }
            set
            {
                _currencyCodeListVersionID = value;
            }
        }
        
        [XmlTextAttribute]
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransactionCurrencyTaxAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalTaxAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalTaskAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalPaymentAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalInvoiceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalDebitAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalCreditAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalBalanceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ThresholdAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxableAmountType : AmountType1
    {
    }
       
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxEnergyOnAccountAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxEnergyBalanceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxEnergyAmountType : AmountType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SettlementDiscountAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RoundingAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequiredFeeAmountType : AmountType1
    {
    }
        
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrepaidAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PerUnitAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PenaltyAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PayableRoundingAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PayableAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PayableAlternativeAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartyCapacityAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaidAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumPaidAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumAdvertisementAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MarketValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LowerTenderAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LiabilityAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InventoryValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InsuranceValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InsurancePremiumAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HigherTenderAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FreeOnBoardValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FeeAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FaceValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedOverallContractAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DocumentationFeeAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeclaredStatisticsValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeclaredForCarriageValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeclaredCustomsValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeclaredCarriageValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DebitLineAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CreditLineAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CorrectionUnitAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CorrectionAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CorporateStockAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChargeTotalAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CallExtensionAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CallBaseAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BaseAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BalanceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AverageSubsequentContractAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AverageAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AnnualAverageAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="AmountType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AmountType2 : AmountType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdvertisementAmountType : AmountType1
    {
    }
    
        
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SourceCurrencyCodeType : CodeType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WorkPhaseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WeightingAlgorithmCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WeekDayCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidationResultCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class UtilityStatementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class UrgencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class UNDGCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportationStatusTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportServiceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportModeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportMeansTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportHandlingUnitTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportExecutionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportEventTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportEquipmentTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportEmergencyCardCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportAuthorizationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransitDirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TradeServiceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TradeItemPackingLabelingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TrackingDeviceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TimingComplaintCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TimeFrequencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ThresholdValueComparisonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TendererRoleCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TendererRequirementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TenderTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TenderResultCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TenderEnvelopeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelecommunicationsSupplyTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelecommunicationsServiceCategoryCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelecommunicationsServiceCallCodeType : CodeType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxExemptionReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TariffCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TariffClassCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TargetCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SupplyChainActivityTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubstitutionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubscriberTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubmissionMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubcontractingConditionsCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class StatusReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class StatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class StatementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SpecificationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SizeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ShortageActionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ShippingPriorityLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ServiceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ServiceInformationPreferenceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SecurityClassificationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SealStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SealIssuerTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RoleCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RevisionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RetailEventStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResponseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResolutionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResidenceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequestedInvoiceCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReminderTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RejectReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RejectActionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReferenceEventCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReceiptAdviceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class QuantityDiscrepancyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class QualityControlCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PurposeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProviderTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PromotionalEventTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProfileStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProcurementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProcurementSubTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProcessReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProcedureCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrivacyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PricingCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PriceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PriceEvaluationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreviousMeterReadingMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreviousCancellationReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreferenceCriterionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PositionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PerformanceMetricTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentPurposeCodeType : CodeType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentFrequencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentCurrencyCodeType : CodeType1
    {
    }
    

    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentAlternativeCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartyTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartPresentationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ParentDocumentTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PackingCriteriaCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PackagingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PackageLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PackLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OwnerTypeCodeType : CodeType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderResponseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OneTimeChargeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NotificationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NatureCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NameCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MiscellaneousEventTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MimeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeterReadingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeterConstantCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MedicalFirstAidGuideCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MathematicOperatorCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MandateTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LossRiskResponsibilityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LongitudeDirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LocationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LocaleCodeType : CodeType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LifeCycleStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatitudeDirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestMeterReadingMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ItemClassificationCodeType : CodeType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InspectionMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InhalationToxicityZoneCodeType : CodeType1
    {
    }
      
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ImportanceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class IdentificationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HeatingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HazardousRegulationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HazardousCategoryCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HandlingCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GuaranteeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GenderCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FundingProgramCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FullnessIndicationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FreightRateClassCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FormatCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ForecastTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ForecastPurposeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FinancingInstrumentCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FeatureTacticTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExpressionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExpenseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExemptionReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExecutionRequirementCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExceptionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExceptionResolutionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EvidenceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EvaluationCriterionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EnvironmentalEmissionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EncodingCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EmergencyProceduresCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DutyCodeType : CodeType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DocumentStatusReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DocumentStatusCodeType : CodeType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DispositionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DisplayTacticTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DespatchAdviceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DescriptionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeclarationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DataSourceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomsStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CurrentChargeTypeCodeType : CodeType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CreditNoteTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CountrySubentityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CorrectionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CorporateRegistrationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CoordinateSystemCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContractingSystemCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContractTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumersEnergyLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumerIncentiveTacticTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConstitutionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConditionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ComparisonDataSourceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ComparisonDataCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CompanyLiquidationStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CompanyLegalFormCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CommodityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CollaborationPriorityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CharacterSetCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChannelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CertificateTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CargoTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CardTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CardChipCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CapabilityTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CalculationMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CalculationExpressionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AwardingMethodTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AwardingCriterionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AvailabilityStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ApplicationStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AllowanceChargeReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdmissionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdjustmentReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AddressTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AddressFormatCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActivityTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AccountingCostCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AccountTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AccountFormatCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CalculationRateType : RateType
    {
    }
    
    [XmlInclude(typeof(TargetCurrencyBaseRateType))]
    [XmlInclude(typeof(SourceCurrencyBaseRateType))]
    [XmlInclude(typeof(RateType1))]
    [XmlInclude(typeof(OrderableUnitFactorRateType))]
    [XmlInclude(typeof(CalculationRateType))]
    [XmlInclude(typeof(AmountRateType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class RateType : NumericType
    {
    }
    
    [XmlInclude(typeof(RateType))]
    [XmlInclude(typeof(TargetCurrencyBaseRateType))]
    [XmlInclude(typeof(SourceCurrencyBaseRateType))]
    [XmlInclude(typeof(RateType1))]
    [XmlInclude(typeof(OrderableUnitFactorRateType))]
    [XmlInclude(typeof(CalculationRateType))]
    [XmlInclude(typeof(AmountRateType))]
    [XmlInclude(typeof(PercentType))]
    [XmlInclude(typeof(TierRatePercentType))]
    [XmlInclude(typeof(TargetServicePercentType))]
    [XmlInclude(typeof(SettlementDiscountPercentType))]
    [XmlInclude(typeof(ReliabilityPercentType))]
    [XmlInclude(typeof(ProgressPercentType))]
    [XmlInclude(typeof(PercentType1))]
    [XmlInclude(typeof(PenaltySurchargePercentType))]
    [XmlInclude(typeof(PaymentPercentType))]
    [XmlInclude(typeof(ParticipationPercentType))]
    [XmlInclude(typeof(PartecipationPercentType))]
    [XmlInclude(typeof(MinimumPercentType))]
    [XmlInclude(typeof(MaximumPercentType))]
    [XmlInclude(typeof(HumidityPercentType))]
    [XmlInclude(typeof(AirFlowPercentType))]
    [XmlInclude(typeof(ValueType1))]
    [XmlInclude(typeof(NumericType1))]
    [XmlInclude(typeof(WeightNumericType))]
    [XmlInclude(typeof(SequenceNumericType))]
    [XmlInclude(typeof(ResidentOccupantsNumericType))]
    [XmlInclude(typeof(ReminderSequenceNumericType))]
    [XmlInclude(typeof(PackSizeNumericType))]
    [XmlInclude(typeof(OrderQuantityIncrementNumericType))]
    [XmlInclude(typeof(OrderIntervalDaysNumericType))]
    [XmlInclude(typeof(MultiplierFactorNumericType))]
    [XmlInclude(typeof(MinimumNumberNumericType))]
    [XmlInclude(typeof(MaximumPaymentInstructionsNumericType))]
    [XmlInclude(typeof(MaximumNumberNumericType))]
    [XmlInclude(typeof(MaximumCopiesNumericType))]
    [XmlInclude(typeof(LineNumberNumericType))]
    [XmlInclude(typeof(LineCountNumericType))]
    [XmlInclude(typeof(FrozenPeriodDaysNumericType))]
    [XmlInclude(typeof(CalculationSequenceNumericType))]
    [XmlInclude(typeof(BudgetYearNumericType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class NumericType
    {
        #region Private fields
        private string _format;
        private decimal _value;
        #endregion
        
        [XmlAttribute]
        public string format
        {
            get
            {
                return _format;
            }
            set
            {
                _format = value;
            }
        }
        
        [XmlTextAttribute]
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [XmlInclude(typeof(TierRatePercentType))]
    [XmlInclude(typeof(TargetServicePercentType))]
    [XmlInclude(typeof(SettlementDiscountPercentType))]
    [XmlInclude(typeof(ReliabilityPercentType))]
    [XmlInclude(typeof(ProgressPercentType))]
    [XmlInclude(typeof(PercentType1))]
    [XmlInclude(typeof(PenaltySurchargePercentType))]
    [XmlInclude(typeof(PaymentPercentType))]
    [XmlInclude(typeof(ParticipationPercentType))]
    [XmlInclude(typeof(PartecipationPercentType))]
    [XmlInclude(typeof(MinimumPercentType))]
    [XmlInclude(typeof(MaximumPercentType))]
    [XmlInclude(typeof(HumidityPercentType))]
    [XmlInclude(typeof(AirFlowPercentType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class PercentType : NumericType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TierRatePercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TargetServicePercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SettlementDiscountPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReliabilityPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProgressPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="PercentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PercentType1 : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PenaltySurchargePercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ParticipationPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartecipationPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HumidityPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AirFlowPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="ValueType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class ValueType1 : NumericType
    {
    }
    
    [XmlInclude(typeof(WeightNumericType))]
    [XmlInclude(typeof(SequenceNumericType))]
    [XmlInclude(typeof(ResidentOccupantsNumericType))]
    [XmlInclude(typeof(ReminderSequenceNumericType))]
    [XmlInclude(typeof(PackSizeNumericType))]
    [XmlInclude(typeof(OrderQuantityIncrementNumericType))]
    [XmlInclude(typeof(OrderIntervalDaysNumericType))]
    [XmlInclude(typeof(MultiplierFactorNumericType))]
    [XmlInclude(typeof(MinimumNumberNumericType))]
    [XmlInclude(typeof(MaximumPaymentInstructionsNumericType))]
    [XmlInclude(typeof(MaximumNumberNumericType))]
    [XmlInclude(typeof(MaximumCopiesNumericType))]
    [XmlInclude(typeof(LineNumberNumericType))]
    [XmlInclude(typeof(LineCountNumericType))]
    [XmlInclude(typeof(FrozenPeriodDaysNumericType))]
    [XmlInclude(typeof(CalculationSequenceNumericType))]
    [XmlInclude(typeof(BudgetYearNumericType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="NumericType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class NumericType1 : NumericType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WeightNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SequenceNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResidentOccupantsNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReminderSequenceNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PackSizeNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderQuantityIncrementNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderIntervalDaysNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MultiplierFactorNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumNumberNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumPaymentInstructionsNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumNumberNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumCopiesNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LineNumberNumericType : NumericType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FrozenPeriodDaysNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CalculationSequenceNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BudgetYearNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TargetCurrencyBaseRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SourceCurrencyBaseRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="RateType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RateType1 : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderableUnitFactorRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AmountRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="DateType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DateType1 : DateType
    {
    }
    
        
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidityStartDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxPointDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubmissionDueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubmissionDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class StartDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SourceForecastIssueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RevisionDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResponseDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResolutionDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequiredDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequestedPublicationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequestedDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequestedDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegistrationExpirationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegistrationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegisteredDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReferenceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReceivedDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreviousMeterReadingDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PlannedDateType : DateType
    {
    }
           
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaidDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OccurrenceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NominationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ManufactureDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestSecurityClearanceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestProposalAcceptanceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestPickupDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestMeterReadingDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LastRevisionDateType : DateType
    {
    }
    
        
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InstallmentDueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GuaranteedDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FirstShipmentAvailibilityDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExpiryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EndDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EffectiveDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EarliestPickupDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ComparisonForecastIssueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CallDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BirthDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BestBeforeDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AwardDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AvailabilityDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ApprovalDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActualPickupDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActualDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActualDeliveryDateType : DateType
    {
    }         
    
    [XmlInclude(typeof(VesselNameType))]
    [XmlInclude(typeof(TechnicalNameType))]
    [XmlInclude(typeof(StreetNameType))]
    [XmlInclude(typeof(ServiceNameType))]
    [XmlInclude(typeof(RoamingPartnerNameType))]
    [XmlInclude(typeof(RetailEventNameType))]
    [XmlInclude(typeof(RegistrationNameType))]
    [XmlInclude(typeof(OtherNameType))]
    [XmlInclude(typeof(NameType1))]
    [XmlInclude(typeof(ModelNameType))]
    [XmlInclude(typeof(MiddleNameType))]
    [XmlInclude(typeof(HolderNameType))]
    [XmlInclude(typeof(FirstNameType))]
    [XmlInclude(typeof(FileNameType))]
    [XmlInclude(typeof(FamilyNameType))]
    [XmlInclude(typeof(CitySubdivisionNameType))]
    [XmlInclude(typeof(CityNameType))]
    [XmlInclude(typeof(CategoryNameType))]
    [XmlInclude(typeof(BuildingNameType))]
    [XmlInclude(typeof(BrandNameType))]
    [XmlInclude(typeof(BlockNameType))]
    [XmlInclude(typeof(AliasNameType))]
    [XmlInclude(typeof(AdditionalStreetNameType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class NameType : TextType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class VesselNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TechnicalNameType : NameType
    {
    }
            
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ServiceNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RoamingPartnerNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RetailEventNameType : NameType
    {
    }   
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OtherNameType : NameType
    {
    }
      
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MiddleNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HolderNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FirstNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FileNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FamilyNameType : NameType
    {
    }   
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CategoryNameType : NameType
    {
    }
       
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AliasNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdditionalStreetNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionAgencyNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class XPathType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WorkPhaseType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WeightType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class WarrantyInformationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValueQualifierType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidateToolVersionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidateToolType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidateProcessType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportationServiceDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportUserSpecialTermsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportUserRemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportServiceProviderSpecialTermsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportServiceProviderRemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TradingRestrictionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TitleType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TimingComplaintType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TimezoneOffsetType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TimeAmountType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TierRangeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="TextType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TextType2 : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TestMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelephoneType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelefaxType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelecommunicationsSupplyTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelecommunicationsServiceCategoryType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TelecommunicationsServiceCallType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TechnicalCommitteeDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxExemptionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TariffDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SummaryDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubscriberTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class StatusReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SpecialTransportRequirementsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SpecialTermsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SpecialServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SpecialInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SignatureMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ShipsRequirementsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ShippingMarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ServiceTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ServiceNumberCalledType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SealingPartyTypeType : TextType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RoleDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResolutionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResidenceTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReplenishmentOwnerDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RejectionNoteType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RejectReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegulatoryDomainType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegistrationNationalityType : TextType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RankType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PurposeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProcessReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProcessDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrizeDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PriorityType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrintQualifierType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PriceTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PriceRevisionFormulaDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PriceChangeReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreviousMeterReadingMethodType : TextType1
    {
    }
       
  
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PlotIdentificationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PlacardNotationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PlacardEndorsementType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PhoneNumberType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PersonalSituationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentOrderReferenceType : TextType1
    {
    }   
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PayerReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PayPerViewType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PasswordType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartyTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PackingMaterialType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OutstandingReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OtherInstructionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrganizationDepartmentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderableUnitType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OptionsDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OneTimeChargeTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NegotiationDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NameSuffixType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MovieTitleType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MonetaryScopeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumImprovementBidType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeterReadingTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeterReadingCommentsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeterNumberType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeterNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeterConstantType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MarkCareType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MarkAttentionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LowTendersDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LossRiskType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LoginType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LocationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ListValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LineType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LimitationDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LegalReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestMeterReadingMethodType : TextType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class JustificationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class JustificationDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class JobTitleType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InvoicingPartyReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InstructionsType : TextType1
    {
    }
    

    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InhouseMailType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InformationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HeatingTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HaulageInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HashAlgorithmMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HandlingInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FundingProgramType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FrequencyType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ForwarderServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FloorType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FeeDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExtensionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExpressionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExemptionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExclusionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ElectronicMailType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ElectronicDeviceDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DutyType : TextType1
    {
    }
          
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DocumentStatusReasonDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DocumentHashType : TextType1
    {
    }       
   
   
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DepartmentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DemurrageInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeliveryInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DataSendingCapabilityType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DamageRemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomsClearanceServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomerReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CurrentChargeTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CountrySubentityType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CorrectionTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContractTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContractSubdivisionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContractNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionLevelType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumersEnergyLevelType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConditionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConditionsDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConditionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CompanyLegalFormType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CommentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CodeValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CharacteristicsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChannelType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChangeConditionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CertificateTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CarrierServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CanonicalizationMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CandidateStatementType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CancellationNoteType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CalculationExpressionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BuyerReferenceType : TextType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BirthplaceNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BackorderReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AwardingCriterionDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ApprovalStatusType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AllowanceChargeReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AgencyNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdditionalInformationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdditionalConditionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActivityTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AccountingCostType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AcceptedVariantsDescriptionType : TextType1
    {
    }
       
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class StartTimeType : TimeType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidationTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SourceForecastIssueTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RevisionTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResponseTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ResolutionTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequiredDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequestedDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegisteredTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReferenceTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaidTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OccurrenceTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NominationTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ManufactureTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestPickupTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LastRevisionTimeType : TimeType
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GuaranteedDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExpiryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EndTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EffectiveTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EarliestPickupTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ComparisonForecastIssueTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CallTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AwardTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActualPickupTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActualDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActualDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DurationMeasureType : MeasureType1
    {
    }
    
    [XmlInclude(typeof(ValueMeasureType))]
    [XmlInclude(typeof(TareWeightMeasureType))]
    [XmlInclude(typeof(SourceValueMeasureType))]
    [XmlInclude(typeof(PreEventNotificationDurationMeasureType))]
    [XmlInclude(typeof(PostEventNotificationDurationMeasureType))]
    [XmlInclude(typeof(NetWeightMeasureType))]
    [XmlInclude(typeof(NetVolumeMeasureType))]
    [XmlInclude(typeof(NetTonnageMeasureType))]
    [XmlInclude(typeof(NetNetWeightMeasureType))]
    [XmlInclude(typeof(MinimumMeasureType))]
    [XmlInclude(typeof(MeasureType2))]
    [XmlInclude(typeof(MaximumMeasureType))]
    [XmlInclude(typeof(LongitudeMinutesMeasureType))]
    [XmlInclude(typeof(LongitudeDegreesMeasureType))]
    [XmlInclude(typeof(LoadingLengthMeasureType))]
    [XmlInclude(typeof(LeadTimeMeasureType))]
    [XmlInclude(typeof(LatitudeMinutesMeasureType))]
    [XmlInclude(typeof(LatitudeDegreesMeasureType))]
    [XmlInclude(typeof(GrossWeightMeasureType))]
    [XmlInclude(typeof(GrossVolumeMeasureType))]
    [XmlInclude(typeof(GrossTonnageMeasureType))]
    [XmlInclude(typeof(DurationMeasureType))]
    [XmlInclude(typeof(ComparedValueMeasureType))]
    [XmlInclude(typeof(ChargeableWeightMeasureType))]
    [XmlInclude(typeof(BaseUnitMeasureType))]
    [XmlInclude(typeof(AltitudeMeasureType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="MeasureType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class MeasureType1 : MeasureType
    {
    }
    
    [XmlInclude(typeof(MeasureType1))]
    [XmlInclude(typeof(ValueMeasureType))]
    [XmlInclude(typeof(TareWeightMeasureType))]
    [XmlInclude(typeof(SourceValueMeasureType))]
    [XmlInclude(typeof(PreEventNotificationDurationMeasureType))]
    [XmlInclude(typeof(PostEventNotificationDurationMeasureType))]
    [XmlInclude(typeof(NetWeightMeasureType))]
    [XmlInclude(typeof(NetVolumeMeasureType))]
    [XmlInclude(typeof(NetTonnageMeasureType))]
    [XmlInclude(typeof(NetNetWeightMeasureType))]
    [XmlInclude(typeof(MinimumMeasureType))]
    [XmlInclude(typeof(MeasureType2))]
    [XmlInclude(typeof(MaximumMeasureType))]
    [XmlInclude(typeof(LongitudeMinutesMeasureType))]
    [XmlInclude(typeof(LongitudeDegreesMeasureType))]
    [XmlInclude(typeof(LoadingLengthMeasureType))]
    [XmlInclude(typeof(LeadTimeMeasureType))]
    [XmlInclude(typeof(LatitudeMinutesMeasureType))]
    [XmlInclude(typeof(LatitudeDegreesMeasureType))]
    [XmlInclude(typeof(GrossWeightMeasureType))]
    [XmlInclude(typeof(GrossVolumeMeasureType))]
    [XmlInclude(typeof(GrossTonnageMeasureType))]
    [XmlInclude(typeof(DurationMeasureType))]
    [XmlInclude(typeof(ComparedValueMeasureType))]
    [XmlInclude(typeof(ChargeableWeightMeasureType))]
    [XmlInclude(typeof(BaseUnitMeasureType))]
    [XmlInclude(typeof(AltitudeMeasureType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class MeasureType
    {
        #region Private fields
        private string _unitCode;
        private string _unitCodeListVersionID;
        private decimal _value;
        #endregion
        
        [XmlAttribute(DataType="normalizedString")]
        public string unitCode
        {
            get
            {
                return _unitCode;
            }
            set
            {
                _unitCode = value;
            }
        }
        
        [XmlAttribute(DataType="normalizedString")]
        public string unitCodeListVersionID
        {
            get
            {
                return _unitCodeListVersionID;
            }
            set
            {
                _unitCodeListVersionID = value;
            }
        }
        
        [XmlTextAttribute]
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValueMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TareWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SourceValueMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreEventNotificationDurationMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PostEventNotificationDurationMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NetWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NetVolumeMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NetTonnageMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NetNetWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="MeasureType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MeasureType2 : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LongitudeMinutesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LongitudeDegreesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LoadingLengthMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LeadTimeMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatitudeMinutesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatitudeDegreesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GrossWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GrossVolumeMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GrossTonnageMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ComparedValueMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChargeableWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BaseUnitMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AltitudeMeasureType : MeasureType1
    {
    }
       
    

        
    
    [XmlInclude(typeof(ReferencedSignatureIDType))]
    [XmlInclude(typeof(ExtensionVersionIDType))]
    [XmlInclude(typeof(ExtensionURIType))]
    [XmlInclude(typeof(ExtensionAgencyURIType))]
    [XmlInclude(typeof(ExtensionAgencyIDType))]
    [XmlInclude(typeof(WebsiteURIType))]
    [XmlInclude(typeof(VesselIDType))]
    [XmlInclude(typeof(VersionIDType))]
    [XmlInclude(typeof(VariantIDType))]
    [XmlInclude(typeof(ValidatorIDType))]
    [XmlInclude(typeof(UpperOrangeHazardPlacardIDType))]
    [XmlInclude(typeof(UUIDType))]
    [XmlInclude(typeof(URIType))]
    [XmlInclude(typeof(UBLVersionIDType))]
    [XmlInclude(typeof(TransportationServiceDetailsURIType))]
    [XmlInclude(typeof(TransportExecutionPlanReferenceIDType))]
    [XmlInclude(typeof(TrainIDType))]
    [XmlInclude(typeof(TrackingIDType))]
    [XmlInclude(typeof(TraceIDType))]
    [XmlInclude(typeof(TenderEnvelopeIDType))]
    [XmlInclude(typeof(SupplierAssignedAccountIDType))]
    [XmlInclude(typeof(SuccessiveSequenceIDType))]
    [XmlInclude(typeof(SubscriberIDType))]
    [XmlInclude(typeof(SpecificationIDType))]
    [XmlInclude(typeof(SignatureIDType))]
    [XmlInclude(typeof(ShippingOrderIDType))]
    [XmlInclude(typeof(SerialIDType))]
    [XmlInclude(typeof(SequenceNumberIDType))]
    [XmlInclude(typeof(SequenceIDType))]
    [XmlInclude(typeof(SellerEventIDType))]
    [XmlInclude(typeof(SecurityIDType))]
    [XmlInclude(typeof(SchemeURIType))]
    [XmlInclude(typeof(SalesOrderLineIDType))]
    [XmlInclude(typeof(SalesOrderIDType))]
    [XmlInclude(typeof(RevisedForecastLineIDType))]
    [XmlInclude(typeof(RequiredCustomsIDType))]
    [XmlInclude(typeof(RequestForQuotationLineIDType))]
    [XmlInclude(typeof(ReleaseIDType))]
    [XmlInclude(typeof(RegistrationNationalityIDType))]
    [XmlInclude(typeof(RegistrationIDType))]
    [XmlInclude(typeof(ReferencedConsignmentIDType))]
    [XmlInclude(typeof(ReferenceIDType))]
    [XmlInclude(typeof(RailCarIDType))]
    [XmlInclude(typeof(RadioCallSignIDType))]
    [XmlInclude(typeof(ProfileIDType))]
    [XmlInclude(typeof(ProfileExecutionIDType))]
    [XmlInclude(typeof(ProductTraceIDType))]
    [XmlInclude(typeof(PrimaryAccountNumberIDType))]
    [XmlInclude(typeof(PreviousVersionIDType))]
    [XmlInclude(typeof(PreviousJobIDType))]
    [XmlInclude(typeof(PrepaidPaymentReferenceIDType))]
    [XmlInclude(typeof(PerformingCarrierAssignedIDType))]
    [XmlInclude(typeof(PaymentTermsDetailsURIType))]
    [XmlInclude(typeof(PaymentMeansIDType))]
    [XmlInclude(typeof(PaymentIDType))]
    [XmlInclude(typeof(ParentDocumentVersionIDType))]
    [XmlInclude(typeof(ParentDocumentLineReferenceIDType))]
    [XmlInclude(typeof(ParentDocumentIDType))]
    [XmlInclude(typeof(OriginalJobIDType))]
    [XmlInclude(typeof(OriginalContractingSystemIDType))]
    [XmlInclude(typeof(OpenTenderIDType))]
    [XmlInclude(typeof(OntologyURIType))]
    [XmlInclude(typeof(NetworkIDType))]
    [XmlInclude(typeof(NationalityIDType))]
    [XmlInclude(typeof(MarkingIDType))]
    [XmlInclude(typeof(LowerOrangeHazardPlacardIDType))]
    [XmlInclude(typeof(LotNumberIDType))]
    [XmlInclude(typeof(LogoReferenceIDType))]
    [XmlInclude(typeof(LocationIDType))]
    [XmlInclude(typeof(LoadingSequenceIDType))]
    [XmlInclude(typeof(LineIDType))]
    [XmlInclude(typeof(LicensePlateIDType))]
    [XmlInclude(typeof(LanguageIDType))]
    [XmlInclude(typeof(JourneyIDType))]
    [XmlInclude(typeof(IssuerIDType))]
    [XmlInclude(typeof(IssueNumberIDType))]
    [XmlInclude(typeof(InstructionIDType))]
    [XmlInclude(typeof(InformationURIType))]
    [XmlInclude(typeof(ImmobilizationCertificateIDType))]
    [XmlInclude(typeof(IdentificationIDType))]
    [XmlInclude(typeof(IDType))]
    [XmlInclude(typeof(HazardClassIDType))]
    [XmlInclude(typeof(FreightForwarderAssignedIDType))]
    [XmlInclude(typeof(ExtendedIDType))]
    [XmlInclude(typeof(ExchangeMarketIDType))]
    [XmlInclude(typeof(EndpointIDType))]
    [XmlInclude(typeof(EconomicOperatorRegistryURIType))]
    [XmlInclude(typeof(DocumentIDType))]
    [XmlInclude(typeof(CustomizationIDType))]
    [XmlInclude(typeof(CustomerAssignedAccountIDType))]
    [XmlInclude(typeof(ContractedCarrierAssignedIDType))]
    [XmlInclude(typeof(ContractFolderIDType))]
    [XmlInclude(typeof(ConsumptionReportIDType))]
    [XmlInclude(typeof(ConsumptionIDType))]
    [XmlInclude(typeof(ConsignorAssignedIDType))]
    [XmlInclude(typeof(ConsigneeAssignedIDType))]
    [XmlInclude(typeof(CompanyIDType))]
    [XmlInclude(typeof(ChipApplicationIDType))]
    [XmlInclude(typeof(CarrierAssignedIDType))]
    [XmlInclude(typeof(CV2IDType))]
    [XmlInclude(typeof(BuyerProfileURIType))]
    [XmlInclude(typeof(BuyerEventIDType))]
    [XmlInclude(typeof(BusinessIdentityEvidenceIDType))]
    [XmlInclude(typeof(BusinessClassificationEvidenceIDType))]
    [XmlInclude(typeof(BrokerAssignedIDType))]
    [XmlInclude(typeof(BarcodeSymbologyIDType))]
    [XmlInclude(typeof(AwardingCriterionIDType))]
    [XmlInclude(typeof(AuctionURIType))]
    [XmlInclude(typeof(AttributeIDType))]
    [XmlInclude(typeof(AircraftIDType))]
    [XmlInclude(typeof(AgencyIDType))]
    [XmlInclude(typeof(AdditionalAccountIDType))]
    [XmlInclude(typeof(AccountIDType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="IdentifierType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class IdentifierType1 : IdentifierType
    {
    }
    
    [XmlInclude(typeof(IdentifierType1))]
    [XmlInclude(typeof(ReferencedSignatureIDType))]
    [XmlInclude(typeof(ExtensionVersionIDType))]
    [XmlInclude(typeof(ExtensionURIType))]
    [XmlInclude(typeof(ExtensionAgencyURIType))]
    [XmlInclude(typeof(ExtensionAgencyIDType))]
    [XmlInclude(typeof(WebsiteURIType))]
    [XmlInclude(typeof(VesselIDType))]
    [XmlInclude(typeof(VersionIDType))]
    [XmlInclude(typeof(VariantIDType))]
    [XmlInclude(typeof(ValidatorIDType))]
    [XmlInclude(typeof(UpperOrangeHazardPlacardIDType))]
    [XmlInclude(typeof(UUIDType))]
    [XmlInclude(typeof(URIType))]
    [XmlInclude(typeof(UBLVersionIDType))]
    [XmlInclude(typeof(TransportationServiceDetailsURIType))]
    [XmlInclude(typeof(TransportExecutionPlanReferenceIDType))]
    [XmlInclude(typeof(TrainIDType))]
    [XmlInclude(typeof(TrackingIDType))]
    [XmlInclude(typeof(TraceIDType))]
    [XmlInclude(typeof(TenderEnvelopeIDType))]
    [XmlInclude(typeof(SupplierAssignedAccountIDType))]
    [XmlInclude(typeof(SuccessiveSequenceIDType))]
    [XmlInclude(typeof(SubscriberIDType))]
    [XmlInclude(typeof(SpecificationIDType))]
    [XmlInclude(typeof(SignatureIDType))]
    [XmlInclude(typeof(ShippingOrderIDType))]
    [XmlInclude(typeof(SerialIDType))]
    [XmlInclude(typeof(SequenceNumberIDType))]
    [XmlInclude(typeof(SequenceIDType))]
    [XmlInclude(typeof(SellerEventIDType))]
    [XmlInclude(typeof(SecurityIDType))]
    [XmlInclude(typeof(SchemeURIType))]
    [XmlInclude(typeof(SalesOrderLineIDType))]
    [XmlInclude(typeof(SalesOrderIDType))]
    [XmlInclude(typeof(RevisedForecastLineIDType))]
    [XmlInclude(typeof(RequiredCustomsIDType))]
    [XmlInclude(typeof(RequestForQuotationLineIDType))]
    [XmlInclude(typeof(ReleaseIDType))]
    [XmlInclude(typeof(RegistrationNationalityIDType))]
    [XmlInclude(typeof(RegistrationIDType))]
    [XmlInclude(typeof(ReferencedConsignmentIDType))]
    [XmlInclude(typeof(ReferenceIDType))]
    [XmlInclude(typeof(RailCarIDType))]
    [XmlInclude(typeof(RadioCallSignIDType))]
    [XmlInclude(typeof(ProfileIDType))]
    [XmlInclude(typeof(ProfileExecutionIDType))]
    [XmlInclude(typeof(ProductTraceIDType))]
    [XmlInclude(typeof(PrimaryAccountNumberIDType))]
    [XmlInclude(typeof(PreviousVersionIDType))]
    [XmlInclude(typeof(PreviousJobIDType))]
    [XmlInclude(typeof(PrepaidPaymentReferenceIDType))]
    [XmlInclude(typeof(PerformingCarrierAssignedIDType))]
    [XmlInclude(typeof(PaymentTermsDetailsURIType))]
    [XmlInclude(typeof(PaymentMeansIDType))]
    [XmlInclude(typeof(PaymentIDType))]
    [XmlInclude(typeof(ParentDocumentVersionIDType))]
    [XmlInclude(typeof(ParentDocumentLineReferenceIDType))]
    [XmlInclude(typeof(ParentDocumentIDType))]
    [XmlInclude(typeof(OriginalJobIDType))]
    [XmlInclude(typeof(OriginalContractingSystemIDType))]
    [XmlInclude(typeof(OpenTenderIDType))]
    [XmlInclude(typeof(OntologyURIType))]
    [XmlInclude(typeof(NetworkIDType))]
    [XmlInclude(typeof(NationalityIDType))]
    [XmlInclude(typeof(MarkingIDType))]
    [XmlInclude(typeof(LowerOrangeHazardPlacardIDType))]
    [XmlInclude(typeof(LotNumberIDType))]
    [XmlInclude(typeof(LogoReferenceIDType))]
    [XmlInclude(typeof(LocationIDType))]
    [XmlInclude(typeof(LoadingSequenceIDType))]
    [XmlInclude(typeof(LineIDType))]
    [XmlInclude(typeof(LicensePlateIDType))]
    [XmlInclude(typeof(LanguageIDType))]
    [XmlInclude(typeof(JourneyIDType))]
    [XmlInclude(typeof(IssuerIDType))]
    [XmlInclude(typeof(IssueNumberIDType))]
    [XmlInclude(typeof(InstructionIDType))]
    [XmlInclude(typeof(InformationURIType))]
    [XmlInclude(typeof(ImmobilizationCertificateIDType))]
    [XmlInclude(typeof(IdentificationIDType))]
    [XmlInclude(typeof(IDType))]
    [XmlInclude(typeof(HazardClassIDType))]
    [XmlInclude(typeof(FreightForwarderAssignedIDType))]
    [XmlInclude(typeof(ExtendedIDType))]
    [XmlInclude(typeof(ExchangeMarketIDType))]
    [XmlInclude(typeof(EndpointIDType))]
    [XmlInclude(typeof(EconomicOperatorRegistryURIType))]
    [XmlInclude(typeof(DocumentIDType))]
    [XmlInclude(typeof(CustomizationIDType))]
    [XmlInclude(typeof(CustomerAssignedAccountIDType))]
    [XmlInclude(typeof(ContractedCarrierAssignedIDType))]
    [XmlInclude(typeof(ContractFolderIDType))]
    [XmlInclude(typeof(ConsumptionReportIDType))]
    [XmlInclude(typeof(ConsumptionIDType))]
    [XmlInclude(typeof(ConsignorAssignedIDType))]
    [XmlInclude(typeof(ConsigneeAssignedIDType))]
    [XmlInclude(typeof(CompanyIDType))]
    [XmlInclude(typeof(ChipApplicationIDType))]
    [XmlInclude(typeof(CarrierAssignedIDType))]
    [XmlInclude(typeof(CV2IDType))]
    [XmlInclude(typeof(BuyerProfileURIType))]
    [XmlInclude(typeof(BuyerEventIDType))]
    [XmlInclude(typeof(BusinessIdentityEvidenceIDType))]
    [XmlInclude(typeof(BusinessClassificationEvidenceIDType))]
    [XmlInclude(typeof(BrokerAssignedIDType))]
    [XmlInclude(typeof(BarcodeSymbologyIDType))]
    [XmlInclude(typeof(AwardingCriterionIDType))]
    [XmlInclude(typeof(AuctionURIType))]
    [XmlInclude(typeof(AttributeIDType))]
    [XmlInclude(typeof(AircraftIDType))]
    [XmlInclude(typeof(AgencyIDType))]
    [XmlInclude(typeof(AdditionalAccountIDType))]
    [XmlInclude(typeof(AccountIDType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class IdentifierType
    {
        #region Private fields
        private string _schemeID;
        private string _schemeName;
        private string _schemeAgencyID;
        private string _schemeAgencyName;
        private string _schemeVersionID;
        private string _schemeDataURI;
        private string _schemeURI;
        private string _value;
        #endregion
        
        [XmlAttribute(DataType="normalizedString")]
        public string schemeID
        {
            get
            {
                return _schemeID;
            }
            set
            {
                _schemeID = value;
            }
        }
        
        [XmlAttribute]
        public string schemeName
        {
            get
            {
                return _schemeName;
            }
            set
            {
                _schemeName = value;
            }
        }
        
        [XmlAttribute(DataType="normalizedString")]
        public string schemeAgencyID
        {
            get
            {
                return _schemeAgencyID;
            }
            set
            {
                _schemeAgencyID = value;
            }
        }
        
        [XmlAttribute]
        public string schemeAgencyName
        {
            get
            {
                return _schemeAgencyName;
            }
            set
            {
                _schemeAgencyName = value;
            }
        }
        
        [XmlAttribute(DataType="normalizedString")]
        public string schemeVersionID
        {
            get
            {
                return _schemeVersionID;
            }
            set
            {
                _schemeVersionID = value;
            }
        }
        
        [XmlAttribute(DataType="anyURI")]
        public string schemeDataURI
        {
            get
            {
                return _schemeDataURI;
            }
            set
            {
                _schemeDataURI = value;
            }
        }
        
        [XmlAttribute(DataType="anyURI")]
        public string schemeURI
        {
            get
            {
                return _schemeURI;
            }
            set
            {
                _schemeURI = value;
            }
        }
        
        [XmlTextAttribute(DataType="normalizedString")]
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
    public class ReferencedSignatureIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionVersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionAgencyURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public class ExtensionAgencyIDType : IdentifierType1
    {
    }
        
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class VesselIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class VersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class VariantIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValidatorIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class UpperOrangeHazardPlacardIDType : IdentifierType1
    {
    }
            
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class URIType : IdentifierType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportationServiceDetailsURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TransportExecutionPlanReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TrainIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TrackingIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TraceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TenderEnvelopeIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SupplierAssignedAccountIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SuccessiveSequenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SubscriberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SpecificationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SignatureIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ShippingOrderIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SerialIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SequenceNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SequenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SellerEventIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SecurityIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SchemeURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SalesOrderLineIDType : IdentifierType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RevisedForecastLineIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequiredCustomsIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequestForQuotationLineIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReleaseIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegistrationNationalityIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RegistrationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReferencedConsignmentIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RailCarIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RadioCallSignIDType : IdentifierType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProfileExecutionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ProductTraceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrimaryAccountNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreviousVersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreviousJobIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrepaidPaymentReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PerformingCarrierAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentTermsDetailsURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentMeansIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PaymentIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ParentDocumentVersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ParentDocumentLineReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ParentDocumentIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OriginalJobIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OriginalContractingSystemIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OpenTenderIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OntologyURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NetworkIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NationalityIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MarkingIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LowerOrangeHazardPlacardIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LotNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LogoReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LocationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LoadingSequenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LineIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LicensePlateIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LanguageIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class JourneyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class IssuerIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class IssueNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InstructionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class InformationURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ImmobilizationCertificateIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class IdentificationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HazardClassIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FreightForwarderAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExtendedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExchangeMarketIDType : IdentifierType1
    {
    }
   
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EconomicOperatorRegistryURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DocumentIDType : IdentifierType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomerAssignedAccountIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContractedCarrierAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContractFolderIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionReportIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsignorAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsigneeAssignedIDType : IdentifierType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChipApplicationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CarrierAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CV2IDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BuyerProfileURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BuyerEventIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BusinessIdentityEvidenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BusinessClassificationEvidenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BrokerAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BarcodeSymbologyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AwardingCriterionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AuctionURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AttributeIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AircraftIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AgencyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdditionalAccountIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AccountIDType : IdentifierType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class FinancialInstitutionType
    {
        #region Private fields
        private NameType1 _name;
        #endregion
        
        public FinancialInstitutionType()
        {
            _name = new NameType1();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public NameType1 Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class CustomsDeclarationType
    {
        #region Private fields
        private IDType _id;
        private PartyType _issuerParty;
        #endregion
        
        public CustomsDeclarationType()
        {
            _issuerParty = new PartyType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Order=1)]
        public PartyType IssuerParty
        {
            get
            {
                return _issuerParty;
            }
            set
            {
                _issuerParty = value;
            }
        }
    }
                         
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="LocationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class LocationType1
    {
        #region Private fields
        private IDType _id;
        private AddressType _address;
        #endregion
        
        public LocationType1()
        {
            _address = new AddressType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Order=1)]
        public AddressType Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
    }
    
    
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PartyLegalEntityType
    {
        #region Private fields
        private RegistrationNameType _registrationName;
        private CompanyIDType _companyID;
        private RegistrationDateType _registrationDate;
        private SoleProprietorshipIndicatorType _soleProprietorshipIndicator;
        private CorporateStockAmountType _corporateStockAmount;
        private FullyPaidSharesIndicatorType _fullyPaidSharesIndicator;
        private CorporateRegistrationSchemeType _corporateRegistrationScheme;
        private PartyType _headOfficeParty;
        #endregion
        
        public PartyLegalEntityType()
        {
            _headOfficeParty = new PartyType();
            _corporateRegistrationScheme = new CorporateRegistrationSchemeType();
            _fullyPaidSharesIndicator = new FullyPaidSharesIndicatorType();
            _corporateStockAmount = new CorporateStockAmountType();
            _soleProprietorshipIndicator = new SoleProprietorshipIndicatorType();
            _registrationDate = new RegistrationDateType();
            _companyID = new CompanyIDType();
            _registrationName = new RegistrationNameType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public RegistrationNameType RegistrationName
        {
            get
            {
                return _registrationName;
            }
            set
            {
                _registrationName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public CompanyIDType CompanyID
        {
            get
            {
                return _companyID;
            }
            set
            {
                _companyID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public RegistrationDateType RegistrationDate
        {
            get
            {
                return _registrationDate;
            }
            set
            {
                _registrationDate = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public SoleProprietorshipIndicatorType SoleProprietorshipIndicator
        {
            get
            {
                return _soleProprietorshipIndicator;
            }
            set
            {
                _soleProprietorshipIndicator = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public CorporateStockAmountType CorporateStockAmount
        {
            get
            {
                return _corporateStockAmount;
            }
            set
            {
                _corporateStockAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public FullyPaidSharesIndicatorType FullyPaidSharesIndicator
        {
            get
            {
                return _fullyPaidSharesIndicator;
            }
            set
            {
                _fullyPaidSharesIndicator = value;
            }
        }
        
        [XmlElement(Order=6)]
        public CorporateRegistrationSchemeType CorporateRegistrationScheme
        {
            get
            {
                return _corporateRegistrationScheme;
            }
            set
            {
                _corporateRegistrationScheme = value;
            }
        }
        
        [XmlElement(Order=7)]
        public PartyType HeadOfficeParty
        {
            get
            {
                return _headOfficeParty;
            }
            set
            {
                _headOfficeParty = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SoleProprietorshipIndicatorType : IndicatorType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class VariantConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class UnknownPriceIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ToOrderIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ThirdPartyPayerIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxIncludedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TaxEvidenceIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class StatusAvailableIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SplitConsignmentIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SpecialSecurityIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReturnableMaterialIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReturnabilityIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RequiredCurriculaIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RefrigerationOnIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RefrigeratedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PublishAwardIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrizeIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PricingUpdateRequestIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PrepaidIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreCarriageIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PowerIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PartialDeliveryIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OtherConditionsIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OrderableIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OptionalLineItemIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OnCarriageIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MarkCareIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MarkAttentionIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LivestockIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LegalStatusIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ItemUpdateRequestIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class IndicationIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HumanFoodIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HumanFoodApprovedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class HazardousRiskIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GovernmentAgreementConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GeneralCargoIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FullyPaidSharesIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FrozenDocumentIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FreeOfChargeIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class FollowupContractIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DangerousGoodsApprovedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomsImportClassifiedIndicatorType : IndicatorType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContainerizedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsolidatableIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CompletionIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChargeIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CatalogueIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CandidateReductionConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BulkCargoIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BindingOnBuyerIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BasedOnConsensusIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BalanceBroughtForwardIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BackOrderAllowedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AuctionConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AnimalFoodIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AnimalFoodApprovedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AdValoremIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class AcceptedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class CorporateRegistrationSchemeType
    {
        #region Private fields
        private IDType _id;
        private NameType1 _name;
        private CorporateRegistrationTypeCodeType _corporateRegistrationTypeCode;
        private List<AddressType> _jurisdictionRegionAddress;
        #endregion
        
        public CorporateRegistrationSchemeType()
        {
            _jurisdictionRegionAddress = new List<AddressType>();
            _corporateRegistrationTypeCode = new CorporateRegistrationTypeCodeType();
            _name = new NameType1();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public NameType1 Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public CorporateRegistrationTypeCodeType CorporateRegistrationTypeCode
        {
            get
            {
                return _corporateRegistrationTypeCode;
            }
            set
            {
                _corporateRegistrationTypeCode = value;
            }
        }
        
        [XmlElement("JurisdictionRegionAddress", Order=3)]
        public List<AddressType> JurisdictionRegionAddress
        {
            get
            {
                return _jurisdictionRegionAddress;
            }
            set
            {
                _jurisdictionRegionAddress = value;
            }
        }
    }
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class CommunicationType
    {
        #region Private fields
        private ChannelCodeType _channelCode;
        private ChannelType _channel;
        private ValueType _value;
        #endregion
        
        public CommunicationType()
        {
            _value = new ValueType();
            _channel = new ChannelType();
            _channelCode = new ChannelCodeType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public ChannelCodeType ChannelCode
        {
            get
            {
                return _channelCode;
            }
            set
            {
                _channelCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public ChannelType Channel
        {
            get
            {
                return _channel;
            }
            set
            {
                _channel = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public ValueType Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PersonType
    {
        #region Private fields
        private FirstNameType _firstName;
        private FamilyNameType _familyName;
        private TitleType _title;
        private MiddleNameType _middleName;
        private NameSuffixType _nameSuffix;
        private NationalityIDType _nationalityID;
        private FinancialAccountType _financialAccount;
        private DocumentReferenceType _identityDocumentReference;
        #endregion
        
        public PersonType()
        {
            _identityDocumentReference = new DocumentReferenceType();
            _financialAccount = new FinancialAccountType();
            _nationalityID = new NationalityIDType();
            _nameSuffix = new NameSuffixType();
            _middleName = new MiddleNameType();
            _title = new TitleType();
            _familyName = new FamilyNameType();
            _firstName = new FirstNameType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public FirstNameType FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public FamilyNameType FamilyName
        {
            get
            {
                return _familyName;
            }
            set
            {
                _familyName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public TitleType Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public MiddleNameType MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public NameSuffixType NameSuffix
        {
            get
            {
                return _nameSuffix;
            }
            set
            {
                _nameSuffix = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public NationalityIDType NationalityID
        {
            get
            {
                return _nationalityID;
            }
            set
            {
                _nationalityID = value;
            }
        }
        
        [XmlElement(Order=6)]
        public FinancialAccountType FinancialAccount
        {
            get
            {
                return _financialAccount;
            }
            set
            {
                _financialAccount = value;
            }
        }
        
        [XmlElement(Order=7)]
        public DocumentReferenceType IdentityDocumentReference
        {
            get
            {
                return _identityDocumentReference;
            }
            set
            {
                _identityDocumentReference = value;
            }
        }
    }
                       
           
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class VideoType : BinaryObjectType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class SoundType : BinaryObjectType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class PictureType : BinaryObjectType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class GraphicType : BinaryObjectType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class HazardousGoodsTransitType
    {
        #region Private fields
        private TransportEmergencyCardCodeType _transportEmergencyCardCode;
        private PackingCriteriaCodeType _packingCriteriaCode;
        private HazardousRegulationCodeType _hazardousRegulationCode;
        private InhalationToxicityZoneCodeType _inhalationToxicityZoneCode;
        private TransportAuthorizationCodeType _transportAuthorizationCode;
        private TemperatureType _maximumTemperature;
        private TemperatureType _minimumTemperature;
        #endregion
        
        public HazardousGoodsTransitType()
        {
            _minimumTemperature = new TemperatureType();
            _maximumTemperature = new TemperatureType();
            _transportAuthorizationCode = new TransportAuthorizationCodeType();
            _inhalationToxicityZoneCode = new InhalationToxicityZoneCodeType();
            _hazardousRegulationCode = new HazardousRegulationCodeType();
            _packingCriteriaCode = new PackingCriteriaCodeType();
            _transportEmergencyCardCode = new TransportEmergencyCardCodeType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public TransportEmergencyCardCodeType TransportEmergencyCardCode
        {
            get
            {
                return _transportEmergencyCardCode;
            }
            set
            {
                _transportEmergencyCardCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public PackingCriteriaCodeType PackingCriteriaCode
        {
            get
            {
                return _packingCriteriaCode;
            }
            set
            {
                _packingCriteriaCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public HazardousRegulationCodeType HazardousRegulationCode
        {
            get
            {
                return _hazardousRegulationCode;
            }
            set
            {
                _hazardousRegulationCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public InhalationToxicityZoneCodeType InhalationToxicityZoneCode
        {
            get
            {
                return _inhalationToxicityZoneCode;
            }
            set
            {
                _inhalationToxicityZoneCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public TransportAuthorizationCodeType TransportAuthorizationCode
        {
            get
            {
                return _transportAuthorizationCode;
            }
            set
            {
                _transportAuthorizationCode = value;
            }
        }
        
        [XmlElement(Order=5)]
        public TemperatureType MaximumTemperature
        {
            get
            {
                return _maximumTemperature;
            }
            set
            {
                _maximumTemperature = value;
            }
        }
        
        [XmlElement(Order=6)]
        public TemperatureType MinimumTemperature
        {
            get
            {
                return _minimumTemperature;
            }
            set
            {
                _minimumTemperature = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TemperatureType
    {
        #region Private fields
        private AttributeIDType _attributeID;
        private MeasureType2 _measure;
        private List<DescriptionType> _description;
        #endregion
        
        public TemperatureType()
        {
            _description = new List<DescriptionType>();
            _measure = new MeasureType2();
            _attributeID = new AttributeIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public AttributeIDType AttributeID
        {
            get
            {
                return _attributeID;
            }
            set
            {
                _attributeID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public MeasureType2 Measure
        {
            get
            {
                return _measure;
            }
            set
            {
                _measure = value;
            }
        }
        
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public List<DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TransportEquipmentType
    {
        #region Private fields
        private IDType _id;
        private TransportEquipmentTypeCodeType _transportEquipmentTypeCode;
        private DescriptionType _description;
        #endregion
        
        public TransportEquipmentType()
        {
            _description = new DescriptionType();
            _transportEquipmentTypeCode = new TransportEquipmentTypeCodeType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public TransportEquipmentTypeCodeType TransportEquipmentTypeCode
        {
            get
            {
                return _transportEquipmentTypeCode;
            }
            set
            {
                _transportEquipmentTypeCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public DescriptionType Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class PackageType
    {
        #region Private fields
        private IDType _id;
        private QuantityType2 _quantity;
        private ReturnableMaterialIndicatorType _returnableMaterialIndicator;
        private PackageLevelCodeType _packageLevelCode;
        private PackagingTypeCodeType _packagingTypeCode;
        private List<PackingMaterialType> _packingMaterial;
        private List<PackageType> _containedPackage;
        private List<GoodsItemType> _goodsItem;
        private List<DimensionType> _measurementDimension;
        #endregion
        
        public PackageType()
        {
            _measurementDimension = new List<DimensionType>();
            _goodsItem = new List<GoodsItemType>();
            _containedPackage = new List<PackageType>();
            _packingMaterial = new List<PackingMaterialType>();
            _packagingTypeCode = new PackagingTypeCodeType();
            _packageLevelCode = new PackageLevelCodeType();
            _returnableMaterialIndicator = new ReturnableMaterialIndicatorType();
            _quantity = new QuantityType2();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public QuantityType2 Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public ReturnableMaterialIndicatorType ReturnableMaterialIndicator
        {
            get
            {
                return _returnableMaterialIndicator;
            }
            set
            {
                _returnableMaterialIndicator = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public PackageLevelCodeType PackageLevelCode
        {
            get
            {
                return _packageLevelCode;
            }
            set
            {
                _packageLevelCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public PackagingTypeCodeType PackagingTypeCode
        {
            get
            {
                return _packagingTypeCode;
            }
            set
            {
                _packagingTypeCode = value;
            }
        }
        
        [XmlElement("PackingMaterial", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public List<PackingMaterialType> PackingMaterial
        {
            get
            {
                return _packingMaterial;
            }
            set
            {
                _packingMaterial = value;
            }
        }
        
        [XmlElement("ContainedPackage", Order=6)]
        public List<PackageType> ContainedPackage
        {
            get
            {
                return _containedPackage;
            }
            set
            {
                _containedPackage = value;
            }
        }
        
        [XmlElement("GoodsItem", Order=7)]
        public List<GoodsItemType> GoodsItem
        {
            get
            {
                return _goodsItem;
            }
            set
            {
                _goodsItem = value;
            }
        }
        
        [XmlElement("MeasurementDimension", Order=8)]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="QuantityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class QuantityType2 : QuantityType1
    {
    }
    
    [XmlInclude(typeof(VarianceQuantityType))]
    [XmlInclude(typeof(ValueQuantityType))]
    [XmlInclude(typeof(TotalTransportHandlingUnitQuantityType))]
    [XmlInclude(typeof(TotalPackagesQuantityType))]
    [XmlInclude(typeof(TotalPackageQuantityType))]
    [XmlInclude(typeof(TotalMeteredQuantityType))]
    [XmlInclude(typeof(TotalGoodsItemQuantityType))]
    [XmlInclude(typeof(TotalDeliveredQuantityType))]
    [XmlInclude(typeof(TotalConsumedQuantityType))]
    [XmlInclude(typeof(TimeDeltaDaysQuantityType))]
    [XmlInclude(typeof(ThresholdQuantityType))]
    [XmlInclude(typeof(TargetInventoryQuantityType))]
    [XmlInclude(typeof(ShortQuantityType))]
    [XmlInclude(typeof(SharesNumberQuantityType))]
    [XmlInclude(typeof(ReturnableQuantityType))]
    [XmlInclude(typeof(RejectedQuantityType))]
    [XmlInclude(typeof(ReceivedTenderQuantityType))]
    [XmlInclude(typeof(ReceivedQuantityType))]
    [XmlInclude(typeof(ReceivedForeignTenderQuantityType))]
    [XmlInclude(typeof(ReceivedElectronicTenderQuantityType))]
    [XmlInclude(typeof(QuantityType2))]
    [XmlInclude(typeof(PreviousMeterQuantityType))]
    [XmlInclude(typeof(PerformanceValueQuantityType))]
    [XmlInclude(typeof(PassengerQuantityType))]
    [XmlInclude(typeof(PackQuantityType))]
    [XmlInclude(typeof(OversupplyQuantityType))]
    [XmlInclude(typeof(OutstandingQuantityType))]
    [XmlInclude(typeof(OperatingYearsQuantityType))]
    [XmlInclude(typeof(NormalTemperatureReductionQuantityType))]
    [XmlInclude(typeof(MultipleOrderQuantityType))]
    [XmlInclude(typeof(MinimumQuantityType))]
    [XmlInclude(typeof(MinimumOrderQuantityType))]
    [XmlInclude(typeof(MinimumInventoryQuantityType))]
    [XmlInclude(typeof(MinimumBackorderQuantityType))]
    [XmlInclude(typeof(MaximumVariantQuantityType))]
    [XmlInclude(typeof(MaximumQuantityType))]
    [XmlInclude(typeof(MaximumOrderQuantityType))]
    [XmlInclude(typeof(MaximumOperatorQuantityType))]
    [XmlInclude(typeof(MaximumBackorderQuantityType))]
    [XmlInclude(typeof(LatestMeterQuantityType))]
    [XmlInclude(typeof(InvoicedQuantityType))]
    [XmlInclude(typeof(GasPressureQuantityType))]
    [XmlInclude(typeof(ExpectedQuantityType))]
    [XmlInclude(typeof(ExpectedOperatorQuantityType))]
    [XmlInclude(typeof(EstimatedOverallContractQuantityType))]
    [XmlInclude(typeof(EstimatedConsumedQuantityType))]
    [XmlInclude(typeof(EmployeeQuantityType))]
    [XmlInclude(typeof(DifferenceTemperatureReductionQuantityType))]
    [XmlInclude(typeof(DeliveredQuantityType))]
    [XmlInclude(typeof(DebitedQuantityType))]
    [XmlInclude(typeof(CustomsTariffQuantityType))]
    [XmlInclude(typeof(CrewQuantityType))]
    [XmlInclude(typeof(CreditedQuantityType))]
    [XmlInclude(typeof(ContentUnitQuantityType))]
    [XmlInclude(typeof(ConsumptionWaterQuantityType))]
    [XmlInclude(typeof(ConsumptionEnergyQuantityType))]
    [XmlInclude(typeof(ConsumerUnitQuantityType))]
    [XmlInclude(typeof(ConsignmentQuantityType))]
    [XmlInclude(typeof(ChildConsignmentQuantityType))]
    [XmlInclude(typeof(ChargeableQuantityType))]
    [XmlInclude(typeof(BatchQuantityType))]
    [XmlInclude(typeof(BasicConsumedQuantityType))]
    [XmlInclude(typeof(BaseQuantityType))]
    [XmlInclude(typeof(BackorderQuantityType))]
    [XmlInclude(typeof(ActualTemperatureReductionQuantityType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(TypeName="QuantityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public class QuantityType1 : QuantityType
    {
    }
    
    [XmlInclude(typeof(QuantityType1))]
    [XmlInclude(typeof(VarianceQuantityType))]
    [XmlInclude(typeof(ValueQuantityType))]
    [XmlInclude(typeof(TotalTransportHandlingUnitQuantityType))]
    [XmlInclude(typeof(TotalPackagesQuantityType))]
    [XmlInclude(typeof(TotalPackageQuantityType))]
    [XmlInclude(typeof(TotalMeteredQuantityType))]
    [XmlInclude(typeof(TotalGoodsItemQuantityType))]
    [XmlInclude(typeof(TotalDeliveredQuantityType))]
    [XmlInclude(typeof(TotalConsumedQuantityType))]
    [XmlInclude(typeof(TimeDeltaDaysQuantityType))]
    [XmlInclude(typeof(ThresholdQuantityType))]
    [XmlInclude(typeof(TargetInventoryQuantityType))]
    [XmlInclude(typeof(ShortQuantityType))]
    [XmlInclude(typeof(SharesNumberQuantityType))]
    [XmlInclude(typeof(ReturnableQuantityType))]
    [XmlInclude(typeof(RejectedQuantityType))]
    [XmlInclude(typeof(ReceivedTenderQuantityType))]
    [XmlInclude(typeof(ReceivedQuantityType))]
    [XmlInclude(typeof(ReceivedForeignTenderQuantityType))]
    [XmlInclude(typeof(ReceivedElectronicTenderQuantityType))]
    [XmlInclude(typeof(QuantityType2))]
    [XmlInclude(typeof(PreviousMeterQuantityType))]
    [XmlInclude(typeof(PerformanceValueQuantityType))]
    [XmlInclude(typeof(PassengerQuantityType))]
    [XmlInclude(typeof(PackQuantityType))]
    [XmlInclude(typeof(OversupplyQuantityType))]
    [XmlInclude(typeof(OutstandingQuantityType))]
    [XmlInclude(typeof(OperatingYearsQuantityType))]
    [XmlInclude(typeof(NormalTemperatureReductionQuantityType))]
    [XmlInclude(typeof(MultipleOrderQuantityType))]
    [XmlInclude(typeof(MinimumQuantityType))]
    [XmlInclude(typeof(MinimumOrderQuantityType))]
    [XmlInclude(typeof(MinimumInventoryQuantityType))]
    [XmlInclude(typeof(MinimumBackorderQuantityType))]
    [XmlInclude(typeof(MaximumVariantQuantityType))]
    [XmlInclude(typeof(MaximumQuantityType))]
    [XmlInclude(typeof(MaximumOrderQuantityType))]
    [XmlInclude(typeof(MaximumOperatorQuantityType))]
    [XmlInclude(typeof(MaximumBackorderQuantityType))]
    [XmlInclude(typeof(LatestMeterQuantityType))]
    [XmlInclude(typeof(InvoicedQuantityType))]
    [XmlInclude(typeof(GasPressureQuantityType))]
    [XmlInclude(typeof(ExpectedQuantityType))]
    [XmlInclude(typeof(ExpectedOperatorQuantityType))]
    [XmlInclude(typeof(EstimatedOverallContractQuantityType))]
    [XmlInclude(typeof(EstimatedConsumedQuantityType))]
    [XmlInclude(typeof(EmployeeQuantityType))]
    [XmlInclude(typeof(DifferenceTemperatureReductionQuantityType))]
    [XmlInclude(typeof(DeliveredQuantityType))]
    [XmlInclude(typeof(DebitedQuantityType))]
    [XmlInclude(typeof(CustomsTariffQuantityType))]
    [XmlInclude(typeof(CrewQuantityType))]
    [XmlInclude(typeof(CreditedQuantityType))]
    [XmlInclude(typeof(ContentUnitQuantityType))]
    [XmlInclude(typeof(ConsumptionWaterQuantityType))]
    [XmlInclude(typeof(ConsumptionEnergyQuantityType))]
    [XmlInclude(typeof(ConsumerUnitQuantityType))]
    [XmlInclude(typeof(ConsignmentQuantityType))]
    [XmlInclude(typeof(ChildConsignmentQuantityType))]
    [XmlInclude(typeof(ChargeableQuantityType))]
    [XmlInclude(typeof(BatchQuantityType))]
    [XmlInclude(typeof(BasicConsumedQuantityType))]
    [XmlInclude(typeof(BaseQuantityType))]
    [XmlInclude(typeof(BackorderQuantityType))]
    [XmlInclude(typeof(ActualTemperatureReductionQuantityType))]
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public class QuantityType
    {
        #region Private fields
        private string _unitCode;
        private string _unitCodeListID;
        private string _unitCodeListAgencyID;
        private string _unitCodeListAgencyName;
        private decimal _value;
        #endregion
        
        [XmlAttribute(DataType="normalizedString")]
        public string unitCode
        {
            get
            {
                return _unitCode;
            }
            set
            {
                _unitCode = value;
            }
        }
        
        [XmlAttribute(DataType="normalizedString")]
        public string unitCodeListID
        {
            get
            {
                return _unitCodeListID;
            }
            set
            {
                _unitCodeListID = value;
            }
        }
        
        [XmlAttribute(DataType="normalizedString")]
        public string unitCodeListAgencyID
        {
            get
            {
                return _unitCodeListAgencyID;
            }
            set
            {
                _unitCodeListAgencyID = value;
            }
        }
        
        [XmlAttribute]
        public string unitCodeListAgencyName
        {
            get
            {
                return _unitCodeListAgencyName;
            }
            set
            {
                _unitCodeListAgencyName = value;
            }
        }
        
        [XmlTextAttribute]
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class VarianceQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ValueQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalTransportHandlingUnitQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalPackagesQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalPackageQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalMeteredQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalGoodsItemQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalDeliveredQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TotalConsumedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TimeDeltaDaysQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ThresholdQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class TargetInventoryQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ShortQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class SharesNumberQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReturnableQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class RejectedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReceivedTenderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReceivedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReceivedForeignTenderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ReceivedElectronicTenderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PreviousMeterQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PerformanceValueQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PassengerQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class PackQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OversupplyQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OutstandingQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class OperatingYearsQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class NormalTemperatureReductionQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MultipleOrderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumOrderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumInventoryQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MinimumBackorderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumVariantQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumOrderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumOperatorQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class MaximumBackorderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class LatestMeterQuantityType : QuantityType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class GasPressureQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExpectedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ExpectedOperatorQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedOverallContractQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EstimatedConsumedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class EmployeeQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DifferenceTemperatureReductionQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DeliveredQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class DebitedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CustomsTariffQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CrewQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class CreditedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ContentUnitQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionWaterQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumptionEnergyQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsumerUnitQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ConsignmentQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChildConsignmentQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ChargeableQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BatchQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BasicConsumedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BaseQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class BackorderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public class ActualTemperatureReductionQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class GoodsItemType
    {
        #region Private fields
        private IDType _id;
        private List<DescriptionType> _description;
        private HazardousRiskIndicatorType _hazardousRiskIndicator;
        private DeclaredCustomsValueAmountType _declaredCustomsValueAmount;
        private DeclaredForCarriageValueAmountType _declaredForCarriageValueAmount;
        private DeclaredStatisticsValueAmountType _declaredStatisticsValueAmount;
        private FreeOnBoardValueAmountType _freeOnBoardValueAmount;
        private InsuranceValueAmountType _insuranceValueAmount;
        private ValueAmountType _valueAmount;
        private GrossWeightMeasureType _grossWeightMeasure;
        private NetWeightMeasureType _netWeightMeasure;
        private ChargeableWeightMeasureType _chargeableWeightMeasure;
        private GrossVolumeMeasureType _grossVolumeMeasure;
        private NetVolumeMeasureType _netVolumeMeasure;
        private QuantityType2 _quantity;
        private RequiredCustomsIDType _requiredCustomsID;
        private CustomsStatusCodeType _customsStatusCode;
        private CustomsTariffQuantityType _customsTariffQuantity;
        private CustomsImportClassifiedIndicatorType _customsImportClassifiedIndicator;
        private ChargeableQuantityType _chargeableQuantity;
        private ReturnableQuantityType _returnableQuantity;
        private TraceIDType _traceID;
        private List<ItemType> _item;
        private List<AllowanceChargeType> _freightAllowanceCharge;
        private List<InvoiceLineType> _invoiceLine;
        private List<TemperatureType> _temperature;
        private AddressType _originAddress;
        private List<DimensionType> _measurementDimension;
        #endregion
        
        public GoodsItemType()
        {
            _measurementDimension = new List<DimensionType>();
            _originAddress = new AddressType();
            _temperature = new List<TemperatureType>();
            _invoiceLine = new List<InvoiceLineType>();
            _freightAllowanceCharge = new List<AllowanceChargeType>();
            _item = new List<ItemType>();
            _traceID = new TraceIDType();
            _returnableQuantity = new ReturnableQuantityType();
            _chargeableQuantity = new ChargeableQuantityType();
            _customsImportClassifiedIndicator = new CustomsImportClassifiedIndicatorType();
            _customsTariffQuantity = new CustomsTariffQuantityType();
            _customsStatusCode = new CustomsStatusCodeType();
            _requiredCustomsID = new RequiredCustomsIDType();
            _quantity = new QuantityType2();
            _netVolumeMeasure = new NetVolumeMeasureType();
            _grossVolumeMeasure = new GrossVolumeMeasureType();
            _chargeableWeightMeasure = new ChargeableWeightMeasureType();
            _netWeightMeasure = new NetWeightMeasureType();
            _grossWeightMeasure = new GrossWeightMeasureType();
            _valueAmount = new ValueAmountType();
            _insuranceValueAmount = new InsuranceValueAmountType();
            _freeOnBoardValueAmount = new FreeOnBoardValueAmountType();
            _declaredStatisticsValueAmount = new DeclaredStatisticsValueAmountType();
            _declaredForCarriageValueAmount = new DeclaredForCarriageValueAmountType();
            _declaredCustomsValueAmount = new DeclaredCustomsValueAmountType();
            _hazardousRiskIndicator = new HazardousRiskIndicatorType();
            _description = new List<DescriptionType>();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public List<DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return _hazardousRiskIndicator;
            }
            set
            {
                _hazardousRiskIndicator = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return _declaredCustomsValueAmount;
            }
            set
            {
                _declaredCustomsValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return _declaredForCarriageValueAmount;
            }
            set
            {
                _declaredForCarriageValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return _declaredStatisticsValueAmount;
            }
            set
            {
                _declaredStatisticsValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return _freeOnBoardValueAmount;
            }
            set
            {
                _freeOnBoardValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return _insuranceValueAmount;
            }
            set
            {
                _insuranceValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public ValueAmountType ValueAmount
        {
            get
            {
                return _valueAmount;
            }
            set
            {
                _valueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return _grossWeightMeasure;
            }
            set
            {
                _grossWeightMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return _netWeightMeasure;
            }
            set
            {
                _netWeightMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public ChargeableWeightMeasureType ChargeableWeightMeasure
        {
            get
            {
                return _chargeableWeightMeasure;
            }
            set
            {
                _chargeableWeightMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return _grossVolumeMeasure;
            }
            set
            {
                _grossVolumeMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return _netVolumeMeasure;
            }
            set
            {
                _netVolumeMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public QuantityType2 Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
        public RequiredCustomsIDType RequiredCustomsID
        {
            get
            {
                return _requiredCustomsID;
            }
            set
            {
                _requiredCustomsID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
        public CustomsStatusCodeType CustomsStatusCode
        {
            get
            {
                return _customsStatusCode;
            }
            set
            {
                _customsStatusCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
        public CustomsTariffQuantityType CustomsTariffQuantity
        {
            get
            {
                return _customsTariffQuantity;
            }
            set
            {
                _customsTariffQuantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=18)]
        public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator
        {
            get
            {
                return _customsImportClassifiedIndicator;
            }
            set
            {
                _customsImportClassifiedIndicator = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=19)]
        public ChargeableQuantityType ChargeableQuantity
        {
            get
            {
                return _chargeableQuantity;
            }
            set
            {
                _chargeableQuantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=20)]
        public ReturnableQuantityType ReturnableQuantity
        {
            get
            {
                return _returnableQuantity;
            }
            set
            {
                _returnableQuantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=21)]
        public TraceIDType TraceID
        {
            get
            {
                return _traceID;
            }
            set
            {
                _traceID = value;
            }
        }
        
        [XmlElement("Item", Order=22)]
        public List<ItemType> Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
            }
        }
        
        [XmlElement("FreightAllowanceCharge", Order=23)]
        public List<AllowanceChargeType> FreightAllowanceCharge
        {
            get
            {
                return _freightAllowanceCharge;
            }
            set
            {
                _freightAllowanceCharge = value;
            }
        }
        
        [XmlElement("InvoiceLine", Order=24)]
        public List<InvoiceLineType> InvoiceLine
        {
            get
            {
                return _invoiceLine;
            }
            set
            {
                _invoiceLine = value;
            }
        }
        
        [XmlElement("Temperature", Order=25)]
        public List<TemperatureType> Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
            }
        }
        
        [XmlElement(Order=26)]
        public AddressType OriginAddress
        {
            get
            {
                return _originAddress;
            }
            set
            {
                _originAddress = value;
            }
        }
        
        [XmlElement("MeasurementDimension", Order=27)]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
    }
          
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ItemPropertyType
    {
        #region Private fields
        private IDType _id;
        private NameType1 _name;
        private NameCodeType _nameCode;
        private TestMethodType _testMethod;
        private ValueType _value;
        private ValueQuantityType _valueQuantity;
        private List<ValueQualifierType> _valueQualifier;
        private ImportanceCodeType _importanceCode;
        private List<ListValueType> _listValue;
        private PeriodType _usabilityPeriod;
        private List<ItemPropertyGroupType> _itemPropertyGroup;
        private DimensionType _rangeDimension;
        private ItemPropertyRangeType _itemPropertyRange;
        #endregion
        
        public ItemPropertyType()
        {
            _itemPropertyRange = new ItemPropertyRangeType();
            _rangeDimension = new DimensionType();
            _itemPropertyGroup = new List<ItemPropertyGroupType>();
            _usabilityPeriod = new PeriodType();
            _listValue = new List<ListValueType>();
            _importanceCode = new ImportanceCodeType();
            _valueQualifier = new List<ValueQualifierType>();
            _valueQuantity = new ValueQuantityType();
            _value = new ValueType();
            _testMethod = new TestMethodType();
            _nameCode = new NameCodeType();
            _name = new NameType1();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public NameType1 Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public NameCodeType NameCode
        {
            get
            {
                return _nameCode;
            }
            set
            {
                _nameCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public TestMethodType TestMethod
        {
            get
            {
                return _testMethod;
            }
            set
            {
                _testMethod = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public ValueType Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public ValueQuantityType ValueQuantity
        {
            get
            {
                return _valueQuantity;
            }
            set
            {
                _valueQuantity = value;
            }
        }
        
        [XmlElement("ValueQualifier", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public List<ValueQualifierType> ValueQualifier
        {
            get
            {
                return _valueQualifier;
            }
            set
            {
                _valueQualifier = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public ImportanceCodeType ImportanceCode
        {
            get
            {
                return _importanceCode;
            }
            set
            {
                _importanceCode = value;
            }
        }
        
        [XmlElement("ListValue", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public List<ListValueType> ListValue
        {
            get
            {
                return _listValue;
            }
            set
            {
                _listValue = value;
            }
        }
        
        [XmlElement(Order=9)]
        public PeriodType UsabilityPeriod
        {
            get
            {
                return _usabilityPeriod;
            }
            set
            {
                _usabilityPeriod = value;
            }
        }
        
        [XmlElement("ItemPropertyGroup", Order=10)]
        public List<ItemPropertyGroupType> ItemPropertyGroup
        {
            get
            {
                return _itemPropertyGroup;
            }
            set
            {
                _itemPropertyGroup = value;
            }
        }
        
        [XmlElement(Order=11)]
        public DimensionType RangeDimension
        {
            get
            {
                return _rangeDimension;
            }
            set
            {
                _rangeDimension = value;
            }
        }
        
        [XmlElement(Order=12)]
        public ItemPropertyRangeType ItemPropertyRange
        {
            get
            {
                return _itemPropertyRange;
            }
            set
            {
                _itemPropertyRange = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ItemPropertyGroupType
    {
        #region Private fields
        private IDType _id;
        private NameType1 _name;
        private ImportanceCodeType _importanceCode;
        #endregion
        
        public ItemPropertyGroupType()
        {
            _importanceCode = new ImportanceCodeType();
            _name = new NameType1();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public NameType1 Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public ImportanceCodeType ImportanceCode
        {
            get
            {
                return _importanceCode;
            }
            set
            {
                _importanceCode = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class DimensionType
    {
        #region Private fields
        private AttributeIDType _attributeID;
        private MeasureType2 _measure;
        private List<DescriptionType> _description;
        private MinimumMeasureType _minimumMeasure;
        private MaximumMeasureType _maximumMeasure;
        #endregion
        
        public DimensionType()
        {
            _maximumMeasure = new MaximumMeasureType();
            _minimumMeasure = new MinimumMeasureType();
            _description = new List<DescriptionType>();
            _measure = new MeasureType2();
            _attributeID = new AttributeIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public AttributeIDType AttributeID
        {
            get
            {
                return _attributeID;
            }
            set
            {
                _attributeID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public MeasureType2 Measure
        {
            get
            {
                return _measure;
            }
            set
            {
                _measure = value;
            }
        }
        
        [XmlElement("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public List<DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public MinimumMeasureType MinimumMeasure
        {
            get
            {
                return _minimumMeasure;
            }
            set
            {
                _minimumMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public MaximumMeasureType MaximumMeasure
        {
            get
            {
                return _maximumMeasure;
            }
            set
            {
                _maximumMeasure = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ItemPropertyRangeType
    {
        #region Private fields
        private MinimumValueType _minimumValue;
        private MaximumValueType _maximumValue;
        #endregion
        
        public ItemPropertyRangeType()
        {
            _maximumValue = new MaximumValueType();
            _minimumValue = new MinimumValueType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public MinimumValueType MinimumValue
        {
            get
            {
                return _minimumValue;
            }
            set
            {
                _minimumValue = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public MaximumValueType MaximumValue
        {
            get
            {
                return _maximumValue;
            }
            set
            {
                _maximumValue = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class LotIdentificationType
    {
        #region Private fields
        private LotNumberIDType _lotNumberID;
        private ExpiryDateType _expiryDate;
        private List<ItemPropertyType> _additionalItemProperty;
        #endregion
        
        public LotIdentificationType()
        {
            _additionalItemProperty = new List<ItemPropertyType>();
            _expiryDate = new ExpiryDateType();
            _lotNumberID = new LotNumberIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public LotNumberIDType LotNumberID
        {
            get
            {
                return _lotNumberID;
            }
            set
            {
                _lotNumberID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public ExpiryDateType ExpiryDate
        {
            get
            {
                return _expiryDate;
            }
            set
            {
                _expiryDate = value;
            }
        }
        
        [XmlElement("AdditionalItemProperty", Order=2)]
        public List<ItemPropertyType> AdditionalItemProperty
        {
            get
            {
                return _additionalItemProperty;
            }
            set
            {
                _additionalItemProperty = value;
            }
        }
    }
      
       
       
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class LineReferenceType
    {
        #region Private fields
        private LineIDType _lineID;
        private LineStatusCodeType _lineStatusCode;
        private DocumentReferenceType _documentReference;
        #endregion
        
        public LineReferenceType()
        {
            _documentReference = new DocumentReferenceType();
            _lineStatusCode = new LineStatusCodeType();
            _lineID = new LineIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public LineIDType LineID
        {
            get
            {
                return _lineID;
            }
            set
            {
                _lineID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public LineStatusCodeType LineStatusCode
        {
            get
            {
                return _lineStatusCode;
            }
            set
            {
                _lineStatusCode = value;
            }
        }
        
        [XmlElement(Order=2)]
        public DocumentReferenceType DocumentReference
        {
            get
            {
                return _documentReference;
            }
            set
            {
                _documentReference = value;
            }
        }
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class DespatchType
    {
        #region Private fields
        private IDType _id;
        private ActualDespatchDateType _actualDespatchDate;
        private ActualDespatchTimeType _actualDespatchTime;
        private InstructionsType _instructions;
        private AddressType _despatchAddress;
        private PartyType _despatchParty;
        private ContactType _contact;
        private PeriodType _estimatedDespatchPeriod;
        #endregion
        
        public DespatchType()
        {
            _estimatedDespatchPeriod = new PeriodType();
            _contact = new ContactType();
            _despatchParty = new PartyType();
            _despatchAddress = new AddressType();
            _instructions = new InstructionsType();
            _actualDespatchTime = new ActualDespatchTimeType();
            _actualDespatchDate = new ActualDespatchDateType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public ActualDespatchDateType ActualDespatchDate
        {
            get
            {
                return _actualDespatchDate;
            }
            set
            {
                _actualDespatchDate = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public ActualDespatchTimeType ActualDespatchTime
        {
            get
            {
                return _actualDespatchTime;
            }
            set
            {
                _actualDespatchTime = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public InstructionsType Instructions
        {
            get
            {
                return _instructions;
            }
            set
            {
                _instructions = value;
            }
        }
        
        [XmlElement(Order=4)]
        public AddressType DespatchAddress
        {
            get
            {
                return _despatchAddress;
            }
            set
            {
                _despatchAddress = value;
            }
        }
        
        [XmlElement(Order=5)]
        public PartyType DespatchParty
        {
            get
            {
                return _despatchParty;
            }
            set
            {
                _despatchParty = value;
            }
        }
        
        [XmlElement(Order=6)]
        public ContactType Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }
        
        [XmlElement(Order=7)]
        public PeriodType EstimatedDespatchPeriod
        {
            get
            {
                return _estimatedDespatchPeriod;
            }
            set
            {
                _estimatedDespatchPeriod = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class DeliveryTermsType
    {
        #region Private fields
        private IDType _id;
        private SpecialTermsType _specialTerms;
        private AmountType2 _amount;
        #endregion
        
        public DeliveryTermsType()
        {
            _amount = new AmountType2();
            _specialTerms = new SpecialTermsType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public SpecialTermsType SpecialTerms
        {
            get
            {
                return _specialTerms;
            }
            set
            {
                _specialTerms = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public AmountType2 Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ShipmentType
    {
        #region Private fields
        private IDType _id;
        private HandlingCodeType _handlingCode;
        private HandlingInstructionsType _handlingInstructions;
        private GrossWeightMeasureType _grossWeightMeasure;
        private NetWeightMeasureType _netWeightMeasure;
        private GrossVolumeMeasureType _grossVolumeMeasure;
        private NetVolumeMeasureType _netVolumeMeasure;
        private TotalGoodsItemQuantityType _totalGoodsItemQuantity;
        private TotalTransportHandlingUnitQuantityType _totalTransportHandlingUnitQuantity;
        private InsuranceValueAmountType _insuranceValueAmount;
        private DeclaredCustomsValueAmountType _declaredCustomsValueAmount;
        private DeclaredForCarriageValueAmountType _declaredForCarriageValueAmount;
        private DeclaredStatisticsValueAmountType _declaredStatisticsValueAmount;
        private FreeOnBoardValueAmountType _freeOnBoardValueAmount;
        private List<SpecialInstructionsType> _specialInstructions;
        private List<GoodsItemType> _goodsItem;
        private List<ShipmentStageType> _shipmentStage;
        private DeliveryType _delivery;
        private List<TransportHandlingUnitType> _transportHandlingUnit;
        private AddressType _returnAddress;
        private LocationType1 _firstArrivalPortLocation;
        private LocationType1 _lastExitPortLocation;
        #endregion
        
        public ShipmentType()
        {
            _lastExitPortLocation = new LocationType1();
            _firstArrivalPortLocation = new LocationType1();
            _returnAddress = new AddressType();
            _transportHandlingUnit = new List<TransportHandlingUnitType>();
            _delivery = new DeliveryType();
            _shipmentStage = new List<ShipmentStageType>();
            _goodsItem = new List<GoodsItemType>();
            _specialInstructions = new List<SpecialInstructionsType>();
            _freeOnBoardValueAmount = new FreeOnBoardValueAmountType();
            _declaredStatisticsValueAmount = new DeclaredStatisticsValueAmountType();
            _declaredForCarriageValueAmount = new DeclaredForCarriageValueAmountType();
            _declaredCustomsValueAmount = new DeclaredCustomsValueAmountType();
            _insuranceValueAmount = new InsuranceValueAmountType();
            _totalTransportHandlingUnitQuantity = new TotalTransportHandlingUnitQuantityType();
            _totalGoodsItemQuantity = new TotalGoodsItemQuantityType();
            _netVolumeMeasure = new NetVolumeMeasureType();
            _grossVolumeMeasure = new GrossVolumeMeasureType();
            _netWeightMeasure = new NetWeightMeasureType();
            _grossWeightMeasure = new GrossWeightMeasureType();
            _handlingInstructions = new HandlingInstructionsType();
            _handlingCode = new HandlingCodeType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return _handlingCode;
            }
            set
            {
                _handlingCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public HandlingInstructionsType HandlingInstructions
        {
            get
            {
                return _handlingInstructions;
            }
            set
            {
                _handlingInstructions = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public GrossWeightMeasureType GrossWeightMeasure
        {
            get
            {
                return _grossWeightMeasure;
            }
            set
            {
                _grossWeightMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public NetWeightMeasureType NetWeightMeasure
        {
            get
            {
                return _netWeightMeasure;
            }
            set
            {
                _netWeightMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public GrossVolumeMeasureType GrossVolumeMeasure
        {
            get
            {
                return _grossVolumeMeasure;
            }
            set
            {
                _grossVolumeMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public NetVolumeMeasureType NetVolumeMeasure
        {
            get
            {
                return _netVolumeMeasure;
            }
            set
            {
                _netVolumeMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return _totalGoodsItemQuantity;
            }
            set
            {
                _totalGoodsItemQuantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity
        {
            get
            {
                return _totalTransportHandlingUnitQuantity;
            }
            set
            {
                _totalTransportHandlingUnitQuantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public InsuranceValueAmountType InsuranceValueAmount
        {
            get
            {
                return _insuranceValueAmount;
            }
            set
            {
                _insuranceValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount
        {
            get
            {
                return _declaredCustomsValueAmount;
            }
            set
            {
                _declaredCustomsValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount
        {
            get
            {
                return _declaredForCarriageValueAmount;
            }
            set
            {
                _declaredForCarriageValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount
        {
            get
            {
                return _declaredStatisticsValueAmount;
            }
            set
            {
                _declaredStatisticsValueAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public FreeOnBoardValueAmountType FreeOnBoardValueAmount
        {
            get
            {
                return _freeOnBoardValueAmount;
            }
            set
            {
                _freeOnBoardValueAmount = value;
            }
        }
        
        [XmlElement("SpecialInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public List<SpecialInstructionsType> SpecialInstructions
        {
            get
            {
                return _specialInstructions;
            }
            set
            {
                _specialInstructions = value;
            }
        }
        
        [XmlElement("GoodsItem", Order=15)]
        public List<GoodsItemType> GoodsItem
        {
            get
            {
                return _goodsItem;
            }
            set
            {
                _goodsItem = value;
            }
        }
        
        [XmlElement("ShipmentStage", Order=16)]
        public List<ShipmentStageType> ShipmentStage
        {
            get
            {
                return _shipmentStage;
            }
            set
            {
                _shipmentStage = value;
            }
        }
        
        [XmlElement(Order=17)]
        public DeliveryType Delivery
        {
            get
            {
                return _delivery;
            }
            set
            {
                _delivery = value;
            }
        }
        
        [XmlElement("TransportHandlingUnit", Order=18)]
        public List<TransportHandlingUnitType> TransportHandlingUnit
        {
            get
            {
                return _transportHandlingUnit;
            }
            set
            {
                _transportHandlingUnit = value;
            }
        }
        
        [XmlElement(Order=19)]
        public AddressType ReturnAddress
        {
            get
            {
                return _returnAddress;
            }
            set
            {
                _returnAddress = value;
            }
        }
        
        [XmlElement(Order=20)]
        public LocationType1 FirstArrivalPortLocation
        {
            get
            {
                return _firstArrivalPortLocation;
            }
            set
            {
                _firstArrivalPortLocation = value;
            }
        }
        
        [XmlElement(Order=21)]
        public LocationType1 LastExitPortLocation
        {
            get
            {
                return _lastExitPortLocation;
            }
            set
            {
                _lastExitPortLocation = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class ShipmentStageType
    {
        #region Private fields
        private IDType _id;
        private TransportModeCodeType _transportModeCode;
        private TransportMeansTypeCodeType _transportMeansTypeCode;
        private TransitDirectionCodeType _transitDirectionCode;
        private List<InstructionsType> _instructions;
        private PeriodType _transitPeriod;
        private TransportMeansType _transportMeans;
        private List<PersonType> _driverPerson;
        #endregion
        
        public ShipmentStageType()
        {
            _driverPerson = new List<PersonType>();
            _transportMeans = new TransportMeansType();
            _transitPeriod = new PeriodType();
            _instructions = new List<InstructionsType>();
            _transitDirectionCode = new TransitDirectionCodeType();
            _transportMeansTypeCode = new TransportMeansTypeCodeType();
            _transportModeCode = new TransportModeCodeType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public TransportModeCodeType TransportModeCode
        {
            get
            {
                return _transportModeCode;
            }
            set
            {
                _transportModeCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public TransportMeansTypeCodeType TransportMeansTypeCode
        {
            get
            {
                return _transportMeansTypeCode;
            }
            set
            {
                _transportMeansTypeCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public TransitDirectionCodeType TransitDirectionCode
        {
            get
            {
                return _transitDirectionCode;
            }
            set
            {
                _transitDirectionCode = value;
            }
        }
        
        [XmlElement("Instructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public List<InstructionsType> Instructions
        {
            get
            {
                return _instructions;
            }
            set
            {
                _instructions = value;
            }
        }
        
        [XmlElement(Order=5)]
        public PeriodType TransitPeriod
        {
            get
            {
                return _transitPeriod;
            }
            set
            {
                _transitPeriod = value;
            }
        }
        
        [XmlElement(Order=6)]
        public TransportMeansType TransportMeans
        {
            get
            {
                return _transportMeans;
            }
            set
            {
                _transportMeans = value;
            }
        }
        
        [XmlElement("DriverPerson", Order=7)]
        public List<PersonType> DriverPerson
        {
            get
            {
                return _driverPerson;
            }
            set
            {
                _driverPerson = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TransportMeansType
    {
        #region Private fields
        private JourneyIDType _journeyID;
        private RegistrationNationalityIDType _registrationNationalityID;
        private List<RegistrationNationalityType> _registrationNationality;
        private DirectionCodeType _directionCode;
        private TransportMeansTypeCodeType _transportMeansTypeCode;
        private TradeServiceCodeType _tradeServiceCode;
        private StowageType _stowage;
        private AirTransportType _airTransport;
        private RoadTransportType _roadTransport;
        private RailTransportType _railTransport;
        private MaritimeTransportType _maritimeTransport;
        private PartyType _ownerParty;
        private List<DimensionType> _measurementDimension;
        #endregion
        
        public TransportMeansType()
        {
            _measurementDimension = new List<DimensionType>();
            _ownerParty = new PartyType();
            _maritimeTransport = new MaritimeTransportType();
            _railTransport = new RailTransportType();
            _roadTransport = new RoadTransportType();
            _airTransport = new AirTransportType();
            _stowage = new StowageType();
            _tradeServiceCode = new TradeServiceCodeType();
            _transportMeansTypeCode = new TransportMeansTypeCodeType();
            _directionCode = new DirectionCodeType();
            _registrationNationality = new List<RegistrationNationalityType>();
            _registrationNationalityID = new RegistrationNationalityIDType();
            _journeyID = new JourneyIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public JourneyIDType JourneyID
        {
            get
            {
                return _journeyID;
            }
            set
            {
                _journeyID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public RegistrationNationalityIDType RegistrationNationalityID
        {
            get
            {
                return _registrationNationalityID;
            }
            set
            {
                _registrationNationalityID = value;
            }
        }
        
        [XmlElement("RegistrationNationality", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public List<RegistrationNationalityType> RegistrationNationality
        {
            get
            {
                return _registrationNationality;
            }
            set
            {
                _registrationNationality = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public DirectionCodeType DirectionCode
        {
            get
            {
                return _directionCode;
            }
            set
            {
                _directionCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public TransportMeansTypeCodeType TransportMeansTypeCode
        {
            get
            {
                return _transportMeansTypeCode;
            }
            set
            {
                _transportMeansTypeCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public TradeServiceCodeType TradeServiceCode
        {
            get
            {
                return _tradeServiceCode;
            }
            set
            {
                _tradeServiceCode = value;
            }
        }
        
        [XmlElement(Order=6)]
        public StowageType Stowage
        {
            get
            {
                return _stowage;
            }
            set
            {
                _stowage = value;
            }
        }
        
        [XmlElement(Order=7)]
        public AirTransportType AirTransport
        {
            get
            {
                return _airTransport;
            }
            set
            {
                _airTransport = value;
            }
        }
        
        [XmlElement(Order=8)]
        public RoadTransportType RoadTransport
        {
            get
            {
                return _roadTransport;
            }
            set
            {
                _roadTransport = value;
            }
        }
        
        [XmlElement(Order=9)]
        public RailTransportType RailTransport
        {
            get
            {
                return _railTransport;
            }
            set
            {
                _railTransport = value;
            }
        }
        
        [XmlElement(Order=10)]
        public MaritimeTransportType MaritimeTransport
        {
            get
            {
                return _maritimeTransport;
            }
            set
            {
                _maritimeTransport = value;
            }
        }
        
        [XmlElement(Order=11)]
        public PartyType OwnerParty
        {
            get
            {
                return _ownerParty;
            }
            set
            {
                _ownerParty = value;
            }
        }
        
        [XmlElement("MeasurementDimension", Order=12)]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class StowageType
    {
        #region Private fields
        private LocationIDType _locationID;
        private List<LocationType> _location;
        private List<DimensionType> _measurementDimension;
        #endregion
        
        public StowageType()
        {
            _measurementDimension = new List<DimensionType>();
            _location = new List<LocationType>();
            _locationID = new LocationIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public LocationIDType LocationID
        {
            get
            {
                return _locationID;
            }
            set
            {
                _locationID = value;
            }
        }
        
        [XmlElement("Location", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public List<LocationType> Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
        
        [XmlElement("MeasurementDimension", Order=2)]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class AirTransportType
    {
        #region Private fields
        private AircraftIDType _aircraftID;
        #endregion
        
        public AirTransportType()
        {
            _aircraftID = new AircraftIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public AircraftIDType AircraftID
        {
            get
            {
                return _aircraftID;
            }
            set
            {
                _aircraftID = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class RoadTransportType
    {
        #region Private fields
        private LicensePlateIDType _licensePlateID;
        #endregion
        
        public RoadTransportType()
        {
            _licensePlateID = new LicensePlateIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public LicensePlateIDType LicensePlateID
        {
            get
            {
                return _licensePlateID;
            }
            set
            {
                _licensePlateID = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class RailTransportType
    {
        #region Private fields
        private TrainIDType _trainID;
        private RailCarIDType _railCarID;
        #endregion
        
        public RailTransportType()
        {
            _railCarID = new RailCarIDType();
            _trainID = new TrainIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public TrainIDType TrainID
        {
            get
            {
                return _trainID;
            }
            set
            {
                _trainID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public RailCarIDType RailCarID
        {
            get
            {
                return _railCarID;
            }
            set
            {
                _railCarID = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class MaritimeTransportType
    {
        #region Private fields
        private VesselIDType _vesselID;
        private VesselNameType _vesselName;
        private RadioCallSignIDType _radioCallSignID;
        private List<ShipsRequirementsType> _shipsRequirements;
        private GrossTonnageMeasureType _grossTonnageMeasure;
        private NetTonnageMeasureType _netTonnageMeasure;
        private DocumentReferenceType _registryCertificateDocumentReference;
        private LocationType1 _registryPortLocation;
        #endregion
        
        public MaritimeTransportType()
        {
            _registryPortLocation = new LocationType1();
            _registryCertificateDocumentReference = new DocumentReferenceType();
            _netTonnageMeasure = new NetTonnageMeasureType();
            _grossTonnageMeasure = new GrossTonnageMeasureType();
            _shipsRequirements = new List<ShipsRequirementsType>();
            _radioCallSignID = new RadioCallSignIDType();
            _vesselName = new VesselNameType();
            _vesselID = new VesselIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public VesselIDType VesselID
        {
            get
            {
                return _vesselID;
            }
            set
            {
                _vesselID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public VesselNameType VesselName
        {
            get
            {
                return _vesselName;
            }
            set
            {
                _vesselName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public RadioCallSignIDType RadioCallSignID
        {
            get
            {
                return _radioCallSignID;
            }
            set
            {
                _radioCallSignID = value;
            }
        }
        
        [XmlElement("ShipsRequirements", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public List<ShipsRequirementsType> ShipsRequirements
        {
            get
            {
                return _shipsRequirements;
            }
            set
            {
                _shipsRequirements = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public GrossTonnageMeasureType GrossTonnageMeasure
        {
            get
            {
                return _grossTonnageMeasure;
            }
            set
            {
                _grossTonnageMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public NetTonnageMeasureType NetTonnageMeasure
        {
            get
            {
                return _netTonnageMeasure;
            }
            set
            {
                _netTonnageMeasure = value;
            }
        }
        
        [XmlElement(Order=6)]
        public DocumentReferenceType RegistryCertificateDocumentReference
        {
            get
            {
                return _registryCertificateDocumentReference;
            }
            set
            {
                _registryCertificateDocumentReference = value;
            }
        }
        
        [XmlElement(Order=7)]
        public LocationType1 RegistryPortLocation
        {
            get
            {
                return _registryPortLocation;
            }
            set
            {
                _registryPortLocation = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class TransportHandlingUnitType
    {
        #region Private fields
        private IDType _id;
        private TransportHandlingUnitTypeCodeType _transportHandlingUnitTypeCode;
        private HandlingCodeType _handlingCode;
        private HandlingInstructionsType _handlingInstructions;
        private HazardousRiskIndicatorType _hazardousRiskIndicator;
        private TotalGoodsItemQuantityType _totalGoodsItemQuantity;
        private TotalPackageQuantityType _totalPackageQuantity;
        private List<DamageRemarksType> _damageRemarks;
        private TraceIDType _traceID;
        private List<PackageType> _actualPackage;
        private List<TransportEquipmentType> _transportEquipment;
        private List<TransportMeansType> _transportMeans;
        private List<HazardousGoodsTransitType> _hazardousGoodsTransit;
        private List<DimensionType> _measurementDimension;
        private TemperatureType _minimumTemperature;
        private TemperatureType _maximumTemperature;
        private DimensionType _floorSpaceMeasurementDimension;
        private DimensionType _palletSpaceMeasurementDimension;
        private List<DocumentReferenceType> _shipmentDocumentReference;
        private List<CustomsDeclarationType> _customsDeclaration;
        #endregion
        
        public TransportHandlingUnitType()
        {
            _customsDeclaration = new List<CustomsDeclarationType>();
            _shipmentDocumentReference = new List<DocumentReferenceType>();
            _palletSpaceMeasurementDimension = new DimensionType();
            _floorSpaceMeasurementDimension = new DimensionType();
            _maximumTemperature = new TemperatureType();
            _minimumTemperature = new TemperatureType();
            _measurementDimension = new List<DimensionType>();
            _hazardousGoodsTransit = new List<HazardousGoodsTransitType>();
            _transportMeans = new List<TransportMeansType>();
            _transportEquipment = new List<TransportEquipmentType>();
            _actualPackage = new List<PackageType>();
            _traceID = new TraceIDType();
            _damageRemarks = new List<DamageRemarksType>();
            _totalPackageQuantity = new TotalPackageQuantityType();
            _totalGoodsItemQuantity = new TotalGoodsItemQuantityType();
            _hazardousRiskIndicator = new HazardousRiskIndicatorType();
            _handlingInstructions = new HandlingInstructionsType();
            _handlingCode = new HandlingCodeType();
            _transportHandlingUnitTypeCode = new TransportHandlingUnitTypeCodeType();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode
        {
            get
            {
                return _transportHandlingUnitTypeCode;
            }
            set
            {
                _transportHandlingUnitTypeCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public HandlingCodeType HandlingCode
        {
            get
            {
                return _handlingCode;
            }
            set
            {
                _handlingCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public HandlingInstructionsType HandlingInstructions
        {
            get
            {
                return _handlingInstructions;
            }
            set
            {
                _handlingInstructions = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public HazardousRiskIndicatorType HazardousRiskIndicator
        {
            get
            {
                return _hazardousRiskIndicator;
            }
            set
            {
                _hazardousRiskIndicator = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public TotalGoodsItemQuantityType TotalGoodsItemQuantity
        {
            get
            {
                return _totalGoodsItemQuantity;
            }
            set
            {
                _totalGoodsItemQuantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public TotalPackageQuantityType TotalPackageQuantity
        {
            get
            {
                return _totalPackageQuantity;
            }
            set
            {
                _totalPackageQuantity = value;
            }
        }
        
        [XmlElement("DamageRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public List<DamageRemarksType> DamageRemarks
        {
            get
            {
                return _damageRemarks;
            }
            set
            {
                _damageRemarks = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public TraceIDType TraceID
        {
            get
            {
                return _traceID;
            }
            set
            {
                _traceID = value;
            }
        }
        
        [XmlElement("ActualPackage", Order=9)]
        public List<PackageType> ActualPackage
        {
            get
            {
                return _actualPackage;
            }
            set
            {
                _actualPackage = value;
            }
        }
        
        [XmlElement("TransportEquipment", Order=10)]
        public List<TransportEquipmentType> TransportEquipment
        {
            get
            {
                return _transportEquipment;
            }
            set
            {
                _transportEquipment = value;
            }
        }
        
        [XmlElement("TransportMeans", Order=11)]
        public List<TransportMeansType> TransportMeans
        {
            get
            {
                return _transportMeans;
            }
            set
            {
                _transportMeans = value;
            }
        }
        
        [XmlElement("HazardousGoodsTransit", Order=12)]
        public List<HazardousGoodsTransitType> HazardousGoodsTransit
        {
            get
            {
                return _hazardousGoodsTransit;
            }
            set
            {
                _hazardousGoodsTransit = value;
            }
        }
        
        [XmlElement("MeasurementDimension", Order=13)]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
        
        [XmlElement(Order=14)]
        public TemperatureType MinimumTemperature
        {
            get
            {
                return _minimumTemperature;
            }
            set
            {
                _minimumTemperature = value;
            }
        }
        
        [XmlElement(Order=15)]
        public TemperatureType MaximumTemperature
        {
            get
            {
                return _maximumTemperature;
            }
            set
            {
                _maximumTemperature = value;
            }
        }
        
        [XmlElement(Order=16)]
        public DimensionType FloorSpaceMeasurementDimension
        {
            get
            {
                return _floorSpaceMeasurementDimension;
            }
            set
            {
                _floorSpaceMeasurementDimension = value;
            }
        }
        
        [XmlElement(Order=17)]
        public DimensionType PalletSpaceMeasurementDimension
        {
            get
            {
                return _palletSpaceMeasurementDimension;
            }
            set
            {
                _palletSpaceMeasurementDimension = value;
            }
        }
        
        [XmlElement("ShipmentDocumentReference", Order=18)]
        public List<DocumentReferenceType> ShipmentDocumentReference
        {
            get
            {
                return _shipmentDocumentReference;
            }
            set
            {
                _shipmentDocumentReference = value;
            }
        }
        
        [XmlElement("CustomsDeclaration", Order=19)]
        public List<CustomsDeclarationType> CustomsDeclaration
        {
            get
            {
                return _customsDeclaration;
            }
            set
            {
                _customsDeclaration = value;
            }
        }
    }
    
        
  
    
    
        
    
             
    
    [System.CodeDom.Compiler.GeneratedCode("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class BillingReferenceLineType
    {
        #region Private fields
        private IDType _id;
        private AmountType2 _amount;
        private List<AllowanceChargeType> _allowanceCharge;
        #endregion
        
        public BillingReferenceLineType()
        {
            _allowanceCharge = new List<AllowanceChargeType>();
            _amount = new AmountType2();
            _id = new IDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IDType ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public AmountType2 Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        [XmlElement("AllowanceCharge", Order=2)]
        public List<AllowanceChargeType> AllowanceCharge
        {
            get
            {
                return _allowanceCharge;
            }
            set
            {
                _allowanceCharge = value;
            }
        }
    }        
}