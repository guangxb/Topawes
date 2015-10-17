using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.function.search
    /// </summary>
    public class HanoiFunctionSearchRequest : ITopRequest<HanoiFunctionSearchResponse>
    {
        /// <summary>
        /// 分配给调用方的名称信息，内部统计使用
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// FunctionQuery的json格式
        /// </summary>
        public string Sdata { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.function.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("sdata", this.Sdata);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("sdata", this.Sdata);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
