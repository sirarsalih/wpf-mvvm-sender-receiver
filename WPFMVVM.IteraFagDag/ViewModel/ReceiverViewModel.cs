using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using WPFMVVM.IteraFagDag.Messages;

namespace WPFMVVM.IteraFagDag.ViewModel
{
    public class ReceiverViewModel : ViewModelBase
    {
        private string _contentText;

        public string ContentText
        {
            get { return _contentText; }
            set
            {
                _contentText = value;
                RaisePropertyChanged("ContentText");
            }
        }

        public ReceiverViewModel()
        {
            Messenger.Default.Register<ViewModelMessage>(this, OnReceiveMessageAction);
        }

        private void OnReceiveMessageAction(ViewModelMessage obj)
        {
            ContentText = obj.Text;
        }
    }
}