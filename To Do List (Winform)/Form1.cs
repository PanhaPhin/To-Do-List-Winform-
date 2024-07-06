namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(txtName.Text, txtAddress.Text, txtSalary.Text + "$", txtWork.Text, txtSkills.Text + "%");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                dgv.CurrentRow.Cells["name"].Value = txtName.Text;
                dgv.CurrentRow.Cells["address"].Value = txtAddress.Text;
                dgv.CurrentRow.Cells["salary"].Value = txtSalary.Text + "$";
                dgv.CurrentRow.Cells["work"].Value = txtWork.Text;
                dgv.CurrentRow.Cells["skills"].Value = txtSkills.Text + "%";

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }

        private void btnAddCol_Click(object sender, EventArgs e)
        {
            dgv.Columns.Add(txtNameCol.Text, txtTextCol.Text);
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow !=null)
            {
                txtName.Text = dgv.CurrentRow.Cells["name"].Value.ToString();
                txtAddress.Text = dgv.CurrentRow.Cells["address"].Value.ToString();
                txtSalary.Text = dgv.CurrentRow.Cells["Salary"].Value.ToString();
                txtWork.Text = dgv.CurrentRow.Cells["work"].Value.ToString();
                txtSkills.Text = dgv.CurrentRow.Cells["skills"].Value.ToString();
            }

        }
    }
}