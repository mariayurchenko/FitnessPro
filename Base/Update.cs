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
    public partial class Update : Form
    {
        private SqlConnection sqlConnection = null;
        private int id;
        public Update(SqlConnection connection, int id)
        {
            InitializeComponent();

            sqlConnection = connection;
            this.id = id;
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


        private async void Update_Load(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2), (ScreenHeight / 2) - (this.Height / 2));


            SqlCommand getClientInfoComm = new SqlCommand("SELECT [name], [dataVisit],[dataStart],[dataEnd],[phoneNumber],[email],[dateOfBirth],[note] FROM [Clients] WHERE [Id]=@Id", sqlConnection);
            getClientInfoComm.Parameters.AddWithValue("Id", id);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await getClientInfoComm.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    nameTextBox.Text = Convert.ToString(sqlReader["name"]);
                    dataVisitDateTimePicker.Text = Convert.ToString((sqlReader["dataVisit"]));
                    dateStartTimePicker.Text = Convert.ToString((sqlReader["dataStart"]));
                    dateEndTimePicker.Text = Convert.ToString((sqlReader["dataEnd"]));
                    phoneNumberTextBox.Text = Convert.ToString(sqlReader["phoneNumber"]);
                    emailTextBox.Text = Convert.ToString(sqlReader["email"]);
                    dateOfBirthDateTimePicker.Text = Convert.ToString((sqlReader["dateOfBirth"]));
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

        private async void login_Click(object sender, EventArgs e)
        {
            SqlCommand updateClientCommand = new SqlCommand("UPDATE [Clients] SET [name] = @name, [dataVisit]=@dataVisit, [dataStart]=@dataStart,[dataEnd]=@dataEnd,[phoneNumber]=@phoneNumber,[email]=@email,[dateOfBirth]=@dateOfBirth,[note]=@note WHERE [Id]=@Id", sqlConnection);
            if (nameTextBox.Text == "" || dataVisitDateTimePicker.Text == "" || dateOfBirthDateTimePicker.Text == "")
            {
                MessageBox.Show("Помилка! Не всі данні введенні!");
            }
            else if ((phoneNumberTextBox.Text == "" && emailTextBox.Text == ""))
            {
                MessageBox.Show("Помилка! Укажіть номер телефону або email!");
            }
            else
            {

                updateClientCommand.Parameters.AddWithValue("Id", id);
                updateClientCommand.Parameters.AddWithValue("name", nameTextBox.Text);
                updateClientCommand.Parameters.AddWithValue("dataVisit",
                    Convert.ToDateTime(dataVisitDateTimePicker.Text));
                updateClientCommand.Parameters.AddWithValue("dataStart", Convert.ToDateTime(dateStartTimePicker.Text));
                updateClientCommand.Parameters.AddWithValue("dataEnd", Convert.ToDateTime(dateEndTimePicker.Text));
                updateClientCommand.Parameters.AddWithValue("phoneNumber", phoneNumberTextBox.Text);
                updateClientCommand.Parameters.AddWithValue("email", emailTextBox.Text);
                updateClientCommand.Parameters.AddWithValue("dateOfBirth",
                    Convert.ToDateTime(dateOfBirthDateTimePicker.Text));
                updateClientCommand.Parameters.AddWithValue("note", noteTextBox.Text);

                try
                {
                    await updateClientCommand.ExecuteNonQueryAsync();
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
    }
}

