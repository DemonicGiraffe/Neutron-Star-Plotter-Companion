using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;
using Spire.Xls.Converter;


namespace NeutronStarPlotterCompanion
{
    public partial class Form1 : Form
    {
        public string JumpsHeader { get; set; }
        public int JumpVal { get; set; }
        public int IntitSum { get; set; }

        public Form1()
        {

            InitializeComponent();
            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)Keys.NumPad1);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID1, 0, (int)Keys.NumPad2);
            
    }
        private void button1_Click(object sender, EventArgs e)
        {
            //button1 AKA "browse"
            //the following snippet opens a system explorer to find the CSV file
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV document(*.csv)|*.csv";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try {
                    RFWarn.Visible = false;
                    progressBar1.Value = 0;
                string csvFile = dialog.FileName;
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(csvFile, ",");
                Worksheet worksheet = workbook.Worksheets[0];
                System.Data.DataTable t = worksheet.ExportDataTable();
                this.dataGridView1.DataSource = t;
                
                //sets the width of the column so you can see the whole system name
                DataGridViewColumn column = dataGridView1.Columns["System Name"];
                column.Width = 150;

                

                if (dataGridView1.Columns[4].HeaderText == "Jumps") 
                {
                    JumpsHeader = "Jumps";
                    
                }
                else
                {
                    JumpsHeader = dataGridView1.Columns[4].HeaderText;
                }
                Console.WriteLine(JumpsHeader);


                if (JumpsHeader == "Jumps")
                {
                    //calculates the sum of total jumps
                    int sum = 0;
                for (int x = 0; x < dataGridView1.Rows.Count; x++)
                {
                    sum += Convert.ToInt32(dataGridView1.Rows[x].Cells[JumpsHeader].Value);
                }

                 
                Jumps.Text = sum.ToString();
                        Form3 frmWarn = new Form3();
                        frmWarn.Show();
                    }
                if (JumpsHeader == "Fuel Used")
                {
                    int sum = 0;
                    for (int x = 0; x < dataGridView1.Rows.Count; x++)
                    {
                        sum = x;
                    }
                    JumpVal = sum;
                    IntitSum = sum;
                    var Total = sum.ToString();
                    Jumps.Text = Total;
                }

                //setting the groundwork for the realtime jump caluclation as well as setting up the progress bar
                int rownumberammount = dataGridView1.RowCount;
                progressBar1.Maximum = rownumberammount;
                textBox1.Text = "File opened Successfully!";
                //updates start point and endpoint title
                string cell = dataGridView1.Rows[0].Cells["System Name"].Value.ToString();
                string cell2 = dataGridView1.Rows[rownumberammount - 1].Cells["System Name"].Value.ToString();
                textBox2.Text = "You are traveling from " + cell + " to " + cell2;
                }
                catch
                {
                    MessageBox.Show("File is in use by another process or may be unsupported. Please end that process and try again.", "Error");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Next_Data_Click(object sender, EventArgs e)
        {

          if(JumpsHeader == "Jumps") 
            {
                
                //function that runs when you click "next"
                try
                {
                    //calculating progress bar percentage
                    int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                    textBox1.Text = percent + "% Traveled";

                    //variables for the remaining jumps calculation
                    int rownum = dataGridView1.CurrentCell.RowIndex;
                    string input = Jumps.Text;
                    int result = Int32.Parse(input);
                    if (result >= 3)
                    {
                        //updating with the updated calculation as well as a check to make sure it's not mis-aligned
                        string input2 = dataGridView1.Rows[rownum].Cells["Jumps"].Value.ToString();
                        int result2 = Int32.Parse(input2);
                        int updatedjumps = (result - result2);
                        Console.WriteLine(updatedjumps);
                        if (updatedjumps >= 1)
                        {
                            Jumps.Text = updatedjumps.ToString();
                        }
                        progressBar1.Value = rownum;

                    }
                    else
                    {
                        //if it fails the mis-alignment check it does the following. this usually takes place if the final jump amount is greater than 0
                        int rownum1 = dataGridView1.CurrentCell.RowIndex;
                        string input1 = Jumps.Text;
                        int result1 = Int32.Parse(input);
                        string input2 = dataGridView1.Rows[rownum].Cells["Jumps"].Value.ToString();
                        int result2 = Int32.Parse(input2);
                        int updatedjumps = (result - result2);
                        Jumps.Text = result2.ToString();
                        progressBar1.Value = (rownum + 1);
                    }
                }


                catch
                {
                    MessageBox.Show("the row number has come back with an invalid value");
                }
                try
                {
                    //this is what moves the selection down within the datagridview
                    int col = dataGridView1.CurrentCell.ColumnIndex;
                    int row = dataGridView1.CurrentCell.RowIndex;
                    if (col < dataGridView1.ColumnCount - 1)
                    {
                        col = 0;
                        row++;
                    }
                    else
                    {
                        col = 0;
                        row++;
                    }

                    if (row == dataGridView1.RowCount)

                        textBox1.Text = "File Error";
                    try
                    {
                        dataGridView1.CurrentCell = dataGridView1[col, row];
                    }
                    catch
                    {
                        //when you reach the last cell
                        textBox1.Text = "End of File";
                    }
                    //automatically copies the Cell data to the users clipboard
                    string value = dataGridView1.CurrentCell.Value.ToString();
                    System.Windows.Forms.Clipboard.SetText(value);
                }
                catch
                {
                    //if the button is pressed without a file loaded
                    MessageBox.Show("Please Select a File", "Error");
                }
            }
          if (JumpsHeader == "Fuel Used")
            {
                //calculating progress bar percentage
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                textBox1.Text = percent + "% Traveled";

                int rownum = dataGridView1.CurrentCell.RowIndex;
                try {

                if (dataGridView1.Rows[rownum+1].Cells["Refuel"].Value.ToString() == "Yes")
                {
                    RFWarn.Visible = true;
                }
                if (dataGridView1.Rows[rownum + 1].Cells["Refuel"].Value.ToString() == "No")
                {
                    RFWarn.Visible = false;
                }
                }
                catch
                {

                };


                if (JumpVal > 0)
                {
                    JumpVal = JumpVal - 1;
                }

                var Total = JumpVal.ToString();

                try
                {
                    //this is what moves the selection up within the datagridview
                    int col = dataGridView1.CurrentCell.ColumnIndex;
                    int row = dataGridView1.CurrentCell.RowIndex;
                    if (col < dataGridView1.ColumnCount - 1)
                    {
                        col = 0;
                        row++;
                    }
                    else
                    {
                        col = 0;
                        row++;
                    }

                    if (row == dataGridView1.RowCount)
                        textBox1.Text = "File Error";
                    try
                    {
                        dataGridView1.CurrentCell = dataGridView1[col, row];
                    }
                    catch
                    {
                        //when the top of the file is reached
                        textBox1.Text = "End of file";
                    }
                    //automatically copies the Cell data to the users clipboard
                    string value = dataGridView1.CurrentCell.Value.ToString();
                    System.Windows.Forms.Clipboard.SetText(value);
                    progressBar1.Value = rownum;
                    Jumps.Text = Total;//dataGridView1.Rows[rownum].Cells[JumpsHeader].Value.ToString();
                    
                }
                catch
                {
                    //if the "prev" button was pressed without a file loaded
                    MessageBox.Show("Please Select a File", "Error");
                }

            }
        }


        private void previous_Data_Click(object sender, EventArgs e)
        {

            if (JumpsHeader == "Jumps") { 
          //function that runs when you click "prev"
            try
            {
                //calculating progress bar percentage
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                textBox1.Text = percent + "% Traveled";

                //variables for the remaining jumps calculation
                int rownum = dataGridView1.CurrentCell.RowIndex -1;
                string input = Jumps.Text;
                int result = Int32.Parse(input);
                //updating with the updated calculation
                string input2 = dataGridView1.Rows[rownum].Cells["Jumps"].Value.ToString();
                int result2 = Int32.Parse(input2);
                int updatedjumps = (result2 + result);
                Jumps.Text = updatedjumps.ToString();
            }
            //if the user clicked "prev" at the top of the file
            catch { textBox1.Text = "wrong way buddy!"; }

            try
            {
                //this is what moves the selection up within the datagridview
                int col = dataGridView1.CurrentCell.ColumnIndex;
                int row = dataGridView1.CurrentCell.RowIndex;
                if (col < dataGridView1.ColumnCount - 1)
                {
                    col = 0;
                    row--;
                }
                else
                {
                    col = 0;
                    row--;
                }

                if (row == dataGridView1.RowCount)
                    textBox1.Text = "File Error";
                try
                {
                    dataGridView1.CurrentCell = dataGridView1[col, row];
                }
                catch
                {
                        //when the top of the file is reached
                    textBox1.Text = "Beginning of file";
                }
                //automatically copies the Cell data to the users clipboard
                string value = dataGridView1.CurrentCell.Value.ToString();
                int rownum = dataGridView1.CurrentCell.RowIndex;
                System.Windows.Forms.Clipboard.SetText(value);
                progressBar1.Value = rownum;
            }
            catch
            {
                //if the "prev" button was pressed without a file loaded
                MessageBox.Show("Please Select a File","Error");
            }
            }
            if (JumpsHeader =="Fuel Used")
            {
                //calculating progress bar percentage
                int percent = (int)(((double)progressBar1.Value / (double)progressBar1.Maximum) * 100);
                textBox1.Text = percent + "% Traveled";
                int rownum = dataGridView1.CurrentCell.RowIndex;
                try
                {
                    if (dataGridView1.Rows[rownum + 1].Cells["Refuel"].Value.ToString() == "Yes")
                    {
                        RFWarn.Visible = true;
                    }
                    if (dataGridView1.Rows[rownum + 1].Cells["Refuel"].Value.ToString() == "No")
                    {
                        RFWarn.Visible = false;
                    }
                }
                catch
                {

                };

                if (JumpVal < IntitSum)
                {
                    JumpVal = JumpVal + 1;
                }

                var Total = JumpVal.ToString();

                try
                {
                    //this is what moves the selection up within the datagridview
                    int col = dataGridView1.CurrentCell.ColumnIndex;
                    int row = dataGridView1.CurrentCell.RowIndex;
                    if (col < dataGridView1.ColumnCount - 1)
                    {
                        col = 0;
                        row--;
                    }
                    else
                    {
                        col = 0;
                        row--;
                    }

                    if (row == dataGridView1.RowCount)
                        textBox1.Text = "File Error";
                    try
                    {
                        dataGridView1.CurrentCell = dataGridView1[col, row];
                    }
                    catch
                    {
                        //when the top of the file is reached
                        textBox1.Text = "Beginning of file";
                    }
                    //automatically copies the Cell data to the users clipboard
                    string value = dataGridView1.CurrentCell.Value.ToString();
                    System.Windows.Forms.Clipboard.SetText(value);
                    progressBar1.Value = rownum;
                    Jumps.Text = Total;//dataGridView1.Rows[rownum].Cells[JumpsHeader].Value.ToString();
                }
                catch
                {
                    //if the "prev" button was pressed without a file loaded
                    MessageBox.Show("Please Select a File", "Error");
                }

            }
        }




        public int a = 1;
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        //assigning Num1 & Num2 to functions
        const int MYACTION_HOTKEY_ID = 1;
        const int MYACTION_HOTKEY_ID1 = 2;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                previous_Data_Click(null, null);
            }
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID1)
            {
                Next_Data_Click(null, null);
            }
            base.WndProc(ref m);
        }
        //Social Links
        private void Twitch_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/thedemonicgiraffe");
        }

        private void Youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCjDlrNYGUf60Pcfi_3GLFZg");
        }

        private void Twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/DemonicGiraffe");
        }

        private void Discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/HJqfpUd");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.spansh.co.uk/exact-plotter/");
        }

        private void Jumps_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
