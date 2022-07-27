using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.DTOs.Home
{
  public  class LoginViewModel
    {
        public string CustomerMobile { get; set; }
        public string CustomerPassword { get; set; }
        public bool RememberMe { get; set; }

    }
}
