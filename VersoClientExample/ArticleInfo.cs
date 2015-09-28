
namespace VersoClientExample
{
    /// <summary>
    /// Handles the article object to be imported to Verso
    /// </summary>
    public class ArticleInfo
    {

        #region Properties

        /// <summary>
        /// Handles the article Article Number property
        /// </summary>
        public string ArticleNo { get; set; }

        /// <summary>
        /// Handles the article Serial Number property
        /// </summary>
        public string SerialNo { get; set; }

        /// <summary>
        /// Handles the article Description property
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Handles the article Delivery Address property
        /// </summary>
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// Handles the article Warranty Start Date value
        /// </summary>
        public string WarratyStartDateValue { get; set; }

        /// <summary>
        /// Handles the article End Date value
        /// </summary>
        public string WarrantyEndDateValue { get; set; }

        /// <summary>
        /// Handles the article price value
        /// </summary>
        public string PriceValue { get; set; }

        /// <summary>
        /// Handles the article Supplier Code to be used
        /// </summary>
        public string SupplierCode { get; set; }

        /// <summary>
        /// Handles the article specific order or contract number
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Handles the article Buy Channel property
        /// </summary>
        public string BuyChannel { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// The Class constructor
        /// </summary>
        /// <param name="pArticleNo">The article No to be imported</param>
        /// <param name="pSerialNo">The article Serial No to be imported</param>
        /// <param name="pDescription">The article Description</param>
        /// <param name="pDeliveryAddress">The article delivery address</param>
        /// <param name="pWarratyStartDateValue">The article warranty start date</param>
        /// <param name="pWarrantyEndDateValue">The article warranty end date</param>
        /// <param name="pPriceValue">The article price value</param>
        /// <param name="pSupplierCode">The article supplier code</param>
        /// <param name="pOrderNumber">The article order or contract number</param>
        /// <param name="pBuyChannel">The article buy channel</param>
        public ArticleInfo(string pArticleNo, string pSerialNo, string pDescription,
                string pDeliveryAddress, string pWarratyStartDateValue, string pWarrantyEndDateValue,
                string pPriceValue, string pSupplierCode, string pOrderNumber, string pBuyChannel)
        {
            ArticleNo = pArticleNo;
            SerialNo = pSerialNo;
            Description = pDescription;
            DeliveryAddress = pDeliveryAddress;
            WarratyStartDateValue = pWarratyStartDateValue;
            WarrantyEndDateValue = pWarrantyEndDateValue;
            PriceValue = pPriceValue;
            SupplierCode = pSupplierCode;
            OrderNumber = pOrderNumber;
            BuyChannel = pBuyChannel;
        }

        #endregion 

    }
}
