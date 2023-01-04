using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhookGithub.Application.Dto;

namespace WebhookGithub.Application;

internal interface IGithubIssuesService
{
    Task<Issues> GetIssuesAsync(string tokenAutenticacao, string donoRepositorio, string nomeRepositorio);
}
