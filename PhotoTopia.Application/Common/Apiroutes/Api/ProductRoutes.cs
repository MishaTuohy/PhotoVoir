namespace PhotoVoir.Application.Common.Apiroutes.Api
{
    public static class ProductRoutes
    {
        // BASE
        public const string Base = "api/product";

        // GET REQUESTS
        public const string GetById = Base + "/id={id}";

        // UPDATE REQUESTS
        public const string UpdateAll = Base + "/update";

        // DELETE REQUESTS
        public const string Delete = Base + "/id={Id}";
    }
}
