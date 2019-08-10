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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UpdateDealParamsDetailsItem
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDealParamsDetailsItem
        /// class.
        /// </summary>
        public UpdateDealParamsDetailsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateDealParamsDetailsItem
        /// class.
        /// </summary>
        /// <param name="accountItemId">勘定科目ID</param>
        /// <param name="amount">取引金額（税込で指定してください）</param>
        /// <param name="id">取引行ID:
        /// 既存取引行を更新する場合に指定します。IDを指定しない取引行は、新規行として扱われ追加されます。また、detailsに含まれない既存の取引行は削除されます。更新後も残したい行は、必ず取引行IDを指定してdetailsに含めてください。</param>
        /// <param name="taxCode">税区分コード</param>
        /// <param name="taxId">税区分ID（廃止予定。上記tax_codeを使用してください。tax_code,
        /// tax_idはどちらかの指定が必須です。）</param>
        /// <param name="itemId">品目ID</param>
        /// <param name="sectionId">部門ID</param>
        /// <param name="tagIds">メモタグID</param>
        /// <param name="segment1TagId">セグメント１ID</param>
        /// <param name="segment2TagId">セグメント２ID</param>
        /// <param name="segment3TagId">セグメント３ID</param>
        /// <param name="description">備考</param>
        /// <param name="vat">消費税額（指定しない場合は自動で計算されます）</param>
        public UpdateDealParamsDetailsItem(int accountItemId, int amount, int? id = default(int?), int? taxCode = default(int?), int? taxId = default(int?), int? itemId = default(int?), int? sectionId = default(int?), IList<int?> tagIds = default(IList<int?>), int? segment1TagId = default(int?), int? segment2TagId = default(int?), int? segment3TagId = default(int?), string description = default(string), int? vat = default(int?))
        {
            Id = id;
            TaxCode = taxCode;
            TaxId = taxId;
            AccountItemId = accountItemId;
            Amount = amount;
            ItemId = itemId;
            SectionId = sectionId;
            TagIds = tagIds;
            Segment1TagId = segment1TagId;
            Segment2TagId = segment2TagId;
            Segment3TagId = segment3TagId;
            Description = description;
            Vat = vat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 取引行ID:
        /// 既存取引行を更新する場合に指定します。IDを指定しない取引行は、新規行として扱われ追加されます。また、detailsに含まれない既存の取引行は削除されます。更新後も残したい行は、必ず取引行IDを指定してdetailsに含めてください。
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets 税区分コード
        /// </summary>
        [JsonProperty(PropertyName = "tax_code")]
        public int? TaxCode { get; set; }

        /// <summary>
        /// Gets or sets 税区分ID（廃止予定。上記tax_codeを使用してください。tax_code,
        /// tax_idはどちらかの指定が必須です。）
        /// </summary>
        [JsonProperty(PropertyName = "tax_id")]
        public int? TaxId { get; set; }

        /// <summary>
        /// Gets or sets 勘定科目ID
        /// </summary>
        [JsonProperty(PropertyName = "account_item_id")]
        public int AccountItemId { get; set; }

        /// <summary>
        /// Gets or sets 取引金額（税込で指定してください）
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets 品目ID
        /// </summary>
        [JsonProperty(PropertyName = "item_id")]
        public int? ItemId { get; set; }

        /// <summary>
        /// Gets or sets 部門ID
        /// </summary>
        [JsonProperty(PropertyName = "section_id")]
        public int? SectionId { get; set; }

        /// <summary>
        /// Gets or sets メモタグID
        /// </summary>
        [JsonProperty(PropertyName = "tag_ids")]
        public IList<int?> TagIds { get; set; }

        /// <summary>
        /// Gets or sets セグメント１ID
        /// </summary>
        [JsonProperty(PropertyName = "segment_1_tag_id")]
        public int? Segment1TagId { get; set; }

        /// <summary>
        /// Gets or sets セグメント２ID
        /// </summary>
        [JsonProperty(PropertyName = "segment_2_tag_id")]
        public int? Segment2TagId { get; set; }

        /// <summary>
        /// Gets or sets セグメント３ID
        /// </summary>
        [JsonProperty(PropertyName = "segment_3_tag_id")]
        public int? Segment3TagId { get; set; }

        /// <summary>
        /// Gets or sets 備考
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets 消費税額（指定しない場合は自動で計算されます）
        /// </summary>
        [JsonProperty(PropertyName = "vat")]
        public int? Vat { get; set; }

    }
}