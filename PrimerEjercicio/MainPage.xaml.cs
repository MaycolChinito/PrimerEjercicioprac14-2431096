namespace PrimerEjercicio;

//<Summary>
//<Createddate>10/7/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>10/7/2023</lastmodificationdate>
///<lastmodificationdescription>
///Realicé un programa en que solicite 4 números y luego invierta el orden de los números///
///</lastmodificationdescription>
//////<lastmodifierautor>Maycol Barrera</lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{
   
       

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int nume1 = Convert.ToInt32(num1.Text);
        int nume2 = Convert.ToInt32(num2.Text);
        int nume3 = Convert.ToInt32(num3.Text);
        int nume4 = Convert.ToInt32(num4.Text);


        num1.Text = Convert.ToString(nume4);
        num2.Text = Convert.ToString(nume3);
        num3.Text = Convert.ToString(nume2);
        num4.Text = Convert.ToString(nume1);

    }

    private void Button_Clicked_1()
    {

    }
}

