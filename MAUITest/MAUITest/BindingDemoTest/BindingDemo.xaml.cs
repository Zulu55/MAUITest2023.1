namespace MAUITest.BindingDemoTest;

public partial class BindingDemo : ContentPage
{
	public BindingDemo()
	{
		InitializeComponent();
	}

    private void bntOk_Clicked(object sender, EventArgs e)
    {
		var person = new Person
		{
			Name = "Juan Zuluaga",
			Phone = "+57 322 311 4620",
			Address = "Calle Luna Calle Sol"
		};

		BindingContext = person;
		//lblName.SetBinding(Label.TextProperty, "Name");

		//var personBinding = new Binding();
		//personBinding.Source = person;
		//personBinding.Path = "Name";
		//lblName.SetBinding(Label.TextProperty, personBinding);
	}
}