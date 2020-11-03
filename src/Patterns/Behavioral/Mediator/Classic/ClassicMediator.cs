using System;

namespace Mediator.Classic
{
    public class UIControl
    {
        protected DialogBox _owner;

        public UIControl(DialogBox owner)
        {
            _owner = owner;
        }
    }

    public class ListBox : UIControl
    {
        private string _selection;
        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                _owner.Changed(this);
            }
        }

        public ListBox(DialogBox owner) : base(owner) { }
    }

    public class TextBox : UIControl
    {
        private string _content;

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                _owner.Changed(this);
            }
        }

        public TextBox(DialogBox owner) : base(owner) { }
    }

    public class Button : UIControl
    {
        private bool _enabled;

        public bool Enabled
        {
            get => _enabled;
            set
            {
                _enabled = value;
                _owner.Changed(this);
            }
        }

        public Button(DialogBox owner) : base(owner) { }
    }

    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }

    public class ArticlesDialogBox : DialogBox
    {
        private readonly ListBox _articlesListBox;
        private readonly TextBox _titleTextBox;
        private readonly Button _saveButton;

        public void SimulateInteractions()
        {
            _articlesListBox.Selection = "Article 1";
            _titleTextBox.Content = "";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.Enabled}");
        }

        public ArticlesDialogBox()
        {
            _saveButton = new Button(this);
            _titleTextBox = new TextBox(this);
            _articlesListBox = new ListBox(this);
        }

        public override void Changed(UIControl control)
        {
            if (control == _articlesListBox)
            {
                ArticleSelected();
            }
            else if (control == _titleTextBox)
            {
                TitleChanged();
            }
        }

        private void ArticleSelected()
        {
            _titleTextBox.Content = _articlesListBox.Selection;
            _saveButton.Enabled = true;
        }

        private void TitleChanged()
        {
            var isEmpty = string.IsNullOrEmpty(_titleTextBox.Content);
            _saveButton.Enabled = !isEmpty;
        }
    }
}
