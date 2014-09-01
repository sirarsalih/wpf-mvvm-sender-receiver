﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using WPFMVVM.IteraFagDag.Messages;

namespace WPFMVVM.IteraFagDag.ViewModel
{
    public class SenderViewModel : ViewModelBase
    {
        public RelayCommand OnClickCommand { get; set; }

        private string _textBoxText;

        public string TextBoxText
        {
            get { return _textBoxText; }
            set
            {
                _textBoxText = value;
                RaisePropertyChanged("TextBoxText");
            }
        }

        public SenderViewModel()
        {
            OnClickCommand = new RelayCommand(OnClickCommandAction, null);
        }

        private void OnClickCommandAction()
        {
            var viewModelMessage = new ViewModelMessage()
                {
                    Text = TextBoxText
                };
            Messenger.Default.Send(viewModelMessage);
        }
    }
}