using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoppingg.Models
{
    public class Oferta
    {
        public int OfertaId { get; set; }
        public string Ditore { get; set; }
        public string Javore { get; set; }
        public string Sezonale { get; set; }

        public string Outlet { get; set; }


        public string PhotoFile { get; set; }

    }
}