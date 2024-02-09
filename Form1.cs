using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace addname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(textBox.Text);
            textBox.Text = "";
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != -1)
            {
                for (int i = ListBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    ListBox1.Items.RemoveAt(ListBox1.SelectedIndices[i]);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            // Check if an item is selected and the textbox has input
            if (ListBox1.SelectedIndex != -1 && !string.IsNullOrEmpty(textBox.Text))
            {
                int selectedIndex = ListBox1.SelectedIndex;
                string newText = textBox.Text;

                // Replace the selected item
                ListBox1.Items[selectedIndex] = newText;

                // Optionally, clear the textbox after substitution
                textBox.Text = "";
            }
            else
            {
                // Handle the case where no item is selected or textbox is empty
                MessageBox.Show("Please select an item in the listbox and enter text in the textbox.");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }
    }
}