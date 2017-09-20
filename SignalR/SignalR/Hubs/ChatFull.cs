using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Hubs
{
    public class ChatFull :Hub
    {
        public Task EnviarMensagem(Mensagem Mensagem)
        {
            return Clients.All.InvokeAsync("publicarMensagem", Mensagem);
        }
    }

    public class Mensagem
    {
        public String Nome { get; set; }

        public String Texto { get; set; }
    }
}
