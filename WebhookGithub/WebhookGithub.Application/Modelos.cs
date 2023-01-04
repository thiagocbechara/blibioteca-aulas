using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebhookGithub.Application.Dto;

public record Issues
{
    // url
    public string Url { get; set; }

    [JsonPropertyName("repository_url")]
    public string RepositoryUrl { get; set; }
}

public record Colaboradores
{
}


public record WebhookDto
{
    public string User { get; set; }
    public string Repository { get; set; }
    public IEnumerable<IssueDto> Issues { get; set; }
    public IEnumerable<Conttributor> Contributors { get; set; }
}

public record IssueDto(string Title, string Author, IEnumerable<string> Labels);

public record Conttributor
{
    public string Name { get; set; }
    public string User { get; set; }

    [JsonPropertyName("qtd_commits")]
    public int QtdCommits { get; set; }
}