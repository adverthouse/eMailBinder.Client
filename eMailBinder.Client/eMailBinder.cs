using eMailBinder.Client.Requests;
using eMailBinder.Core.Common;

namespace eMailBinder.Client;

public class eMailBinder :IeMailBinder
{
     private string _apiKey;
     private string _apiEndPoint;
     private APIService apiService;

     public eMailBinder(string apiEndPoint, string apiKey)
     {
        _apiKey = apiKey;
        _apiEndPoint = apiEndPoint;

        apiService = new APIService(new HttpClient(){
           BaseAddress = new Uri(apiEndPoint)            
        });
     }

     public async Task<StatusInfo<string>?> SubscribeToList(SubscriptionRequest subscriptionRequest)
     {          
          var result = await apiService.Post<StatusInfo<string>,SubscriptionRequest>($"api/subscribe",subscriptionRequest);
          if (result.IsSuccess){
               return result.result;
          }     
    
          return result.result;
     }

/*
        public async Task<(bool IsSuccess, List<ApiVMCategory>? Categories, string? ErrorMessage)> GetAllActiveCategoriesAsync() => 
            await Get<List<ApiVMCategory>>($"api/Categories");

        public async Task<(bool IsSuccess, List<ApiVMFeature>? Features, string? ErrorMessage)> GetAllActiveFeaturesAsync(string lang) =>
               await Get<List<ApiVMFeature>>($"api/Features/AllActiveFeatures/{lang}");

        public async Task<(bool IsSuccess, List<ApiVMFeatureValue>? Features, string? ErrorMessage)> GetAllActiveFeatureValuesAsync(string lang) =>
                await Get<List<ApiVMFeatureValue>>($"api/Features/AllActiveFeatureValues/{lang}");

        public async Task<(bool IsSuccess, List<ApiVMFeaturesByCategory>? Features, string? ErrorMessage)> GetAllFeaturesByCategoryAsync() =>
              await Get<List<ApiVMFeaturesByCategory>>($"api/Features/AllFeaturesByCategory");

        public async Task<(bool IsSuccess, VM_SearchResult? searchResult, string? ErrorMessage)> SearchProductsAsync(string lang, PSFProduct psf) =>
                            await Post<VM_SearchResult,PSFProduct>($"api/Products/SearchProducts/{lang}",psf);

        public async Task<(bool IsSuccess, StatusInfo<string>? result, string? ErrorMessage)> CropResizeImageAsync(string guid)
                => await GetImageProcessingApi<StatusInfo<string>>($"/CropResizeImage/{guid}");

        public async Task<(bool IsSuccess, NoSQLProductDetail? productDetail, string? ErrorMessage)> GetProductDetailsByLangAndProductIDAsync(string lang, int productID) =>
                        await Get<NoSQLProductDetail>($"api/Products/Detail/{lang}/{productID}");

        public async Task<(bool IsSuccess, List<ApiVMCategory>? Categories, string? ErrorMessage)> GetAllActiveFeaturedCategoriesAsync() =>
                           await Get<List<ApiVMCategory>>($"api/Categories/Featured");

        public async Task<(bool IsSuccess, List<NoSQLProduct>? productList, string? ErrorMessage)> GetLatestTopNProductsByLangAsync(string lang, int top) =>
                           await Get<List<NoSQLProduct>>($"api/Products/LatestProducts/{lang}/{top}");*/
}
