using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhookGithub.Application.Dto;

namespace WebhookGithub.Application;

internal interface IWebhookService
{
    Task Enviar(WebhookDto dto);
}
