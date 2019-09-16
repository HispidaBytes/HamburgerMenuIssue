using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HamburgerMenuTest.ViewModel;
using System.Diagnostics;
using System.Windows.Input;

namespace HamburgerMenuTest
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { Set(ref _currentViewModel, value); }
        }

        public ICommand OpenFirstViewModelCommand { get; }
        public ICommand OpenSecondViewModelCommand { get; }


        public MainViewModel()
        {
            OpenFirstViewModelCommand = new RelayCommand(OpenFirstViewModel);
            OpenSecondViewModelCommand = new RelayCommand(OpenSecondViewModel);

            CurrentViewModel = new FirstViewModel();
        }

        private void OpenFirstViewModel()
        {
            Debug.WriteLine("Setting FirstViewModel");
            CurrentViewModel = new FirstViewModel();
        }

        private void OpenSecondViewModel()
        {
            Debug.WriteLine("Setting SecondViewModel");
            CurrentViewModel = new SecondViewModel();
        }
    }
}
