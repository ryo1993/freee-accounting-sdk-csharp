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
    /// AccountItemParamsAccountItem
    /// </summary>
    [DataContract]
    public partial class AccountItemParamsAccountItem :  IEquatable<AccountItemParamsAccountItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountItemParamsAccountItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountItemParamsAccountItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountItemParamsAccountItem" /> class.
        /// </summary>
        /// <param name="name">勘定科目名 (30文字以内) (required).</param>
        /// <param name="shortcut">ショートカット1 (20文字以内).</param>
        /// <param name="shortcutNum">ショートカット2(勘定科目コード)(20文字以内).</param>
        /// <param name="taxName">税区分 (required).</param>
        /// <param name="groupName">決算書表示名 (required).</param>
        /// <param name="accountCategory">勘定科目カテゴリー (required).</param>
        /// <param name="correspondingIncomeName">収入取引相手勘定科目 (required).</param>
        /// <param name="correspondingExpenseName">支出取引相手勘定科目 (required).</param>
        /// <param name="accumulatedDepAccountItemName">減価償却累計額勘定科目.</param>
        /// <param name="searchable">検索可能:2, 検索不可：3.</param>
        /// <param name="items">品目.</param>
        /// <param name="partners">取引先.</param>
        public AccountItemParamsAccountItem(string name = default(string), string shortcut = default(string), string shortcutNum = default(string), string taxName = default(string), string groupName = default(string), string accountCategory = default(string), string correspondingIncomeName = default(string), string correspondingExpenseName = default(string), string accumulatedDepAccountItemName = default(string), int searchable = default(int), List<AccountItemParamsAccountItemItems> items = default(List<AccountItemParamsAccountItemItems>), List<AccountItemParamsAccountItemItems> partners = default(List<AccountItemParamsAccountItemItems>))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AccountItemParamsAccountItem and cannot be null");;
            // to ensure "taxName" is required (not null)
            this.TaxName = taxName ?? throw new ArgumentNullException("taxName is a required property for AccountItemParamsAccountItem and cannot be null");;
            // to ensure "groupName" is required (not null)
            this.GroupName = groupName ?? throw new ArgumentNullException("groupName is a required property for AccountItemParamsAccountItem and cannot be null");;
            // to ensure "accountCategory" is required (not null)
            this.AccountCategory = accountCategory ?? throw new ArgumentNullException("accountCategory is a required property for AccountItemParamsAccountItem and cannot be null");;
            // to ensure "correspondingIncomeName" is required (not null)
            this.CorrespondingIncomeName = correspondingIncomeName ?? throw new ArgumentNullException("correspondingIncomeName is a required property for AccountItemParamsAccountItem and cannot be null");;
            // to ensure "correspondingExpenseName" is required (not null)
            this.CorrespondingExpenseName = correspondingExpenseName ?? throw new ArgumentNullException("correspondingExpenseName is a required property for AccountItemParamsAccountItem and cannot be null");;
            this.Shortcut = shortcut;
            this.ShortcutNum = shortcutNum;
            this.AccumulatedDepAccountItemName = accumulatedDepAccountItemName;
            this.Searchable = searchable;
            this.Items = items;
            this.Partners = partners;
        }
        
        /// <summary>
        /// 勘定科目名 (30文字以内)
        /// </summary>
        /// <value>勘定科目名 (30文字以内)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ショートカット1 (20文字以内)
        /// </summary>
        /// <value>ショートカット1 (20文字以内)</value>
        [DataMember(Name="shortcut", EmitDefaultValue=false)]
        public string Shortcut { get; set; }

        /// <summary>
        /// ショートカット2(勘定科目コード)(20文字以内)
        /// </summary>
        /// <value>ショートカット2(勘定科目コード)(20文字以内)</value>
        [DataMember(Name="shortcut_num", EmitDefaultValue=false)]
        public string ShortcutNum { get; set; }

        /// <summary>
        /// 税区分
        /// </summary>
        /// <value>税区分</value>
        [DataMember(Name="tax_name", EmitDefaultValue=false)]
        public string TaxName { get; set; }

        /// <summary>
        /// 決算書表示名
        /// </summary>
        /// <value>決算書表示名</value>
        [DataMember(Name="group_name", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 勘定科目カテゴリー
        /// </summary>
        /// <value>勘定科目カテゴリー</value>
        [DataMember(Name="account_category", EmitDefaultValue=false)]
        public string AccountCategory { get; set; }

        /// <summary>
        /// 収入取引相手勘定科目
        /// </summary>
        /// <value>収入取引相手勘定科目</value>
        [DataMember(Name="corresponding_income_name", EmitDefaultValue=false)]
        public string CorrespondingIncomeName { get; set; }

        /// <summary>
        /// 支出取引相手勘定科目
        /// </summary>
        /// <value>支出取引相手勘定科目</value>
        [DataMember(Name="corresponding_expense_name", EmitDefaultValue=false)]
        public string CorrespondingExpenseName { get; set; }

        /// <summary>
        /// 減価償却累計額勘定科目
        /// </summary>
        /// <value>減価償却累計額勘定科目</value>
        [DataMember(Name="accumulated_dep_account_item_name", EmitDefaultValue=false)]
        public string AccumulatedDepAccountItemName { get; set; }

        /// <summary>
        /// 検索可能:2, 検索不可：3
        /// </summary>
        /// <value>検索可能:2, 検索不可：3</value>
        [DataMember(Name="searchable", EmitDefaultValue=false)]
        public int Searchable { get; set; }

        /// <summary>
        /// 品目
        /// </summary>
        /// <value>品目</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<AccountItemParamsAccountItemItems> Items { get; set; }

        /// <summary>
        /// 取引先
        /// </summary>
        /// <value>取引先</value>
        [DataMember(Name="partners", EmitDefaultValue=false)]
        public List<AccountItemParamsAccountItemItems> Partners { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountItemParamsAccountItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Shortcut: ").Append(Shortcut).Append("\n");
            sb.Append("  ShortcutNum: ").Append(ShortcutNum).Append("\n");
            sb.Append("  TaxName: ").Append(TaxName).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  AccountCategory: ").Append(AccountCategory).Append("\n");
            sb.Append("  CorrespondingIncomeName: ").Append(CorrespondingIncomeName).Append("\n");
            sb.Append("  CorrespondingExpenseName: ").Append(CorrespondingExpenseName).Append("\n");
            sb.Append("  AccumulatedDepAccountItemName: ").Append(AccumulatedDepAccountItemName).Append("\n");
            sb.Append("  Searchable: ").Append(Searchable).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Partners: ").Append(Partners).Append("\n");
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
            return this.Equals(input as AccountItemParamsAccountItem);
        }

        /// <summary>
        /// Returns true if AccountItemParamsAccountItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountItemParamsAccountItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountItemParamsAccountItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Shortcut == input.Shortcut ||
                    (this.Shortcut != null &&
                    this.Shortcut.Equals(input.Shortcut))
                ) && 
                (
                    this.ShortcutNum == input.ShortcutNum ||
                    (this.ShortcutNum != null &&
                    this.ShortcutNum.Equals(input.ShortcutNum))
                ) && 
                (
                    this.TaxName == input.TaxName ||
                    (this.TaxName != null &&
                    this.TaxName.Equals(input.TaxName))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.AccountCategory == input.AccountCategory ||
                    (this.AccountCategory != null &&
                    this.AccountCategory.Equals(input.AccountCategory))
                ) && 
                (
                    this.CorrespondingIncomeName == input.CorrespondingIncomeName ||
                    (this.CorrespondingIncomeName != null &&
                    this.CorrespondingIncomeName.Equals(input.CorrespondingIncomeName))
                ) && 
                (
                    this.CorrespondingExpenseName == input.CorrespondingExpenseName ||
                    (this.CorrespondingExpenseName != null &&
                    this.CorrespondingExpenseName.Equals(input.CorrespondingExpenseName))
                ) && 
                (
                    this.AccumulatedDepAccountItemName == input.AccumulatedDepAccountItemName ||
                    (this.AccumulatedDepAccountItemName != null &&
                    this.AccumulatedDepAccountItemName.Equals(input.AccumulatedDepAccountItemName))
                ) && 
                (
                    this.Searchable == input.Searchable ||
                    this.Searchable.Equals(input.Searchable)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.Partners == input.Partners ||
                    this.Partners != null &&
                    input.Partners != null &&
                    this.Partners.SequenceEqual(input.Partners)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Shortcut != null)
                    hashCode = hashCode * 59 + this.Shortcut.GetHashCode();
                if (this.ShortcutNum != null)
                    hashCode = hashCode * 59 + this.ShortcutNum.GetHashCode();
                if (this.TaxName != null)
                    hashCode = hashCode * 59 + this.TaxName.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.AccountCategory != null)
                    hashCode = hashCode * 59 + this.AccountCategory.GetHashCode();
                if (this.CorrespondingIncomeName != null)
                    hashCode = hashCode * 59 + this.CorrespondingIncomeName.GetHashCode();
                if (this.CorrespondingExpenseName != null)
                    hashCode = hashCode * 59 + this.CorrespondingExpenseName.GetHashCode();
                if (this.AccumulatedDepAccountItemName != null)
                    hashCode = hashCode * 59 + this.AccumulatedDepAccountItemName.GetHashCode();
                hashCode = hashCode * 59 + this.Searchable.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.Partners != null)
                    hashCode = hashCode * 59 + this.Partners.GetHashCode();
                return hashCode;
            }
        }

    }

}
