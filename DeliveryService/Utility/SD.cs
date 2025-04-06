namespace DeliveryService.Utility
{
    public class SD
    {
        //public static string CouponAPIBase { get; set; }
        //public static string ProductAPIBase { get; set; }
        //public static string AuthAPIBase { get; set; }
        //public static string ShoppingCartAPIBase { get; set; }
        //public static string OrderAPIBase { get; set; }
        public static string ApiGatwayAPIBase { get; set; } = "https://localhost:7001";
        public const string TokenCookie = "JWTToken";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public const string Status_Pending = "Pending";
        public const string Status_Completed = "Completed";
        public const string Status_Cancelled = "Cancelled";

        public enum ContentType
        {
            Json,
            MultipartFormData,
        }


        public const string MicroserviceOrderQueue = "MicroserviceOrderQueue";
        public const string MicroserviceCancelledOrderQueue = "MicroserviceCancelledOrderQueue";

        public const string CustomerRole = "Customer";
        public const string DeliveryPartnerRole = "DeliveryPartner";
    }
}
