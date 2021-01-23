using System;
using Model;
using Controller;
using System.Windows.Forms;

namespace Project_XPTO
{
   public partial class FrmWorker : Form
   {
      private Connection cx = new Connection();

      public FrmWorker()
      {
         InitializeComponent();
      }

      private void FrmWorker_Load(object sender, EventArgs e)
      {
      }

      private void InsertWorker_Click(object sender, System.EventArgs e) 
      {
         Worker worker = new Worker
         {
            Nome = txtNome.Text,
            Email = txtEmail.Text,
            Cpf = Convert.ToDecimal(mskCpf.Text),
            DataNascimeto = Convert.ToDateTime(mskDataNascimento.Text)
         };
         cx.InsertWorker(worker);
         MessageBox.Show("Tudo Certo");
      }
   }
}
