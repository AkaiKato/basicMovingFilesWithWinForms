using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3HM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startFunc();
        }

        private static string fromDirName = Directory.GetCurrentDirectory();
        private static string toDirName = Directory.GetCurrentDirectory();

        static Regex regex = new Regex(@"([A-Za-z]:\\)((?:.*\\)?)");

        public void startFunc()
        {
            fromTextBox.Text = fromDirName;
            toTextBox.Text = toDirName;
            fillListBox(fromListBox, fromTextBox);
            fillListBox(toListBox, toTextBox);
        }

        private void backFromButton_Click(object sender, EventArgs e)
        {
            if (checkParentPath(fromDirName))
            {
                fromDirName = Directory.GetParent(fromDirName).ToString();
                fromTextBox.Text = fromDirName;
                fillListBox(fromListBox, fromTextBox);
            }
        }

        private void backToButton_Click(object sender, EventArgs e)
        {
            if (checkParentPath(toDirName))
            {
                toDirName = Directory.GetParent(toDirName).ToString();
                toTextBox.Text = toDirName;
                fillListBox(toListBox, toTextBox);
            }
        }

        private bool checkParentPath (string dirName)
        {
            if (Directory.GetParent(dirName) != null)
                return true;
            else
            {
                MessageBox.Show("Дальше вернуться невозможно!", "Внимание!");
                return false;
            }
        }

        private void fillListBox(ListBox listBox, TextBox path)
        {
            listBox.Items.Clear();

            string[] dirs = Directory.GetDirectories(path.Text.ToString());
            listBox.Items.AddRange(getNames(dirs));

            string[] files = Directory.GetFiles(path.Text.ToString());
            listBox.Items.AddRange(getNames(files));
        }

        private void checkRightPath(ListBox listBox, TextBox textBox, bool path)
        {
            if (regex.IsMatch(textBox.Text.ToString()) && Directory.Exists(textBox.Text.ToString()))
            {
                if (path)
                    fromDirName = textBox.Text.ToString();
                else
                    toDirName = textBox.Text.ToString(); 
                fillListBox(listBox, textBox);
            }
            else
            {
                MessageBox.Show("Проверьте правильность написания пути!", "Внимание!");
                if (path)
                    textBox.Text = fromDirName;
                else
                    textBox.Text = toDirName;
            }
        }

        private void fromTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                checkRightPath(fromListBox, fromTextBox, true);
        }

        private void toTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                checkRightPath(toListBox, toTextBox, false);
        }

        private string[] getNames(string[] strings)
        {
            string[] dirsName = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                var buf = strings[i].ToString().Split('\\');
                dirsName[i] = buf[buf.Length - 1];
            }
            return dirsName;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            var selectedItems = fromListBox.SelectedItems;

            foreach (var item in selectedItems)
            {
                string filePath = fromDirName + "\\" + item.ToString();
                string destPath = toDirName + "\\" + item.ToString();
                if(File.Exists(filePath))
                    File.Move(filePath, destPath);
                if (Directory.Exists(filePath))
                {
                    if (filePath != toDirName && filePath != destPath)
                        Directory.Move(filePath, destPath);
                    else if (filePath == destPath)
                        MessageBox.Show($"Исходный и результирующий путь должны различаться.", "Внимание!");
                    else
                        MessageBox.Show($"Невозможно переместить папку: {item.ToString()} \nТак как в нее происходит перемещение.", "Внимание!");
                }
            }
            fillListBox(fromListBox, fromTextBox);
            fillListBox(toListBox, toTextBox);
        }

        private void fromListBox_DoubleClick(object sender, EventArgs e)
        {
            if(Directory.Exists(fromDirName + "\\" + fromListBox.SelectedItem))
            {
                fromDirName = fromDirName + "\\" + fromListBox.SelectedItem;
                fromTextBox.Text = fromDirName;
                fillListBox(fromListBox, fromTextBox);
            }
        }

        private void toListBox_DoubleClick(object sender, EventArgs e)
        {
            if (Directory.Exists(toDirName + "\\" + toListBox.SelectedItem))
            {
                toDirName = toDirName + "\\" + toListBox.SelectedItem;
                toTextBox.Text = toDirName;
                fillListBox(toListBox, toTextBox);
            }
        }
    }
}
