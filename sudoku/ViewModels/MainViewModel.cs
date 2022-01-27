﻿namespace Sudoku.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel currentViewModel;
        private BaseViewModel buttonViewModel;
        private SudokuGridViewModel sgvm;
        private ButtonViewModel bvm;

        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set
            {
                currentViewModel = value;
                OnPropertyChanged();
            }
        }
        public BaseViewModel ButtonViewModel
        {
            get { return buttonViewModel; }
            set
            {
                buttonViewModel = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            initViewModels();
        }
        private void initViewModels()
        {
            sgvm = new SudokuGridViewModel();
            bvm = new ButtonViewModel();
            CurrentViewModel = sgvm;
            ButtonViewModel = bvm;
        }

    }
}