using Cvapi.Models;
using Cvapi.Models.Civitai.Images;
using Cvapi.Models.Civitai.Models;
using Cvapi.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvapi
{
    public class CivitaiClient : CvBaseModel
    {
        public CivitaiClient()
        {
        }

        #region モデル検索処理
        /// <summary>
        /// モデル検索処理
        /// </summary>
        /// <param name="query">モデル検索条件（クエリ）</param>
        /// <returns>検索結果</returns>
        public async Task<CvsModelM> ModelSearch(string query)
        {
            string request = string.Empty;

            // エンドポイント + パラメータ
            string url = CvsModelM.Endpoint + query;

            CivitaiRequest tmp = new CivitaiRequest();

            // 実行してJSON形式をデシリアライズ
            var request_tmp = await tmp.Request(url);

            // Jsonファイルを展開して返却
            return JSONUtil.DeserializeFromText<CvsModelM>(request_tmp);
        }

        /// <summary>
        /// モデル検索処理
        /// </summary>
        /// <param name="searchCondition">モデル検索条件</param>
        /// <returns>検索結果</returns>
        public async Task<CvsModelM> ModelSearch(CvsModelSearchM searchCondition)
        {
            // Jsonファイルを展開して返却
            return await ModelSearch(searchCondition.RequestQuery);
        }
        #endregion

        #region イメージ検索処理
        /// <summary>
        /// イメージ検索処理
        /// </summary>
        /// <param name="query">検索条件（クエリ）</param>
        /// <returns>検索結果</returns>
        public async Task<CvsImageM> ImageSearch(string query)
        {
            string request = string.Empty;

            // エンドポイント + パラメータ
            string url = CvsImageM.Endpoint + query;

            CivitaiRequest tmp = new CivitaiRequest();

            // 実行してJSON形式をデシリアライズ
            var request_tmp = await tmp.Request(url);

            // Jsonファイルを展開して返却
            return JSONUtil.DeserializeFromText<CvsImageM>(request_tmp);
        }


        /// <summary>
        /// イメージ検索処理
        /// </summary>
        /// <param name="searchCondition">検索条件</param>
        /// <returns>検索結果</returns>
        public async Task<CvsImageM> ImageSearch(CvsImageSearchM searchCondition)
        {
            // Jsonファイルを展開して返却
            return await ImageSearch(searchCondition.RequestQuery);
        }
        #endregion
    }
}
