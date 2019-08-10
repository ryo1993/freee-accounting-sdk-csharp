// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class FiscalYears
    {
        /// <summary>
        /// Initializes a new instance of the FiscalYears class.
        /// </summary>
        public FiscalYears()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FiscalYears class.
        /// </summary>
        /// <param name="useIndustryTemplate">製造業向け機能（true: 使用する、false:
        /// 使用しない）</param>
        /// <param name="indirectWriteOffMethod">固定資産の控除法(false:
        /// 減価償却累計額でまとめる、true: 独立間接控除方式)</param>
        /// <param name="depreciationRecordMethod">月次償却（0: しない、1: する）</param>
        /// <param name="taxMethod">課税区分（0: 免税、1: 簡易課税、2: 本則課税（個別対応方式）、3:
        /// 本則課税（一括比例配分方式）、4: 本則課税（全額控除））</param>
        /// <param name="salesTaxBusinessCode">簡易課税用事業区分（0: 第一種：卸売業、1:
        /// 第二種：小売業、2: 第三種：農林水産業、工業、建設業、製造業など、3: 第四種：飲食店業など、4:
        /// 第五種：金融・保険業、運輸通信業、サービス業など、5: 第六種：不動産業など</param>
        /// <param name="taxFraction">消費税端数処理方法（0: 切り捨て、1: 切り上げ、2:
        /// 四捨五入）</param>
        /// <param name="taxAccountMethod">消費税経理処理方法（0: 税込経理、1: 旧税抜経理、2:
        /// 税抜経理）</param>
        /// <param name="returnCode">不動産所得使用区分（0: 一般、1: 一般/不動産）
        /// ※個人事業主のみ設定可能</param>
        /// <param name="startDate">期首日</param>
        /// <param name="endDate">期末日</param>
        public FiscalYears(bool useIndustryTemplate, bool indirectWriteOffMethod, int depreciationRecordMethod, int taxMethod, int salesTaxBusinessCode, int taxFraction, int taxAccountMethod, int returnCode, string startDate = default(string), string endDate = default(string))
        {
            UseIndustryTemplate = useIndustryTemplate;
            IndirectWriteOffMethod = indirectWriteOffMethod;
            StartDate = startDate;
            EndDate = endDate;
            DepreciationRecordMethod = depreciationRecordMethod;
            TaxMethod = taxMethod;
            SalesTaxBusinessCode = salesTaxBusinessCode;
            TaxFraction = taxFraction;
            TaxAccountMethod = taxAccountMethod;
            ReturnCode = returnCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 製造業向け機能（true: 使用する、false: 使用しない）
        /// </summary>
        [JsonProperty(PropertyName = "use_industry_template")]
        public bool UseIndustryTemplate { get; set; }

        /// <summary>
        /// Gets or sets 固定資産の控除法(false: 減価償却累計額でまとめる、true: 独立間接控除方式)
        /// </summary>
        [JsonProperty(PropertyName = "indirect_write_off_method")]
        public bool IndirectWriteOffMethod { get; set; }

        /// <summary>
        /// Gets or sets 期首日
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets 期末日
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or sets 月次償却（0: しない、1: する）
        /// </summary>
        [JsonProperty(PropertyName = "depreciation_record_method")]
        public int DepreciationRecordMethod { get; set; }

        /// <summary>
        /// Gets or sets 課税区分（0: 免税、1: 簡易課税、2: 本則課税（個別対応方式）、3:
        /// 本則課税（一括比例配分方式）、4: 本則課税（全額控除））
        /// </summary>
        [JsonProperty(PropertyName = "tax_method")]
        public int TaxMethod { get; set; }

        /// <summary>
        /// Gets or sets 簡易課税用事業区分（0: 第一種：卸売業、1: 第二種：小売業、2:
        /// 第三種：農林水産業、工業、建設業、製造業など、3: 第四種：飲食店業など、4: 第五種：金融・保険業、運輸通信業、サービス業など、5:
        /// 第六種：不動産業など
        /// </summary>
        [JsonProperty(PropertyName = "sales_tax_business_code")]
        public int SalesTaxBusinessCode { get; set; }

        /// <summary>
        /// Gets or sets 消費税端数処理方法（0: 切り捨て、1: 切り上げ、2: 四捨五入）
        /// </summary>
        [JsonProperty(PropertyName = "tax_fraction")]
        public int TaxFraction { get; set; }

        /// <summary>
        /// Gets or sets 消費税経理処理方法（0: 税込経理、1: 旧税抜経理、2: 税抜経理）
        /// </summary>
        [JsonProperty(PropertyName = "tax_account_method")]
        public int TaxAccountMethod { get; set; }

        /// <summary>
        /// Gets or sets 不動産所得使用区分（0: 一般、1: 一般/不動産） ※個人事業主のみ設定可能
        /// </summary>
        [JsonProperty(PropertyName = "return_code")]
        public int ReturnCode { get; set; }

    }
}