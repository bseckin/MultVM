using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace MultVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        // Properties to observer
        private ViewModelBase currentVM;
        public ViewModelBase CurrentVM {
            get { return currentVM; }
            set { currentVM = value; RaisePropertyChanged(); }
        }

        public RelayCommand AddBtnClickedCmd { get; set; }
        public RelayCommand SearchBtnClickedCmd { get; set; }


        // Constructor
        public MainViewModel()
        {
            AddBtnClickedCmd = new RelayCommand(
                () => { CurrentVM = SimpleIoc.Default.GetInstance<AddVM>(); }
            );

            SearchBtnClickedCmd = new RelayCommand(
                () => { CurrentVM = SimpleIoc.Default.GetInstance<SearchVM>(); }
            );
        }
    }
}