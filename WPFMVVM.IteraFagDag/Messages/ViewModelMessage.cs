using GalaSoft.MvvmLight.Messaging;

namespace WPFMVVM.IteraFagDag.Messages
{
    public class ViewModelMessage : MessageBase
    {
        public string Text { get; set; }
    }
}
