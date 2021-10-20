﻿using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityPauseResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantActivityPauseResponse : AlipayResponse
    {
        /// <summary>
        /// 商户活动ID
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 外部请求号,用于幂等管理
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
