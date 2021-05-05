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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Mumbling(string str)
        {
            var accumString = "";

            var charList = new List<char>(str);

            for (var i = 0; i < charList.Count; i++)
            {
                for (var j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        accumString += char.ToUpper(charList[i]);
                    }
                    else
                    {
                        accumString += char.ToLower(charList[i]);
                    }
                }
                if (i != charList.Count - 1)
                    accumString += '-';
            }
            return accumString;
        }

    }
}