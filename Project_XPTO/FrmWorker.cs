using System;
using System.Globalization;
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
         PreencheDataGrid();
      }

      private void InsertWorker_Click(object sender, System.EventArgs e)
      {
         Worker worker = new Worker
         {
            Nome = txtNome.Text,
            Email = txtEmail.Text,
            Cpf = mskCpf.Text,
            DataNascimeto = DateTime.ParseExact(mskDataNascimento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
         };
         cx.InsertWorker(worker);
         PreencheDataGrid();
      }

      public void PreencheDataGrid()
      {
         var list = cx.GetAllWorker();
         dgWorker.Rows.Clear();

         foreach (Worker teste in list)
         {
            dgWorker.Rows.Add(
               teste.Id,
               teste.Nome,
               teste.Email,
               Convert.ToUInt64(teste.Cpf).ToString(@"000\.000\.000\-00"),
               teste.DataNascimeto.ToString("dd/MM/yyyy")
            );
         }
      }

      private void dgWorker_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         if (e.RowIndex<0) return;
       
         int id = Convert.ToInt32(dgWorker.Rows[e.RowIndex].Cells[0].Value);
         Worker worker = cx.GetWorker(id);

         txtNome.Text = worker.Nome;
         txtEmail.Text = worker.Email;
         mskCpf.Text = worker.Cpf;
         mskDataNascimento.Text = worker.DataNascimeto.ToString();

      }

   }
}