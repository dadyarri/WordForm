using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using Common.Data;
using Common.Serialization;
using WordForm.Xml;
using Office = Microsoft.Office.Core;

namespace WordForm.Ui
{
    /// <summary>
    /// Interaction logic for CustomizeFormWindow.xaml
    /// </summary>
    public partial class CustomizeFormWindow : Window, INotifyPropertyChanged
    {
        private FieldsCollection _fields;
        public FieldsCollection Fields
        {
            get => _fields;
            set
            {
                if (_fields == value) return;
                _fields = value;
                OnPropertyChanged();
            }
        }

        public CustomizeFormWindow(Office.CustomXMLParts xmlParts)
        {
            InitializeComponent();
            Fields = new FieldsCollection();
            foreach (Office.CustomXMLPart customXmlPart in xmlParts)
            {
                if (XmlSerializer.TryDeserialize(customXmlPart.XML, out var fieldsData))
                {
                    Fields = fieldsData;
                }
            }

            foreach (var field in Fields.FormFields)
            {
                GenerateField(field);
            }
        }

        private void GenerateField(FieldInfo info)
        {
            var stackPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };

            var fieldRow = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Margin = new Thickness(5)
            };

            var secondFieldRow = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Margin = new Thickness(5)
            };

            var fieldTextBlock = new TextBlock
            {
                Text = "Поле",
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Margin = new Thickness(5)
            };

            var fieldTextBox = new TextBox
            {
                Text = info.VisibleName,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Width = 200
            };

            var replaceTagTextBlock = new TextBlock
            {
                Text = "Тег для замены",
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Margin = new Thickness(5)
            };

            var replaceTagTextBox = new TextBox
            {
                Text = info.ReplaceTag,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Width = 200
            };

            fieldRow.Children.Add(fieldTextBlock);
            fieldRow.Children.Add(fieldTextBox);

            secondFieldRow.Children.Add(replaceTagTextBlock);
            secondFieldRow.Children.Add(replaceTagTextBox);

            stackPanel.Children.Add(fieldRow);
            stackPanel.Children.Add(secondFieldRow);
            FieldsStackPanel.Children.Add(stackPanel);
        }

        public void AddEmptyField()
        {
            GenerateField(new FieldInfo
            {
                Id = "",
                ReplaceTag = "",
                VisibleName = ""
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddEmptyFieldButton_OnClick(object sender, RoutedEventArgs e)
        {
            AddEmptyField();
        }
    }
}
