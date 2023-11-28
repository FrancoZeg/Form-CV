using Xamarin.Forms;

namespace App13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EnviarFormulario(object sender, EventArgs e)
        {
            var nombre = ((Entry)((StackLayout)Content).Children[1]).Text;
            var pais = ((Picker)((StackLayout)Content).Children[3]).SelectedItem;
            var fechaNacimiento = ((DatePicker)((StackLayout)Content).Children[5]).Date;
            var tieneExperiencia = ((Switch)((StackLayout)Content).Children[7]).IsToggled;

            string curriculumVitae = $"Curriculum Vitae\n\n" +
                $"Nombre: {nombre}\n" +
                $"País: {pais}\n" +
                $"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}\n" +
                $"Experiencia laboral: {(tieneExperiencia ? "Sí" : "No")}\n";

            MostrarCV(curriculumVitae);
        }
        
        private void MostrarCV(string cv)
        {
            // Por ejemplo, puedes mostrar el CV en una nueva página
            Navigation.PushAsync(new CVPage(cv));
        }
        
    }
}
