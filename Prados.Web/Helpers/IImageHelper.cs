using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFIle);
        Task<string> UploadImageAsyncNegocio(IFormFile imageFIle);
        Task<string> UploadImageAsyncProducto(IFormFile imageFIle);
        Task<string> UploadImageAsyncNoticia(IFormFile imageFIle);
    }
}
