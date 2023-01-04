using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebhookGithub.Application.Dto;

namespace WebhookGithub.Application
{
    internal class GithubCollabService : IGithubCollabService
    {
        public async Task<Colaboradores> GetColaboradoresAsync(string tokenAutenticacao, string donoRepositorio, string nomeRepositorio)
        {
            throw new NotImplementedException();
        }
    }
}
