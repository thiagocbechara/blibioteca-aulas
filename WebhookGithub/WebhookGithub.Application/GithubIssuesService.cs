using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebhookGithub.Application.Dto;

namespace WebhookGithub.Application;

internal class GithubIssuesService : IGithubIssuesService
{
    public GithubIssuesService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    private IHttpClientFactory _clientFactory;
    private static string baseUrl = "https://api.github.com";

    public async Task<Issues> GetIssuesAsync(string tokenAutenticacao, string donoRepositorio, string nomeRepositorio)
    {
        // HttpClientFactory -> Gerar um client HTTP
        var client = _clientFactory.CreateClient();
        client.DefaultRequestHeaders.Add("Bearer", tokenAutenticacao);
        client.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");

        var response = await client.GetAsync($"{baseUrl}/repos/{donoRepositorio}/{nomeRepositorio}/issues");
        if (response.IsSuccessStatusCode)
        {
            return await JsonSerializer.DeserializeAsync<Issues>(await response.Content.ReadAsStreamAsync());
        }
        throw new Exception();
    }
}
