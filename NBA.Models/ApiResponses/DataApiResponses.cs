using System.Collections.Generic;

namespace NBA.Models.ApiResponses
{
    public class DataApiResponses<T>
    {
        public List<T> Data { get; set; }
        public Meta Meta { get; set; }
    }
}
