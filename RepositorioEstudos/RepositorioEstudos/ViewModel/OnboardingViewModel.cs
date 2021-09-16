

using RepositorioEstudos.Model;
using System.Collections.ObjectModel;

namespace RepositorioEstudos.ViewModel
{
    public class OnboardingViewModel
    {
        #region propriedade
        private ObservableCollection<Onboarding> _onboardings;

        public ObservableCollection<Onboarding> Onboardings 
        {
            get { return _onboardings; }
            set { _onboardings = value; }
        }

        #endregion
        #region contrutor
        public OnboardingViewModel()
        {
            
            CardsAdd();
        }
        #endregion
        #region método
        private void CardsAdd()
        {
            Onboardings = new ObservableCollection<Onboarding>();
            Onboardings.Add(new Onboarding { Id = 1, Imagem = "brigadeiro2", Texto = "É um fato conhecido de todos que um leitor se distrairá com o conteúdo de texto legível de uma página quando estiver examinando sua diagramação. ", Titulo = "Seja bem-vindo!", SubTitulo = "Porque nós o usamos?" });
            Onboardings.Add(new Onboarding { Id = 2, Imagem = "stock2", Texto = "Existem muitas variações disponíveis de passagens de Lorem Ipsum, mas a maioria sofreu algum tipo de alteração, seja por inserção de passagens com humor, ou palavras aleatórias que não parecem nem um pouco convincentes.", Titulo = "Churros!", SubTitulo= "Onde posso conseguí-lo?" });
            Onboardings.Add(new Onboarding { Id = 3, Imagem = "Munffins", Texto = "Ao contrário do que se acredita, Lorem Ipsum não é simplesmente um texto randômico. ", Titulo = "Munffins!", SubTitulo = "De onde ele vem?" });
           
        }
        #endregion
    }
}
