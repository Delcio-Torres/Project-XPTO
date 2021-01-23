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

         cx.InsertWorker(new Worker { Nome = "Delcio de Abreu Torres", Email = "delcio.at@gmail.com", DataNascimeto = Convert.ToDateTime("26/04/1963"), Cpf = 71843752620 });
         MessageBox.Show("Tudo Certo");
      }

   }
}
