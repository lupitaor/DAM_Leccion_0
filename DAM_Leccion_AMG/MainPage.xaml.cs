﻿using DAM_Leccion_AMG.Model;

namespace DAM_Leccion_AMG
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public PersonaModel personaModel{ get; set; }


        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void Ejecutar()
        {
            personaModel = new PersonaModel()
            {
                Nombre = "Hola aqui estoy",

            };

            BindingContext= personaModel;

            //txtNombre.Text = personaModel.Nombre;

            //Binding personaBinding = new Binding();

            //personaBinding.Source = personaModel; //Origen
            //personaBinding.Path = "Nombre"; //Ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding); //Destino final



        }

        //Evento Guardar
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            // DisplayAlert("Asistente del sistema","Se ha guardado el registro en la BD","Aceptar");
            personaModel.Nombre = "Alondra Montalvo";
        }
    }

}
