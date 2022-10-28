namespace Core.ElasticSearch.Models;

public class ElasticSearchResult : IElasticSearchResult
{
    public ElasticSearchResult(bool success)
    {
        Success = success;
    }
    public ElasticSearchResult(bool success, string message) : this(success)
    {
        Message = message;
    }

    

    public bool Success { get; }
    public string Message { get; }
}