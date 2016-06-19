using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using Microsoft.VisualBasic;

namespace TextCoder
{
    public partial class Form1 : Form
    {

        CSharpCodeProvider provider = new CSharpCodeProvider();
        CompilerParameters parameters = new CompilerParameters();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb1.Text = TextCoder.Resources.DefaultCode;
            parameters.GenerateInMemory = true;
            parameters.GenerateExecutable = true;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new string[] { "System.dll", "mscorlib.dll", "System.ComponentModel.dll", "System.Data.dll", "System.Drawing.dll", "System.Linq.dll",
                                                   "System.Threading.Tasks.dll", "System.Windows.Forms.dll"});
        }

        private void runCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                parameters.ReferencedAssemblies.Clear();
                foreach (string s in listBox1.Items)
                    parameters.ReferencedAssemblies.Add(s);
                CompilerResults results = provider.CompileAssemblyFromSource(parameters, rtb1.Text);
                rtb2.Text = "";
                if (results.Errors.HasErrors)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (CompilerError error in results.Errors)
                        sb.AppendLine(String.Format("Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                    rtb2.Text = sb.ToString();
                    return;
                }
                rtb2.AppendText("Compiled successfully.\r\n");
                Assembly assembly = results.CompiledAssembly;
                Type program = assembly.GetType("Code.Program");
                rtb4.Text = (string)program.GetMethod("Execute").Invoke(Activator.CreateInstance(program), new object[] { rtb3.Text });
            }
            catch (Exception ex)
            {
                rtb4.Text = "An exception occured:\r\n" + ex.Message;
            }
        }

        private void splitAndSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Text = TextCoder.Resources.ExampleTemplate.Replace("/*marker*/", TextCoder.Resources.ExampleSplitAndSort);
        }

        private void addDependecyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.dll|*.dll";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                listBox1.Items.Add(Path.GetFileName(d.FileName));
        }

        private void removeDependecyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            listBox1.Items.RemoveAt(n);
        }

        private void loadInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.*|*.*";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtb3.Text = File.ReadAllText(d.FileName);
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "*.txt|*.txt|*.*|*.*";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtb4.SaveFile(d.FileName);
                MessageBox.Show("Done.");
            }
        }

        private void saveCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "*.tcc|*.tcc";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(d.FileName, FileMode.Create, FileAccess.Write);
                WriteInt(fs, listBox1.Items.Count);
                foreach (string s in listBox1.Items)
                    WriteString(fs, s);
                WriteString(fs, rtb1.Text);
                fs.Close();
                MessageBox.Show("Done.");
            }
        }

        private void WriteString(Stream s, string t)
        {
            byte[] buff = Encoding.UTF8.GetBytes(t);
            WriteInt(s, buff.Length);
            s.Write(buff, 0, buff.Length);
        }

        private string ReadString(Stream s)
        {
            int len = ReadInt(s);
            byte[] buff = new byte[len];
            s.Read(buff, 0, len);
            return Encoding.UTF8.GetString(buff);
        }

        private int ReadInt(Stream s)
        {
            byte[] buff = new byte[4];
            s.Read(buff, 0, 4);
            return BitConverter.ToInt32(buff, 0);
        }

        private void WriteInt(Stream s, int i)
        {
            s.Write(BitConverter.GetBytes(i), 0, 4);
        }

        private void loadCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.tcc|*.tcc";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream fs = new FileStream(d.FileName, FileMode.Open, FileAccess.Read);
                int count = ReadInt(fs);
                listBox1.Items.Clear();
                for (int i = 0; i < count; i++)
                    listBox1.Items.Add(ReadString(fs));
                rtb1.Text = ReadString(fs);
                fs.Close();
            }
        }
    }
}
