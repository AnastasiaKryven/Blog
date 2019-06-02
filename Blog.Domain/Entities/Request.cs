using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities
{
    public class Request
    {
        public Request()
        {
            DateRequest = DateTime.Now.ToString();
        }

        public int RequestId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string TextOfRequest { get; set; }
        public string DateRequest { get; set; }
    }
}
