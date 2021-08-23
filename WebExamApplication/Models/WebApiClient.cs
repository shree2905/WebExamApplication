using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WebExamApplication.Models
{
    public class WebApiClient : IApiClient
    {
        private System.Net.Http.HttpClient _httpClient;

        protected string BuildCompleteUri(string relativePath)
        {
            // Using a URI will help us to validate the URL before making an invalid call.
            ApiBaseUrl apiBaseUrl = new ApiBaseUrl();
            string returnUri = string.Concat(apiBaseUrl.baseUrl, relativePath);

            return returnUri;
        }
        public async Task<ApiResponse> GetAsync(string relativePath)
        {
            Uri completeUri = new Uri(this.BuildCompleteUri(relativePath));
            ApiResponse response = new ApiResponse();
            HttpResponseMessage apiResponse = await this.Client.GetAsync(completeUri);
            if (apiResponse.IsSuccessStatusCode)
            {
                string responseData = apiResponse.Content.ReadAsStringAsync().Result;
                if (!string.IsNullOrWhiteSpace(responseData))
                {
                    response.IsSuccessful = true;
                    response.Data = responseData;
                }
            }
            else
            {
                // TODO: Log Errors
            }

            return response;
        }
        public async Task<ApiResponse> PostAsync(string relativePath, object obj)
        {
            Uri completeUri = new Uri(this.BuildCompleteUri(relativePath));
            ApiResponse response = new ApiResponse();
            HttpResponseMessage apiResponse = await this.Client.PostAsJsonAsync(completeUri, obj);
            if (apiResponse.IsSuccessStatusCode)
            {
                string responseData = apiResponse.Content.ReadAsStringAsync().Result;
                if (!string.IsNullOrWhiteSpace(responseData))
                {
                    response.IsSuccessful = true;
                    response.Data = responseData;
                }
            }
            else
            {
                // TODO: Log Errors
            }

            return response;
        }
        public async Task<ApiResponse> PutAsync(string relativePath, object obj)
        {
            Uri completeUri = new Uri(this.BuildCompleteUri(relativePath));
            ApiResponse response = new ApiResponse();
            HttpResponseMessage apiResponse = await this.Client.PutAsJsonAsync(completeUri, obj);
            if (apiResponse.IsSuccessStatusCode)
            {
                string responseData = apiResponse.Content.ReadAsStringAsync().Result;
                if (!string.IsNullOrWhiteSpace(responseData))
                {
                    response.IsSuccessful = true;
                    response.Data = responseData;
                }
            }
            else
            {
                // TODO: Log Errors
            }

            return response;
        }
        public async Task<ApiResponse> DeleteAsync(string relativePath)
        {
            Uri completeUri = new Uri(this.BuildCompleteUri(relativePath));
            ApiResponse response = new ApiResponse();
            HttpResponseMessage apiResponse = await this.Client.DeleteAsync(completeUri);
            if (apiResponse.IsSuccessStatusCode)
            {
                string responseData = apiResponse.Content.ReadAsStringAsync().Result;
                if (!string.IsNullOrWhiteSpace(responseData))
                {
                    response.IsSuccessful = true;
                    response.Data = responseData;
                }
            }
            else
            {
                // TODO: Log Errors
            }

            return response;
        }
        public HttpClient Client
        {
            get
            {
                if (this._httpClient == null)
                {
                    this._httpClient = new HttpClient();
                }

                return this._httpClient;
            }
        }
    }
}