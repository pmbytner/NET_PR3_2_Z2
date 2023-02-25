﻿using System;
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

namespace NET_PR3_2_Z2;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class WidokOsoby : Window
{
	//Osoba osoba = new Osoba() { Imię = "Adam", Nazwisko = "Mickiewicz" };
	public WidokOsoby(Osoba osoba)
	{
		DataContext = osoba;
		InitializeComponent();
	}

	private void OK(object sender, RoutedEventArgs e)
	{
		Close();
	}
}
