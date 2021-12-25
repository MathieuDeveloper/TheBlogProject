using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace TheBlogProject.Services
{
    public class BasicImageService : IImageService
    {
        public string ContentType(IFormFile file)
        {
            return file?.ContentType;
        }

        public string DecodeImage(byte[] data, string type)
        {
            if (data is null || type is null) return null;
            return $"data:image/{type};base64,{Convert.ToBase64String(data)}";
        }

        public Task<byte[]> EncodeImageAsync(IFormFile file)
        {
            throw new System.NotImplementedException();
        }

        public Task<byte[]> EncodeImageAsync(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public int Size(IFormFile file)
        {
            throw new System.NotImplementedException();
        }
    }
}
