using System.Text;
using System.Windows.Forms;

namespace TimeShiftSRT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFilename_DragDrop(object sender, DragEventArgs e)
        {
            if (e == null)
            {
                return;
            }
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //}
            txtFilename.Text = files[0];
        }

        private void txtFilename_DragEnter(object sender, DragEventArgs e)
        {
            if (e == null)
            {
                return;
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }

        }

        private void cmdFileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Subtitle (SRT)|*.srt|All (*.*)|*.*";
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            fileDialog.FilterIndex = 0;
            fileDialog.Title = "Select a file";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = fileDialog.FileName;
            }//if
        }

        private void cmdShift_Click(object sender, EventArgs e)
        {
            TimeSpan shiftSpan;
            StringBuilder output= new StringBuilder();
            try
            {
                shiftSpan = TimeSpan.FromSeconds(double.Parse(txtShift.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not parse Time Shift. " + ex.Message);
                return;
            }
            if(chkBackup.Checked)
            {
                try
                {
                    string backup = txtFilename.Text + ".bak";
                    if (File.Exists(backup))
                    {
                        File.Delete(backup);
                    }
                    File.Copy(txtFilename.Text, backup);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not save backup file. " + ex.Message);
                }
            }
            using (StreamReader sr = new StreamReader(txtFilename.Text))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    // if it's a "time" line
                    if (line.Length > 22 && line.Substring(2,1) == ":" && line.Substring(5,1) == ":")
                    {
                        string startTimeStr = line.Substring(0, 12);
                        string endTimeStr = line.Substring(17, 12);
                        TimeOnly start = new TimeOnly();
                        TimeOnly end = new TimeOnly();
                        TimeOnly.TryParseExact(startTimeStr, "HH:mm:ss,fff", out start);
                        start = start.Add(shiftSpan);
                        TimeOnly.TryParseExact(endTimeStr, "HH:mm:ss,fff", out end);
                        end = end.Add(shiftSpan);
                        output.AppendFormat("{0:HH:mm:ss,fff} --> {1:HH:mm:ss,fff}\r\n", start, end);
                    }
                    else
                    {
                        output.AppendLine(line);
                    }
                    line = sr.ReadLine();
                }
            }
            //MessageBox.Show(output.ToString().Substring(0,500));
            // rewrite the file
            try
            {
                using (StreamWriter sw = new StreamWriter(txtFilename.Text))
                {
                    sw.Write(output.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not write updated file. " + ex.Message);
            }
        }
    }
}