using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace NET_PR3_2_Z2;
/// <summary>
/// Logika interakcji dla klasy ListaOsób.xaml
/// </summary>
public partial class ListaOsób : Window
{
	public ObservableCollection<Osoba> Osoby { get; } = new ObservableCollection<Osoba>()
	{
		new() { Imię="Adam", Nazwisko="Mickiewicz", DataUrodzenia=DateTime.Parse("01.01.1701") },
		new() { Imię="Juliusz", Nazwisko="Słowacki" }
	};

	public ListaOsób()
	{
		DataContext= this;
		InitializeComponent();
	}
}
