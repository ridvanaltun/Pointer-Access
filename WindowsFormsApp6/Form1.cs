using System;
using System.Windows.Forms;
using System.Diagnostics;
using memory;
using System.Drawing;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Media;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        Bellek oku;
        Int64 anaAdres = 0;
        string exeName = "explorer";
        Boolean status = false;
        string crypterPass = "qwerty123hbfdshg87D";
        string searchName = "";
        string formName = "Pointer Access";
        string compareProcess = "";

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                selectButton.Enabled = false;
                timer1.Enabled = false;
                listView1.Enabled = false;
                useButton.Enabled = true;
                toolStripStatusLabel2.Text = listView1.CheckedItems.Count + "\t process selected,\t";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listProcess();

            timer1.Enabled = true;
            listView1.Enabled = true;
            useButton.Enabled = false;
            toolStripStatusLabel2.Text = listView1.CheckedItems.Count + "\t process selected,\t";
        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count >0){selectButton.Enabled = true;}
            else{selectButton.Enabled = false;}

            checkContextMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID", 75);
            listView1.Columns.Add("Process Name", 100);
            listProcess();

            changeThisText();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //Keep the width not changed.
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
            //Cancel the event.
            e.Cancel = true;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listView1.Items.Count;i++)
            {
                listView1.Items[i].Checked = true;
            }
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].Checked = false;
            }
        }

        private void listProcess()
        {
            listView1.Items.Clear();
            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                if(theprocess.ProcessName.Contains(searchName))
                {
                    string[] bilgiler = { theprocess.Id.ToString(),theprocess.ProcessName};
                    listView1.Items.Add(new ListViewItem(bilgiler));
                }
            }
        }

        private void checkContextMenu()
        {
            if (listView1.Items.Count > 0)
            {
                contextMenuStrip1.Enabled = true;
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                selectButton.Enabled = true;
                selectButton_Click(sender, e);
            }
            else
            {
                selectButton.Enabled = false;
            }

            checkContextMenu();
            
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            if(Properties.Settings.Default.hideGoster)
            {
                notifyIcon1.BalloonTipTitle = "You can find the program here!";
                notifyIcon1.BalloonTipText = "Yes i am here.";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(10000);
                Properties.Settings.Default.hideGoster = false;
                Properties.Settings.Default.Save();
            }

            
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void useButton_Click(object sender, EventArgs e)
        {
            if(useButton.Text == "USE")
            {
                panel2.Enabled = false;
                panel3.Enabled = false;
                useButton.Text = "WORKING";
                useButton.ForeColor = Color.Green;
                refreshButton.Enabled = false;

                notifyIcon1.Icon = new System.Drawing.Icon("C:/Users/ridva/Desktop/WindowsFormsApp6/WindowsFormsApp6/Resources/green.ico");
                notifyIcon1.Text = "Active";

                toolStripStatusLabel3.ForeColor = Color.Green;
                toolStripStatusLabel3.Text = "ACTIVE";

                if (Properties.Settings.Default.notifyGoster)
                {
                    notifyIcon1.BalloonTipTitle = "Active";
                    notifyIcon1.BalloonTipText = "Program sağ alt köşede konumlandı.";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
                    notifyIcon1.ShowBalloonTip(15000);
                    Properties.Settings.Default.notifyGoster = false;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                panel2.Enabled = true;
                panel3.Enabled = true;
                useButton.ForeColor = Color.Black;
                useButton.Text = "USE";
                refreshButton.Enabled = true;

                notifyIcon1.Icon = new System.Drawing.Icon("C:/Users/ridva/Desktop/WindowsFormsApp6/WindowsFormsApp6/Resources/red.ico");
                notifyIcon1.Text = "Passive";

                toolStripStatusLabel3.ForeColor = Color.Red;
                toolStripStatusLabel3.Text = "PASSIVE";
            }

            //METHOD 1 FAIL
            
            Process[] prc = Process.GetProcessesByName("explorer");
            oku = new Bellek(prc[0]);

            foreach (ProcessModule modul in prc[0].Modules)
            {
                if (modul.ModuleName == "explorer.exe")
                {
                    anaAdres = modul.BaseAddress.ToInt64();
                    //processLabel.Text = "sssd";
                }
                //processLabel.Text = modul.ModuleName;

            }
            

            //Program 64 bit debug modunda patlıyor bu yüzden realase de build yap, 32 bit debug modunda ne oluyoır blmiyorum ama ondada muhtemelen aynı şey olur
            //deger = oku.Int_OKU_Offset(anaAdres + yanDeger, new int[] { offset1, offset2, offset3, offset4, offset5, offset6 });
            //deger = oku.Int_OKU_Offset(anaAdres + yanDeger, "338+789+e8+c4+40";
            //offsetler alttan üste doğruu cheat engine ile alıyorsan eğer
            // eğer ilk oku. yı kullanacaksan offset1 falan yerlere 0x338 falan olması gerekiyor
            // yan değer misal 00068c7 falansa başındaki sıfırları silip 0x68c7 yazabilirsin, fark etmiyor
            // yan deger her halukarda başında 0x var unutma
            // offset ve yandeğer yazan yerler Int32

            // METHOD 2 FAIL
            /*
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if(listView1.Items[i].Checked == true)
                {
                    string ID = listView1.Items[i].SubItems[0].Text;

                    Process localById = Process.GetProcessById(Int32.Parse(ID));
                    oku = new Bellek(exeName);

                    foreach (ProcessModule modul in localById.Modules)
                    {
                        if (modul.ModuleName == exeName + ".exe")
                        {
                            anaAdres = modul.BaseAddress.ToInt64();
                            processLabel.Text = "sd";
                        }
                        processLabel.Text = modul.ModuleName;
                    }

                }
            }*/

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (temporaryRadioButton.Checked)
            {
                offsetsTextBox.Enabled = false;

            }
            else if (permanentRadioButton.Checked)
            {
                offsetsTextBox.Enabled = true;
            }

            if (temporaryRadioButton.Checked)
            {
                modulTextBox.Enabled = false;
            }
            else
            {
                modulTextBox.Enabled = true;
            }
        }
        
        //For Info

        private void q1_Click(object sender, EventArgs e)
        {
            Form2 q1 = new Form2();
            q1.Name = "question1";
            if (Application.OpenForms["question1"] == null)
            {
                q1.Show();
            }
        }

        private void q2_Click(object sender, EventArgs e)
        {
            Form3 q2 = new Form3();
            q2.Name = "question2";
            if (Application.OpenForms["question2"] == null)
            {
                q2.Show();
            }

        }

        private void q3_Click(object sender, EventArgs e)
        {
            Form4 q3 = new Form4();
            q3.Name = "question3";
            if (Application.OpenForms["question3"] == null)
            {
                q3.Show();
            }
        }

        private void q4_Click(object sender, EventArgs e)
        {
            Form5 q4 = new Form5();
            q4.Name = "question4";
            if (Application.OpenForms["question4"] == null)
            {
                q4.Show();
            }
        }

        //save-load

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pointer Access|*.pa";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(Encrypt.EncryptString("buraya data gelecek", crypterPass));
                Kayit.Close();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "pa files (*.pa)|*.pa";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            //processLabel.Text = Encrypt.DecryptString(myStream.ToString(), crypterPass);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        public static class Encrypt
        {
            // This size of the IV (in bytes) must = (keysize / 8).  Default keysize is 256, so the IV must be
            // 32 bytes long.  Using a 16 character string here gives us 32 bytes when converted to a byte array.
            private const string initVector = "demgail9uzpgzl81";
            // This constant is used to determine the keysize of the encryption algorithm
            private const int keysize = 256;
            //Encrypt
            public static string EncryptString(string plainText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return Convert.ToBase64String(cipherTextBytes);
            }
            //Decrypt
            public static string DecryptString(string cipherText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
        }

        private void openAnotherPA_Click(object sender, EventArgs e)
        {
            Process.Start(System.AppDomain.CurrentDomain.FriendlyName, System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back && !string.IsNullOrEmpty(searchName))
            {
                searchName = searchName.Remove(searchName.Length-1);
            }
            else if(e.KeyChar != (char)Keys.Back)
            {
                searchName = string.Concat(searchName, e.KeyChar.ToString());
            }

            if(string.IsNullOrEmpty(searchName))
            {
                changeThisText();
            }
            else
            {
                this.Text = formName + " - " + searchName;
                listProcess();
            }
        }
    
        private void changeThisText()
        {
            Process[] paProcess = Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            this.Text = "Process Access" + " " + "[" + paProcess.Length + "]";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
              SoundPlayer player = new SoundPlayer();
              string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+"/Sounds/"+(comboBox1.SelectedIndex+1)+".wav";
              player.SoundLocation = path;
              player.Play();
        }
    }
}
