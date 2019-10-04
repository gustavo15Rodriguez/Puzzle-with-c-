using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rompecabezas
{
    public partial class Form1 : Form
    {
        public int contador;
        public Form1()
        {
            InitializeComponent();
            contador = 0;
            timer1.Enabled = false;
        }

        OpenFileDialog openFileDialog = null;
        Image image;
        Image imageMuestra;
        PictureBox picBoxWhole = null;
        PictureBox picBoxWholeMuestra = null;
        public void ButtonImageBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog == null)
                openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxImagePath.Text = openFileDialog.FileName;
                image = CreateBitmapImage(Image.FromFile(openFileDialog.FileName));
                imageMuestra = CreateBitmapImageMuestra(Image.FromFile(openFileDialog.FileName));
                if (picBoxWhole == null)
                {
                    picBoxWhole = new PictureBox();
                    picBoxWholeMuestra = new PictureBox();

                    picBoxWhole.Height = groupBoxPuzzle.Height;
                    picBoxWhole.Width = groupBoxPuzzle.Width;
                    groupBoxPuzzle.Controls.Add(picBoxWhole);

                    picBoxWholeMuestra.Height = groupBoxGuia.Height;
                    picBoxWholeMuestra.Width = groupBoxGuia.Width;
                    groupBoxGuia.Controls.Add(picBoxWholeMuestra);
                }

                picBoxWhole.Image = image;
                picBoxWholeMuestra.Image = imageMuestra;
            }
        }

        private Bitmap CreateBitmapImageMuestra(Image image)
        {
            Bitmap objBmpImageMuestra = new Bitmap(groupBoxGuia.Width, groupBoxGuia.Height);
            Graphics objGraphicsMuestra = Graphics.FromImage(objBmpImageMuestra);
            objGraphicsMuestra.Clear(Color.White);
            objGraphicsMuestra.DrawImage(image, new Rectangle(0, 0, groupBoxGuia.Width, groupBoxGuia.Height));
            objGraphicsMuestra.Flush();

            return objBmpImageMuestra;
        }

        private Bitmap CreateBitmapImage(Image image)
        {
            Bitmap objBmpImage = new Bitmap(groupBoxPuzzle.Width, groupBoxPuzzle.Height);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.Clear(Color.White);
            objGraphics.DrawImage(image, new Rectangle(0, 0, groupBoxPuzzle.Width, groupBoxPuzzle.Height));
            objGraphics.Flush();

            return objBmpImage;
        }

        PictureBox[] picBoxes = null;
        Image[] images = null;
        const int START = 16;
        //int currentLevel = 16;
        //const int START = 4;
        int currentLevel = 4;
        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog != null)
            { 
                currentLevel = START;
                labelStatus.Text = "Acaba de iniciar el juego. Tienes 15 minutos. ¡Animo!";
                PlayStart();
                contador = 0;
                timer1.Enabled = true;
                progressBar1.Value = 0;
                groupBoxPuzzle.Enabled = true;
            }

            else
            {
                labelStatus.Text = "Antes de iniciar el juego debes selecionar una imagen.";
            }

        }

        public void PlayStart()
        {
            if (picBoxWhole != null)
            {
                groupBoxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }

            if (picBoxes == null)
            {
                images = new Image[currentLevel];
                picBoxes = new PictureBox[currentLevel];
            }

            int numRow = (int)Math.Sqrt(currentLevel);
            int numCol = numRow;
            int unitX = groupBoxPuzzle.Width / numRow;
            int unitY = groupBoxPuzzle.Height / numCol;
            int[] indice = new int[currentLevel];

            for (int i = 0; i < currentLevel; i++)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                { 
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }

                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;

                ((MyPictureBox)picBoxes[i]).Index = i;

                CreateBitmapImage(image, images, i, numRow, numCol, unitX, unitY);

                picBoxes[i].Location = new Point(unitX * (i % numCol), unitY * (i / numCol));
                if (!groupBoxPuzzle.Controls.Contains(picBoxes[i]))
                    groupBoxPuzzle.Controls.Add(picBoxes[i]);
            }

            shuffle(ref indice);
            for (int i = 0; i < currentLevel; i++)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).ImageIndex = indice[i];
            }
        }

        private void CreateBitmapImage(Image image, Image [] images, int index, int numRow, int numCol, int unitX, int unitY)
        {
            images[index] = new Bitmap(unitX, unitY);
            Graphics objGraphics = Graphics.FromImage(images[index]);
            objGraphics.Clear(Color.White);
            
            objGraphics.DrawImage(image,
                new Rectangle(0, 0, unitX, unitY),
                new Rectangle(unitX * (index % numCol), unitY * (index / numCol), unitX, unitY),
                GraphicsUnit.Pixel);
            objGraphics.Flush();
        }

        private void shuffle(ref int[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
        MyPictureBox firstBox = null;
        MyPictureBox secondBox = null;
        public void OnPuzzleClick(object sender, EventArgs e)
        {
            //((MyPictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
            if (firstBox == null)
            {
                firstBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.FixedSingle;
            }

            else if (secondBox == null)
            {
                secondBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
                secondBox.BorderStyle = BorderStyle.FixedSingle;
                SwitchImages(firstBox, secondBox);
                firstBox = null;
                secondBox = null;
            }
 
        }

        private void SwitchImages(MyPictureBox box1, MyPictureBox box2)
        {
            int tmp = box2.ImageIndex;
            box2.Image = images[box1.ImageIndex];
            box2.ImageIndex = box1.ImageIndex;
            box1.Image = images[tmp];
            box1.ImageIndex = tmp;

            if (isSuccessful())
            {
                labelStatus.Text = "Lo has logrado, ¡Felicitaciones!";
                this.timer1.Enabled = false;
                groupBoxPuzzle.Enabled = false;
            }

        }
        private bool isSuccessful()
        {
            for (int i = 0; i < currentLevel; i++)
            {
                if (((MyPictureBox)picBoxes[i]).ImageIndex != ((MyPictureBox)picBoxes[i]).Index)
                    return false;
            }
            return true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true) { 
                contador +=1;
                labelContador.Text = contador.ToString();
            }

            if (contador == 900)
            {
                this.timer1.Enabled = false;
                labelStatus.Text = "Lo sentimos, tu tiempo ha espirado. ¡Intentalo Una vez mas!";
            }

            if (progressBar1.Value < 900)
            {
                progressBar1.Value++;
            }

            if (progressBar1.Value == 900)
            {
                timer1.Enabled = false;
                groupBoxPuzzle.Enabled = false;
            }

            if (progressBar1.Value == 750)
            {
                labelStatus.Text = "¡Advertencia! Tu tiempo esta acabando. ";
            }
        }

    }
}
