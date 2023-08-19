using System.Security.Cryptography;
using System.Text;

namespace File_Encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string selFile = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = selFile;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selFile = ofd.FileName;
                label2.Text = selFile;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!File.Exists(selFile))
            {
                MessageBox.Show("Please select a valid file to encrypt");
                return;
            }
            SHA256 hash = SHA256.Create();
            byte[] key = hash.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text)).Take(16).ToArray();
            MessageBox.Show(key[0].ToString("X2"));
            FileStream reader = new FileStream(selFile, FileMode.Open, FileAccess.Read);
            FileStream writer = new FileStream(selFile + ".aes", FileMode.Create, FileAccess.Write);
            AES aes = new AES(key);
            writer.Write(aes.getNonce());
            byte[][] buffer = new byte[256][];
            ulong block = 0;
            bool done = false;
            while (!done)
            {
                int b = 0;
                for (int i = 0; i < 256; i++)
                {
                    buffer[i] = new byte[16];
                    int len = reader.Read(buffer[i], 0, 16);
                    if (len < 16)
                    {
                        if (len > 0)
                        {
                            byte[] temp = buffer[i];
                            buffer[i] = new byte[len];
                            for (int j = 0; j < len; j++)
                            {
                                buffer[i][j] = temp[j];
                            }
                            b++;
                        }
                        done = true;
                        break;
                    }
                    b++;
                }

                Parallel.For(0, b, i =>
                {
                    buffer[i] = aes.encryptBlock(buffer[i], block + (ulong)i);
                });

                for (int i = 0; i < b; i++)
                {
                    writer.Write(buffer[i]);
                }
                block += 256;
            }

            reader.Close();
            writer.Close();
            MessageBox.Show("Done");

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!File.Exists(selFile))
            {
                MessageBox.Show("Please select a valid file to decrypt");
                return;
            }
            SHA256 hash = SHA256.Create();
            byte[] key = hash.ComputeHash(Encoding.UTF8.GetBytes(textBox1.Text)).Take(16).ToArray();
            FileStream reader = new FileStream(selFile, FileMode.Open, FileAccess.Read);
            FileStream writer = new FileStream(selFile.Substring(0, selFile.Length - 4), FileMode.Create, FileAccess.Write);
            byte[] nonce = new byte[16];
            reader.Read(nonce, 0, 16);
            AES aes = new AES(key, nonce);
            byte[][] buffer = new byte[256][];
            ulong block = 0;
            bool done = false;
            while (!done)
            {
                int b = 0;
                for (int i = 0; i < 256; i++)
                {
                    buffer[i] = new byte[16];
                    int len = reader.Read(buffer[i], 0, 16);
                    if (len < 16)
                    {
                        if (len > 0)
                        {
                            byte[] temp = buffer[i];
                            buffer[i] = new byte[len];
                            for (int j = 0; j < len; j++)
                            {
                                buffer[i][j] = temp[j];
                            }
                            b++;
                        }
                        done = true;
                        break;
                    }
                    b++;
                }

                Parallel.For(0, b, i =>
                {
                    buffer[i] = aes.encryptBlock(buffer[i], block + (ulong)i);
                });

                for (int i = 0; i < b; i++)
                {
                    writer.Write(buffer[i]);
                }
                block += 256;
            }
            reader.Close();
            writer.Close();
            MessageBox.Show("Done");
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            btnSelect.Focus();
        }
    }
}