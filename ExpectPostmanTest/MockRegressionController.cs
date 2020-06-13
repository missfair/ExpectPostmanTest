using Microsoft.AspNetCore.Mvc;
using System;

namespace ExpectPostmanTest.Controllers
{
    public class MockRegressionController : Controller
    {
        [HttpPost("api/mock-regression")]
        public object MockRegression([FromBody] object request)
        {
            try
            {
                return request.WrtieMockRegression();             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
