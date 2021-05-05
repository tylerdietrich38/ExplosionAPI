using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Explosion(string str)
        {
            var expStr = "";
            for (var i = 0; i < str.Length; i++)
            {
                var numChar = str[i].ToString();
                var num = Int32.Parse(numChar);
                for (var j = 0; j < num; j++)
                {
                    expStr += numChar;
                }
            }
            return expStr;
        }
    }
}