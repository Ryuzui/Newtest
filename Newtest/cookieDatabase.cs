namespace Newtest
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CookieDatabase : DbContext
    {

     
          

        public CookieDatabase()
            : base("name=cookieDatabase")
        {
        }

    }

}