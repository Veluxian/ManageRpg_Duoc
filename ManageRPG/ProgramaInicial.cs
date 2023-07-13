namespace ManageRPG;

static class InicioPrograma

{
  
    [STAThread]
    static void Main()
    {
      

        ApplicationConfiguration.Initialize();

        ////iniciamos la vista principal del pryecto
        Application.Run(new Login());


    }
}