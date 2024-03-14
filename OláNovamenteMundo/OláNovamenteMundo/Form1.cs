using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OláNovamenteMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string login = txtUsername.Text;
            string senha = txtSenha.Text;
            MessageBox.Show("Seu login foi realizado com sucesso!");
        }

        private void Login_Click(object sender, EventArgs e)
        {
            
        }
    }
}
