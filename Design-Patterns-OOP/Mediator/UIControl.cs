using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Mediator
{
    public abstract class UIControl
    {
        public IList<EventHandler> Observers { get; set; } = new List<EventHandler>();

        public void AddEventHandler(EventHandler eventHandler)
        {
            Observers.Add(eventHandler);
        }

        private protected void NotifyEventHandlers()
        {
            foreach (var observer in Observers)
                observer.Handle();
        }
    }

    public class ListBox : UIControl
    {
        public string Selection { get; private set; }

        public void SetSelection(string selection)
        {
            Selection = selection;
            NotifyEventHandlers();
        }
    }

    public class TextBox : UIControl
    {
        public string Content { get; private set; }

        public void SetContent(string content)
        {
            Content = content;
            NotifyEventHandlers();
        }
    }

    public class Button : UIControl
    {
        public bool IsEnabled { get; private set; }

        public void SetEnabled(bool enb)
        {
            IsEnabled = enb;
            NotifyEventHandlers();
        }
    }
}