using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public AddEmployee()
        {
            InitializeComponent();
            displayEmployeeData();
            
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void clearFields()
        {
            addEmpoloyee_id.Text = "";
            addEmpoloyee_fullName.Text = "";
            addEmpoloyee_gender.SelectedIndex = -1;
            addEmpoloyee_phoneNumber.Text = "";
            addEmpoloyee_position.SelectedIndex = -1;
            addEmpoloyee_status.SelectedIndex = -1;
            addEmpoloyee_picture.Image = null;
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }



        private void addEmpoloyee_addBtn_Click(object sender, EventArgs e)
        {
            if (addEmpoloyee_id.Text == ""
              || addEmpoloyee_fullName.Text == ""
              || addEmpoloyee_gender.Text == ""
              || addEmpoloyee_phoneNumber.Text == ""
              || addEmpoloyee_position.Text == ""
              || addEmpoloyee_status.Text == ""
              || addEmpoloyee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmpoloyee_id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmpoloyee_id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                    "(employee_id, full_name, gender, contact_number" +
                                    ", position, image, salary, insert_date, status) " +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum" +
                                    ", @position, @image, @salary, @insertDate, @status)";

                                string path = Path.Combine(@"C:\Users\Admin\Desktop\Employe\WindowsFormsApp1\WindowsFormsApp1\Directory\"
                                    + addEmpoloyee_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(addEmpoloyee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmpoloyee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmpoloyee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmpoloyee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmpoloyee_phoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmpoloyee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addEmpoloyee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmpoloyee_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmpoloyee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmpoloyee_id.Text = row.Cells[1].Value.ToString();
                addEmpoloyee_fullName.Text = row.Cells[2].Value.ToString();
                addEmpoloyee_gender.Text = row.Cells[3].Value.ToString();
                addEmpoloyee_phoneNumber.Text = row.Cells[4].Value.ToString();
                addEmpoloyee_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    addEmpoloyee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmpoloyee_picture.Image = null;
                }

                addEmpoloyee_status.Text = row.Cells[8].Value.ToString();
            }
        }

        private void addEmpoloyee_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmpoloyee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addEmpoloyee_id.Text == ""
            || addEmpoloyee_fullName.Text == ""
            || addEmpoloyee_gender.Text == ""
            || addEmpoloyee_phoneNumber.Text == ""
            || addEmpoloyee_position.Text == ""
            || addEmpoloyee_status.Text == ""
            || addEmpoloyee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addEmpoloyee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", addEmpoloyee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void addEmpoloyee_updateBtn_Click(object sender, EventArgs e)
        {
            if (addEmpoloyee_id.Text == ""
               || addEmpoloyee_fullName.Text == ""
               || addEmpoloyee_gender.Text == ""
               || addEmpoloyee_phoneNumber.Text == ""
               || addEmpoloyee_position.Text == ""
               || addEmpoloyee_status.Text == ""
               || addEmpoloyee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "Employee ID: " + addEmpoloyee_id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employees SET full_name = @fullName" +
                            ", gender = @gender, contact_number = @contactNum" +
                            ", position = @position, update_date = @updateDate, status = @status " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullName", addEmpoloyee_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmpoloyee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNum", addEmpoloyee_phoneNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addEmpoloyee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addEmpoloyee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addEmpoloyee_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
    }

