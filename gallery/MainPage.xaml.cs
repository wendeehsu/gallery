using gallery.Models;
using System.Collections.Generic;
using System.Diagnostics;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using System.Windows.Input;
using Windows.UI.Xaml.Input;
using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Threading;


// 空白頁項目範本已記錄在 https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x404

namespace gallery
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    /*public class ModifyBook : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private static void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private List<Book> _books;
        public  List<Book> Books(string a) {
            _books = BookManager.GetBooks(a);
            OnPropertyChanged(null);
            return (_books);
        }
    }*/

    public sealed partial class MainPage : Page 
    {
        private ObservableCollection<Book> Books;

        public MainPage(){
            this.InitializeComponent();
            Books = BookManager.GetBooks("");
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void OnKeyDownHandler(object sender, KeyRoutedEventArgs e)
        {
            if(Convert.ToString(e.Key) == "Enter")
            {
                Books.Clear();
                ObservableCollection<Book> t = BookManager.GetBooks(Search.Text);
                foreach(Book i in t)
                {
                    Books.Add(i);
                }
                Debug.WriteLine($"books={Books.Count}");
                //OnPropertyChanged(null);
                //Target.ItemsSource = Books;
            }
        }

        /*private void BtnClick1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var t = Task.Run(() => Setup());
            Debug.WriteLine("start task:");
            t.Wait();
            Debug.WriteLine($"end thread with result: {t.Result}");
            btn1.Content = "finish1";
        }
        private async void BtnClick2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var t = Task.Run(() => Setup());
            Debug.WriteLine("start task:");
            var result = await t;
            Debug.WriteLine($"end thread with result: {result}");
            btn2.Content = "finish2";
        }
        private int Setup()
        {
            Debug.WriteLine("doing setup works");
            Task.Delay(3000).Wait();
            Debug.WriteLine("done setup");
            return 123;
        }*/
    }
}
