using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmAnimais : Form
    {
        public frmAnimais()
        {
            InitializeComponent();
        }

        private void cboAnimais_Load(object sender, EventArgs e)
        {
            //limpa os itens adicionados no ComboBox
            cboAnimais.Items.Clear();

            //adiciona os Itens no ComboBox 
            //por meio do méto Add( )

            cboAnimais.Items.Add("Cachorro");
            cboAnimais.Items.Add("Cavalo");
            cboAnimais.Items.Add("Gato");
            cboAnimais.Items.Add("Centopeia");
            cboAnimais.Items.Add("Cobra");
            cboAnimais.Items.Add("Pássaro");
        }

        private void cboAnimais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPatas_Click(object sender, EventArgs e)
        {
            //declara variável
            String strAnimal;

            //variável recebe o texto do item do ComboBox Selecionado
            strAnimal = cboAnimais.Text;

            //instrução de seleção
            switch (strAnimal)
            {
                case "Cachorro":

                    //carrega o arquivo que está na pasta Debug
                    pctAnimais.Load("cachorro.png");
                    break;
                case "Cavalo":
                    pctAnimais.Load("cavalo.png");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Centopeia":
                    pctAnimais.Load("centopeia.png");
                    MessageBox.Show("Este animal tem 100 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Cobra":
                    pctAnimais.Load("cobra.png");
                    MessageBox.Show("Este animal não tem patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Gato":
                    pctAnimais.Load("gato.png");
                    MessageBox.Show("Este animal tem 4 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Pássaro":
                    pctAnimais.Load("passaro.png");
                    MessageBox.Show("Este animal tem 2 patas", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    //limpa o PictureBox
                    pctAnimais.ResetText();
                    MessageBox.Show("Selecione um Animal", "Animais", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
