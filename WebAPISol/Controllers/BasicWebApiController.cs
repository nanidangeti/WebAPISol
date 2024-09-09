using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace WebAPISol.Controllers
{
    [Route("api/[controller]")] // http://HostPath/api/BasicWebApi
    [ApiController]
    public class BasicWebApiController : ControllerBase
    {
        public int a = 10;
        public string name = "venkat";
        public int[] Nvalues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public ArrayList Name = new ArrayList() { "Venkat", "Nani", "Tarun" };

        [HttpGet]
        [Route("Show")]
        public void Show()
        {
            //write any logic
        }

        [HttpGet]
        [Route("Test1")]

        public int Test()
        {
            return a;
        }

        [HttpGet]
        [Route("Addition")]
        public int Addition(int x, int y)
        {
            return x + y;
        }
        [HttpGet]
        [Route("Test2")]
        public string Test2()
        {
            return name;
        }
        [HttpGet]
        [Route("Test3")]
        public int[] Test3()
        {
            return Nvalues;
        }
        [HttpGet]
        [Route("Names")]
        public ArrayList Names() 
        {
            return Name;
        }
        [HttpGet]
        [Route("Operations")]
        public int Operations (int x , int y , int opt)
        {
            int res = 0;
            switch (opt)
            {
                case 1: {  res = x + y; break; }
                case 2: { res = x - y; break; }
                case 3: { res = x * y; break; }
                case 4: { res = x / y; break; }
                case 5: { res = x % y; break; }
                default: {  res = 0; break; }
            }
            return res;
        
        }
        [HttpGet]
        [Route("FindEvenorOdd")]
        public string FindEvenorOdd(int n) 
        {
            if (n % 2 == 0)
            { return "Even"; }
            else 
            { return "Odd"; }
        }
        [HttpGet]
        [Route("FindPrime")]
        public string FindPrime(int n)
        {
            int i = 1, count = 0;
            while (i <= n)
            { 
                if (n % 1 == 0) 
                { count++; }
                i++;
            }
            if (count == 2)
            {
                return "Prime";
            }
            else 
            {
                return "Not Prime";
            }

        }
    }
}
