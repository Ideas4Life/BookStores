using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Книжный_магазин.Properties;

namespace Книжный_магазин
{
    public partial class AddBooks : Form
    {
        Жанры generes;

        public AddBooks()
        {
            InitializeComponent();
        }
        public void Initialize(Жанры geners)
        {
            generes = geners;
        }

        private void back_addBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            //if (login.bLogin)
            //    loginRegistr.Show();
            generes.Show();
        }

        private void addPicture1_Click(object sender, EventArgs e)
        {
            if (tBAuthor1.Text!="")
            {
                OpenFileDialog OPF = new OpenFileDialog();
                OPF.Filter = "Text files("+ tBAuthor1.Text+ ".jpg)|" + tBAuthor1.Text + ".jpg|(" + tBAuthor1.Text + ".png)|" + tBAuthor1.Text + ".png";
                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    if (OPF.ShowDialog() == DialogResult.Cancel)
                        return;
                    // получаем выбранный файл
                    string filename = OPF.FileName;
                    var image = Image.FromFile(OPF.FileName);

                    /*
                    var asmName = new AssemblyNameDefinition("DynamicAssembly", new Version(1, 0, 0, 0));
                    var assembly = AssemblyDefinition.CreateAssembly(asmName, "<Module>", ModuleKind.Dll);
                    string imageFilePath = @"C:\Users\kalinov\Desktop\20.jpg";
                    byte[] imageData = File.ReadAllBytes(imageFilePath);
                    var imageResource = new EmbeddedResource("SomeImage.jpg", ManifestResourceAttributes.Private, imageData);
                    assembly.MainModule.Resources.Add(imageResource);
                    string desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string assemblyPath = Path.Combine(desktopDirectory, "DynamicAssembly.dll");
                    assembly.Write(assemblyPath);
                    */
                    
                    MessageBox.Show("Изображение принято");
                }
            }
        }
    }
}
