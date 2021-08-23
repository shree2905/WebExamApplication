using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebExamApplication.Models
{
    public interface IApiClient
    {
        Task<ApiResponse> GetAsync(string relativePath);
        Task<ApiResponse> PostAsync(string relativePath, object obj);
        Task<ApiResponse> PutAsync(string relativePath, object obj);
        Task<ApiResponse> DeleteAsync(string relativePath);
    }
}