// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SegmentTags operations.
    /// </summary>
    public partial interface ISegmentTags
    {
        /// <summary>
        /// セグメントタグ一覧の取得
        /// </summary>
        /// <remarks>
        /// 指定した事業所のセグメントタグ一覧を取得する
        /// </remarks>
        /// <param name='companyId'>
        /// 事業所ID
        /// </param>
        /// <param name='segmentId'>
        /// セグメントID
        /// </param>
        /// <param name='offset'>
        /// 取得レコードのオフセット (デフォルト: 0)
        /// </param>
        /// <param name='limit'>
        /// 取得レコードの件数 (デフォルト: 20, 最大: 500)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<SegmentTagsIndexResponse>> ListWithHttpMessagesAsync(int companyId, int segmentId, int? offset = default(int?), int? limit = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// セグメントの作成
        /// </summary>
        /// <remarks>
        /// 指定した事業所のセグメントタグを作成する
        /// </remarks>
        /// <param name='parameters'>
        /// セグメントタグの作成
        /// </param>
        /// <param name='segmentId'>
        /// セグメントID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<SegmentTagsResponse>> CreateWithHttpMessagesAsync(SegmentTagParams parameters, int segmentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// セグメントタグの更新
        /// </summary>
        /// <remarks>
        /// 指定した事業所のセグメントタグを更新する
        /// </remarks>
        /// <param name='parameters'>
        /// セグメントタグの作成
        /// </param>
        /// <param name='segmentId'>
        /// セグメントID
        /// </param>
        /// <param name='id'>
        /// セグメントタグID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<SegmentTagsResponse>> UpdateWithHttpMessagesAsync(SegmentTagParams parameters, int segmentId, int id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// セグメントタグの削除
        /// </summary>
        /// <remarks>
        /// 指定した事業所のセグメントタグを削除する
        /// </remarks>
        /// <param name='segmentId'>
        /// セグメントID
        /// </param>
        /// <param name='id'>
        /// セグメントタグID
        /// </param>
        /// <param name='companyId'>
        /// 事業所ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DestroySegmentsTagWithHttpMessagesAsync(int segmentId, int id, int companyId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}