using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DropDownFilterDataAccessSQL;

namespace GlobalJobSearch.Controllers
{
    public class DropDownFilterController : ApiController
    {
        public IEnumerable<DropDownFilter> Get()
        {
            using (section8Entities entities = new section8Entities())
            {
                return entities.DropDownFilters.ToList();
            }
        }

        public DropDownFilter Get(int id)
        {
            using (section8Entities entities = new section8Entities())
            {
                return entities.DropDownFilters.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
