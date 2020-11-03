using System;
using System.Collections.Generic;

namespace Mediator.WithObserver
{
    public abstract class UIControl
    {
        private readonly List<Action> _observers = new List<Action>();

        public void Attach(Action observer)
        {
            _observers.Add(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Invoke();
            }
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
                NotifyObservers();
            }
        }

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
                NotifyObservers();
            }
        }
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
                NotifyObservers();
            }
        }
    }


    public class ArticlesDialogBox
    {
        private readonly ListBox _articlesListBox = new ListBox();
        private readonly TextBox _titleTextBox = new TextBox();
        private readonly Button _saveButton = new Button();

        public void SimulateInteractions()
        {
            _articlesListBox.Selection = "Article 1";
            //_titleTextBox.Content = "";
            Console.WriteLine($"TextBox: {_titleTextBox.Content}");
            Console.WriteLine($"Button: {_saveButton.Enabled}");
        }

        public ArticlesDialogBox()
        {
            _articlesListBox.Attach(ArticleSelected);
            _titleTextBox.Attach(TitleChanged);
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
