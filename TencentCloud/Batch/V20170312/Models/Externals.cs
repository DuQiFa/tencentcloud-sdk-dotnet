/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Externals : AbstractModel
    {
        
        /// <summary>
        /// 释放地址
        /// </summary>
        [JsonProperty("ReleaseAddress")]
        public bool? ReleaseAddress{ get; set; }

        /// <summary>
        /// 不支持的网络类型
        /// </summary>
        [JsonProperty("UnsupportNetworks")]
        public string[] UnsupportNetworks{ get; set; }

        /// <summary>
        /// HDD本地存储属性
        /// </summary>
        [JsonProperty("StorageBlockAttr")]
        public StorageBlock StorageBlockAttr{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReleaseAddress", this.ReleaseAddress);
            this.SetParamArraySimple(map, prefix + "UnsupportNetworks.", this.UnsupportNetworks);
            this.SetParamObj(map, prefix + "StorageBlockAttr.", this.StorageBlockAttr);
        }
    }
}

