using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaladeChat.SRChat;

namespace SaladeChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SRChat.ServicioChatSoapClient Ili = new ServicioChatSoapClient();
            var respuesta=Ili.chatiar(txtMensaje.Text);
            lstSala.Items.Add(txtMensaje.Text);
            lstSala.Items.Add(respuesta);

        }
    }
}
