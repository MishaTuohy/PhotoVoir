using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Application.Common.Apiroutes
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
