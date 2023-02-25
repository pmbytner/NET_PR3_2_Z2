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
	private static Dictionary<string, ICollection<string>> powiązaneWłaściwości = new()
	{
		["Imię"] = new string[] { "ImięNazwisko" },
		["Nazwisko"] = new string[] { "ImięNazwisko" },
	};
	private void NotyfikujZmianę([CallerMemberName] string? nazwaWłaściwości = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nazwaWłaściwości));
		foreach(string powiązanaWłaściwość in powiązaneWłaściwości[nazwaWłaściwości])
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(powiązanaWłaściwość));

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
		}
	}

	public string Nazwisko
	{
		get => nazwisko;
		set
		{
			nazwisko = value;
			NotyfikujZmianę();
		}
	}

	public string ImięNazwisko => $"{Imię} {Nazwisko}";

}
