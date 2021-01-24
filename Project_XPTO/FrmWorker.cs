using System;
using System.Globalization;
using System.Collections.Generic;
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

      private void FrmWorker_Load(object sender, EventArgs e)
      {
      }

      private void InsertWorker_Click(object sender, System.EventArgs e)
      {
         Worker worker = new Worker
         {
            Nome = txtNome.Text,
            Email = txtEmail.Text,
            Cpf = mskCpf.Text,
            DataNascimeto = mskDataNascimento.Text
         };
         cx.InsertWorker(worker);
         PreencheDataGrid();
      }

      public void PreencheDataGrid()
      {
         var list = cx.GetAllWorker();
         dgWorker.Rows.Clear();

         foreach(Worker teste in list)
         {
            dgWorker.Rows.Add(
               teste.Id,
               teste.Nome,
               teste.Email,
               Convert.ToUInt64(teste.Cpf).ToString(@"000\.000\.000\-00"),
               Convert.ToUInt64(teste.DataNascimeto).ToString(@"00\/00\/0000"));
         }
      }

      private void button3_Click(object sender, EventArgs e)
      {
         DateTime d1 = Convert.ToDateTime(mskDataNascimento.Text);
         MessageBox.Show(d1.ToString("dd/MM/yyyy"));
      }
   }
}
