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
    /// UpdateExpenseApplicationParams
    /// </summary>
    [DataContract]
    public partial class UpdateExpenseApplicationParams :  IEquatable<UpdateExpenseApplicationParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExpenseApplicationParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateExpenseApplicationParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateExpenseApplicationParams" /> class.
        /// </summary>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="title">申請タイトル (required).</param>
        /// <param name="issueDate">申請日 (yyyy-mm-dd) (required).</param>
        /// <param name="description">備考.</param>
        /// <param name="editableOnWeb">会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。.</param>
        /// <param name="sectionId">部門ID.</param>
        /// <param name="tagIds">メモタグID.</param>
        /// <param name="expenseApplicationLines">expenseApplicationLines (required).</param>
        public UpdateExpenseApplicationParams(int companyId = default(int), string title = default(string), string issueDate = default(string), string description = default(string), bool editableOnWeb = default(bool), int sectionId = default(int), List<int> tagIds = default(List<int>), List<UpdateExpenseApplicationParamsExpenseApplicationLines> expenseApplicationLines = default(List<UpdateExpenseApplicationParamsExpenseApplicationLines>))
        {
            this.CompanyId = companyId;
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for UpdateExpenseApplicationParams and cannot be null");;
            // to ensure "issueDate" is required (not null)
            this.IssueDate = issueDate ?? throw new ArgumentNullException("issueDate is a required property for UpdateExpenseApplicationParams and cannot be null");;
            // to ensure "expenseApplicationLines" is required (not null)
            this.ExpenseApplicationLines = expenseApplicationLines ?? throw new ArgumentNullException("expenseApplicationLines is a required property for UpdateExpenseApplicationParams and cannot be null");;
            this.Description = description;
            this.EditableOnWeb = editableOnWeb;
            this.SectionId = sectionId;
            this.TagIds = tagIds;
        }
        
        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 申請タイトル
        /// </summary>
        /// <value>申請タイトル</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// 申請日 (yyyy-mm-dd)
        /// </summary>
        /// <value>申請日 (yyyy-mm-dd)</value>
        [DataMember(Name="issue_date", EmitDefaultValue=false)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 備考
        /// </summary>
        /// <value>備考</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// 会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。
        /// </summary>
        /// <value>会計freeeのWeb画面から申請内容を編集可能：falseの場合、Web上からの項目行の追加／削除・金額の編集が出来なくなります。APIでの編集は可能です。</value>
        [DataMember(Name="editable_on_web", EmitDefaultValue=false)]
        public bool EditableOnWeb { get; set; }

        /// <summary>
        /// 部門ID
        /// </summary>
        /// <value>部門ID</value>
        [DataMember(Name="section_id", EmitDefaultValue=false)]
        public int SectionId { get; set; }

        /// <summary>
        /// メモタグID
        /// </summary>
        /// <value>メモタグID</value>
        [DataMember(Name="tag_ids", EmitDefaultValue=false)]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseApplicationLines
        /// </summary>
        [DataMember(Name="expense_application_lines", EmitDefaultValue=false)]
        public List<UpdateExpenseApplicationParamsExpenseApplicationLines> ExpenseApplicationLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExpenseApplicationParams {\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EditableOnWeb: ").Append(EditableOnWeb).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
            sb.Append("  ExpenseApplicationLines: ").Append(ExpenseApplicationLines).Append("\n");
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
            return this.Equals(input as UpdateExpenseApplicationParams);
        }

        /// <summary>
        /// Returns true if UpdateExpenseApplicationParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateExpenseApplicationParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateExpenseApplicationParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EditableOnWeb == input.EditableOnWeb ||
                    this.EditableOnWeb.Equals(input.EditableOnWeb)
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
                    this.ExpenseApplicationLines == input.ExpenseApplicationLines ||
                    this.ExpenseApplicationLines != null &&
                    input.ExpenseApplicationLines != null &&
                    this.ExpenseApplicationLines.SequenceEqual(input.ExpenseApplicationLines)
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
                hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.EditableOnWeb.GetHashCode();
                hashCode = hashCode * 59 + this.SectionId.GetHashCode();
                if (this.TagIds != null)
                    hashCode = hashCode * 59 + this.TagIds.GetHashCode();
                if (this.ExpenseApplicationLines != null)
                    hashCode = hashCode * 59 + this.ExpenseApplicationLines.GetHashCode();
                return hashCode;
            }
        }

    }

}
