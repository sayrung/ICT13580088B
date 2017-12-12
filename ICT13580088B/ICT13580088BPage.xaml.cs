using Xamarin.Forms;

namespace ICT13580088B
{
    public partial class ICT13580088BPage : ContentPage
    {
        public ICT13580088BPage()
        {
            InitializeComponent();
            okBotton.Clicked += OkBotton_Clicked;
            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;
        }

        void OkBotton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
