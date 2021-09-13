using RepositorioEstudos.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RepositorioEstudos.ViewModel
{
    public class CafeViewModel
    {
        #region construtor
        public CafeViewModel()
        {
            Cafes =  new ObservableCollection<Cafe>
            {
                new Cafe{ Id = 1, Title = "Café coado", Descricao ="É a forma mais comum de servir café no Brasil. Ele é preparado na hora, em coador de pano ou de papel e é uma bebida bastante concentrada. Normalmente, é adoçado, mas isso não é uma regra.", Icon="cafe0", Preco=5M},
                 new Cafe{ Id = 2, Title = "Café curto", Descricao ="Nada mais é do que o próprio café espresso, a diferença é a quantidade de bebida a ser servida. Esse café é bem encorpado, em razão do rápido contato com a água durante a preparação.", Icon="cafe1", Preco=5M},
                 new Cafe{ Id = 3, Title = "Espresso brasileiro", Descricao ="Enquanto em outros países a quantidade-padrão para o café espresso é 30 mL, aqui no Brasil, essa medida é 50 mL. Isso porque nós estamos mais acostumados a consumir grandes quantidades da bebida.", Icon="cafe2", Preco=5M},
                 new Cafe{ Id = 4, Title = "Café longo", Descricao ="Esse tipo de café também é diluído em água e é uma espécie de “meio do caminho” entre o curto e o americano.", Icon="cafe3", Preco=5M}
            };
           
        }
        #endregion

        #region propriedade
        private ObservableCollection<Cafe> _cafes;

        public ObservableCollection<Cafe> Cafes
        {
            get { return _cafes; }
            set { _cafes = value; }
        }

        #endregion
    }
}
