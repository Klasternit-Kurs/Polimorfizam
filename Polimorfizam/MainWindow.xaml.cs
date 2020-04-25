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

namespace Polimorfizam
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			int x = 5;
			double d = x;

			x = (int)d;


			Osoba o = new Osoba();
			o.Ime = "Pera";

			Object objekt = o;
			objekt = "Asd";
			Osoba druga = objekt as Osoba;
			//MessageBox.Show(druga.Ime);

			DataContext = o;

			List<Object> nekaLista = new List<object>();

			nekaLista.Add(o);
			nekaLista.Add(5);
			nekaLista.Add(new Button());

			nekaLista.ForEach(stvar =>
			{
				if (stvar is Osoba osb && osb.Ime == "Pera")
					MessageBox.Show(osb.Ime);
				else
					MessageBox.Show(stvar.ToString());

				switch(stvar)
				{
					case Osoba osb2:
						MessageBox.Show(osb2.Ime);
						break;
					case int broj:
						MessageBox.Show((broj * 2).ToString());
						break;
				}
			});

		}

		public class Osoba
		{
			public string Ime;
			public string Prezime;
		}
	}
}
