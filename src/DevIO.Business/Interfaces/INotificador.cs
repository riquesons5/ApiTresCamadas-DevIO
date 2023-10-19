using DevIO.Business.Notificacoes;
using System.Collections.Generic;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacaos();
        void Handle(Notificacao notificacao);
    }
}
