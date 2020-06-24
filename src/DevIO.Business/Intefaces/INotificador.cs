using DevIO.Business.Notificacoes;
using System.Collections.Generic;

namespace DevIO.Business.Intefaces
{
    public interface INotificador
    {
        void Handle(Notificacao notificacao);
        List<Notificacao> ObterNotificacoes();
        bool TemNotificacao();
    }
}