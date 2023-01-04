using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhookGithub.Application.Dto;

namespace WebhookGithub.Application;

internal interface IWebhookDtoGenerator
{
    WebhookDto GerarDto(string donoRepositorio, string nomeRepositorio, Issues issues, Colaboradores colaboradores);
}
