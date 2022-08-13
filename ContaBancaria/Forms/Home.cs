using ContaBancaria.Controllers;
using ContaBancaria.Models;
using System;

namespace ContaBancaria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            var dataBase = new Database();
            var conn = dataBase.OpenConection();
            dataGridViewContas.DataSource = dataBase.GetAccounts(conn).Tables[0];
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            var dataBase = new Database();
            var conn = dataBase.OpenConection();
            Account account = new Account();
            account.Titular = txtTitular.Text;
            account.Number = txtAccountNumber.Text == "" ? default(int) : Int32.Parse(txtAccountNumber.Text);
            account.FirstDeposit = txtFirstDeposit.Checked != true ? default(decimal) : Decimal.Parse(txtDeposit.Text);
            account.Deposit = txtDeposit.Text == "" ? default(decimal) : Decimal.Parse(txtDeposit.Text);

            dataBase.PutAccount(conn, account);
            dataGridViewContas.DataSource = dataBase.GetAccounts(conn).Tables[0];
        }

        private void dataGridViewContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                int rowindex = e.RowIndex;
                DataGridViewRow row = dataGridViewContas.Rows[rowindex];
                txtAccountNumber.Text = row.Cells[0].Value.ToString();
                txtTitular.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var dataBase = new Database();
            var conn = dataBase.OpenConection();
            Account account = new Account();
            account.Titular = txtTitular.Text;
            account.Number = txtAccountNumber.Text == "" ? default(int) : Int32.Parse(txtAccountNumber.Text);

            dataBase.PutAccount(conn, account);
            dataGridViewContas.DataSource = dataBase.GetAccounts(conn).Tables[0];
        }
    }
}