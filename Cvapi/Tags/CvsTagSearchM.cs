using Cvapi.Models.Civitai.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvapi.Tags
{
    public class CvsTagSearchM : CvBaseModel
    {
        #region The number of results to be returned per page. This can be a number between 1 and 200. By default, each page will return 100 results[Limit]プロパティ
        /// <summary>
        /// The number of results to be returned per page. This can be a number between 1 and 200. By default, each page will return 100 results[Limit]プロパティ用変数
        /// </summary>
        int? _Limit = 100;
        /// <summary>
        /// The number of results to be returned per page. This can be a number between 1 and 200. By default, each page will return 100 results[Limit]プロパティ
        /// </summary>
        public int? Limit
        {
            get
            {
                return _Limit;
            }
            set
            {
                if (_Limit == null || !_Limit.Equals(value))
                {
                    _Limit = value;
                    RaisePropertyChanged("Limit");
                }
            }
        }
        #endregion

        #region The page from which to start fetching models[Page ]プロパティ
        /// <summary>
        /// The page from which to start fetching models[Page ]プロパティ用変数
        /// </summary>
        int? _Page = 1;
        /// <summary>
        /// The page from which to start fetching models[Page ]プロパティ
        /// </summary>
        public int? Page
        {
            get
            {
                return _Page;
            }
            set
            {
                if (_Page == null || !_Page.Equals(value))
                {
                    _Page = value;
                    RaisePropertyChanged("Page");
                }
            }
        }
        #endregion

        #region Search query to filter models by name[Query ]プロパティ
        /// <summary>
        /// Search query to filter models by name[Query ]プロパティ用変数
        /// </summary>
        string? _Query = null;
        /// <summary>
        /// Search query to filter models by name[Query ]プロパティ
        /// </summary>
        public string? Query
        {
            get
            {
                return _Query;
            }
            set
            {
                if (_Query == null || !_Query.Equals(value))
                {
                    _Query = value;
                    RaisePropertyChanged("Query");
                }
            }
        }
        #endregion

        #region GET Condition[RequestQuery]プロパティ
        /// <summary>
        /// GET Condition[RequestQuery]プロパティ用変数
        /// </summary>
        string _RequestQuery = string.Empty;
        /// <summary>
        /// GET Condition[RequestQuery]プロパティ
        /// </summary>
        public string RequestQuery
        {
            get
            {
                string query = string.Empty;


                query += $"limit={this.Limit}";
                if (this.Page.HasValue) query += $"&page={this.Page.Value}";
                if (!string.IsNullOrEmpty(this.Query)) query += $"&query={this.Query}";

                return "?" + query;

            }
        }
        #endregion
    }

}
