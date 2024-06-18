using System.Collections.Concurrent;
using _01_Controller.Models;

namespace _01_Controller.Services;

public class ConcorrenteCEP : ICEPService
{
    private ConcurrentDictionary<string, CEPViewModel> listaDeCEPs;

    public ConcorrenteCEP(){
        listaDeCEPs = new ConcurrentDictionary<string, CEPViewModel>();
        listaDeCEPs.TryAdd("90470320", new CEPViewModel(){CEP="90470320", logradouro="Rua Primeiro de Janeiro", Bairro="Três Figueiras", Cidade="Viamão", Estado="RS", DataDoCadastro=DateTime.Now, numeroQq=0 });
        listaDeCEPs.TryAdd("90150040", new CEPViewModel(){CEP="90150040", logradouro="Rua Augusto Melecchi", Bairro="Menino Deus", Cidade="Viamão", Estado="SC", DataDoCadastro=DateTime.Now, numeroQq=1 });
        listaDeCEPs.TryAdd("91740000", new CEPViewModel(){CEP="91740000", logradouro="Avenida da Cavalhada", Bairro="Cavalhada", Cidade="Viamão", Estado="PR", DataDoCadastro=DateTime.Now, numeroQq=2 });
        listaDeCEPs.TryAdd("90035005", new CEPViewModel(){CEP="90035005", logradouro="Rua Ramiro Barcelos", Bairro="Independência", Cidade="Viamão", Estado="SP", DataDoCadastro=DateTime.Now, numeroQq=3 });
    }
    public void cadastreUmCEP(CEPViewModel novoCEP)
    {
        listaDeCEPs.TryAdd(novoCEP.CEP, novoCEP);
    }

    public IEnumerable<CEPViewModel> listaTodosOsCEPs()
    {
        return listaDeCEPs.Values;
    }

    public CEPViewModel? pesquiseUmCEPEspecifico(string CEP)
    {
        throw new NotImplementedException();
    }
}