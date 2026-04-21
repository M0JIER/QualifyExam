using Microsoft.EntityFrameworkCore.Internal;

namespace QualifExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.Movies.ToList();

        }

        void loadData()
        {
            dataGridView1.DataSource = db.Movies.ToList();
        }

        DBFuncs db = new DBFuncs();

        int? varId = null;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtYearCreate.Text, out int y)) { MessageBox.Show("¬ведите корректный год"); return; }

            db.Movies.Add(new Movie()
            {
                Name = txtNameCreate.Text,
                Author = txtAuthorCreate.Text,
                Year = y
            });
            db.SaveChanges();
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                varId = (int)dataGridView1[0, e.RowIndex].Value;

                txtNameEdit.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                txtAuthorEdit.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                txtYearEdit.Text = dataGridView1[3, e.RowIndex].Value.ToString();

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtYearEdit.Text, out int y)) { MessageBox.Show("¬ведите корректный год"); return; }

            db.Edit(varId, new Movie()
            {
                Name = txtNameEdit.Text,
                Year = y,
                Author = txtAuthorEdit.Text
            });
            loadData();
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            db.Delete(varId);
            varId = null;
            loadData();

        }

        private void txtYearEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYearCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
