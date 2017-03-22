using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
        
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
         try
            {
                IDBManager dbManager = new MySQLDBManager();

                gridStudents.DataSource = dbManager.RetrieveStudents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
         try
            {
                Student student = RetrieveStudentInformation();

                IDBManager db = new MySQLDBManager();
                db.AddStudent(student);
                EmptyControls();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
        try
            {
                Student student = RetrieveStudentInformation();

                IDBManager db = new MySQLDBManager();
                db.UpdateStudent(student);
                EmptyControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = RetrieveStudentInformation();

                IDBManager db = new MySQLDBManager();
                db.DeleteStudent(student);
                EmptyControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
//
        private void gridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void lbl(object sender, EventArgs e)
        {
        
        }

        private void lblStudentName_Click(object sender, EventArgs e)
        {
        
        }

        private void lblStudentBd_Click(object sender, EventArgs e)
        {
        
        }

        private void lblStudentAddress_Click(object sender, EventArgs e)
        {
        
        }

            private void EmptyControls()
        {
            txtStudentID.Text = string.Empty;
            txtStudentName.Text = string.Empty;
            dtpStudentBirthDate.Value = DateTime.Now;
            txtStudentAddress.Text = string.Empty;
            gridStudents.SelectedRows[0].Selected = false;
        }

         private Student RetrieveStudentInformation()
        {
            Student student = new Student();
            student.ID = Convert.ToInt32(txtStudentID.Text);
            student.Name = txtStudentName.Text;
            student.BirthDate = dtpStudentBirthDate.Value;
            student.Address = txtStudentAddress.Text;
            return student;
        }

         private void gridStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (gridStudents.SelectedRows.Count > 0)
            {
                Student student = gridStudents.SelectedRows[0].DataBoundItem as Student;
                if (student != null)
                {
                    txtStudentName.Text = student.Name;
                    txtStudentID.Text = student.ID.ToString();
                    dtpStudentBirthDate.Value = student.BirthDate;
                    txtStudentAddress.Text = student.Address;
                }
            }
        }

        private void dtpStudentBirthDate_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void txtStudentAddress_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textIdC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNameC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTeacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSY_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelSY_Click(object sender, EventArgs e)
        {

        }

        private void labelTeacher_Click(object sender, EventArgs e)
        {

        }

        private void labelNameC_Click(object sender, EventArgs e)
        {

        }

        private void labelIDC_Click(object sender, EventArgs e)
        {

        }

    }
}
