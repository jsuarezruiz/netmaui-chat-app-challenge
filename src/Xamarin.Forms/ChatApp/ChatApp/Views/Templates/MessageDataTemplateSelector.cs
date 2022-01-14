using ChatApp.Models;
using Xamarin.Forms;

namespace ChatApp.Views.Templates
{
    internal class MessageDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SenderMessageTemplate { get; set; }
        public DataTemplate ReceiverMessageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = (Message)item;

            if (message.Sender == null)
                return ReceiverMessageTemplate;

            return SenderMessageTemplate;
        }
    }
}