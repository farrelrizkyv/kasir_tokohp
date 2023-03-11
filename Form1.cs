using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace tokohp
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connection.getConnection();
        DataTable dataTable = new DataTable();

        public DataTable getDataTable()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM hp", koneksi))
            {
                koneksi.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                koneksi.Close();
            }
            return dataTable;

        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getDataTable();
            //dataGridView1.Rows.Clear();

            DataGridViewButtonColumn colEditSarana = new DataGridViewButtonColumn();
            colEditSarana.UseColumnTextForButtonValue = true;
            colEditSarana.Text = "Edit";
            colEditSarana.Name = "";
            dataGridView1.Columns.Add(colEditSarana);

            DataGridViewButtonColumn colDeleteSarana = new DataGridViewButtonColumn();
            colDeleteSarana.UseColumnTextForButtonValue = true;
            colDeleteSarana.Text = "Delete";
            colDeleteSarana.Name = "";
            dataGridView1.Columns.Add(colDeleteSarana);

            koneksi.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
                id_hp.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
                nama.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
                jenis.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
                stock.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();

                dataGridView2.Enabled = true;
            }

            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;

                try
                {
                    
                    koneksi.Open();
                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM hp WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", dataGridView1.Rows[id].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                    dataGridView1.Columns.Clear();
                    dataTable.Clear();
                    resetincrement();
                    filldataTable();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                
                koneksi.Open();
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE hp SET nama=@nama, jenis=@jenis, stock=@stock where id=@id";
                cmd.Parameters.AddWithValue("@id", id_hp.Text);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
                cmd.Parameters.AddWithValue("@stock", stock.Text);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataGridView1.Columns.Clear();
                dataTable.Clear();
                resetincrement();
                filldataTable();
            }
            catch (Exception ex) {

            }

        }

        private void btn_simpan_click_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                koneksi.Open();
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO hp (nama, jenis, stock) VALUE(@nama, @jenis, @stock)";
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
                cmd.Parameters.AddWithValue("@stock", stock.Text);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            filldataTable();
        }

        private void search(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM hp WHERE id LIKE '%" + textBox1.Text + "%' OR nama LIKE '%" + textBox1.Text + "%' OR jenis LIKE '%" + textBox1.Text + "%' OR stock LIKE '%" + textBox1.Text + "%'";


            dataGridView1.Columns.Clear();
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(Query, koneksi))
            {
                koneksi.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                koneksi.Close();
            }
            dataGridView1.DataSource = dataTable;

            DataGridViewButtonColumn colEditSarana = new DataGridViewButtonColumn();
            colEditSarana.UseColumnTextForButtonValue = true;
            colEditSarana.Text = "Edit";
            colEditSarana.Name = "";
            dataGridView1.Columns.Add(colEditSarana);

            DataGridViewButtonColumn colDeleteSarana = new DataGridViewButtonColumn();
            colDeleteSarana.UseColumnTextForButtonValue = true;
            colDeleteSarana.Text = "Delete";
            colDeleteSarana.Name = "";
            dataGridView1.Columns.Add(colDeleteSarana);

            koneksi.Close();
        }
        public void resetincrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update hp SET id = @id := (@id+1); " + "ALTER TABLE hp AUTO_INCREMENT = 1;");
            script.Execute();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void jenis_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_2(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {

        }
    }

}