using System;
using System.Collections;
using System.Diagnostics;
using System.Messaging;
using System.Windows;

namespace GettingStarted
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public class MyCollection : IEnumerable, IMyCollection
        {
            public IEnumerator GetEnumerator() => throw new NotImplementedException();
        }

        readonly Customer c = new Customer
        {
            FirstName = "Joe",
            LastName = "Smith"
        };

        internal Customer C => c;

        public EventLog eventLog = new EventLog();

        public MessageQueue messageQueue = new MessageQueue();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSayHello_Click(object sender, RoutedEventArgs e)
        {
            MessagesRow();
            this.eventLog.Source = "My server Explorer App";
            this.eventLog.WriteEntry("Something happened", EventLogEntryType.Information);
        }

        private void MessagesRow() 
        {
            MessageBox.Show("Hello " + textBoxSayHello.Text + "!");
            MessageBox.Show("Hello " + textBoxSayHello.Text + "!");
            MessageBox.Show("Hello " + textBoxSayHello.Text + "!");
        }
    }
}
