/* 
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"\">スタートガイド</h2> <p>1. セットアップ</p> <ol> <ul><li><a href=\"https://support.freee.co.jp/hc/ja/articles/202847230\" class=\"external-link\" rel=\"nofollow\">freeeアカウント（無料）</a>を<a href=\"https://secure.freee.co.jp/users/sign_up\" class=\"external-link\" rel=\"nofollow\">作成</a>します（すでにお持ちの場合は次へ）</li><li><a href=\"https://app.secure.freee.co.jp/developers/demo_companies/description\" class=\"external-link\" rel=\"nofollow\">開発者向け事業所・環境を作成</a>します</li><li><span><a href=\"https://app.secure.freee.co.jp/developers/applications\" class=\"external-link\" rel=\"nofollow\">前のステップで作成した事業所を選択してfreeeアプリを追加</a>します</span></li><li>Client IDをCopyしておきます</li> </ul> </ol>  <p>2. 実際にAPIを叩いてみる（ブラウザからAPIのレスポンスを確認する）</p> <ol> <ul><li><span><span>以下のURLの●をclient_idに入れ替えて<a href=\"https://app.secure.freee.co.jp/developers/tutorials/3-%E3%82%A2%E3%82%AF%E3%82%BB%E3%82%B9%E3%83%88%E3%83%BC%E3%82%AF%E3%83%B3%E3%82%92%E5%8F%96%E5%BE%97%E3%81%99%E3%82%8B#%E8%AA%8D%E5%8F%AF%E3%82%B3%E3%83%BC%E3%83%89%E3%82%92%E5%8F%96%E5%BE%97%E3%81%99%E3%82%8B\" class=\"external-link\" rel=\"nofollow\">アクセストークンを取得</a>します</span></span><ul><li><span><span><pre><code>https://accounts.secure.freee.co.jp/public_api/authorize?client_id=●&amp;redirect_uri=urn%3Aietf%3Awg%3Aoauth%3A2.0%3Aoob&amp;response_type=token</a></code></pre></span></span></li></ul></li><li><span><a href=\"https://developer.freee.co.jp/docs/accounting/reference#/%E9%80%A3%E7%B5%A1%E5%85%88\" class=\"external-link\" rel=\"nofollow\">APIリファレンス</a>で<code>Authorize</code>を押下します</span></li><li><span>アクセストークン<span><span>を入力して</span></span>&nbsp;もう一度<span><code>Authorize</code>を押下して<code>Close</code>を押下します</span></span></li><li>リファレンス内のCompanies（事業所）に移動し、<code>Try it out</code>を押下し、<code>Execute</code>を押下します</li><li>Response bodyを参照し、事業所ID(id属性)を活用して、Companies以外のエンドポイントでどのようなデータのやりとりできるのか確認します</li></ul> </ol> <p>3. 連携を実装する</p> <ol> <ul><li><a href=\"https://developer.freee.co.jp/tips\" class=\"external-link\" rel=\"nofollow\">API TIPS</a>を参考に、ユースケースごとの連携の概要を学びます。<span>例えば</span><span>&nbsp;</span><a href=\"https://developer.freee.co.jp/tips/how-to-cooperate-salesmanegement-system\" class=\"external-link\" rel=\"nofollow\">SFA、CRM、販売管理システムから会計freeeへの連携</a>や<a href=\"https://developer.freee.co.jp/tips/how-to-cooperate-excel-and-spreadsheet\" class=\"external-link\" rel=\"nofollow\">エクセルやgoogle spreadsheetからの連携</a>です</li><li>実利用向け事業所がすでにある場合は利用、ない場合は作成します（セットアップで作成したのは開発者向け環境のため活用不可）</li><li><a href=\"https://developer.freee.co.jp/docs/accounting/reference\" class=\"external-link\" rel=\"nofollow\">API documentation</a><span>&nbsp;を参照し、躓いた場合は</span><span>&nbsp;</span><a href=\"https://developer.freee.co.jp/community/forum/community\" class=\"external-link\" rel=\"nofollow\">Community</a><span>&nbsp;で質問してみましょう</span></li></ul> </ol> <p>アプリケーションの登録方法や認証方法、またはAPIの活用方法でご不明な点がある場合は<a href=\"https://support.freee.co.jp/hc/ja/sections/115000030743\">ヘルプセンター</a>もご確認ください</p> <hr /> <h2 id=\"_2\">仕様</h2>  <h3 id=\"api\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"_3\">認証方式</h3>  <p><a href=\"http://tools.ietf.org/html/rfc6749\">OAuth2</a>に対応</p>  <ul> <li>Authorization Code Flow (Webアプリ向け)</li>  <li>Implicit Flow (Mobileアプリ向け)</li> </ul>  <h3 id=\"_4\">認証エンドポイント</h3>  <p>https://accounts.secure.freee.co.jp/</p>  <ul> <li>authorize : https://accounts.secure.freee.co.jp/public_api/authorize</li>  <li>token : https://accounts.secure.freee.co.jp/public_api/token</li> </ul>  <h3 id=\"_5\">アクセストークンのリフレッシュ</h3>  <p>認証時に得たrefresh_token を使ってtoken の期限をリフレッシュして新規に発行することが出来ます。</p>  <p>grant_type=refresh_token で https://accounts.secure.freee.co.jp/public_api/token にアクセスすればリフレッシュされます。</p>  <p>e.g.)</p>  <p>POST: https://accounts.secure.freee.co.jp/public_api/token</p>  <p>params: grant_type=refresh_token&amp;client_id=UID&amp;client_secret=SECRET&amp;refresh_token=REFRESH_TOKEN</p>  <p>詳細は<a href=\"https://github.com/applicake/doorkeeper/wiki/Enable-Refresh-Token-Credentials#flow\">refresh_token</a>を参照下さい。</p>  <h3 id=\"_6\">アクセストークンの破棄</h3>  <p>認証時に得たaccess_tokenまたはrefresh_tokenを使って、tokenを破棄することができます。 token=access_tokenまたはtoken=refresh_tokenでhttps://accounts.secure.freee.co.jp/public_api/revokeにアクセスすると破棄されます。token_type_hintでaccess_tokenまたはrefresh_tokenを陽に指定できます。</p>  <p>e.g.)</p>  <p>POST: https://accounts.secure.freee.co.jp/public_api/revoke</p>  <p>params: token=ACCESS_TOKEN</p>  <p>または</p>  <p>params: token=REFRESH_TOKEN</p>  <p>または</p>  <p>params: token=ACCESS_TOKEN&amp;token_type_hint=access_token</p>  <p>または</p>  <p>params: token=REFRESH_TOKEN&amp;token_type_hint=refresh_token</p>  <p>詳細は <a href=\"https://tools.ietf.org/html/rfc7009\">OAuth 2.0 Token revocation</a> をご参照ください。</p>  <h3 id=\"_7\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポート</p>  <h3 id=\"_8\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"_9\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li>  <li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre> <hr /> <h2 id=\"_10\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
 *
 * The version of the OpenAPI document: v1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// InvoicesCreateParamsInvoiceContents
    /// </summary>
    [DataContract]
    public partial class InvoicesCreateParamsInvoiceContents :  IEquatable<InvoicesCreateParamsInvoiceContents>
    {
        /// <summary>
        /// 行の種類
        /// </summary>
        /// <value>行の種類</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 1,

            /// <summary>
            /// Enum Discount for value: discount
            /// </summary>
            [EnumMember(Value = "discount")]
            Discount = 2,

            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 3

        }

        /// <summary>
        /// 行の種類
        /// </summary>
        /// <value>行の種類</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesCreateParamsInvoiceContents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvoicesCreateParamsInvoiceContents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesCreateParamsInvoiceContents" /> class.
        /// </summary>
        /// <param name="order">順序 (required).</param>
        /// <param name="type">行の種類 (required).</param>
        /// <param name="qty">数量.</param>
        /// <param name="unit">単位.</param>
        /// <param name="unitPrice">単価 (tax_entry_method: inclusiveの場合は税込価格、tax_entry_method: exclusiveの場合は税抜価格となります).</param>
        /// <param name="vat">消費税額.</param>
        /// <param name="description">備考.</param>
        /// <param name="accountItemId">勘定科目ID.</param>
        /// <param name="taxCode">税区分ID.</param>
        /// <param name="itemId">品目ID.</param>
        /// <param name="sectionId">部門ID.</param>
        /// <param name="tagIds">tagIds.</param>
        /// <param name="segment1TagId">セグメント１ID.</param>
        /// <param name="segment2TagId">セグメント２ID.</param>
        /// <param name="segment3TagId">セグメント３ID.</param>
        public InvoicesCreateParamsInvoiceContents(int order = default(int), TypeEnum type = default(TypeEnum), decimal qty = default(decimal), string unit = default(string), decimal unitPrice = default(decimal), int vat = default(int), string description = default(string), int accountItemId = default(int), int taxCode = default(int), int itemId = default(int), int sectionId = default(int), List<int> tagIds = default(List<int>), int segment1TagId = default(int), int segment2TagId = default(int), int segment3TagId = default(int))
        {
            this.Order = order;
            this.Type = type;
            this.Qty = qty;
            this.Unit = unit;
            this.UnitPrice = unitPrice;
            this.Vat = vat;
            this.Description = description;
            this.AccountItemId = accountItemId;
            this.TaxCode = taxCode;
            this.ItemId = itemId;
            this.SectionId = sectionId;
            this.TagIds = tagIds;
            this.Segment1TagId = segment1TagId;
            this.Segment2TagId = segment2TagId;
            this.Segment3TagId = segment3TagId;
        }
        
        /// <summary>
        /// 順序
        /// </summary>
        /// <value>順序</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int Order { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <value>数量</value>
        [DataMember(Name="qty", EmitDefaultValue=false)]
        public decimal Qty { get; set; }

        /// <summary>
        /// 単位
        /// </summary>
        /// <value>単位</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// 単価 (tax_entry_method: inclusiveの場合は税込価格、tax_entry_method: exclusiveの場合は税抜価格となります)
        /// </summary>
        /// <value>単価 (tax_entry_method: inclusiveの場合は税込価格、tax_entry_method: exclusiveの場合は税抜価格となります)</value>
        [DataMember(Name="unit_price", EmitDefaultValue=false)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 消費税額
        /// </summary>
        /// <value>消費税額</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public int Vat { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        /// <value>備考</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// 勘定科目ID
        /// </summary>
        /// <value>勘定科目ID</value>
        [DataMember(Name="account_item_id", EmitDefaultValue=false)]
        public int AccountItemId { get; set; }

        /// <summary>
        /// 税区分ID
        /// </summary>
        /// <value>税区分ID</value>
        [DataMember(Name="tax_code", EmitDefaultValue=false)]
        public int TaxCode { get; set; }

        /// <summary>
        /// 品目ID
        /// </summary>
        /// <value>品目ID</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public int ItemId { get; set; }

        /// <summary>
        /// 部門ID
        /// </summary>
        /// <value>部門ID</value>
        [DataMember(Name="section_id", EmitDefaultValue=false)]
        public int SectionId { get; set; }

        /// <summary>
        /// Gets or Sets TagIds
        /// </summary>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// セグメント１ID
        /// </summary>
        /// <value>セグメント１ID</value>
        [DataMember(Name="segment_1_tag_id", EmitDefaultValue=false)]
        public int Segment1TagId { get; set; }

        /// <summary>
        /// セグメント２ID
        /// </summary>
        /// <value>セグメント２ID</value>
        [DataMember(Name="segment_2_tag_id", EmitDefaultValue=false)]
        public int Segment2TagId { get; set; }

        /// <summary>
        /// セグメント３ID
        /// </summary>
        /// <value>セグメント３ID</value>
        [DataMember(Name="segment_3_tag_id", EmitDefaultValue=false)]
        public int Segment3TagId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvoicesCreateParamsInvoiceContents {\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AccountItemId: ").Append(AccountItemId).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  Segment1TagId: ").Append(Segment1TagId).Append("\n");
            sb.Append("  Segment2TagId: ").Append(Segment2TagId).Append("\n");
            sb.Append("  Segment3TagId: ").Append(Segment3TagId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvoicesCreateParamsInvoiceContents);
        }

        /// <summary>
        /// Returns true if InvoicesCreateParamsInvoiceContents instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoicesCreateParamsInvoiceContents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoicesCreateParamsInvoiceContents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Qty == input.Qty ||
                    this.Qty.Equals(input.Qty)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.Vat == input.Vat ||
                    this.Vat.Equals(input.Vat)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AccountItemId == input.AccountItemId ||
                    this.AccountItemId.Equals(input.AccountItemId)
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    this.TaxCode.Equals(input.TaxCode)
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    this.SectionId.Equals(input.SectionId)
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    input.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
                ) && 
                (
                    this.Segment1TagId == input.Segment1TagId ||
                    this.Segment1TagId.Equals(input.Segment1TagId)
                ) && 
                (
                    this.Segment2TagId == input.Segment2TagId ||
                    this.Segment2TagId.Equals(input.Segment2TagId)
                ) && 
                (
                    this.Segment3TagId == input.Segment3TagId ||
                    this.Segment3TagId.Equals(input.Segment3TagId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                hashCode = hashCode * 59 + this.Vat.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.AccountItemId.GetHashCode();
                hashCode = hashCode * 59 + this.TaxCode.GetHashCode();
                hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                hashCode = hashCode * 59 + this.SectionId.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                hashCode = hashCode * 59 + this.Segment1TagId.GetHashCode();
                hashCode = hashCode * 59 + this.Segment2TagId.GetHashCode();
                hashCode = hashCode * 59 + this.Segment3TagId.GetHashCode();
                return hashCode;
            }
        }

    }

}
