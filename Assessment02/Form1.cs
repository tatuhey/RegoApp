namespace Assessment02
{
    public partial class Form1 : Form
    {
        private const string V = "Duplicate rego.";
        List<string> regoList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            ststripRego.Text = "";
        }

        private void statusStripReset()
        {
            ststripRego.Text = "";
            ststripRego.BackColor = Color.Empty;
        }

        private void duplicateRego()
        {
            ststripRego.Text = "Duplicate rego.";
            ststripRego.BackColor = Color.Red;
        }

        private void blankRego()
        {
            ststripRego.Text = "Blank rego.";
            ststripRego.BackColor = Color.Yellow;
        }

        private void regoNotFound()
        {
            ststripRego.Text = "Rego is not found.";
            ststripRego.BackColor = Color.Red;
        }

        private void updateListBox()
        {
            lstboxRego.Items.Clear();
            regoList.Sort();
            for (int i = 0; i < regoList.Count; i++)
            {
                lstboxRego.Items.Add(regoList[i]);
                statusStripReset();
            }
        }

        public int selectedRegoIndex = 0;

        private void lstboxRego_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstboxRego.SelectedIndex >= 0)
            {
                tbxInputRego.Text = lstboxRego.SelectedItem.ToString();
                selectedRegoIndex = lstboxRego.SelectedIndex;
            }
        }

        private void btnOpenRego_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "..\\Assessment02";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (var sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            regoList.Add(line);
                        }
                    }
                }
            }
            updateListBox();
        }

        private void btnEnterRego_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxInputRego.Text))
            {
                if (!regoList.Contains(tbxInputRego.Text))
                {
                    regoList.Add(tbxInputRego.Text);
                    updateListBox();
                }
                else
                {
                    duplicateRego();
                }
            }
            else
            {
                blankRego();
            }
        }

        private void btnExitRego_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxInputRego.Text))
            {
                regoList.Remove(tbxInputRego.Text);
                updateListBox();
            }
            else
            {
                blankRego();
            }

        }

        private void btnEditRego_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxInputRego.Text) || lstboxRego.Select == null)
            {
                if (!regoList.Contains(tbxInputRego.Text) && lstboxRego.Select == null)
                {
                    regoList[lstboxRego.SelectedIndex] = tbxInputRego.Text;
                    updateListBox();
                }
                else if (!regoList.Contains(tbxInputRego.Text) && lstboxRego.Select != null)
                {
                    MessageBox.Show("Cannot edit non existent rego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    duplicateRego();
                }
            }
            else
            {
                blankRego();
            }
        }

        private void btnResetRego_Click(object sender, EventArgs e)
        {
            regoList.Clear();
            tbxInputRego.Clear();
            updateListBox();

        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxInputRego.Text))
            {
                int index = regoList.BinarySearch(tbxInputRego.Text);
                string temp = tbxInputRego.Text;
                if (index >= 0)
                {
                    MessageBox.Show($"Rego {temp} is found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show($"Rego {temp} is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    regoNotFound();
                    tbxInputRego.Clear();
                }
            }
            else
            {
                MessageBox.Show("Texbox is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                blankRego();
            }
        }

        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxInputRego.Text))
            {
                string temp = tbxInputRego.Text;
                bool linear = false;
                for (int i = 0; i < regoList.Count; i++)
                {
                    if (regoList[i] == tbxInputRego.Text)
                    {
                        linear = true;
                    }
                }
                if (linear)
                {
                    MessageBox.Show($"Rego {temp} is found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show($"Rego {temp} is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    regoNotFound();
                    tbxInputRego.Clear();
                }
            }
            else
            {
                MessageBox.Show("Texbox is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                blankRego();
            }
        }
    }
}