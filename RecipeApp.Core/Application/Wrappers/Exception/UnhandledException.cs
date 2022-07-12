using System.Net;
using RecipeApp.Core.Wrappers.Exception.Base;

namespace RecipeApp.Core.Wrappers.Exception
{

    public class UnhandledException : aBaseException
    {
        public UnhandledException()
        {
            StatusCode = HttpStatusCode.InternalServerError;
            Message = "Beklenmedik bir hata oluştu";
            Success = false;
        }
        
    }

}