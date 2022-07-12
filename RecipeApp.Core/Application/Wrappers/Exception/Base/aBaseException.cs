using System.Net;
using RecipeApp.Core.Wrappers.Response;

namespace RecipeApp.Core.Wrappers.Exception.Base
{

    public abstract class aBaseException
    {
        public HttpStatusCode StatusCode { get; init; }
        public string Message {get;init;}
        public bool Success {get;init;}


        public BaseResponse HandleException()
        {
            return new BaseResponse()
            {
                Status = this.StatusCode,
                Message = this.Message,
                Success = this.Success
            };
        }
        
    }

}