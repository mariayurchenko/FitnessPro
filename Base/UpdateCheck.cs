using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public partial class UpdateCheck : Form
    {
        private SqlConnection sqlConnection = null;
        private int id;
        public UpdateCheck(SqlConnection connection, int id)
        {
            InitializeComponent();

            sqlConnection = connection;
            this.id = id;
            this.numberLabel.Text = "Квитанція №"+id;
            if (nameTextBox.Text != nameValue)
                nameTextBox.Text = nameValue;

        }

        private string nameValue;
        private async void save_Click(object sender, EventArgs e)
        {
            SqlCommand updateCheckCommand = new SqlCommand("UPDATE [Check] SET [name] = @name, [dataVisit]=@dataVisit, [dataStart]=@dataStart,[dataEnd]=@dataEnd,[value]=@value,[status]=@status,[note]=@note WHERE [Id]=@Id", sqlConnection);
            if (nameTextBox.Text == "" || dataVisitDateTimePicker.Text == "" || dataStartTimePicker.Text == "" || dataEndTimePicker.Text == "" || valueTextBox.Text=="" || noteTextBox.Text=="")
            {
                MessageBox.Show("Помилка! Не всі данні введенні!");
            }
            else if (radioButtonYes.Checked == false && radioButtonNo.Checked == false)
            {
                MessageBox.Show("Помилка! Укажіть статус оплати!");
            }
            else
            {

                updateCheckCommand.Parameters.AddWithValue("Id", id);
                updateCheckCommand.Parameters.AddWithValue("name", nameTextBox.Text);
                updateCheckCommand.Parameters.AddWithValue("dataVisit",
                    Convert.ToDateTime(dataVisitDateTimePicker.Text));
                updateCheckCommand.Parameters.AddWithValue("dataStart", Convert.ToDateTime(dataStartTimePicker.Text));
                updateCheckCommand.Parameters.AddWithValue("dataEnd", Convert.ToDateTime(dataEndTimePicker.Text));
                updateCheckCommand.Parameters.AddWithValue("value", valueTextBox.Text);
                if (radioButtonYes.Checked == true)
                    updateCheckCommand.Parameters.AddWithValue("status", "Оплачено");
                else
                    updateCheckCommand.Parameters.AddWithValue("status", "Не оплачено");
                updateCheckCommand.Parameters.AddWithValue("note", noteTextBox.Text);

                try
                {
                    await updateCheckCommand.ExecuteNonQueryAsync();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void close_MouseEnter(object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }
        private Point lastPoint;
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private async void UpdateCheck_Load(object sender, EventArgs e)
        {
            
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));

            SqlCommand getCheckInfoComm = new SqlCommand("SELECT [name], [dataVisit],[dataStart],[dataEnd],[value],[status],[note] FROM [Check] WHERE [Id]=@Id", sqlConnection);
            getCheckInfoComm.Parameters.AddWithValue("Id", id);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await getCheckInfoComm.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    nameValue = Convert.ToString(sqlReader["name"]);
                    nameTextBox.Text = nameValue;
                    dataVisitDateTimePicker.Text = Convert.ToString((sqlReader["dataVisit"]));
                    dataStartTimePicker.Text = Convert.ToString((sqlReader["dataStart"]));
                    dataEndTimePicker.Text = Convert.ToString((sqlReader["dataEnd"]));
                    valueTextBox.Text = Convert.ToString(sqlReader["value"]);
                    if (Convert.ToString(sqlReader["status"]) == "Оплачено")
                        radioButtonYes.Checked = true;
                    else
                        radioButtonNo.Checked = true;
                    noteTextBox.Text = Convert.ToString(sqlReader["note"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                    sqlReader.Close();
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text != nameValue)
                nameTextBox.Text = nameValue;
        }
    }
}
