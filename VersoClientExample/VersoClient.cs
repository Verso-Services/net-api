using System;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace VersoClientExample
{
    /// <summary>
    /// Java class that handles the Verso API client Methods
    /// </summary>
    public class VersoClient
    {

        #region Properties

        /// <summary>
        /// Verso Client unique instance
        /// </summary>
        private static VersoClient _instance;

        #endregion

        #region Private Methods

        /// <summary>
        /// Class private constuctor
        /// </summary>
        private VersoClient() { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get instance method to get unique VersoClient object
        /// </summary>
        /// <returns>The class unique instance</returns>
        public static VersoClient GetInstance()
        {
            return _instance ?? (_instance = new VersoClient());
        }

        /// <summary>
        /// Import Articles Batch method example
        /// </summary>
        public async void ImportArticlesBatch()
        {
            // Create the htppClient
            var httpClient = new HttpClient();

            // Here you place the Verso API Url (TestUrl)
            var url = "http://qa-verso-enterprise-service.azurewebsites.net/VersoApiService.svc/ImportArticlesBatch";

            try
            {
                // Here we create a sample ImportArticles Object to import in Verso
                // You are free to add as many articles as you like
                var batchImport = new ImportArticlesBatchInfo("mnavarro", "123");
                batchImport.AddArticle(new ArticleInfo("TestPart00", "TestPartS00", "Test",
                    "ATE3", "08/06/2015", "10/10/2015", "", "", "", ""));
                batchImport.AddArticle(new ArticleInfo("TestPart01", "TestPartS01", "Test",
                    "ATE3", "08/06/2015", "10/10/2015", "", "", "", "TestBuyChannel"));
                var batchImportJson = JsonConvert.SerializeObject(batchImport);

                // Set client properties and execute post
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response =
                    await
                        httpClient.PostAsync(url, new StringContent(batchImportJson, Encoding.UTF8, "application/json"));

                var readAsStringAsync = await response.Content.ReadAsStringAsync();

                // Print response value (Just for testing)
                Console.WriteLine(readAsStringAsync);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // Handle your exception
            }
            finally
            {
                // Close client connection
                httpClient.Dispose();
            }
        }


        #endregion


    }
}
