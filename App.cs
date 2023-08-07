using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FileOrganizer.Class;

namespace FileOrganizer
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnOrganize_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPath.Text;
                if (!String.IsNullOrWhiteSpace(path) && Directory.Exists(path))
                {
                    List<string> files = Directory.GetFiles(path).ToList();
                    foreach (var file in files)
                    {
                        string extension = Path.GetExtension(file);
                        string directory = Path.Combine(path, Tools.GetSubfolderName(extension));

                        if (!Directory.Exists(directory))
                        {
                            Directory.CreateDirectory(directory);
                        }

                        string newFilePath = Path.Combine(directory, Path.GetFileName(file));
                        File.Move(file, newFilePath);
                    }
                    MessageBox.Show("Your Files Now Organized!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Path!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPath.Focus();
                }
            }
            catch
            {
                MessageBox.Show("A Problem Has Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
