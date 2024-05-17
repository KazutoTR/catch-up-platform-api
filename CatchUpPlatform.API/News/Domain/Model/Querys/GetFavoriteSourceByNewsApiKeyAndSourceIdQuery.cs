namespace CatchUpPlatform.API.News.Domain.Model.Querys;

public record GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(string NewsApiKey, string SourceId);