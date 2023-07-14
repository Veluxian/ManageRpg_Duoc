using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;

namespace ManageRPG.Controlador
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();

        }

        public void controladorBD (Object sender, EventArgs e)
        {
            string conexionstring = "server= SAGITTARIUS\\SQLEXPRESS ; database= ManageRPG ; integrated security= true";
            SqlConnection conexion = new SqlConnection(conexionstring);

        }

        public Component1(IContainer container)
        {
            


            container.Add(this);

            InitializeComponent();
        }
    }
}
