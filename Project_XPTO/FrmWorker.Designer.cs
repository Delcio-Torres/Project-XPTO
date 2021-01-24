
namespace Project_XPTO
{
   partial class FrmWorker
   {
      /// <summary>
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Windows Form Designer

      /// <summary>
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         this.button1 = new System.Windows.Forms.Button();
         this.txtNome = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.mskCpf = new System.Windows.Forms.MaskedTextBox();
         this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
         this.dgWorker = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgWorker)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(70, 112);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 4;
         this.button1.Text = "Salvar";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.InsertWorker_Click);
         // 
         // txtNome
         // 
         this.txtNome.Location = new System.Drawing.Point(70, 29);
         this.txtNome.Name = "txtNome";
         this.txtNome.Size = new System.Drawing.Size(177, 20);
         this.txtNome.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(70, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Nome";
         // 
         // txtEmail
         // 
         this.txtEmail.Location = new System.Drawing.Point(266, 29);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(177, 20);
         this.txtEmail.TabIndex = 1;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(266, 13);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(32, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Email";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(70, 57);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(27, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "CPF";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(205, 57);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(89, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "Data Nascimento";
         // 
         // mskCpf
         // 
         this.mskCpf.Location = new System.Drawing.Point(70, 73);
         this.mskCpf.Mask = "000,000,000-00";
         this.mskCpf.Name = "mskCpf";
         this.mskCpf.PromptChar = ' ';
         this.mskCpf.Size = new System.Drawing.Size(100, 20);
         this.mskCpf.TabIndex = 2;
         this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
         // 
         // mskDataNascimento
         // 
         this.mskDataNascimento.Location = new System.Drawing.Point(208, 73);
         this.mskDataNascimento.Mask = "00/00/0000";
         this.mskDataNascimento.Name = "mskDataNascimento";
         this.mskDataNascimento.Size = new System.Drawing.Size(100, 20);
         this.mskDataNascimento.TabIndex = 3;
         this.mskDataNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
         // 
         // dgWorker
         // 
         this.dgWorker.AllowUserToAddRows = false;
         this.dgWorker.AllowUserToDeleteRows = false;
         this.dgWorker.AllowUserToOrderColumns = true;
         this.dgWorker.AllowUserToResizeColumns = false;
         this.dgWorker.AllowUserToResizeRows = false;
         this.dgWorker.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
         this.dgWorker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.dgWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
         this.dgWorker.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.dgWorker.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
         this.dgWorker.Location = new System.Drawing.Point(0, 145);
         this.dgWorker.Name = "dgWorker";
         this.dgWorker.RowHeadersVisible = false;
         this.dgWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dgWorker.Size = new System.Drawing.Size(558, 177);
         this.dgWorker.TabIndex = 6;
         this.dgWorker.TabStop = false;
         // 
         // Column1
         // 
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.Format = "0000";
         dataGridViewCellStyle4.NullValue = null;
         this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
         this.Column1.HeaderText = "ID";
         this.Column1.Name = "Column1";
         this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.Column1.Width = 50;
         // 
         // Column2
         // 
         this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.Column2.HeaderText = "Nome";
         this.Column2.Name = "Column2";
         this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         // 
         // Column3
         // 
         this.Column3.HeaderText = "Email";
         this.Column3.Name = "Column3";
         this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.Column3.Width = 130;
         // 
         // Column4
         // 
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle5.Format = "999,999,999-99";
         dataGridViewCellStyle5.NullValue = null;
         this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
         this.Column4.HeaderText = "CPF";
         this.Column4.Name = "Column4";
         this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         // 
         // Column5
         // 
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle6.Format = "##/##/####";
         dataGridViewCellStyle6.NullValue = null;
         this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
         this.Column5.HeaderText = "Data de Nascimento";
         this.Column5.Name = "Column5";
         this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.Column5.Width = 128;
         // 
         // FrmWorker
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(558, 322);
         this.Controls.Add(this.dgWorker);
         this.Controls.Add(this.mskDataNascimento);
         this.Controls.Add(this.mskCpf);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.txtNome);
         this.Controls.Add(this.button1);
         this.Name = "FrmWorker";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.dgWorker)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox txtNome;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtEmail;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.MaskedTextBox mskCpf;
      private System.Windows.Forms.MaskedTextBox mskDataNascimento;
      private System.Windows.Forms.DataGridView dgWorker;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
   }
}

