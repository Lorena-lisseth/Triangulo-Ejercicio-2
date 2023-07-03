namespace Triangulo;
///<Summary>
///<Createddate>2023/06/30</Createddate>
///<company>SandBox</company>
///<lastmodificationdate>2023/07/01</lastmodificationdate>
///<lastmodificationdescription>
///Agregar la documentacion y la imagen
///</lastmodificationdescription>
///<lastmodifierautor>Lorena Vasquez</lastmodifierautor>
///</Summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Constructor de la clase 
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}
	/// <summary>
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>

	private void CounterBtn_Clicked(object sender, EventArgs e)
	{
		//hacemos una multiplicacion de base x altura y luego dividimos entre 2, en la superficie 
		//se mostrara el resultado.
		if (!string.IsNullOrEmpty(B.Text) && !string.IsNullOrEmpty(A.Text))
		{
			double bas, altura, super;
			bas = Convert.ToDouble(B.Text);
			altura = Convert.ToDouble(A.Text);

			super = bas * altura / 2;
			Superficie.Text = super.ToString();

		}
		else
		{
			DisplayAlert("Error", "Ingrese todos los datos", "Oki Doki Yo");
		}
	}
}

