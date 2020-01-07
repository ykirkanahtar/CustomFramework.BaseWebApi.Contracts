using System.Collections.Generic;

namespace CustomFramework.BaseWebApi.Contracts.ApiContracts
{
    public interface ICustomList<T> where T : class
    {
        int TotalCount { get; set; }
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int PageCount { get; set; }
        List<T> Result { get; set; }
    }
}
