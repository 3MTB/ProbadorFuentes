using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
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
using Color = System.Windows.Media.Color;

namespace ProbadorFuentes
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// CREATED BY: 3MTB
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			valores();

		}
		int tamaño;
		string fuente;
		string color;
		string adicional;
		string Background1;
		string Background2;
		string Background3;

		private void valores()
		{
			List<Fuentes> listaFuentes = new List<Fuentes>()
			{
				new Fuentes { Fuente = "Arial" },
				new Fuentes { Fuente = "Arial Black" },
				new Fuentes { Fuente = "Baskerville" },
				new Fuentes { Fuente = "Book Antiqua" },
				new Fuentes { Fuente = "Brush Script MT" },
				new Fuentes { Fuente = "Calibri" },
				new Fuentes { Fuente = "Cambria" },
				new Fuentes { Fuente = "Century Gothic" },
				new Fuentes { Fuente = "Comic Sans MS" },
				new Fuentes { Fuente = "Courier New" },
				new Fuentes { Fuente = "Copperplate" },
				new Fuentes { Fuente = "Franklin Gothic Medium" },
				new Fuentes { Fuente = "Futura" },
				new Fuentes { Fuente = "Garamond" },
				new Fuentes { Fuente = "Georgia" },
				new Fuentes { Fuente = "Helvetica" },
				new Fuentes { Fuente = "Impact" },
				new Fuentes { Fuente = "Lucida Sans" },
				new Fuentes { Fuente = "Palatino" },
				new Fuentes { Fuente = "Rockwell" },
				new Fuentes { Fuente = "Tahoma" },
				new Fuentes { Fuente = "Times New Roman" },
				new Fuentes { Fuente = "Trebuchet MS" },
				new Fuentes { Fuente = "Verdana" }
			};
			CBFuentes.ItemsSource = listaFuentes;

			List<TamañoFuentes> listaTamaño = new List<TamañoFuentes>();

			for (int i = 1; i <= 40; i++)
			{
				listaTamaño.Add(new TamañoFuentes { Tamaño = i });
			}
			CBTamaño.ItemsSource = listaTamaño;

			List<ColoresDisponibles> listaColores = new List<ColoresDisponibles>()
			{
				new ColoresDisponibles { nombreColor = "DarkBlue", valorColor = Colors.DarkBlue },
				new ColoresDisponibles { nombreColor = "DarkCyan", valorColor = Colors.DarkCyan },
				new ColoresDisponibles { nombreColor = "DarkGoldenRod", valorColor = Colors.DarkGoldenrod },
				new ColoresDisponibles { nombreColor = "DarkGray", valorColor = Colors.DarkGray },
				new ColoresDisponibles { nombreColor = "DarkGreen", valorColor = Colors.DarkGreen },
				new ColoresDisponibles { nombreColor = "DarkKhaki", valorColor = Colors.DarkKhaki },
				new ColoresDisponibles { nombreColor = "DarkMagenta", valorColor = Colors.DarkMagenta },
				new ColoresDisponibles { nombreColor = "DarkOliveGreen", valorColor = Colors.DarkOliveGreen },
				new ColoresDisponibles { nombreColor = "DarkOrange", valorColor = Colors.DarkOrange },
				new ColoresDisponibles { nombreColor = "DarkOrchid", valorColor = Colors.DarkOrchid },
				new ColoresDisponibles { nombreColor = "DarkRed", valorColor = Colors.DarkRed },
				new ColoresDisponibles { nombreColor = "DarkSalmon", valorColor = Colors.DarkSalmon },
				new ColoresDisponibles { nombreColor = "DarkSeaGreen", valorColor = Colors.DarkSeaGreen },
				new ColoresDisponibles { nombreColor = "DarkSlateBlue", valorColor = Colors.DarkSlateBlue },
				new ColoresDisponibles { nombreColor = "DarkSlateGray", valorColor = Colors.DarkSlateGray },
				new ColoresDisponibles { nombreColor = "DarkTurquoise", valorColor = Colors.DarkTurquoise },
				new ColoresDisponibles { nombreColor = "DarkViolet", valorColor = Colors.DarkViolet },
				new ColoresDisponibles { nombreColor = "DeepPink", valorColor = Colors.DeepPink },
				new ColoresDisponibles { nombreColor = "DeepSkyBlue", valorColor = Colors.DeepSkyBlue },
				new ColoresDisponibles { nombreColor = "DimGray", valorColor = Colors.DimGray },
				new ColoresDisponibles { nombreColor = "DodgerBlue", valorColor = Colors.DodgerBlue },
				new ColoresDisponibles { nombreColor = "FireBrick", valorColor = Colors.Firebrick },
				new ColoresDisponibles { nombreColor = "FloralWhite", valorColor = Colors.FloralWhite },
				new ColoresDisponibles { nombreColor = "ForestGreen", valorColor = Colors.ForestGreen },
				new ColoresDisponibles { nombreColor = "Fuchsia", valorColor = Colors.Fuchsia },
				new ColoresDisponibles { nombreColor = "Gainsboro", valorColor = Colors.Gainsboro },
				new ColoresDisponibles { nombreColor = "GhostWhite", valorColor = Colors.GhostWhite },
				new ColoresDisponibles { nombreColor = "Gold", valorColor = Colors.Gold },
				new ColoresDisponibles { nombreColor = "GoldenRod", valorColor = Colors.Goldenrod },
				new ColoresDisponibles { nombreColor = "Gray", valorColor = Colors.Gray },
				new ColoresDisponibles { nombreColor = "Green", valorColor = Colors.Green },
				new ColoresDisponibles { nombreColor = "GreenYellow", valorColor = Colors.GreenYellow },
				new ColoresDisponibles { nombreColor = "HoneyDew", valorColor = Colors.Honeydew },
				new ColoresDisponibles { nombreColor = "HotPink", valorColor = Colors.HotPink },
				new ColoresDisponibles { nombreColor = "IndianRed", valorColor = Colors.IndianRed },
				new ColoresDisponibles { nombreColor = "Indigo", valorColor = Colors.Indigo },
				new ColoresDisponibles { nombreColor = "Ivory", valorColor = Colors.Ivory },
				new ColoresDisponibles { nombreColor = "Khaki", valorColor = Colors.Khaki },
				new ColoresDisponibles { nombreColor = "Lavender", valorColor = Colors.Lavender },
				new ColoresDisponibles { nombreColor = "LavenderBlush", valorColor = Colors.LavenderBlush },
				new ColoresDisponibles { nombreColor = "LawnGreen", valorColor = Colors.LawnGreen },
				new ColoresDisponibles { nombreColor = "LemonChiffon", valorColor = Colors.LemonChiffon },
				new ColoresDisponibles { nombreColor = "LightBlue", valorColor = Colors.LightBlue },
				new ColoresDisponibles { nombreColor = "LightCoral", valorColor = Colors.LightCoral },
				new ColoresDisponibles { nombreColor = "LightCyan", valorColor = Colors.LightCyan },
				new ColoresDisponibles { nombreColor = "LightGoldenrodYellow", valorColor = Colors.LightGoldenrodYellow },
				new ColoresDisponibles { nombreColor = "LightGray", valorColor = Colors.LightGray },
				new ColoresDisponibles { nombreColor = "LightGreen", valorColor = Colors.LightGreen },
				new ColoresDisponibles { nombreColor = "LightPink", valorColor = Colors.LightPink },
				new ColoresDisponibles { nombreColor = "LightSalmon", valorColor = Colors.LightSalmon },
				new ColoresDisponibles { nombreColor = "LightSeaGreen", valorColor = Colors.LightSeaGreen },
				new ColoresDisponibles { nombreColor = "LightSkyBlue", valorColor = Colors.LightSkyBlue },
				new ColoresDisponibles { nombreColor = "LightSlateGray", valorColor = Colors.LightSlateGray },
				new ColoresDisponibles { nombreColor = "LightSteelBlue", valorColor = Colors.LightSteelBlue },
				new ColoresDisponibles { nombreColor = "LightYellow", valorColor = Colors.LightYellow },
				new ColoresDisponibles { nombreColor = "Lime", valorColor = Colors.Lime },
				new ColoresDisponibles { nombreColor = "LimeGreen", valorColor = Colors.LimeGreen },
				new ColoresDisponibles { nombreColor = "Linen", valorColor = Colors.Linen },
				new ColoresDisponibles { nombreColor = "Magenta", valorColor = Colors.Magenta },
				new ColoresDisponibles { nombreColor = "Maroon", valorColor = Colors.Maroon },
				new ColoresDisponibles { nombreColor = "MediumAquamarine", valorColor = Colors.MediumAquamarine },
				new ColoresDisponibles { nombreColor = "MediumBlue", valorColor = Colors.MediumBlue },
				new ColoresDisponibles { nombreColor = "MediumOrchid", valorColor = Colors.MediumOrchid },
				new ColoresDisponibles { nombreColor = "MediumPurple", valorColor = Colors.MediumPurple },
				new ColoresDisponibles { nombreColor = "MediumSeaGreen", valorColor = Colors.MediumSeaGreen },
				new ColoresDisponibles { nombreColor = "MediumSlateBlue", valorColor = Colors.MediumSlateBlue },
				new ColoresDisponibles { nombreColor = "MediumSpringGreen", valorColor = Colors.MediumSpringGreen },
				new ColoresDisponibles { nombreColor = "MediumTurquoise", valorColor = Colors.MediumTurquoise },
				new ColoresDisponibles { nombreColor = "MediumVioletRed", valorColor = Colors.MediumVioletRed },
				new ColoresDisponibles { nombreColor = "MidnightBlue", valorColor = Colors.MidnightBlue },
				new ColoresDisponibles { nombreColor = "MintCream", valorColor = Colors.MintCream },
				new ColoresDisponibles { nombreColor = "MistyRose", valorColor = Colors.MistyRose },
				new ColoresDisponibles { nombreColor = "Moccasin", valorColor = Colors.Moccasin },
				new ColoresDisponibles { nombreColor = "NavajoWhite", valorColor = Colors.NavajoWhite },
				new ColoresDisponibles { nombreColor = "Navy", valorColor = Colors.Navy },
				new ColoresDisponibles { nombreColor = "OldLace", valorColor = Colors.OldLace },
				new ColoresDisponibles { nombreColor = "Olive", valorColor = Colors.Olive },
				new ColoresDisponibles { nombreColor = "OliveDrab", valorColor = Colors.OliveDrab },
				new ColoresDisponibles { nombreColor = "Orange", valorColor = Colors.Orange },
				new ColoresDisponibles { nombreColor = "OrangeRed", valorColor = Colors.OrangeRed },
				new ColoresDisponibles { nombreColor = "Orchid", valorColor = Colors.Orchid },
				new ColoresDisponibles { nombreColor = "PaleGoldenrod", valorColor = Colors.PaleGoldenrod },
				new ColoresDisponibles { nombreColor = "PaleGreen", valorColor = Colors.PaleGreen },
				new ColoresDisponibles { nombreColor = "PaleTurquoise", valorColor = Colors.PaleTurquoise },
				new ColoresDisponibles { nombreColor = "PaleVioletRed", valorColor = Colors.PaleVioletRed },
				new ColoresDisponibles { nombreColor = "PapayaWhip", valorColor = Colors.PapayaWhip },
				new ColoresDisponibles { nombreColor = "PeachPuff", valorColor = Colors.PeachPuff },
				new ColoresDisponibles { nombreColor = "Peru", valorColor = Colors.Peru },
				new ColoresDisponibles { nombreColor = "Pink", valorColor = Colors.Pink },
				new ColoresDisponibles { nombreColor = "Plum", valorColor = Colors.Plum },
				new ColoresDisponibles { nombreColor = "PowderBlue", valorColor = Colors.PowderBlue },
				new ColoresDisponibles { nombreColor = "Purple", valorColor = Colors.Purple },
				new ColoresDisponibles { nombreColor = "Red", valorColor = Colors.Red },
				new ColoresDisponibles { nombreColor = "RosyBrown", valorColor = Colors.RosyBrown },
				new ColoresDisponibles { nombreColor = "RoyalBlue", valorColor = Colors.RoyalBlue },
				new ColoresDisponibles { nombreColor = "SaddleBrown", valorColor = Colors.SaddleBrown },
				new ColoresDisponibles { nombreColor = "Salmon", valorColor = Colors.Salmon },
				new ColoresDisponibles { nombreColor = "SandyBrown", valorColor = Colors.SandyBrown },
				new ColoresDisponibles { nombreColor = "SeaGreen", valorColor = Colors.SeaGreen },
				new ColoresDisponibles { nombreColor = "SeaShell", valorColor = Colors.SeaShell },
				new ColoresDisponibles { nombreColor = "Sienna", valorColor = Colors.Sienna },
				new ColoresDisponibles { nombreColor = "Silver", valorColor = Colors.Silver },
				new ColoresDisponibles { nombreColor = "SkyBlue", valorColor = Colors.SkyBlue },
				new ColoresDisponibles { nombreColor = "SlateBlue", valorColor = Colors.SlateBlue },
				new ColoresDisponibles { nombreColor = "SlateGray", valorColor = Colors.SlateGray },
				new ColoresDisponibles { nombreColor = "Snow", valorColor = Colors.Snow },
				new ColoresDisponibles { nombreColor = "SpringGreen", valorColor = Colors.SpringGreen },
				new ColoresDisponibles { nombreColor = "SteelBlue", valorColor = Colors.SteelBlue },
				new ColoresDisponibles { nombreColor = "Tan", valorColor = Colors.Tan },
				new ColoresDisponibles { nombreColor = "Teal", valorColor = Colors.Teal },
				new ColoresDisponibles { nombreColor = "Thistle", valorColor = Colors.Thistle },
				new ColoresDisponibles { nombreColor = "Tomato", valorColor = Colors.Tomato },
				new ColoresDisponibles { nombreColor = "Transparent", valorColor = Colors.Transparent },
				new ColoresDisponibles { nombreColor = "Turquoise", valorColor = Colors.Turquoise },
				new ColoresDisponibles { nombreColor = "Violet", valorColor = Colors.Violet },
				new ColoresDisponibles { nombreColor = "Wheat", valorColor = Colors.Wheat },
				new ColoresDisponibles { nombreColor = "White", valorColor = Colors.White },
				new ColoresDisponibles { nombreColor = "WhiteSmoke", valorColor = Colors.WhiteSmoke },
				new ColoresDisponibles { nombreColor = "Yellow", valorColor = Colors.Yellow },
				new ColoresDisponibles { nombreColor = "YellowGreen", valorColor = Colors.YellowGreen },


			};
			CBFondo1.ItemsSource = listaColores;
			CBFondo2.ItemsSource = listaColores;
			CBFondo3.ItemsSource = listaColores;

			CBColorFuente.ItemsSource = listaColores;

			Random random = new Random();
			int valorInicial = random.Next(1, 20);

			tamaño = listaTamaño[valorInicial].Tamaño;
			fuente = listaFuentes[valorInicial].Fuente;
			color = listaColores[valorInicial].nombreColor;

			CBTamaño.SelectedIndex = valorInicial;
			CBFuentes.SelectedIndex = valorInicial;
			CBColorFuente.SelectedIndex = valorInicial;

			CBFondo1.SelectedIndex = valorInicial - 1;
			CBFondo2.SelectedIndex = valorInicial - 4;
			CBFondo3.SelectedIndex = valorInicial + 50;

		}

		private void especificaciones()
		{
			if (display1.Text.Length == 0)
			{
				display1.Text = "Ingresa Texto ";
			}
			if (display2.Text.Length == 0)
			{
				display2.Text = "Ingresa Texto ";
			}
			if (display3.Text.Length == 0)
			{
				display3.Text = "Ingresa Texto ";
			}

			cuadro1.Text = $"Cuadro1: \n \nBackground: {Background1} \nFuente: {fuente}  \nTamaño: {tamaño} \nColor: {color} \nFontWeight: ExtraBlack \n {adicional}";

			cuadro2.Text = $"Cuadro2: \n \nBackground: {Background2}\nFuente: {fuente}   \nTamaño: {tamaño} \nColor: {color}\n {adicional}";

			cuadro3.Text = $"Cuadro3: \n \nBackground: {Background3}\nFuente: {fuente}   \nTamaño: {tamaño} \nColor: {color}\n {adicional}";

		}
		private void cambiarColor(object sender, SelectionChangedEventArgs e)
		{
			if (CBColorFuente.SelectedItem is ColoresDisponibles colorSeleccionado)
			{
				display1.Foreground = new SolidColorBrush(colorSeleccionado.valorColor);
				display2.Foreground = new SolidColorBrush(colorSeleccionado.valorColor);
				display3.Foreground = new SolidColorBrush(colorSeleccionado.valorColor);

				color = colorSeleccionado.nombreColor;
				especificaciones();
			}

		}

		private void CambiarTamaño(object sender, RoutedEventArgs e)
		{
			if (sender.GetType() == typeof(ComboBox))
			{
				TamañoFuentes tamañoSeleccionado = (TamañoFuentes)CBTamaño.SelectedItem;
				tamaño = tamañoSeleccionado.Tamaño;

			}
			if (sender.GetType() == typeof(Button))
			{
				Button btn = (Button)sender;
				string operacion = btn.Tag.ToString();

				if (operacion == "+")
				{
					if (tamaño < 40)
					{
						tamaño++;
					}
					else
					{
						MessageBox.Show("No se acepta tamaño de letra superior a 40");
					}

				}
				else
				{
					if (tamaño > 1)
					{
						tamaño--;
					}
					else
					{
						MessageBox.Show("El tamaño no puede ser inferior a 1");
					}
				}
				CBTamaño.SelectedIndex = tamaño - 1;
			}
			especificaciones();

			display1.FontSize = tamaño;
			display2.FontSize = tamaño;
			display3.FontSize = tamaño;
		}
		private void CambiarFuente(object sender, SelectionChangedEventArgs e)
		{

			if (CBFuentes.SelectedItem != null)
			{
				Fuentes fuenteSeleccionada = (Fuentes)CBFuentes.SelectedItem;

				fuente = fuenteSeleccionada.Fuente;
				display1.FontFamily = new FontFamily(fuente);
				display2.FontFamily = new FontFamily(fuente);
				display3.FontFamily = new FontFamily(fuente);
				especificaciones();


			}


		}

		private void CambiarFondo(object sender, RoutedEventArgs e)
		{

			ComboBox cambiar = (ComboBox)sender;
			string caja = cambiar.Tag.ToString();
			ColoresDisponibles background = cambiar.SelectedItem as ColoresDisponibles;
			if (background != null)
			{
				switch (caja)
				{
					case "1":

						display1.Background = new SolidColorBrush(background.valorColor);
						Background1 = background.nombreColor;
						especificaciones();
						break;
					case "2":
						display2.Background = new SolidColorBrush(background.valorColor);
						Background2 = background.nombreColor;
						especificaciones();
						break;
					case "3":
						display3.Background = new SolidColorBrush(background.valorColor);
						Background3 = background.nombreColor;
						especificaciones();
						break;
				}
			}

		}
		private void CheckBox_Checked(object sender, RoutedEventArgs e)
		{

			CheckBox checkbox = (CheckBox)sender;

			if (checkbox.Tag.ToString() == "italic")
			{
				checkOblique.IsChecked = false;

				display1.FontStyle = FontStyles.Italic;
				display2.FontStyle = FontStyles.Italic;
				display3.FontStyle = FontStyles.Italic;
				adicional = "Italic";
				especificaciones();

			}
			else if (checkbox.Tag.ToString() == "oblique")
			{
				checkItalic.IsChecked = false;

				display1.FontStyle = FontStyles.Oblique;
				display2.FontStyle = FontStyles.Oblique;
				display3.FontStyle = FontStyles.Oblique;
				adicional = "Oblique";
				especificaciones();

			}
		}

		private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
		{

			display1.FontStyle = FontStyles.Normal;
			display2.FontStyle = FontStyles.Normal;
			display3.FontStyle = FontStyles.Normal;
			adicional = "";
			especificaciones();

		}

	}


	class Fuentes
	{
		public string Fuente { get; set; }


	}
	class TamañoFuentes
	{
		public int Tamaño { get; set; }

	}

}

class ColoresDisponibles
{
	public Color valorColor { get; set; }
	public string nombreColor { get; set; }

}

