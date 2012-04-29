using System.Web.Http;

namespace Dodo.Backend.Controllers
{
    public class TokensController : ApiController
    {
        // GET /api/tokens
        public Token Get()
        {
            return new Token
            {
                key = "foo",
                secret = "bar"
            };
        }
    }

    public class Token
    {
        public string key { get; set; }
        public string secret { get; set; }
    }
}