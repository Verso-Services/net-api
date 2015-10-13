using System.Collections.Generic;

namespace VersoClientExample
{
    /// <summary>
    /// Class to handle the import articles batch json object
    /// </summary>
    public class ImportArticlesBatchInfo : ApiUser
    {
        #region Properties

        /// <summary>
        /// Handles the list of articles to be imported in Verso
        /// </summary>
        public List<ArticleInfo> Articles { get; set; }

        #endregion

        #region Public Mehtods

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="pUserName">The Articles batch user to be authenticated</param>
        /// <param name="pPassword">The Articles batch user password to authenticate</param>
        public ImportArticlesBatchInfo(string pUserName, string pPassword) : base(pUserName,pPassword)
        {
            Articles = new List<ArticleInfo>();
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="pUserName">The Articles batch user to be authenticated</param>
        /// <param name="pPassword">The Articles batch user password to authenticate</param>
        /// <param name="pArticles">The list of articles to be imported in Verso</param>
        public ImportArticlesBatchInfo(string pUserName, string pPassword, List<ArticleInfo> pArticles)
            : base(pUserName, pPassword)
        {
            Articles = pArticles;
        }

        /// <summary>
        /// Adds an article to the import articles batch list
        /// </summary>
        /// <param name="pArticle">The article to be added </param>
        public void AddArticle(ArticleInfo pArticle)
        {

            if (Articles == null)
                Articles = new List<ArticleInfo>();

            Articles.Add(pArticle);
        }

        #endregion

    }
}
