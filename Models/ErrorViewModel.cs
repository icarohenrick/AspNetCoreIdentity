using Microsoft.Extensions.Caching.Memory;
using System;

namespace AspNetCoreIdentity.Models
{
    public class ErrorViewModel
    {
        //Padrao
        //public string RequestId { get; set; }
        //public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int ErroCode { get; set; }
        public string Titulo { get; set; }
        public string Mensagem { get; set; }
    }
}
