using EInvoice.Xsd.Invoice.Bases;
using EInvoice.Xsd.Invoice.MonetaryTotal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace EInvoice.Xsd.Invoice {
    [XmlIncludeAttribute(typeof(ValueAmountType))]
    [XmlIncludeAttribute(typeof(TransactionCurrencyTaxAmountType))]
    [XmlIncludeAttribute(typeof(TotalTaxAmountType))]
    [XmlIncludeAttribute(typeof(TotalTaskAmountType))]
    [XmlIncludeAttribute(typeof(TotalPaymentAmountType))]
    [XmlIncludeAttribute(typeof(TotalInvoiceAmountType))]
    [XmlIncludeAttribute(typeof(TotalDebitAmountType))]
    [XmlIncludeAttribute(typeof(TotalCreditAmountType))]
    [XmlIncludeAttribute(typeof(TotalBalanceAmountType))]
    [XmlIncludeAttribute(typeof(TotalAmountType))]
    [XmlIncludeAttribute(typeof(ThresholdAmountType))]
    [XmlIncludeAttribute(typeof(TaxableAmountType))]
    [XmlIncludeAttribute(typeof(TaxInclusiveAmountType))]
    [XmlIncludeAttribute(typeof(TaxExclusiveAmountType))]
    [XmlIncludeAttribute(typeof(TaxEnergyOnAccountAmountType))]
    [XmlIncludeAttribute(typeof(TaxEnergyBalanceAmountType))]
    [XmlIncludeAttribute(typeof(TaxEnergyAmountType))]
    [XmlIncludeAttribute(typeof(TaxAmountType))]
    [XmlIncludeAttribute(typeof(SettlementDiscountAmountType))]
    [XmlIncludeAttribute(typeof(RoundingAmountType))]
    [XmlIncludeAttribute(typeof(RequiredFeeAmountType))]
    [XmlIncludeAttribute(typeof(PriceAmountType))]
    [XmlIncludeAttribute(typeof(PrepaidAmountType))]
    [XmlIncludeAttribute(typeof(PerUnitAmountType))]
    [XmlIncludeAttribute(typeof(PenaltyAmountType))]
    [XmlIncludeAttribute(typeof(PayableRoundingAmountType))]
    [XmlIncludeAttribute(typeof(PayableAmountType))]
    [XmlIncludeAttribute(typeof(PayableAlternativeAmountType))]
    [XmlIncludeAttribute(typeof(PartyCapacityAmountType))]
    [XmlIncludeAttribute(typeof(PaidAmountType))]
    [XmlIncludeAttribute(typeof(MinimumAmountType))]
    [XmlIncludeAttribute(typeof(MaximumPaidAmountType))]
    [XmlIncludeAttribute(typeof(MaximumAmountType))]
    [XmlIncludeAttribute(typeof(MaximumAdvertisementAmountType))]
    [XmlIncludeAttribute(typeof(MarketValueAmountType))]
    [XmlIncludeAttribute(typeof(LowerTenderAmountType))]
    [XmlIncludeAttribute(typeof(LineExtensionAmountType))]
    [XmlIncludeAttribute(typeof(LiabilityAmountType))]
    [XmlIncludeAttribute(typeof(InventoryValueAmountType))]
    [XmlIncludeAttribute(typeof(InsuranceValueAmountType))]
    [XmlIncludeAttribute(typeof(InsurancePremiumAmountType))]
    [XmlIncludeAttribute(typeof(HigherTenderAmountType))]
    [XmlIncludeAttribute(typeof(FreeOnBoardValueAmountType))]
    [XmlIncludeAttribute(typeof(FeeAmountType))]
    [XmlIncludeAttribute(typeof(FaceValueAmountType))]
    [XmlIncludeAttribute(typeof(EstimatedOverallContractAmountType))]
    [XmlIncludeAttribute(typeof(EstimatedAmountType))]
    [XmlIncludeAttribute(typeof(DocumentationFeeAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredStatisticsValueAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredForCarriageValueAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredCustomsValueAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredCarriageValueAmountType))]
    [XmlIncludeAttribute(typeof(DebitLineAmountType))]
    [XmlIncludeAttribute(typeof(CreditLineAmountType))]
    [XmlIncludeAttribute(typeof(CorrectionUnitAmountType))]
    [XmlIncludeAttribute(typeof(CorrectionAmountType))]
    [XmlIncludeAttribute(typeof(CorporateStockAmountType))]
    [XmlIncludeAttribute(typeof(ChargeTotalAmountType))]
    [XmlIncludeAttribute(typeof(CallExtensionAmountType))]
    [XmlIncludeAttribute(typeof(CallBaseAmountType))]
    [XmlIncludeAttribute(typeof(BaseAmountType))]
    [XmlIncludeAttribute(typeof(BalanceAmountType))]
    [XmlIncludeAttribute(typeof(AverageSubsequentContractAmountType))]
    [XmlIncludeAttribute(typeof(AverageAmountType))]
    [XmlIncludeAttribute(typeof(AnnualAverageAmountType))]
    [XmlIncludeAttribute(typeof(AmountType2))]
    [XmlIncludeAttribute(typeof(AllowanceTotalAmountType))]
    [XmlIncludeAttribute(typeof(AdvertisementAmountType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="AmountType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class AmountType1 : AmountType
    {
    }
    
    [XmlIncludeAttribute(typeof(AmountType1))]
    [XmlIncludeAttribute(typeof(ValueAmountType))]
    [XmlIncludeAttribute(typeof(TransactionCurrencyTaxAmountType))]
    [XmlIncludeAttribute(typeof(TotalTaxAmountType))]
    [XmlIncludeAttribute(typeof(TotalTaskAmountType))]
    [XmlIncludeAttribute(typeof(TotalPaymentAmountType))]
    [XmlIncludeAttribute(typeof(TotalInvoiceAmountType))]
    [XmlIncludeAttribute(typeof(TotalDebitAmountType))]
    [XmlIncludeAttribute(typeof(TotalCreditAmountType))]
    [XmlIncludeAttribute(typeof(TotalBalanceAmountType))]
    [XmlIncludeAttribute(typeof(TotalAmountType))]
    [XmlIncludeAttribute(typeof(ThresholdAmountType))]
    [XmlIncludeAttribute(typeof(TaxableAmountType))]
    [XmlIncludeAttribute(typeof(TaxInclusiveAmountType))]
    [XmlIncludeAttribute(typeof(TaxExclusiveAmountType))]
    [XmlIncludeAttribute(typeof(TaxEnergyOnAccountAmountType))]
    [XmlIncludeAttribute(typeof(TaxEnergyBalanceAmountType))]
    [XmlIncludeAttribute(typeof(TaxEnergyAmountType))]
    [XmlIncludeAttribute(typeof(TaxAmountType))]
    [XmlIncludeAttribute(typeof(SettlementDiscountAmountType))]
    [XmlIncludeAttribute(typeof(RoundingAmountType))]
    [XmlIncludeAttribute(typeof(RequiredFeeAmountType))]
    [XmlIncludeAttribute(typeof(PriceAmountType))]
    [XmlIncludeAttribute(typeof(PrepaidAmountType))]
    [XmlIncludeAttribute(typeof(PerUnitAmountType))]
    [XmlIncludeAttribute(typeof(PenaltyAmountType))]
    [XmlIncludeAttribute(typeof(PayableRoundingAmountType))]
    [XmlIncludeAttribute(typeof(PayableAmountType))]
    [XmlIncludeAttribute(typeof(PayableAlternativeAmountType))]
    [XmlIncludeAttribute(typeof(PartyCapacityAmountType))]
    [XmlIncludeAttribute(typeof(PaidAmountType))]
    [XmlIncludeAttribute(typeof(MinimumAmountType))]
    [XmlIncludeAttribute(typeof(MaximumPaidAmountType))]
    [XmlIncludeAttribute(typeof(MaximumAmountType))]
    [XmlIncludeAttribute(typeof(MaximumAdvertisementAmountType))]
    [XmlIncludeAttribute(typeof(MarketValueAmountType))]
    [XmlIncludeAttribute(typeof(LowerTenderAmountType))]
    [XmlIncludeAttribute(typeof(LineExtensionAmountType))]
    [XmlIncludeAttribute(typeof(LiabilityAmountType))]
    [XmlIncludeAttribute(typeof(InventoryValueAmountType))]
    [XmlIncludeAttribute(typeof(InsuranceValueAmountType))]
    [XmlIncludeAttribute(typeof(InsurancePremiumAmountType))]
    [XmlIncludeAttribute(typeof(HigherTenderAmountType))]
    [XmlIncludeAttribute(typeof(FreeOnBoardValueAmountType))]
    [XmlIncludeAttribute(typeof(FeeAmountType))]
    [XmlIncludeAttribute(typeof(FaceValueAmountType))]
    [XmlIncludeAttribute(typeof(EstimatedOverallContractAmountType))]
    [XmlIncludeAttribute(typeof(EstimatedAmountType))]
    [XmlIncludeAttribute(typeof(DocumentationFeeAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredStatisticsValueAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredForCarriageValueAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredCustomsValueAmountType))]
    [XmlIncludeAttribute(typeof(DeclaredCarriageValueAmountType))]
    [XmlIncludeAttribute(typeof(DebitLineAmountType))]
    [XmlIncludeAttribute(typeof(CreditLineAmountType))]
    [XmlIncludeAttribute(typeof(CorrectionUnitAmountType))]
    [XmlIncludeAttribute(typeof(CorrectionAmountType))]
    [XmlIncludeAttribute(typeof(CorporateStockAmountType))]
    [XmlIncludeAttribute(typeof(ChargeTotalAmountType))]
    [XmlIncludeAttribute(typeof(CallExtensionAmountType))]
    [XmlIncludeAttribute(typeof(CallBaseAmountType))]
    [XmlIncludeAttribute(typeof(BaseAmountType))]
    [XmlIncludeAttribute(typeof(BalanceAmountType))]
    [XmlIncludeAttribute(typeof(AverageSubsequentContractAmountType))]
    [XmlIncludeAttribute(typeof(AverageAmountType))]
    [XmlIncludeAttribute(typeof(AnnualAverageAmountType))]
    [XmlIncludeAttribute(typeof(AmountType2))]
    [XmlIncludeAttribute(typeof(AllowanceTotalAmountType))]
    [XmlIncludeAttribute(typeof(AdvertisementAmountType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class AmountType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransactionCurrencyTaxAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalTaxAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalTaskAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalPaymentAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalInvoiceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalDebitAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalCreditAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalBalanceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ThresholdAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxableAmountType : AmountType1
    {
    }
       
       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxEnergyOnAccountAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxEnergyBalanceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxEnergyAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SettlementDiscountAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RoundingAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequiredFeeAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PriceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrepaidAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PerUnitAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PenaltyAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PayableRoundingAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PayableAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PayableAlternativeAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PartyCapacityAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaidAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumPaidAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumAdvertisementAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MarketValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LowerTenderAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LiabilityAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InventoryValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InsuranceValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InsurancePremiumAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HigherTenderAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FreeOnBoardValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FeeAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FaceValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedOverallContractAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DocumentationFeeAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DeclaredStatisticsValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DeclaredForCarriageValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DeclaredCustomsValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DeclaredCarriageValueAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DebitLineAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CreditLineAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CorrectionUnitAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CorrectionAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CorporateStockAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChargeTotalAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CallExtensionAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CallBaseAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BaseAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BalanceAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AverageSubsequentContractAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AverageAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AnnualAverageAmountType : AmountType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="AmountType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AmountType2 : AmountType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdvertisementAmountType : AmountType1
    {
    }
    
        
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SourceCurrencyCodeType : CodeType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WorkPhaseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WeightingAlgorithmCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WeekDayCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidationResultCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class UtilityStatementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class UrgencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class UNDGCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportationStatusTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportServiceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportModeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportMeansTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportHandlingUnitTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportExecutionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportEventTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportEquipmentTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportEmergencyCardCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportAuthorizationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransitDirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TradeServiceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TradeItemPackingLabelingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TrackingDeviceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimingComplaintCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimeFrequencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ThresholdValueComparisonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TendererRoleCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TendererRequirementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TenderTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TenderResultCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TenderEnvelopeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelecommunicationsSupplyTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelecommunicationsServiceCategoryCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelecommunicationsServiceCallCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxExemptionReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TariffCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TariffClassCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TargetCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SupplyChainActivityTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubstitutionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubscriberTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubmissionMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubcontractingConditionsCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StatusReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StatementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SpecificationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SizeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ShortageActionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ShippingPriorityLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ServiceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ServiceInformationPreferenceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SecurityClassificationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SealStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SealIssuerTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RoleCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RevisionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RetailEventStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResponseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResolutionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResidenceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequestedInvoiceCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReminderTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RejectReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RejectActionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReferenceEventCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReceiptAdviceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class QuantityDiscrepancyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class QualityControlCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PurposeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProviderTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PromotionalEventTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProfileStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProcurementTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProcurementSubTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProcessReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProcedureCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrivacyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PricingCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PriceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PriceEvaluationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreviousMeterReadingMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreviousCancellationReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreferenceCriterionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PositionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PerformanceMetricTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentPurposeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentMeansCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentFrequencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentChannelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentAlternativeCurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PartyTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PartPresentationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ParentDocumentTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PackingCriteriaCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PackagingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PackageLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PackLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OwnerTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrderTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrderResponseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OneTimeChargeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NotificationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NatureCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NameCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MiscellaneousEventTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MimeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeterReadingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeterConstantCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MedicalFirstAidGuideCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MathematicOperatorCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MandateTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LossRiskResponsibilityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LongitudeDirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LocationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LocaleCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LineStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LifeCycleStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatitudeDirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestMeterReadingMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ItemClassificationCodeType : CodeType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InspectionMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InhalationToxicityZoneCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IndustryClassificationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ImportanceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IdentificationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HeatingTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HazardousRegulationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HazardousCategoryCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HandlingCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GuaranteeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GenderCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FundingProgramCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FullnessIndicationCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FreightRateClassCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FormatCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ForecastTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ForecastPurposeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FinancingInstrumentCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FeatureTacticTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExpressionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExpenseCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExemptionReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExecutionRequirementCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExceptionStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExceptionResolutionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EvidenceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EvaluationCriterionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EnvironmentalEmissionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EncodingCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EmergencyProceduresCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DutyCodeType : CodeType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DocumentStatusReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DocumentStatusCodeType : CodeType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DispositionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DisplayTacticTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DirectionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DespatchAdviceTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DescriptionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DeclarationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DataSourceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CustomsStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CurrentChargeTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CurrencyCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CreditNoteTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CountrySubentityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CorrectionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CorporateRegistrationTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CoordinateSystemCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContractingSystemCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContractTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumersEnergyLevelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumerIncentiveTacticTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConstitutionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConditionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ComparisonDataSourceCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ComparisonDataCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CompanyLiquidationStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CompanyLegalFormCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CommodityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CollaborationPriorityCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CharacterSetCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChannelCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CertificateTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CargoTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CardTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CardChipCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CapabilityTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CalculationMethodCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CalculationExpressionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AwardingMethodTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AwardingCriterionTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AvailabilityStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ApplicationStatusCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AllowanceChargeReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdmissionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdjustmentReasonCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AddressTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AddressFormatCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActivityTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActionCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AccountingCostCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AccountTypeCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AccountFormatCodeType : CodeType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CalculationRateType : RateType
    {
    }
    
    [XmlIncludeAttribute(typeof(TargetCurrencyBaseRateType))]
    [XmlIncludeAttribute(typeof(SourceCurrencyBaseRateType))]
    [XmlIncludeAttribute(typeof(RateType1))]
    [XmlIncludeAttribute(typeof(OrderableUnitFactorRateType))]
    [XmlIncludeAttribute(typeof(CalculationRateType))]
    [XmlIncludeAttribute(typeof(AmountRateType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class RateType : NumericType
    {
    }
    
    [XmlIncludeAttribute(typeof(RateType))]
    [XmlIncludeAttribute(typeof(TargetCurrencyBaseRateType))]
    [XmlIncludeAttribute(typeof(SourceCurrencyBaseRateType))]
    [XmlIncludeAttribute(typeof(RateType1))]
    [XmlIncludeAttribute(typeof(OrderableUnitFactorRateType))]
    [XmlIncludeAttribute(typeof(CalculationRateType))]
    [XmlIncludeAttribute(typeof(AmountRateType))]
    [XmlIncludeAttribute(typeof(PercentType))]
    [XmlIncludeAttribute(typeof(TierRatePercentType))]
    [XmlIncludeAttribute(typeof(TargetServicePercentType))]
    [XmlIncludeAttribute(typeof(SettlementDiscountPercentType))]
    [XmlIncludeAttribute(typeof(ReliabilityPercentType))]
    [XmlIncludeAttribute(typeof(ProgressPercentType))]
    [XmlIncludeAttribute(typeof(PercentType1))]
    [XmlIncludeAttribute(typeof(PenaltySurchargePercentType))]
    [XmlIncludeAttribute(typeof(PaymentPercentType))]
    [XmlIncludeAttribute(typeof(ParticipationPercentType))]
    [XmlIncludeAttribute(typeof(PartecipationPercentType))]
    [XmlIncludeAttribute(typeof(MinimumPercentType))]
    [XmlIncludeAttribute(typeof(MaximumPercentType))]
    [XmlIncludeAttribute(typeof(HumidityPercentType))]
    [XmlIncludeAttribute(typeof(AirFlowPercentType))]
    [XmlIncludeAttribute(typeof(ValueType1))]
    [XmlIncludeAttribute(typeof(NumericType1))]
    [XmlIncludeAttribute(typeof(WeightNumericType))]
    [XmlIncludeAttribute(typeof(SequenceNumericType))]
    [XmlIncludeAttribute(typeof(ResidentOccupantsNumericType))]
    [XmlIncludeAttribute(typeof(ReminderSequenceNumericType))]
    [XmlIncludeAttribute(typeof(PackSizeNumericType))]
    [XmlIncludeAttribute(typeof(OrderQuantityIncrementNumericType))]
    [XmlIncludeAttribute(typeof(OrderIntervalDaysNumericType))]
    [XmlIncludeAttribute(typeof(MultiplierFactorNumericType))]
    [XmlIncludeAttribute(typeof(MinimumNumberNumericType))]
    [XmlIncludeAttribute(typeof(MaximumPaymentInstructionsNumericType))]
    [XmlIncludeAttribute(typeof(MaximumNumberNumericType))]
    [XmlIncludeAttribute(typeof(MaximumCopiesNumericType))]
    [XmlIncludeAttribute(typeof(LineNumberNumericType))]
    [XmlIncludeAttribute(typeof(LineCountNumericType))]
    [XmlIncludeAttribute(typeof(FrozenPeriodDaysNumericType))]
    [XmlIncludeAttribute(typeof(CalculationSequenceNumericType))]
    [XmlIncludeAttribute(typeof(BudgetYearNumericType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class NumericType
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
    
    [XmlIncludeAttribute(typeof(TierRatePercentType))]
    [XmlIncludeAttribute(typeof(TargetServicePercentType))]
    [XmlIncludeAttribute(typeof(SettlementDiscountPercentType))]
    [XmlIncludeAttribute(typeof(ReliabilityPercentType))]
    [XmlIncludeAttribute(typeof(ProgressPercentType))]
    [XmlIncludeAttribute(typeof(PercentType1))]
    [XmlIncludeAttribute(typeof(PenaltySurchargePercentType))]
    [XmlIncludeAttribute(typeof(PaymentPercentType))]
    [XmlIncludeAttribute(typeof(ParticipationPercentType))]
    [XmlIncludeAttribute(typeof(PartecipationPercentType))]
    [XmlIncludeAttribute(typeof(MinimumPercentType))]
    [XmlIncludeAttribute(typeof(MaximumPercentType))]
    [XmlIncludeAttribute(typeof(HumidityPercentType))]
    [XmlIncludeAttribute(typeof(AirFlowPercentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class PercentType : NumericType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TierRatePercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TargetServicePercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SettlementDiscountPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReliabilityPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProgressPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="PercentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PercentType1 : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PenaltySurchargePercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ParticipationPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PartecipationPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HumidityPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AirFlowPercentType : PercentType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="ValueType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class ValueType1 : NumericType
    {
    }
    
    [XmlIncludeAttribute(typeof(WeightNumericType))]
    [XmlIncludeAttribute(typeof(SequenceNumericType))]
    [XmlIncludeAttribute(typeof(ResidentOccupantsNumericType))]
    [XmlIncludeAttribute(typeof(ReminderSequenceNumericType))]
    [XmlIncludeAttribute(typeof(PackSizeNumericType))]
    [XmlIncludeAttribute(typeof(OrderQuantityIncrementNumericType))]
    [XmlIncludeAttribute(typeof(OrderIntervalDaysNumericType))]
    [XmlIncludeAttribute(typeof(MultiplierFactorNumericType))]
    [XmlIncludeAttribute(typeof(MinimumNumberNumericType))]
    [XmlIncludeAttribute(typeof(MaximumPaymentInstructionsNumericType))]
    [XmlIncludeAttribute(typeof(MaximumNumberNumericType))]
    [XmlIncludeAttribute(typeof(MaximumCopiesNumericType))]
    [XmlIncludeAttribute(typeof(LineNumberNumericType))]
    [XmlIncludeAttribute(typeof(LineCountNumericType))]
    [XmlIncludeAttribute(typeof(FrozenPeriodDaysNumericType))]
    [XmlIncludeAttribute(typeof(CalculationSequenceNumericType))]
    [XmlIncludeAttribute(typeof(BudgetYearNumericType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="NumericType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class NumericType1 : NumericType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WeightNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SequenceNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResidentOccupantsNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReminderSequenceNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PackSizeNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrderQuantityIncrementNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrderIntervalDaysNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MultiplierFactorNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumNumberNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumPaymentInstructionsNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumNumberNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumCopiesNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LineNumberNumericType : NumericType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FrozenPeriodDaysNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CalculationSequenceNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BudgetYearNumericType : NumericType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TargetCurrencyBaseRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SourceCurrencyBaseRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="RateType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RateType1 : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrderableUnitFactorRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AmountRateType : RateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="DateType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DateType1 : DateType
    {
    }
    
        
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidityStartDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxPointDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubmissionDueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubmissionDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StartDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SourceForecastIssueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RevisionDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResponseDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResolutionDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequiredDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequestedPublicationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequestedDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequestedDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegistrationExpirationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegistrationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegisteredDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReferenceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReceivedDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreviousMeterReadingDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PlannedDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentDueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaidDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OccurrenceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NominationDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ManufactureDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestSecurityClearanceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestProposalAcceptanceDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestPickupDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestMeterReadingDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LastRevisionDateType : DateType
    {
    }
    
        
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InstallmentDueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GuaranteedDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FirstShipmentAvailibilityDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExpiryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedDeliveryDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EndDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EffectiveDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EarliestPickupDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ComparisonForecastIssueDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CallDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BirthDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BestBeforeDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AwardDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AvailabilityDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ApprovalDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActualPickupDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActualDespatchDateType : DateType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActualDeliveryDateType : DateType
    {
    }         
    
    [XmlIncludeAttribute(typeof(VesselNameType))]
    [XmlIncludeAttribute(typeof(TechnicalNameType))]
    [XmlIncludeAttribute(typeof(StreetNameType))]
    [XmlIncludeAttribute(typeof(ServiceNameType))]
    [XmlIncludeAttribute(typeof(RoamingPartnerNameType))]
    [XmlIncludeAttribute(typeof(RetailEventNameType))]
    [XmlIncludeAttribute(typeof(RegistrationNameType))]
    [XmlIncludeAttribute(typeof(OtherNameType))]
    [XmlIncludeAttribute(typeof(NameType1))]
    [XmlIncludeAttribute(typeof(ModelNameType))]
    [XmlIncludeAttribute(typeof(MiddleNameType))]
    [XmlIncludeAttribute(typeof(HolderNameType))]
    [XmlIncludeAttribute(typeof(FirstNameType))]
    [XmlIncludeAttribute(typeof(FileNameType))]
    [XmlIncludeAttribute(typeof(FamilyNameType))]
    [XmlIncludeAttribute(typeof(CitySubdivisionNameType))]
    [XmlIncludeAttribute(typeof(CityNameType))]
    [XmlIncludeAttribute(typeof(CategoryNameType))]
    [XmlIncludeAttribute(typeof(BuildingNameType))]
    [XmlIncludeAttribute(typeof(BrandNameType))]
    [XmlIncludeAttribute(typeof(BlockNameType))]
    [XmlIncludeAttribute(typeof(AliasNameType))]
    [XmlIncludeAttribute(typeof(AdditionalStreetNameType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class NameType : TextType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class VesselNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TechnicalNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StreetNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ServiceNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RoamingPartnerNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RetailEventNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegistrationNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OtherNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="NameType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NameType1 : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ModelNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MiddleNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HolderNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FirstNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FileNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FamilyNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CitySubdivisionNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CityNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CategoryNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BuildingNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BrandNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BlockNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AliasNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdditionalStreetNameType : NameType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionAgencyNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class XPathType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WorkPhaseType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WeightType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WarrantyInformationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValueQualifierType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidateToolVersionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidateToolType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidateProcessType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportationServiceDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportUserSpecialTermsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportUserRemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportServiceProviderSpecialTermsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportServiceProviderRemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TradingRestrictionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TitleType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimingComplaintType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimezoneOffsetType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimeAmountType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TierRangeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="TextType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TextType2 : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TestMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelephoneType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelefaxType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelecommunicationsSupplyTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelecommunicationsServiceCategoryType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TelecommunicationsServiceCallType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TechnicalCommitteeDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxExemptionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TariffDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SummaryDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubscriberTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StatusReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SpecialTransportRequirementsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SpecialTermsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SpecialServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SpecialInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SignatureMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ShipsRequirementsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ShippingMarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ServiceTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ServiceNumberCalledType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SealingPartyTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RoomType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RoleDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResolutionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResidenceTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReplenishmentOwnerDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RejectionNoteType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RejectReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegulatoryDomainType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegistrationNationalityType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RankType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PurposeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProcessReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProcessDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrizeDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PriorityType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrintQualifierType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PriceTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PriceRevisionFormulaDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PriceChangeReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreviousMeterReadingMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PostboxType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PostalZoneType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PlotIdentificationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PlacardNotationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PlacardEndorsementType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PhoneNumberType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PersonalSituationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentOrderReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentNoteType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PayerReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PayPerViewType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PasswordType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PartyTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PackingMaterialType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OutstandingReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OtherInstructionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrganizationDepartmentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrderableUnitType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OptionsDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OneTimeChargeTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NegotiationDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NameSuffixType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MovieTitleType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MonetaryScopeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumImprovementBidType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeterReadingTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeterReadingCommentsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeterNumberType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeterNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeterConstantType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MarkCareType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MarkAttentionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LowTendersDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LossRiskType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LoginType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LocationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ListValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LineType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LimitationDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LegalReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestMeterReadingMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class KeywordType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class JustificationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class JustificationDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class JobTitleType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InvoicingPartyReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InstructionNoteType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InhouseMailType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InformationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HeatingTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HaulageInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HashAlgorithmMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HandlingInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FundingProgramType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FrequencyType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ForwarderServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FloorType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FeeDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExtensionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExpressionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExemptionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExclusionReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ElectronicMailType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ElectronicDeviceDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DutyType : TextType1
    {
    }
          
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DocumentStatusReasonDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DocumentHashType : TextType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DistrictType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DepartmentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DemurrageInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DeliveryInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DataSendingCapabilityType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DamageRemarksType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CustomsClearanceServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CustomerReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CurrentChargeTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CountrySubentityType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CorrectionTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContractTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContractSubdivisionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContractNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionLevelType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumersEnergyLevelType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConditionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConditionsDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConditionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CompanyLegalFormType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CommentType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CodeValueType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CharacteristicsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChannelType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChangeConditionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CertificateTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CarrierServiceInstructionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CanonicalizationMethodType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CandidateStatementType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CancellationNoteType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CalculationExpressionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BuyerReferenceType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BuildingNumberType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BirthplaceNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BackorderReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AwardingCriterionDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ApprovalStatusType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AllowanceChargeReasonType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AgencyNameType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdditionalInformationType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdditionalConditionsType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActivityTypeType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AccountingCostType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AcceptedVariantsDescriptionType : TextType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PeriodType
    {
        #region Private fields
        private StartDateType _startDate;
        private StartTimeType _startTime;
        private EndDateType _endDate;
        private EndTimeType _endTime;
        private DurationMeasureType _durationMeasure;
        private DescriptionType _description;
        #endregion
        
        public PeriodType()
        {
            _description = new DescriptionType();
            _durationMeasure = new DurationMeasureType();
            _endTime = new EndTimeType();
            _endDate = new EndDateType();
            _startTime = new StartTimeType();
            _startDate = new StartDateType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public StartDateType StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public StartTimeType StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public EndDateType EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public EndTimeType EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public DurationMeasureType DurationMeasure
        {
            get
            {
                return _durationMeasure;
            }
            set
            {
                _durationMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StartTimeType : TimeType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidationTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SourceForecastIssueTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RevisionTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResponseTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ResolutionTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequiredDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequestedDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegisteredTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReferenceTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaidTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OccurrenceTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NominationTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ManufactureTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestPickupTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LastRevisionTimeType : TimeType
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GuaranteedDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExpiryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EndTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EffectiveTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EarliestPickupTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ComparisonForecastIssueTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CallTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AwardTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActualPickupTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActualDespatchTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActualDeliveryTimeType : TimeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DurationMeasureType : MeasureType1
    {
    }
    
    [XmlIncludeAttribute(typeof(ValueMeasureType))]
    [XmlIncludeAttribute(typeof(TareWeightMeasureType))]
    [XmlIncludeAttribute(typeof(SourceValueMeasureType))]
    [XmlIncludeAttribute(typeof(PreEventNotificationDurationMeasureType))]
    [XmlIncludeAttribute(typeof(PostEventNotificationDurationMeasureType))]
    [XmlIncludeAttribute(typeof(NetWeightMeasureType))]
    [XmlIncludeAttribute(typeof(NetVolumeMeasureType))]
    [XmlIncludeAttribute(typeof(NetTonnageMeasureType))]
    [XmlIncludeAttribute(typeof(NetNetWeightMeasureType))]
    [XmlIncludeAttribute(typeof(MinimumMeasureType))]
    [XmlIncludeAttribute(typeof(MeasureType2))]
    [XmlIncludeAttribute(typeof(MaximumMeasureType))]
    [XmlIncludeAttribute(typeof(LongitudeMinutesMeasureType))]
    [XmlIncludeAttribute(typeof(LongitudeDegreesMeasureType))]
    [XmlIncludeAttribute(typeof(LoadingLengthMeasureType))]
    [XmlIncludeAttribute(typeof(LeadTimeMeasureType))]
    [XmlIncludeAttribute(typeof(LatitudeMinutesMeasureType))]
    [XmlIncludeAttribute(typeof(LatitudeDegreesMeasureType))]
    [XmlIncludeAttribute(typeof(GrossWeightMeasureType))]
    [XmlIncludeAttribute(typeof(GrossVolumeMeasureType))]
    [XmlIncludeAttribute(typeof(GrossTonnageMeasureType))]
    [XmlIncludeAttribute(typeof(DurationMeasureType))]
    [XmlIncludeAttribute(typeof(ComparedValueMeasureType))]
    [XmlIncludeAttribute(typeof(ChargeableWeightMeasureType))]
    [XmlIncludeAttribute(typeof(BaseUnitMeasureType))]
    [XmlIncludeAttribute(typeof(AltitudeMeasureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="MeasureType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class MeasureType1 : MeasureType
    {
    }
    
    [XmlIncludeAttribute(typeof(MeasureType1))]
    [XmlIncludeAttribute(typeof(ValueMeasureType))]
    [XmlIncludeAttribute(typeof(TareWeightMeasureType))]
    [XmlIncludeAttribute(typeof(SourceValueMeasureType))]
    [XmlIncludeAttribute(typeof(PreEventNotificationDurationMeasureType))]
    [XmlIncludeAttribute(typeof(PostEventNotificationDurationMeasureType))]
    [XmlIncludeAttribute(typeof(NetWeightMeasureType))]
    [XmlIncludeAttribute(typeof(NetVolumeMeasureType))]
    [XmlIncludeAttribute(typeof(NetTonnageMeasureType))]
    [XmlIncludeAttribute(typeof(NetNetWeightMeasureType))]
    [XmlIncludeAttribute(typeof(MinimumMeasureType))]
    [XmlIncludeAttribute(typeof(MeasureType2))]
    [XmlIncludeAttribute(typeof(MaximumMeasureType))]
    [XmlIncludeAttribute(typeof(LongitudeMinutesMeasureType))]
    [XmlIncludeAttribute(typeof(LongitudeDegreesMeasureType))]
    [XmlIncludeAttribute(typeof(LoadingLengthMeasureType))]
    [XmlIncludeAttribute(typeof(LeadTimeMeasureType))]
    [XmlIncludeAttribute(typeof(LatitudeMinutesMeasureType))]
    [XmlIncludeAttribute(typeof(LatitudeDegreesMeasureType))]
    [XmlIncludeAttribute(typeof(GrossWeightMeasureType))]
    [XmlIncludeAttribute(typeof(GrossVolumeMeasureType))]
    [XmlIncludeAttribute(typeof(GrossTonnageMeasureType))]
    [XmlIncludeAttribute(typeof(DurationMeasureType))]
    [XmlIncludeAttribute(typeof(ComparedValueMeasureType))]
    [XmlIncludeAttribute(typeof(ChargeableWeightMeasureType))]
    [XmlIncludeAttribute(typeof(BaseUnitMeasureType))]
    [XmlIncludeAttribute(typeof(AltitudeMeasureType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class MeasureType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValueMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TareWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SourceValueMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreEventNotificationDurationMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PostEventNotificationDurationMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NetWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NetVolumeMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NetTonnageMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NetNetWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="MeasureType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MeasureType2 : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LongitudeMinutesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LongitudeDegreesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LoadingLengthMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LeadTimeMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatitudeMinutesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatitudeDegreesMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GrossWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GrossVolumeMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GrossTonnageMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ComparedValueMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChargeableWeightMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BaseUnitMeasureType : MeasureType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AltitudeMeasureType : MeasureType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class FinancialAccountType
    {
        #region Private fields
        private IDType _id;
        private CurrencyCodeType _currencyCode;
        private PaymentNoteType _paymentNote;
        private BranchType _financialInstitutionBranch;
        #endregion
        
        public FinancialAccountType()
        {
            _financialInstitutionBranch = new BranchType();
            _paymentNote = new PaymentNoteType();
            _currencyCode = new CurrencyCodeType();
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
        public CurrencyCodeType CurrencyCode
        {
            get
            {
                return _currencyCode;
            }
            set
            {
                _currencyCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public PaymentNoteType PaymentNote
        {
            get
            {
                return _paymentNote;
            }
            set
            {
                _paymentNote = value;
            }
        }
        
        [XmlElement(Order=3)]
        public BranchType FinancialInstitutionBranch
        {
            get
            {
                return _financialInstitutionBranch;
            }
            set
            {
                _financialInstitutionBranch = value;
            }
        }
    }
        
    
    [XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
    [XmlIncludeAttribute(typeof(ExtensionVersionIDType))]
    [XmlIncludeAttribute(typeof(ExtensionURIType))]
    [XmlIncludeAttribute(typeof(ExtensionAgencyURIType))]
    [XmlIncludeAttribute(typeof(ExtensionAgencyIDType))]
    [XmlIncludeAttribute(typeof(WebsiteURIType))]
    [XmlIncludeAttribute(typeof(VesselIDType))]
    [XmlIncludeAttribute(typeof(VersionIDType))]
    [XmlIncludeAttribute(typeof(VariantIDType))]
    [XmlIncludeAttribute(typeof(ValidatorIDType))]
    [XmlIncludeAttribute(typeof(UpperOrangeHazardPlacardIDType))]
    [XmlIncludeAttribute(typeof(UUIDType))]
    [XmlIncludeAttribute(typeof(URIType))]
    [XmlIncludeAttribute(typeof(UBLVersionIDType))]
    [XmlIncludeAttribute(typeof(TransportationServiceDetailsURIType))]
    [XmlIncludeAttribute(typeof(TransportExecutionPlanReferenceIDType))]
    [XmlIncludeAttribute(typeof(TrainIDType))]
    [XmlIncludeAttribute(typeof(TrackingIDType))]
    [XmlIncludeAttribute(typeof(TraceIDType))]
    [XmlIncludeAttribute(typeof(TenderEnvelopeIDType))]
    [XmlIncludeAttribute(typeof(SupplierAssignedAccountIDType))]
    [XmlIncludeAttribute(typeof(SuccessiveSequenceIDType))]
    [XmlIncludeAttribute(typeof(SubscriberIDType))]
    [XmlIncludeAttribute(typeof(SpecificationIDType))]
    [XmlIncludeAttribute(typeof(SignatureIDType))]
    [XmlIncludeAttribute(typeof(ShippingOrderIDType))]
    [XmlIncludeAttribute(typeof(SerialIDType))]
    [XmlIncludeAttribute(typeof(SequenceNumberIDType))]
    [XmlIncludeAttribute(typeof(SequenceIDType))]
    [XmlIncludeAttribute(typeof(SellerEventIDType))]
    [XmlIncludeAttribute(typeof(SecurityIDType))]
    [XmlIncludeAttribute(typeof(SchemeURIType))]
    [XmlIncludeAttribute(typeof(SalesOrderLineIDType))]
    [XmlIncludeAttribute(typeof(SalesOrderIDType))]
    [XmlIncludeAttribute(typeof(RevisedForecastLineIDType))]
    [XmlIncludeAttribute(typeof(RequiredCustomsIDType))]
    [XmlIncludeAttribute(typeof(RequestForQuotationLineIDType))]
    [XmlIncludeAttribute(typeof(ReleaseIDType))]
    [XmlIncludeAttribute(typeof(RegistrationNationalityIDType))]
    [XmlIncludeAttribute(typeof(RegistrationIDType))]
    [XmlIncludeAttribute(typeof(ReferencedConsignmentIDType))]
    [XmlIncludeAttribute(typeof(ReferenceIDType))]
    [XmlIncludeAttribute(typeof(RailCarIDType))]
    [XmlIncludeAttribute(typeof(RadioCallSignIDType))]
    [XmlIncludeAttribute(typeof(ProfileIDType))]
    [XmlIncludeAttribute(typeof(ProfileExecutionIDType))]
    [XmlIncludeAttribute(typeof(ProductTraceIDType))]
    [XmlIncludeAttribute(typeof(PrimaryAccountNumberIDType))]
    [XmlIncludeAttribute(typeof(PreviousVersionIDType))]
    [XmlIncludeAttribute(typeof(PreviousJobIDType))]
    [XmlIncludeAttribute(typeof(PrepaidPaymentReferenceIDType))]
    [XmlIncludeAttribute(typeof(PerformingCarrierAssignedIDType))]
    [XmlIncludeAttribute(typeof(PaymentTermsDetailsURIType))]
    [XmlIncludeAttribute(typeof(PaymentMeansIDType))]
    [XmlIncludeAttribute(typeof(PaymentIDType))]
    [XmlIncludeAttribute(typeof(ParentDocumentVersionIDType))]
    [XmlIncludeAttribute(typeof(ParentDocumentLineReferenceIDType))]
    [XmlIncludeAttribute(typeof(ParentDocumentIDType))]
    [XmlIncludeAttribute(typeof(OriginalJobIDType))]
    [XmlIncludeAttribute(typeof(OriginalContractingSystemIDType))]
    [XmlIncludeAttribute(typeof(OpenTenderIDType))]
    [XmlIncludeAttribute(typeof(OntologyURIType))]
    [XmlIncludeAttribute(typeof(NetworkIDType))]
    [XmlIncludeAttribute(typeof(NationalityIDType))]
    [XmlIncludeAttribute(typeof(MarkingIDType))]
    [XmlIncludeAttribute(typeof(LowerOrangeHazardPlacardIDType))]
    [XmlIncludeAttribute(typeof(LotNumberIDType))]
    [XmlIncludeAttribute(typeof(LogoReferenceIDType))]
    [XmlIncludeAttribute(typeof(LocationIDType))]
    [XmlIncludeAttribute(typeof(LoadingSequenceIDType))]
    [XmlIncludeAttribute(typeof(LineIDType))]
    [XmlIncludeAttribute(typeof(LicensePlateIDType))]
    [XmlIncludeAttribute(typeof(LanguageIDType))]
    [XmlIncludeAttribute(typeof(JourneyIDType))]
    [XmlIncludeAttribute(typeof(IssuerIDType))]
    [XmlIncludeAttribute(typeof(IssueNumberIDType))]
    [XmlIncludeAttribute(typeof(InstructionIDType))]
    [XmlIncludeAttribute(typeof(InformationURIType))]
    [XmlIncludeAttribute(typeof(ImmobilizationCertificateIDType))]
    [XmlIncludeAttribute(typeof(IdentificationIDType))]
    [XmlIncludeAttribute(typeof(IDType))]
    [XmlIncludeAttribute(typeof(HazardClassIDType))]
    [XmlIncludeAttribute(typeof(FreightForwarderAssignedIDType))]
    [XmlIncludeAttribute(typeof(ExtendedIDType))]
    [XmlIncludeAttribute(typeof(ExchangeMarketIDType))]
    [XmlIncludeAttribute(typeof(EndpointIDType))]
    [XmlIncludeAttribute(typeof(EconomicOperatorRegistryURIType))]
    [XmlIncludeAttribute(typeof(DocumentIDType))]
    [XmlIncludeAttribute(typeof(CustomizationIDType))]
    [XmlIncludeAttribute(typeof(CustomerAssignedAccountIDType))]
    [XmlIncludeAttribute(typeof(ContractedCarrierAssignedIDType))]
    [XmlIncludeAttribute(typeof(ContractFolderIDType))]
    [XmlIncludeAttribute(typeof(ConsumptionReportIDType))]
    [XmlIncludeAttribute(typeof(ConsumptionIDType))]
    [XmlIncludeAttribute(typeof(ConsignorAssignedIDType))]
    [XmlIncludeAttribute(typeof(ConsigneeAssignedIDType))]
    [XmlIncludeAttribute(typeof(CompanyIDType))]
    [XmlIncludeAttribute(typeof(ChipApplicationIDType))]
    [XmlIncludeAttribute(typeof(CarrierAssignedIDType))]
    [XmlIncludeAttribute(typeof(CV2IDType))]
    [XmlIncludeAttribute(typeof(BuyerProfileURIType))]
    [XmlIncludeAttribute(typeof(BuyerEventIDType))]
    [XmlIncludeAttribute(typeof(BusinessIdentityEvidenceIDType))]
    [XmlIncludeAttribute(typeof(BusinessClassificationEvidenceIDType))]
    [XmlIncludeAttribute(typeof(BrokerAssignedIDType))]
    [XmlIncludeAttribute(typeof(BarcodeSymbologyIDType))]
    [XmlIncludeAttribute(typeof(AwardingCriterionIDType))]
    [XmlIncludeAttribute(typeof(AuctionURIType))]
    [XmlIncludeAttribute(typeof(AttributeIDType))]
    [XmlIncludeAttribute(typeof(AircraftIDType))]
    [XmlIncludeAttribute(typeof(AgencyIDType))]
    [XmlIncludeAttribute(typeof(AdditionalAccountIDType))]
    [XmlIncludeAttribute(typeof(AccountIDType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="IdentifierType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class IdentifierType1 : IdentifierType
    {
    }
    
    [XmlIncludeAttribute(typeof(IdentifierType1))]
    [XmlIncludeAttribute(typeof(ReferencedSignatureIDType))]
    [XmlIncludeAttribute(typeof(ExtensionVersionIDType))]
    [XmlIncludeAttribute(typeof(ExtensionURIType))]
    [XmlIncludeAttribute(typeof(ExtensionAgencyURIType))]
    [XmlIncludeAttribute(typeof(ExtensionAgencyIDType))]
    [XmlIncludeAttribute(typeof(WebsiteURIType))]
    [XmlIncludeAttribute(typeof(VesselIDType))]
    [XmlIncludeAttribute(typeof(VersionIDType))]
    [XmlIncludeAttribute(typeof(VariantIDType))]
    [XmlIncludeAttribute(typeof(ValidatorIDType))]
    [XmlIncludeAttribute(typeof(UpperOrangeHazardPlacardIDType))]
    [XmlIncludeAttribute(typeof(UUIDType))]
    [XmlIncludeAttribute(typeof(URIType))]
    [XmlIncludeAttribute(typeof(UBLVersionIDType))]
    [XmlIncludeAttribute(typeof(TransportationServiceDetailsURIType))]
    [XmlIncludeAttribute(typeof(TransportExecutionPlanReferenceIDType))]
    [XmlIncludeAttribute(typeof(TrainIDType))]
    [XmlIncludeAttribute(typeof(TrackingIDType))]
    [XmlIncludeAttribute(typeof(TraceIDType))]
    [XmlIncludeAttribute(typeof(TenderEnvelopeIDType))]
    [XmlIncludeAttribute(typeof(SupplierAssignedAccountIDType))]
    [XmlIncludeAttribute(typeof(SuccessiveSequenceIDType))]
    [XmlIncludeAttribute(typeof(SubscriberIDType))]
    [XmlIncludeAttribute(typeof(SpecificationIDType))]
    [XmlIncludeAttribute(typeof(SignatureIDType))]
    [XmlIncludeAttribute(typeof(ShippingOrderIDType))]
    [XmlIncludeAttribute(typeof(SerialIDType))]
    [XmlIncludeAttribute(typeof(SequenceNumberIDType))]
    [XmlIncludeAttribute(typeof(SequenceIDType))]
    [XmlIncludeAttribute(typeof(SellerEventIDType))]
    [XmlIncludeAttribute(typeof(SecurityIDType))]
    [XmlIncludeAttribute(typeof(SchemeURIType))]
    [XmlIncludeAttribute(typeof(SalesOrderLineIDType))]
    [XmlIncludeAttribute(typeof(SalesOrderIDType))]
    [XmlIncludeAttribute(typeof(RevisedForecastLineIDType))]
    [XmlIncludeAttribute(typeof(RequiredCustomsIDType))]
    [XmlIncludeAttribute(typeof(RequestForQuotationLineIDType))]
    [XmlIncludeAttribute(typeof(ReleaseIDType))]
    [XmlIncludeAttribute(typeof(RegistrationNationalityIDType))]
    [XmlIncludeAttribute(typeof(RegistrationIDType))]
    [XmlIncludeAttribute(typeof(ReferencedConsignmentIDType))]
    [XmlIncludeAttribute(typeof(ReferenceIDType))]
    [XmlIncludeAttribute(typeof(RailCarIDType))]
    [XmlIncludeAttribute(typeof(RadioCallSignIDType))]
    [XmlIncludeAttribute(typeof(ProfileIDType))]
    [XmlIncludeAttribute(typeof(ProfileExecutionIDType))]
    [XmlIncludeAttribute(typeof(ProductTraceIDType))]
    [XmlIncludeAttribute(typeof(PrimaryAccountNumberIDType))]
    [XmlIncludeAttribute(typeof(PreviousVersionIDType))]
    [XmlIncludeAttribute(typeof(PreviousJobIDType))]
    [XmlIncludeAttribute(typeof(PrepaidPaymentReferenceIDType))]
    [XmlIncludeAttribute(typeof(PerformingCarrierAssignedIDType))]
    [XmlIncludeAttribute(typeof(PaymentTermsDetailsURIType))]
    [XmlIncludeAttribute(typeof(PaymentMeansIDType))]
    [XmlIncludeAttribute(typeof(PaymentIDType))]
    [XmlIncludeAttribute(typeof(ParentDocumentVersionIDType))]
    [XmlIncludeAttribute(typeof(ParentDocumentLineReferenceIDType))]
    [XmlIncludeAttribute(typeof(ParentDocumentIDType))]
    [XmlIncludeAttribute(typeof(OriginalJobIDType))]
    [XmlIncludeAttribute(typeof(OriginalContractingSystemIDType))]
    [XmlIncludeAttribute(typeof(OpenTenderIDType))]
    [XmlIncludeAttribute(typeof(OntologyURIType))]
    [XmlIncludeAttribute(typeof(NetworkIDType))]
    [XmlIncludeAttribute(typeof(NationalityIDType))]
    [XmlIncludeAttribute(typeof(MarkingIDType))]
    [XmlIncludeAttribute(typeof(LowerOrangeHazardPlacardIDType))]
    [XmlIncludeAttribute(typeof(LotNumberIDType))]
    [XmlIncludeAttribute(typeof(LogoReferenceIDType))]
    [XmlIncludeAttribute(typeof(LocationIDType))]
    [XmlIncludeAttribute(typeof(LoadingSequenceIDType))]
    [XmlIncludeAttribute(typeof(LineIDType))]
    [XmlIncludeAttribute(typeof(LicensePlateIDType))]
    [XmlIncludeAttribute(typeof(LanguageIDType))]
    [XmlIncludeAttribute(typeof(JourneyIDType))]
    [XmlIncludeAttribute(typeof(IssuerIDType))]
    [XmlIncludeAttribute(typeof(IssueNumberIDType))]
    [XmlIncludeAttribute(typeof(InstructionIDType))]
    [XmlIncludeAttribute(typeof(InformationURIType))]
    [XmlIncludeAttribute(typeof(ImmobilizationCertificateIDType))]
    [XmlIncludeAttribute(typeof(IdentificationIDType))]
    [XmlIncludeAttribute(typeof(IDType))]
    [XmlIncludeAttribute(typeof(HazardClassIDType))]
    [XmlIncludeAttribute(typeof(FreightForwarderAssignedIDType))]
    [XmlIncludeAttribute(typeof(ExtendedIDType))]
    [XmlIncludeAttribute(typeof(ExchangeMarketIDType))]
    [XmlIncludeAttribute(typeof(EndpointIDType))]
    [XmlIncludeAttribute(typeof(EconomicOperatorRegistryURIType))]
    [XmlIncludeAttribute(typeof(DocumentIDType))]
    [XmlIncludeAttribute(typeof(CustomizationIDType))]
    [XmlIncludeAttribute(typeof(CustomerAssignedAccountIDType))]
    [XmlIncludeAttribute(typeof(ContractedCarrierAssignedIDType))]
    [XmlIncludeAttribute(typeof(ContractFolderIDType))]
    [XmlIncludeAttribute(typeof(ConsumptionReportIDType))]
    [XmlIncludeAttribute(typeof(ConsumptionIDType))]
    [XmlIncludeAttribute(typeof(ConsignorAssignedIDType))]
    [XmlIncludeAttribute(typeof(ConsigneeAssignedIDType))]
    [XmlIncludeAttribute(typeof(CompanyIDType))]
    [XmlIncludeAttribute(typeof(ChipApplicationIDType))]
    [XmlIncludeAttribute(typeof(CarrierAssignedIDType))]
    [XmlIncludeAttribute(typeof(CV2IDType))]
    [XmlIncludeAttribute(typeof(BuyerProfileURIType))]
    [XmlIncludeAttribute(typeof(BuyerEventIDType))]
    [XmlIncludeAttribute(typeof(BusinessIdentityEvidenceIDType))]
    [XmlIncludeAttribute(typeof(BusinessClassificationEvidenceIDType))]
    [XmlIncludeAttribute(typeof(BrokerAssignedIDType))]
    [XmlIncludeAttribute(typeof(BarcodeSymbologyIDType))]
    [XmlIncludeAttribute(typeof(AwardingCriterionIDType))]
    [XmlIncludeAttribute(typeof(AuctionURIType))]
    [XmlIncludeAttribute(typeof(AttributeIDType))]
    [XmlIncludeAttribute(typeof(AircraftIDType))]
    [XmlIncludeAttribute(typeof(AgencyIDType))]
    [XmlIncludeAttribute(typeof(AdditionalAccountIDType))]
    [XmlIncludeAttribute(typeof(AccountIDType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class IdentifierType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
    public partial class ReferencedSignatureIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionVersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionAgencyURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class ExtensionAgencyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class WebsiteURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class VesselIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class VersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class VariantIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValidatorIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class UpperOrangeHazardPlacardIDType : IdentifierType1
    {
    }
            
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class URIType : IdentifierType1
    {
    }
       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportationServiceDetailsURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TransportExecutionPlanReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TrainIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TrackingIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TraceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TenderEnvelopeIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SupplierAssignedAccountIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SuccessiveSequenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SubscriberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SpecificationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SignatureIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ShippingOrderIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SerialIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SequenceNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SequenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SellerEventIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SecurityIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SchemeURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SalesOrderLineIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SalesOrderIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RevisedForecastLineIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequiredCustomsIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequestForQuotationLineIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReleaseIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegistrationNationalityIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RegistrationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReferencedConsignmentIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RailCarIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RadioCallSignIDType : IdentifierType1
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProfileExecutionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ProductTraceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrimaryAccountNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreviousVersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreviousJobIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrepaidPaymentReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PerformingCarrierAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentTermsDetailsURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentMeansIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PaymentIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ParentDocumentVersionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ParentDocumentLineReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ParentDocumentIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OriginalJobIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OriginalContractingSystemIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OpenTenderIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OntologyURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NetworkIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NationalityIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MarkingIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LowerOrangeHazardPlacardIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LotNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LogoReferenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LocationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LoadingSequenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LineIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LicensePlateIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LanguageIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class JourneyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IssuerIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IssueNumberIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InstructionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InformationURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ImmobilizationCertificateIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IdentificationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HazardClassIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FreightForwarderAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExtendedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExchangeMarketIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EndpointIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EconomicOperatorRegistryURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DocumentIDType : IdentifierType1
    {
    }       
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CustomerAssignedAccountIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContractedCarrierAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContractFolderIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionReportIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsignorAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsigneeAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CompanyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChipApplicationIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CarrierAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CV2IDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BuyerProfileURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BuyerEventIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BusinessIdentityEvidenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BusinessClassificationEvidenceIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BrokerAssignedIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BarcodeSymbologyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AwardingCriterionIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AuctionURIType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AttributeIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AircraftIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AgencyIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdditionalAccountIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AccountIDType : IdentifierType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BranchType
    {
        #region Private fields
        private NameType1 _name;
        private FinancialInstitutionType _financialInstitution;
        #endregion
        
        public BranchType()
        {
            _financialInstitution = new FinancialInstitutionType();
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
        
        [XmlElement(Order=1)]
        public FinancialInstitutionType FinancialInstitution
        {
            get
            {
                return _financialInstitution;
            }
            set
            {
                _financialInstitution = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class FinancialInstitutionType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CustomsDeclarationType
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
    
        
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyIdentificationType
    {
        #region Private fields
        private IDType _id;
        #endregion
        
        public PartyIdentificationType()
        {
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyNameType
    {
        #region Private fields
        private NameType1 _name;
        #endregion
        
        public PartyNameType()
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AddressType
    {
        #region Private fields
        private IDType _id;
        private PostboxType _postbox;
        private RoomType _room;
        private StreetNameType _streetName;
        private BlockNameType _blockName;
        private BuildingNameType _buildingName;
        private BuildingNumberType _buildingNumber;
        private CitySubdivisionNameType _citySubdivisionName;
        private CityNameType _cityName;
        private PostalZoneType _postalZone;
        private RegionType _region;
        private DistrictType _district;
        private CountryType _country;
        #endregion
        
        public AddressType()
        {
            _country = new CountryType();
            _district = new DistrictType();
            _region = new RegionType();
            _postalZone = new PostalZoneType();
            _cityName = new CityNameType();
            _citySubdivisionName = new CitySubdivisionNameType();
            _buildingNumber = new BuildingNumberType();
            _buildingName = new BuildingNameType();
            _blockName = new BlockNameType();
            _streetName = new StreetNameType();
            _room = new RoomType();
            _postbox = new PostboxType();
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
        public PostboxType Postbox
        {
            get
            {
                return _postbox;
            }
            set
            {
                _postbox = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public RoomType Room
        {
            get
            {
                return _room;
            }
            set
            {
                _room = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public StreetNameType StreetName
        {
            get
            {
                return _streetName;
            }
            set
            {
                _streetName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public BlockNameType BlockName
        {
            get
            {
                return _blockName;
            }
            set
            {
                _blockName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public BuildingNameType BuildingName
        {
            get
            {
                return _buildingName;
            }
            set
            {
                _buildingName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public BuildingNumberType BuildingNumber
        {
            get
            {
                return _buildingNumber;
            }
            set
            {
                _buildingNumber = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public CitySubdivisionNameType CitySubdivisionName
        {
            get
            {
                return _citySubdivisionName;
            }
            set
            {
                _citySubdivisionName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public CityNameType CityName
        {
            get
            {
                return _cityName;
            }
            set
            {
                _cityName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public PostalZoneType PostalZone
        {
            get
            {
                return _postalZone;
            }
            set
            {
                _postalZone = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public RegionType Region
        {
            get
            {
                return _region;
            }
            set
            {
                _region = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public DistrictType District
        {
            get
            {
                return _district;
            }
            set
            {
                _district = value;
            }
        }
        
        [XmlElement(Order=12)]
        public CountryType Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CountryType
    {
        #region Private fields
        private IdentificationCodeType _identificationCode;
        private NameType1 _name;
        #endregion
        
        public CountryType()
        {
            _name = new NameType1();
            _identificationCode = new IdentificationCodeType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public IdentificationCodeType IdentificationCode
        {
            get
            {
                return _identificationCode;
            }
            set
            {
                _identificationCode = value;
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="LocationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LocationType1
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyTaxSchemeType
    {
        #region Private fields
        private RegistrationNameType _registrationName;
        private CompanyIDType _companyID;
        private TaxSchemeType _taxScheme;
        #endregion
        
        public PartyTaxSchemeType()
        {
            _taxScheme = new TaxSchemeType();
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
        
        [XmlElement(Order=2)]
        public TaxSchemeType TaxScheme
        {
            get
            {
                return _taxScheme;
            }
            set
            {
                _taxScheme = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxSchemeType
    {
        #region Private fields
        private IDType _id;
        private NameType1 _name;
        private TaxTypeCodeType _taxTypeCode;
        #endregion
        
        public TaxSchemeType()
        {
            _taxTypeCode = new TaxTypeCodeType();
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
        public TaxTypeCodeType TaxTypeCode
        {
            get
            {
                return _taxTypeCode;
            }
            set
            {
                _taxTypeCode = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PartyLegalEntityType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SoleProprietorshipIndicatorType : IndicatorType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class VariantConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class UnknownPriceIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ToOrderIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ThirdPartyPayerIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxIncludedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TaxEvidenceIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class StatusAvailableIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SplitConsignmentIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SpecialSecurityIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReturnableMaterialIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReturnabilityIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RequiredCurriculaIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RefrigerationOnIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RefrigeratedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PublishAwardIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrizeIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PricingUpdateRequestIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PrepaidIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreCarriageIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PowerIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PartialDeliveryIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OtherConditionsIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OrderableIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OptionalLineItemIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OnCarriageIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MarkCareIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MarkAttentionIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LivestockIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LegalStatusIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ItemUpdateRequestIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class IndicationIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HumanFoodIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HumanFoodApprovedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class HazardousRiskIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GovernmentAgreementConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GeneralCargoIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FullyPaidSharesIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FrozenDocumentIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FreeOfChargeIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class FollowupContractIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DangerousGoodsApprovedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CustomsImportClassifiedIndicatorType : IndicatorType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContainerizedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsolidatableIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CompletionIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChargeIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CatalogueIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CandidateReductionConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BulkCargoIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BindingOnBuyerIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BasedOnConsensusIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BalanceBroughtForwardIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BackOrderAllowedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AuctionConstraintIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AnimalFoodIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AnimalFoodApprovedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AdValoremIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class AcceptedIndicatorType : IndicatorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CorporateRegistrationSchemeType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ContactType
    {
        #region Private fields
        private IDType _id;
        private NameType1 _name;
        private TelephoneType _telephone;
        private TelefaxType _telefax;
        private ElectronicMailType _electronicMail;
        private NoteType _note;
        private List<CommunicationType> _otherCommunication;
        #endregion
        
        public ContactType()
        {
            _otherCommunication = new List<CommunicationType>();
            _note = new NoteType();
            _electronicMail = new ElectronicMailType();
            _telefax = new TelefaxType();
            _telephone = new TelephoneType();
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
        public TelephoneType Telephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public TelefaxType Telefax
        {
            get
            {
                return _telefax;
            }
            set
            {
                _telefax = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public ElectronicMailType ElectronicMail
        {
            get
            {
                return _electronicMail;
            }
            set
            {
                _electronicMail = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public NoteType Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [XmlElement("OtherCommunication", Order=6)]
        public List<CommunicationType> OtherCommunication
        {
            get
            {
                return _otherCommunication;
            }
            set
            {
                _otherCommunication = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CommunicationType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PersonType
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
                       
           
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class VideoType : BinaryObjectType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class SoundType : BinaryObjectType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class PictureType : BinaryObjectType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class GraphicType : BinaryObjectType
    {
    }
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class HazardousGoodsTransitType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TemperatureType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportEquipmentType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PackageType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="QuantityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class QuantityType2 : QuantityType1
    {
    }
    
    [XmlIncludeAttribute(typeof(VarianceQuantityType))]
    [XmlIncludeAttribute(typeof(ValueQuantityType))]
    [XmlIncludeAttribute(typeof(TotalTransportHandlingUnitQuantityType))]
    [XmlIncludeAttribute(typeof(TotalPackagesQuantityType))]
    [XmlIncludeAttribute(typeof(TotalPackageQuantityType))]
    [XmlIncludeAttribute(typeof(TotalMeteredQuantityType))]
    [XmlIncludeAttribute(typeof(TotalGoodsItemQuantityType))]
    [XmlIncludeAttribute(typeof(TotalDeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(TotalConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(TimeDeltaDaysQuantityType))]
    [XmlIncludeAttribute(typeof(ThresholdQuantityType))]
    [XmlIncludeAttribute(typeof(TargetInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(ShortQuantityType))]
    [XmlIncludeAttribute(typeof(SharesNumberQuantityType))]
    [XmlIncludeAttribute(typeof(ReturnableQuantityType))]
    [XmlIncludeAttribute(typeof(RejectedQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedTenderQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedForeignTenderQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedElectronicTenderQuantityType))]
    [XmlIncludeAttribute(typeof(QuantityType2))]
    [XmlIncludeAttribute(typeof(PreviousMeterQuantityType))]
    [XmlIncludeAttribute(typeof(PerformanceValueQuantityType))]
    [XmlIncludeAttribute(typeof(PassengerQuantityType))]
    [XmlIncludeAttribute(typeof(PackQuantityType))]
    [XmlIncludeAttribute(typeof(OversupplyQuantityType))]
    [XmlIncludeAttribute(typeof(OutstandingQuantityType))]
    [XmlIncludeAttribute(typeof(OperatingYearsQuantityType))]
    [XmlIncludeAttribute(typeof(NormalTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(MultipleOrderQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumVariantQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(LatestMeterQuantityType))]
    [XmlIncludeAttribute(typeof(InvoicedQuantityType))]
    [XmlIncludeAttribute(typeof(GasPressureQuantityType))]
    [XmlIncludeAttribute(typeof(ExpectedQuantityType))]
    [XmlIncludeAttribute(typeof(ExpectedOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(EstimatedOverallContractQuantityType))]
    [XmlIncludeAttribute(typeof(EstimatedConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(EmployeeQuantityType))]
    [XmlIncludeAttribute(typeof(DifferenceTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(DeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(DebitedQuantityType))]
    [XmlIncludeAttribute(typeof(CustomsTariffQuantityType))]
    [XmlIncludeAttribute(typeof(CrewQuantityType))]
    [XmlIncludeAttribute(typeof(CreditedQuantityType))]
    [XmlIncludeAttribute(typeof(ContentUnitQuantityType))]
    [XmlIncludeAttribute(typeof(ConsumptionWaterQuantityType))]
    [XmlIncludeAttribute(typeof(ConsumptionEnergyQuantityType))]
    [XmlIncludeAttribute(typeof(ConsumerUnitQuantityType))]
    [XmlIncludeAttribute(typeof(ConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(ChildConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(ChargeableQuantityType))]
    [XmlIncludeAttribute(typeof(BatchQuantityType))]
    [XmlIncludeAttribute(typeof(BasicConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(BaseQuantityType))]
    [XmlIncludeAttribute(typeof(BackorderQuantityType))]
    [XmlIncludeAttribute(typeof(ActualTemperatureReductionQuantityType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(TypeName="QuantityType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    public partial class QuantityType1 : QuantityType
    {
    }
    
    [XmlIncludeAttribute(typeof(QuantityType1))]
    [XmlIncludeAttribute(typeof(VarianceQuantityType))]
    [XmlIncludeAttribute(typeof(ValueQuantityType))]
    [XmlIncludeAttribute(typeof(TotalTransportHandlingUnitQuantityType))]
    [XmlIncludeAttribute(typeof(TotalPackagesQuantityType))]
    [XmlIncludeAttribute(typeof(TotalPackageQuantityType))]
    [XmlIncludeAttribute(typeof(TotalMeteredQuantityType))]
    [XmlIncludeAttribute(typeof(TotalGoodsItemQuantityType))]
    [XmlIncludeAttribute(typeof(TotalDeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(TotalConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(TimeDeltaDaysQuantityType))]
    [XmlIncludeAttribute(typeof(ThresholdQuantityType))]
    [XmlIncludeAttribute(typeof(TargetInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(ShortQuantityType))]
    [XmlIncludeAttribute(typeof(SharesNumberQuantityType))]
    [XmlIncludeAttribute(typeof(ReturnableQuantityType))]
    [XmlIncludeAttribute(typeof(RejectedQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedTenderQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedForeignTenderQuantityType))]
    [XmlIncludeAttribute(typeof(ReceivedElectronicTenderQuantityType))]
    [XmlIncludeAttribute(typeof(QuantityType2))]
    [XmlIncludeAttribute(typeof(PreviousMeterQuantityType))]
    [XmlIncludeAttribute(typeof(PerformanceValueQuantityType))]
    [XmlIncludeAttribute(typeof(PassengerQuantityType))]
    [XmlIncludeAttribute(typeof(PackQuantityType))]
    [XmlIncludeAttribute(typeof(OversupplyQuantityType))]
    [XmlIncludeAttribute(typeof(OutstandingQuantityType))]
    [XmlIncludeAttribute(typeof(OperatingYearsQuantityType))]
    [XmlIncludeAttribute(typeof(NormalTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(MultipleOrderQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(MinimumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumVariantQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(MaximumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(LatestMeterQuantityType))]
    [XmlIncludeAttribute(typeof(InvoicedQuantityType))]
    [XmlIncludeAttribute(typeof(GasPressureQuantityType))]
    [XmlIncludeAttribute(typeof(ExpectedQuantityType))]
    [XmlIncludeAttribute(typeof(ExpectedOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(EstimatedOverallContractQuantityType))]
    [XmlIncludeAttribute(typeof(EstimatedConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(EmployeeQuantityType))]
    [XmlIncludeAttribute(typeof(DifferenceTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(DeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(DebitedQuantityType))]
    [XmlIncludeAttribute(typeof(CustomsTariffQuantityType))]
    [XmlIncludeAttribute(typeof(CrewQuantityType))]
    [XmlIncludeAttribute(typeof(CreditedQuantityType))]
    [XmlIncludeAttribute(typeof(ContentUnitQuantityType))]
    [XmlIncludeAttribute(typeof(ConsumptionWaterQuantityType))]
    [XmlIncludeAttribute(typeof(ConsumptionEnergyQuantityType))]
    [XmlIncludeAttribute(typeof(ConsumerUnitQuantityType))]
    [XmlIncludeAttribute(typeof(ConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(ChildConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(ChargeableQuantityType))]
    [XmlIncludeAttribute(typeof(BatchQuantityType))]
    [XmlIncludeAttribute(typeof(BasicConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(BaseQuantityType))]
    [XmlIncludeAttribute(typeof(BackorderQuantityType))]
    [XmlIncludeAttribute(typeof(ActualTemperatureReductionQuantityType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    public partial class QuantityType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class VarianceQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ValueQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalTransportHandlingUnitQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalPackagesQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalPackageQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalMeteredQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalGoodsItemQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalDeliveredQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TotalConsumedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TimeDeltaDaysQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ThresholdQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class TargetInventoryQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ShortQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class SharesNumberQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReturnableQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class RejectedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReceivedTenderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReceivedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReceivedForeignTenderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ReceivedElectronicTenderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PreviousMeterQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PerformanceValueQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PassengerQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class PackQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OversupplyQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OutstandingQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class OperatingYearsQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class NormalTemperatureReductionQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MultipleOrderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumOrderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumInventoryQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MinimumBackorderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumVariantQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumOrderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumOperatorQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class MaximumBackorderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class LatestMeterQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class InvoicedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class GasPressureQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExpectedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ExpectedOperatorQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedOverallContractQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EstimatedConsumedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class EmployeeQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DifferenceTemperatureReductionQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DeliveredQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class DebitedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CustomsTariffQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CrewQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class CreditedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ContentUnitQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionWaterQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumptionEnergyQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsumerUnitQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ConsignmentQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChildConsignmentQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ChargeableQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BatchQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BasicConsumedQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BaseQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class BackorderQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public partial class ActualTemperatureReductionQuantityType : QuantityType1
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class GoodsItemType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemType
    {
        #region Private fields
        private DescriptionType _description;
        private NameType1 _name;
        private KeywordType _keyword;
        private BrandNameType _brandName;
        private ModelNameType _modelName;
        private ItemIdentificationType _buyersItemIdentification;
        private ItemIdentificationType _sellersItemIdentification;
        private ItemIdentificationType _manufacturersItemIdentification;
        private List<ItemIdentificationType> _additionalItemIdentification;
        private CountryType _originCountry;
        private List<CommodityClassificationType> _commodityClassification;
        private List<ItemInstanceType> _itemInstance;
        #endregion
        
        public ItemType()
        {
            _itemInstance = new List<ItemInstanceType>();
            _commodityClassification = new List<CommodityClassificationType>();
            _originCountry = new CountryType();
            _additionalItemIdentification = new List<ItemIdentificationType>();
            _manufacturersItemIdentification = new ItemIdentificationType();
            _sellersItemIdentification = new ItemIdentificationType();
            _buyersItemIdentification = new ItemIdentificationType();
            _modelName = new ModelNameType();
            _brandName = new BrandNameType();
            _keyword = new KeywordType();
            _name = new NameType1();
            _description = new DescriptionType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
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
        public KeywordType Keyword
        {
            get
            {
                return _keyword;
            }
            set
            {
                _keyword = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public BrandNameType BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                _brandName = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public ModelNameType ModelName
        {
            get
            {
                return _modelName;
            }
            set
            {
                _modelName = value;
            }
        }
        
        [XmlElement(Order=5)]
        public ItemIdentificationType BuyersItemIdentification
        {
            get
            {
                return _buyersItemIdentification;
            }
            set
            {
                _buyersItemIdentification = value;
            }
        }
        
        [XmlElement(Order=6)]
        public ItemIdentificationType SellersItemIdentification
        {
            get
            {
                return _sellersItemIdentification;
            }
            set
            {
                _sellersItemIdentification = value;
            }
        }
        
        [XmlElement(Order=7)]
        public ItemIdentificationType ManufacturersItemIdentification
        {
            get
            {
                return _manufacturersItemIdentification;
            }
            set
            {
                _manufacturersItemIdentification = value;
            }
        }
        
        [XmlElement("AdditionalItemIdentification", Order=8)]
        public List<ItemIdentificationType> AdditionalItemIdentification
        {
            get
            {
                return _additionalItemIdentification;
            }
            set
            {
                _additionalItemIdentification = value;
            }
        }
        
        [XmlElement(Order=9)]
        public CountryType OriginCountry
        {
            get
            {
                return _originCountry;
            }
            set
            {
                _originCountry = value;
            }
        }
        
        [XmlElement("CommodityClassification", Order=10)]
        public List<CommodityClassificationType> CommodityClassification
        {
            get
            {
                return _commodityClassification;
            }
            set
            {
                _commodityClassification = value;
            }
        }
        
        [XmlElement("ItemInstance", Order=11)]
        public List<ItemInstanceType> ItemInstance
        {
            get
            {
                return _itemInstance;
            }
            set
            {
                _itemInstance = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemIdentificationType
    {
        #region Private fields
        private IDType _id;
        #endregion
        
        public ItemIdentificationType()
        {
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CommodityClassificationType
    {
        #region Private fields
        private ItemClassificationCodeType _itemClassificationCode;
        #endregion
        
        public CommodityClassificationType()
        {
            _itemClassificationCode = new ItemClassificationCodeType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public ItemClassificationCodeType ItemClassificationCode
        {
            get
            {
                return _itemClassificationCode;
            }
            set
            {
                _itemClassificationCode = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemInstanceType
    {
        #region Private fields
        private ProductTraceIDType _productTraceID;
        private ManufactureDateType _manufactureDate;
        private ManufactureTimeType _manufactureTime;
        private BestBeforeDateType _bestBeforeDate;
        private RegistrationIDType _registrationID;
        private SerialIDType _serialID;
        private List<ItemPropertyType> _additionalItemProperty;
        private LotIdentificationType _lotIdentification;
        #endregion
        
        public ItemInstanceType()
        {
            _lotIdentification = new LotIdentificationType();
            _additionalItemProperty = new List<ItemPropertyType>();
            _serialID = new SerialIDType();
            _registrationID = new RegistrationIDType();
            _bestBeforeDate = new BestBeforeDateType();
            _manufactureTime = new ManufactureTimeType();
            _manufactureDate = new ManufactureDateType();
            _productTraceID = new ProductTraceIDType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public ProductTraceIDType ProductTraceID
        {
            get
            {
                return _productTraceID;
            }
            set
            {
                _productTraceID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public ManufactureDateType ManufactureDate
        {
            get
            {
                return _manufactureDate;
            }
            set
            {
                _manufactureDate = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public ManufactureTimeType ManufactureTime
        {
            get
            {
                return _manufactureTime;
            }
            set
            {
                _manufactureTime = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public BestBeforeDateType BestBeforeDate
        {
            get
            {
                return _bestBeforeDate;
            }
            set
            {
                _bestBeforeDate = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public RegistrationIDType RegistrationID
        {
            get
            {
                return _registrationID;
            }
            set
            {
                _registrationID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public SerialIDType SerialID
        {
            get
            {
                return _serialID;
            }
            set
            {
                _serialID = value;
            }
        }
        
        [XmlElement("AdditionalItemProperty", Order=6)]
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
        
        [XmlElement(Order=7)]
        public LotIdentificationType LotIdentification
        {
            get
            {
                return _lotIdentification;
            }
            set
            {
                _lotIdentification = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemPropertyType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemPropertyGroupType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DimensionType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemPropertyRangeType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LotIdentificationType
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
      
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class InvoiceLineType
    {
        #region Private fields
        private IDType _id;
        private List<NoteType> _note;
        private InvoicedQuantityType _invoicedQuantity;
        private LineExtensionAmountType _lineExtensionAmount;
        private List<OrderLineReferenceType> _orderLineReference;
        private List<LineReferenceType> _despatchLineReference;
        private List<LineReferenceType> _receiptLineReference;
        private List<DeliveryType> _delivery;
        private List<AllowanceChargeType> _allowanceCharge;
        private TaxTotalType _taxTotal;
        private List<TaxTotalType> _withholdingTaxTotal;
        private ItemType _item;
        private PriceType _price;
        private List<InvoiceLineType> _subInvoiceLine;
        #endregion
        
        public InvoiceLineType()
        {
            _subInvoiceLine = new List<InvoiceLineType>();
            _price = new PriceType();
            _item = new ItemType();
            _withholdingTaxTotal = new List<TaxTotalType>();
            _taxTotal = new TaxTotalType();
            _allowanceCharge = new List<AllowanceChargeType>();
            _delivery = new List<DeliveryType>();
            _receiptLineReference = new List<LineReferenceType>();
            _despatchLineReference = new List<LineReferenceType>();
            _orderLineReference = new List<OrderLineReferenceType>();
            _lineExtensionAmount = new LineExtensionAmountType();
            _invoicedQuantity = new InvoicedQuantityType();
            _note = new List<NoteType>();
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
        
        [XmlElement("Note", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public List<NoteType> Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public InvoicedQuantityType InvoicedQuantity
        {
            get
            {
                return _invoicedQuantity;
            }
            set
            {
                _invoicedQuantity = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public LineExtensionAmountType LineExtensionAmount
        {
            get
            {
                return _lineExtensionAmount;
            }
            set
            {
                _lineExtensionAmount = value;
            }
        }
        
        [XmlElement("OrderLineReference", Order=4)]
        public List<OrderLineReferenceType> OrderLineReference
        {
            get
            {
                return _orderLineReference;
            }
            set
            {
                _orderLineReference = value;
            }
        }
        
        [XmlElement("DespatchLineReference", Order=5)]
        public List<LineReferenceType> DespatchLineReference
        {
            get
            {
                return _despatchLineReference;
            }
            set
            {
                _despatchLineReference = value;
            }
        }
        
        [XmlElement("ReceiptLineReference", Order=6)]
        public List<LineReferenceType> ReceiptLineReference
        {
            get
            {
                return _receiptLineReference;
            }
            set
            {
                _receiptLineReference = value;
            }
        }
        
        [XmlElement("Delivery", Order=7)]
        public List<DeliveryType> Delivery
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
        
        [XmlElement("AllowanceCharge", Order=8)]
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
        
        [XmlElement(Order=9)]
        public TaxTotalType TaxTotal
        {
            get
            {
                return _taxTotal;
            }
            set
            {
                _taxTotal = value;
            }
        }
        
        [XmlElement("WithholdingTaxTotal", Order=10)]
        public List<TaxTotalType> WithholdingTaxTotal
        {
            get
            {
                return _withholdingTaxTotal;
            }
            set
            {
                _withholdingTaxTotal = value;
            }
        }
        
        [XmlElement(Order=11)]
        public ItemType Item
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
        
        [XmlElement(Order=12)]
        public PriceType Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        
        [XmlElement("SubInvoiceLine", Order=13)]
        public List<InvoiceLineType> SubInvoiceLine
        {
            get
            {
                return _subInvoiceLine;
            }
            set
            {
                _subInvoiceLine = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderLineReferenceType
    {
        #region Private fields
        private LineIDType _lineID;
        private SalesOrderLineIDType _salesOrderLineID;
        private UUIDType _uUID;
        private LineStatusCodeType _lineStatusCode;
        private OrderReferenceType _orderReference;
        #endregion
        
        public OrderLineReferenceType()
        {
            _orderReference = new OrderReferenceType();
            _lineStatusCode = new LineStatusCodeType();
            _uUID = new UUIDType();
            _salesOrderLineID = new SalesOrderLineIDType();
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
        public SalesOrderLineIDType SalesOrderLineID
        {
            get
            {
                return _salesOrderLineID;
            }
            set
            {
                _salesOrderLineID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public UUIDType UUID
        {
            get
            {
                return _uUID;
            }
            set
            {
                _uUID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
        
        [XmlElement(Order=4)]
        public OrderReferenceType OrderReference
        {
            get
            {
                return _orderReference;
            }
            set
            {
                _orderReference = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderReferenceType
    {
        #region Private fields
        private IDType _id;
        private SalesOrderIDType _salesOrderID;
        private IssueDateType _issueDate;
        private OrderTypeCodeType _orderTypeCode;
        private DocumentReferenceType _documentReference;
        #endregion
        
        public OrderReferenceType()
        {
            _documentReference = new DocumentReferenceType();
            _orderTypeCode = new OrderTypeCodeType();
            _issueDate = new IssueDateType();
            _salesOrderID = new SalesOrderIDType();
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
        public SalesOrderIDType SalesOrderID
        {
            get
            {
                return _salesOrderID;
            }
            set
            {
                _salesOrderID = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IssueDateType IssueDate
        {
            get
            {
                return _issueDate;
            }
            set
            {
                _issueDate = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public OrderTypeCodeType OrderTypeCode
        {
            get
            {
                return _orderTypeCode;
            }
            set
            {
                _orderTypeCode = value;
            }
        }
        
        [XmlElement(Order=4)]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LineReferenceType
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
    
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DespatchType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DeliveryTermsType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ShipmentType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ShipmentStageType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportMeansType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class StowageType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AirTransportType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RoadTransportType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RailTransportType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MaritimeTransportType
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportHandlingUnitType
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
    
        
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxSubtotalType
    {
        #region Private fields
        private TaxableAmountType _taxableAmount;
        private TaxAmountType _taxAmount;
        private CalculationSequenceNumericType _calculationSequenceNumeric;
        private TransactionCurrencyTaxAmountType _transactionCurrencyTaxAmount;
        private PercentType1 _percent;
        private BaseUnitMeasureType _baseUnitMeasure;
        private PerUnitAmountType _perUnitAmount;
        private TaxCategoryType _taxCategory;
        #endregion
        
        public TaxSubtotalType()
        {
            _taxCategory = new TaxCategoryType();
            _perUnitAmount = new PerUnitAmountType();
            _baseUnitMeasure = new BaseUnitMeasureType();
            _percent = new PercentType1();
            _transactionCurrencyTaxAmount = new TransactionCurrencyTaxAmountType();
            _calculationSequenceNumeric = new CalculationSequenceNumericType();
            _taxAmount = new TaxAmountType();
            _taxableAmount = new TaxableAmountType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public TaxableAmountType TaxableAmount
        {
            get
            {
                return _taxableAmount;
            }
            set
            {
                _taxableAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public TaxAmountType TaxAmount
        {
            get
            {
                return _taxAmount;
            }
            set
            {
                _taxAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public CalculationSequenceNumericType CalculationSequenceNumeric
        {
            get
            {
                return _calculationSequenceNumeric;
            }
            set
            {
                _calculationSequenceNumeric = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public TransactionCurrencyTaxAmountType TransactionCurrencyTaxAmount
        {
            get
            {
                return _transactionCurrencyTaxAmount;
            }
            set
            {
                _transactionCurrencyTaxAmount = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public PercentType1 Percent
        {
            get
            {
                return _percent;
            }
            set
            {
                _percent = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public BaseUnitMeasureType BaseUnitMeasure
        {
            get
            {
                return _baseUnitMeasure;
            }
            set
            {
                _baseUnitMeasure = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public PerUnitAmountType PerUnitAmount
        {
            get
            {
                return _perUnitAmount;
            }
            set
            {
                _perUnitAmount = value;
            }
        }
        
        [XmlElement(Order=7)]
        public TaxCategoryType TaxCategory
        {
            get
            {
                return _taxCategory;
            }
            set
            {
                _taxCategory = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TaxCategoryType
    {
        #region Private fields
        private NameType1 _name;
        private TaxExemptionReasonCodeType _taxExemptionReasonCode;
        private TaxExemptionReasonType _taxExemptionReason;
        private TaxSchemeType _taxScheme;
        #endregion
        
        public TaxCategoryType()
        {
            _taxScheme = new TaxSchemeType();
            _taxExemptionReason = new TaxExemptionReasonType();
            _taxExemptionReasonCode = new TaxExemptionReasonCodeType();
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
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public TaxExemptionReasonCodeType TaxExemptionReasonCode
        {
            get
            {
                return _taxExemptionReasonCode;
            }
            set
            {
                _taxExemptionReasonCode = value;
            }
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public TaxExemptionReasonType TaxExemptionReason
        {
            get
            {
                return _taxExemptionReason;
            }
            set
            {
                _taxExemptionReason = value;
            }
        }
        
        [XmlElement(Order=3)]
        public TaxSchemeType TaxScheme
        {
            get
            {
                return _taxScheme;
            }
            set
            {
                _taxScheme = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PriceType
    {
        #region Private fields
        private PriceAmountType _priceAmount;
        #endregion
        
        public PriceType()
        {
            _priceAmount = new PriceAmountType();
        }
        
        [XmlElement(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
        public PriceAmountType PriceAmount
        {
            get
            {
                return _priceAmount;
            }
            set
            {
                _priceAmount = value;
            }
        }
    }
    
             
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [Serializable]
    [DebuggerStepThrough]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class BillingReferenceLineType
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