using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace App2
{
    partial class subForm2 : Form
    {
       
        public subForm2()
        {
            InitializeComponent();


            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }
       
        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Specify the name of your file
            string fileName = "LECTURE 2.pptx"; // Change this to your file name

            // Combine the application startup path with the "files" folder and the file name
            string filePath = System.IO.Path.Combine(Application.StartupPath, "files", fileName);

            try
            {
                // Open the file with the default application
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                // Show an error message if the file cannot be opened
                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button40_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "Choise 02.pdf";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "Choise 02.pptx";

            string filePath = System.IO.Path.Combine(Application.StartupPath, "choise02", fileName);

            try
            {

                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            // Optionally hide the current form (subForm1)
            this.Hide();

            // Show the MainForm
            mainForm.Show();

        }
    }
}
