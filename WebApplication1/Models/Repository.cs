using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class Repository
    {
        private static List<GuestResponce> responses = new List<GuestResponce>();
        public static IEnumerable<GuestResponce> Responses
        {
            get
            {
                return responses;
            }

        }
        public static void AddResponse(GuestResponce response) {
            responses.Add(response);
        }
    }
}
