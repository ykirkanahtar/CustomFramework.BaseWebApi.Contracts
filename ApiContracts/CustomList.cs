using System.Collections.Generic;

namespace CustomFramework.BaseWebApi.Contracts.ApiContracts
{
    public class CustomList<T> : ICustomList<T> where T : class
    {
        public CustomList()
        {
            Result = new List<T>();
        }
        
        public int TotalCount { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public List<T> Result { get; set; }
    }    
}
