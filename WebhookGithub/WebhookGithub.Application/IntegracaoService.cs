using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhookGithub.Application.Dto;

namespace WebhookGithub.Application;

internal class IntegracaoService
{
    private readonly IGithubIssuesService _githubIssuesService;
    private readonly IGithubCollabService _githubCollabService;
    private readonly IWebhookDtoGenerator _webhookDtoGenerator;
    private readonly IWebhookService _webhookService;

    public IntegracaoService(
        IGithubIssuesService githubIssuesService,
        IGithubCollabService githubCollabService,
        IWebhookDtoGenerator webhookDtoGenerator,
        IWebhookService webhookService)
    {
        _githubIssuesService = githubIssuesService;
        _githubCollabService = githubCollabService;
        _webhookDtoGenerator = webhookDtoGenerator;
        _webhookService = webhookService;
    }

    public async Task IntegrarAsync(string tokenGithub, string nomeUsuario, string nomeRepositorio)
    {
        // Consultar as issues
        var issues = await _githubIssuesService.GetIssuesAsync(tokenGithub, nomeUsuario, nomeRepositorio);
        // Consultar os colaboradores
        var collabs = await _githubCollabService.GetColaboradoresAsync(tokenGithub, nomeUsuario, nomeRepositorio);
        // Gerar o JSON de saída a partir dos 2 de entrada (issues e collab)
        var dto = _webhookDtoGenerator.GerarDto(nomeUsuario, nomeRepositorio, issues, collabs);
        // Enviar para o webhook os dados solicitados
        await _webhookService.Enviar(dto);
    }
}
