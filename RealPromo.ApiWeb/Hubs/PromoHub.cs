using Microsoft.AspNetCore.SignalR;
using RealPromo.ApiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealPromo.ApiWeb.Hubs
{
    
    //RPC
    public class PromoHub : Hub
    {
        /**
         * Cliente - JS/C#/Java
         * RPC
         * Cliente(Javascript) - > Hub(C#)  (C# - CastrarPromocao)
         * Hub (C#)-> Cliente (ReceberPromocao)
         * */


        public async Task CadastrarPromocao(Promocao promocao)
        {
            /*
             * Banco
             * Queue/Scheduler
             * */

            await Clients.Caller.SendAsync("CadastradoSucesso"); //Notificar Caller - > Cadastrado realizado com sucesso.
            await Clients.Others.SendAsync("ReceberPromocao",promocao); //Notificar Promoção Chegou.
        }

    }
}
