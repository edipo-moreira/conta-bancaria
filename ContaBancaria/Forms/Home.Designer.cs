namespace ContaBancaria
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewContas = new System.Windows.Forms.DataGridView();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtFirstDeposit = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContas
            // 
            this.dataGridViewContas.AllowUserToOrderColumns = true;
            this.dataGridViewContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContas.Location = new System.Drawing.Point(2, 119);
            this.dataGridViewContas.Name = "dataGridViewContas";
            this.dataGridViewContas.RowTemplate.Height = 25;
            this.dataGridViewContas.Size = new System.Drawing.Size(679, 332);
            this.dataGridViewContas.TabIndex = 0;
            this.dataGridViewContas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContas_CellDoubleClick);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(2, 22);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PlaceholderText = "Nº da Conta";
            this.txtAccountNumber.Size = new System.Drawing.Size(143, 23);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.Location = new System.Drawing.Point(606, 22);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Depositar";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(151, 22);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.PlaceholderText = "Titular";
            this.txtTitular.Size = new System.Drawing.Size(133, 23);
            this.txtTitular.TabIndex = 3;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(422, 22);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.PlaceholderText = "Valor do Deposito";
            this.txtDeposit.Size = new System.Drawing.Size(178, 23);
            this.txtDeposit.TabIndex = 4;
            // 
            // txtFirstDeposit
            // 
            this.txtFirstDeposit.AutoSize = true;
            this.txtFirstDeposit.Location = new System.Drawing.Point(422, 51);
            this.txtFirstDeposit.Name = "txtFirstDeposit";
            this.txtFirstDeposit.Size = new System.Drawing.Size(126, 19);
            this.txtFirstDeposit.TabIndex = 5;
            this.txtFirstDeposit.Text = "Primeiro Depósito?";
            this.txtFirstDeposit.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(209, 51);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtFirstDeposit);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.dataGridViewContas);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewContas;
        private TextBox txtAccountNumber;
        private Button btnDeposit;
        private TextBox txtTitular;
        private TextBox txtDeposit;
        private CheckBox txtFirstDeposit;
        private Button btnSalvar;
    }
}