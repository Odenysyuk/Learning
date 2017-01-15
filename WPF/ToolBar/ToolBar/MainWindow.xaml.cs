using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ToolBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pages Notepad;
        private List<TabItem> _tabItems;
        private Page _tabPage;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                Notepad = new Pages();
                _tabItems = new List<TabItem>();


                TabItem tabAdd = new TabItem();
                tabAdd.Header = "+";
                _tabItems.Add(tabAdd);

                this.AddTabItem(new Page());
                tabDynamic.DataContext = _tabItems;
                tabDynamic.SelectedIndex = 0;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }           

        }

        private TabItem AddTabItem(Page _tabPage)
        {

            int count = _tabItems.Count;
            TabItem tab = new TabItem();

            if (String.IsNullOrEmpty(_tabPage.SafeFileName))
            {
                tab.Header = string.Format("New {0}", _tabItems.Count);
            }
            else
            {
                tab.Header = string.Format("{0}", _tabPage.SafeFileName);
            }
            tab.Name = string.Format("{0}", _tabPage.PageGiud);
            tab.HeaderTemplate = tabDynamic.FindResource("TabHeader") as DataTemplate;

            tab.Content = _tabPage.Text;
            _tabItems.Insert(count - 1, tab);
            Notepad.AddPage(_tabPage);

            return tab;
        }

        private void tabDynamic_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {
            TabItem tab = tabDynamic.SelectedItem as TabItem;
             if (tab != null && tab.Header != null)
            {
                if (tab.Header.Equals("+"))
                {

                    tabDynamic.DataContext = null;
                    TabItem newTab = this.AddTabItem(new Page());
                    tabDynamic.DataContext = _tabItems;
                    tabDynamic.SelectedItem = newTab;
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
           string tabName = (sender as Button).CommandParameter.ToString();

           var item = tabDynamic.Items.Cast<TabItem>().Where(i => i.Name.Equals(tabName)).SingleOrDefault();

           TabItem tab = item as TabItem;

           if (tab != null)
           {
                if (_tabItems.Count < 3)
                {
                    MessageBox.Show("Cannot remove last tab.");
                }
                else if (MessageBox.Show(string.Format("Are you sure you want to remove notepad {0}?", tab.Header.ToString()),
                    "Remove Tab", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
    
                    TabItem selectedTab = tabDynamic.SelectedItem as TabItem;
                    tabDynamic.DataContext = null;
                    _tabItems.Remove(tab);
                    Notepad.DeletePage(tab.Name);
  
                    tabDynamic.DataContext = _tabItems;

                    if (selectedTab == null || selectedTab.Equals(tab))
                    {
                        selectedTab = _tabItems[0];

                    }
                    tabDynamic.SelectedItem = selectedTab;
                }
            }
        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            tabDynamic.DataContext = null;
            TabItem newTab = this.AddTabItem(new Page());
            tabDynamic.DataContext = _tabItems;
            tabDynamic.SelectedItem = newTab;
        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = "*.rtf";
            dlg.Filter = "RTF Files|*.rtf";
            if (dlg.ShowDialog() == true)
            {                
                tabDynamic.DataContext = null;
                TabItem newTab = this.AddTabItem(new Page(dlg.FileName, dlg.SafeFileName));
                tabDynamic.DataContext = _tabItems;
                tabDynamic.SelectedItem = newTab;
            }
           
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            Notepad.Save();           
        }

        private void MenuItemSaveAs_Click(object sender, RoutedEventArgs e)
        {
            Notepad.SaveAs();
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Undo(object sender, RoutedEventArgs e)
        {
            Notepad.Undo();
        }

        private void MenuItem_Redo(object sender, RoutedEventArgs e)
        {
            Notepad.Redo();
        }

        private void MenuItem_Copy(object sender, RoutedEventArgs e)
        {
            Notepad.Copy();
        }

        private void MenuItem_Cut(object sender, RoutedEventArgs e)
        {
            Notepad.Cut();
        }

        private void MenuItem_Paste(object sender, RoutedEventArgs e)
        {
            Notepad.Paste();
        }

        private void MenuItem_Help(object sender, RoutedEventArgs e)
        {
            Notepad.Help();
        }
    }
}
