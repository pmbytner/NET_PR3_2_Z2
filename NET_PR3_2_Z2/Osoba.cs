using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_PR3_2_Z2;
public class Osoba : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;
	private void NotyfikujZmianę([CallerMemberName] string? nazwaWłaściwości = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nazwaWłaściwości));
	}

	private string
		imię,
		nazwisko
		;

	public string Imię
	{
		get => imię;
		set
		{
			imię = value;
			NotyfikujZmianę();
			NotyfikujZmianę("ImięNazwisko");
		}
	}

	public string Nazwisko
	{
		get => nazwisko;
		set
		{
			nazwisko = value;
			NotyfikujZmianę();
			NotyfikujZmianę("ImięNazwisko");
		}
	}

	public string ImięNazwisko => $"{Imię} {Nazwisko}";

}
