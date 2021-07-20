using System;
using System.Runtime.CompilerServices;
using Design_Patterns_OOP.State.DirectionService;

namespace Design_Patterns_OOP.Mediator
{
    public class ArticleDialogBox
    {
        private ListBox ListBox { get; set; }
        private TextBox TextBox { get; set; }
        private Button SaveButton { get; set; }

        public ArticleDialogBox()
        {
            SaveButton = new Button();
            TextBox = new TextBox();
            ListBox = new ListBox();

            TextBox.AddEventHandler(new TextBoxEventHandler(TextBox, ListBox, SaveButton));
            ListBox.AddEventHandler(new ListBoxEventHandler(TextBox, ListBox, SaveButton));
        }


        public void SimulateUserInteraction()
        {
            ListBox.SetSelection("Article 1");
            TextBox.SetContent("");
            TextBox.SetContent("Article 2");
            Console.WriteLine("TextBox" + TextBox.Content);
            Console.WriteLine("Button:" + SaveButton.IsEnabled);
        }
    }

    public class ListBoxEventHandler : EventHandler
    {
        public TextBox TextBox { get; }
        public ListBox ListBox { get; }
        public Button SaveButton { get; }

        public ListBoxEventHandler(TextBox textBox, ListBox listBox, Button saveButton)
        {
            TextBox = textBox;
            ListBox = listBox;
            SaveButton = saveButton;
        }

        public override void Handle()
        {
            ArticleSelected();
        }

        private void ArticleSelected()
        {
            TextBox.SetContent(ListBox.Selection);
            SaveButton.SetEnabled(true);
        }
    }

    class TextBoxEventHandler : EventHandler

    {
        public TextBox TextBox { get; }
        public ListBox ListBox { get; }
        public Button SaveButton { get; }

        public TextBoxEventHandler(TextBox textBox, ListBox listBox, Button saveButton)
        {
            TextBox = textBox;
            ListBox = listBox;
            SaveButton = saveButton;
        }

        public override void Handle()
        {
            TitleChanged();
        }


        private void TitleChanged()
        {
            var isEmpty = string.IsNullOrWhiteSpace(TextBox.Content);

            SaveButton.SetEnabled(!isEmpty);
        }
    }
}