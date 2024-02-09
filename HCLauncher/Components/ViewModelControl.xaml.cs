using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCLauncher.Components
{
    /// <summary>
    /// ViewModelControl.xaml 的交互逻辑
    /// </summary>
    public partial class ViewModelControl : UserControl
    {
        private static string _pageName = "";
        public static string PageName
        {
            get => $"Pages/{_pageName}.xaml";
            set => _pageName = value;
        }

        public ViewModelControl()
        {
            InitializeComponent();
        }
    }
}
