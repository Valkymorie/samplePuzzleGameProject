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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        public  static string dosyadanOku()
        {
            string dosya_yolu = @"C: \Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\puanlama.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                
                Console.WriteLine(yazi);
                yazi = sw.ReadLine();
            }
            //puan= yazi;
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.

            return yazi;
        }

        private static string dosyayaYaz(String alp)
        {
            string dosya_yolu = @"C: \Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\puanlama.txt";
            //İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            //3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            StreamWriter sw = new StreamWriter(fs);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            
            sw.WriteLine(alp);
            //sw.WriteLine("1.Satır:Merhaba");
            //sw.WriteLine("2.Satır:Dünya");
            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
            return "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            oku();

        }

        private void pictureBox17_MouseClick(object sender, MouseEventArgs e)
        {
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 3;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "3. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\3.jpeg");
                Bitmap b = new Bitmap(pictureBox3.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox3.Enabled = false;
                    label4.Text = "3. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {

                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox3.Image;
                pictureBox3.Image = tutucu;
                
                label1.Text = "3. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\3.jpeg");
                Bitmap b = new Bitmap(pictureBox3.Image);

                if (dogrulama(a, b)){
                   // pictureBox3.Enabled= false;
                label4.Text = "3. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;


                }
                kontrol = 0;
            }
            kontrolReel();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 13;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "13. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\13.jpeg");
                Bitmap b = new Bitmap(pictureBox13.Image);

                if (dogrulama(a, b))
                {
                   // pictureBox13.Enabled = false;
                    label4.Text = "13. KARE DOĞRU";

                }

                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox13.Image;
                pictureBox13.Image = tutucu;
                
                label1.Text = "13. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\13.jpeg");
                Bitmap b = new Bitmap(pictureBox13.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox13.Enabled = false;
                    label4.Text = "13. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }

            kontrolReel();
        }

        Bitmap[,] origin = new Bitmap[4, 4];

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            kontrolSayac = 0;
            

           for(int i =0; i<4; i++)
            {
                for(int j=0; j<4; j++)
                {
                    int index = 4 * i + j;
                    PictureBox pict = this.Controls.Find("pictureBox" + (index + 1).ToString(), true).FirstOrDefault() as PictureBox;
                    pict.Image = btm[i, j];

                }

            }

            
            /*  // bitmap nesnesi oluştur
              Bitmap Screenshot = new Bitmap(this.Width, this.Height);

              // bitmapten grafik nesnesi oluştur
              Graphics GFX = Graphics.FromImage(Screenshot);
          Size s = new Size(1500, 3500);
              // ekrandan programın bulunduğu konumun resmini alalım
              GFX.CopyFromScreen(this.Left+this.Left/4+13, this.Top+this.Top/4+12, 0, 0,this.Size);
          label1.Text = Convert.ToString(this.Left)+"  "+Convert.ToString(this.Top);
          label2.Text = Convert.ToString(this.Right) + "  " + Convert.ToString(this.Bottom) + " "+ Convert.ToString(this.Size);
          label3.Text = Convert.ToString(pictureBox1.Left) + "  " + Convert.ToString(pictureBox1.Top)+" "+ Convert.ToString(s);

          //pictureBox18.Image = Screenshot;
          Screenshot.Save(@"C:\\Users\Hayrullah\Desktop\sss.jpeg"); */

            /*if( dosyadanOku()== null)
                label2.Text="boş";*/
            //KARIŞTIRMA
            /*while (kontrolSayac == 0)
            {
                int[] dizi = new int[17];
                for (int i = 0; i < 17; i++)
                {
                    dizi[i] = 0;
                }
                int sayi = 0;
                Random random = new Random();
                int indis = 0;
                int k = 0;
                int m = 0;
                while (sayi != 16)
                {

                    indis = random.Next(16);
                    if (dizi[indis] == 0)
                    {
                        //index = 4 * i + j;
                        PictureBox pictureB = this.Controls.Find("pictureBox" + (indis + 1).ToString(), true).FirstOrDefault() as PictureBox;
                        pictureB.Image = btm[k, m];
                        pictureB.Image.Save(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\karisik\mixed" + indis + ".jpeg");
                        dizi[indis] = 1;

                        sayi++;
                        m++;
                        if (m == 4)
                        {
                            m = 0;
                            k++;
                        }

                    }

                }

                kontrolReel();

            }*/
                


        }

        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        Bitmap[,] btm = new Bitmap[4, 4];
        int kontrol = 0;
        int dd;


        String line;
        private String oku()
        {
            try
            {

                StreamReader reader = new StreamReader("C:\\Users\\Hayrullah\\Desktop\\WindowsFormsApp1\\WindowsFormsApp1\\WindowsFormsApp1\\puanlama.txt");

                line = reader.ReadLine();

                while (line != null)
                {
                    label2.Text = line;
                    line = reader.ReadLine();
                }
                reader.Close();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return line;

        }
        

        private void pictureBox20_Click(object sender, EventArgs e)
        {


            oku();

            

            OpenFileDialog sec = new OpenFileDialog();
            //sec.ShowDialog();
            String dosyaYolu;
            // pictureBox1.ImageLocation = DosyaYolu;

            if (sec.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = sec.FileName;
                //pictureBox1.Image = new Bitmap(sec.OpenFile
                System.Windows.Forms.MessageBox.Show(sec.FileName + " KONUMUNDA BULUNAN RESIM SEÇİLMİŞTİR");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("resim seçilmedi");
                dosyaYolu = null;
            }



            Image resim = Image.FromFile(dosyaYolu);
            Bitmap bitmap = new Bitmap(resim, new Size(504, 504));
             
            int yukseklik = (int)((double)bitmap.Height / 4);
            int genislik = (int)((double)bitmap.Width / 4);
                    

                    

            int sayac = 1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    btm[i, j] = new Bitmap(genislik, yukseklik);

                    Graphics grap = Graphics.FromImage(btm[i, j]);
                    grap.DrawImage(bitmap, new Rectangle(0, 0, genislik, yukseklik), new Rectangle(j * genislik, i * yukseklik, genislik, yukseklik), GraphicsUnit.Pixel);
                    Bitmap btm2 = btm[i, j];
                    origin[i, j] = btm[i, j];
                    btm2.Save(sayac + ".jpeg");
                    grap.Dispose();
                    sayac++;
                    // FOTOGRAFI NORMAL BASTIRIYOR 
                    /*
                    int index = 4 * i + j;
                    PictureBox pict = this.Controls.Find("pictureBox" + (index+1).ToString(), true).FirstOrDefault() as PictureBox;
                    pict.Image = btm[i, j];
                    //label1.Text = pict.Name; */


                }
            }

           
        }

            
        private  Boolean dogrulama(Bitmap reel, Bitmap karisik)
        {
            bool equals = true;
            bool flag = true;  

            
            
                for (int x = 0; x < reel.Width; ++x)
                {
                    for (int y = 0; y < karisik.Height; ++y)
                    {
                        if (reel.GetPixel(x, y) != karisik.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
                
            
            return equals;

    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            label4.Text = "";
            int buton = 1;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "1. buton 1. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\1.jpeg");
                Bitmap b = new Bitmap(pictureBox1.Image);
                if (dogrulama(a, b))
                {
                    //pictureBox1.Enabled = false;
                    label4.Text = "1.KARE DOĞRU";


                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox1.Image;
                pictureBox1.Image = tutucu;
                
                label1.Text = "1. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\1.jpeg");
                Bitmap b = new Bitmap(pictureBox1.Image);
                if (dogrulama(a, b)) {
                    //pictureBox1.Enabled = false;
                    label4.Text = "1.KARE DOĞRU";

                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }




            kontrolReel();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 2;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "2. buton 1. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\2.jpeg");
                Bitmap b = new Bitmap(pictureBox2.Image);
                if (dogrulama(a, b))
                {
                    //pictureBox2.Enabled = false;
                    label4.Text = "2. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;

                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox2.Image;
                pictureBox2.Image = tutucu;
                
                label1.Text = "2. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\2.jpeg");
                Bitmap b = new Bitmap(pictureBox2.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox2.Enabled = false;
                    label4.Text = "2. KARE DOĞRU";
                 

                }

                kontrol = 0;
            }
            kontrolReel();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 4;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "4. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\4.jpeg");
                Bitmap b = new Bitmap(pictureBox4.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox4.Enabled = false;
                    label4.Text = "4. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;
                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox4.Image;
                pictureBox4.Image = tutucu;
                
                label1.Text = "4. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\4.jpeg");
                Bitmap b = new Bitmap(pictureBox4.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox4.Enabled = false;
                    label4.Text = "4. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }
            kontrolReel();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 5;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "5. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\5.jpeg");
                Bitmap b = new Bitmap(pictureBox5.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox5.Enabled = false;
                    label4.Text = "5. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox5.Image;
                pictureBox5.Image = tutucu;
                
                label1.Text = "5. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\5.jpeg");
                Bitmap b = new Bitmap(pictureBox5.Image);

                if (dogrulama(a, b)) { 
                //pictureBox5.Enabled = false;
                label4.Text = "5. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;
                }

                kontrol = 0;
            }

            kontrolReel();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            label1.Text = "";
            label4.Text = "";
            int buton = 6;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "6. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\6.jpeg");
                Bitmap b = new Bitmap(pictureBox6.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox6.Enabled = false;
                    label4.Text = "6. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox6.Image;
                pictureBox6.Image = tutucu;
                
                label1.Text = "6. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\6.jpeg");
                Bitmap b = new Bitmap(pictureBox6.Image);

                if (dogrulama(a, b))
                {
                   // pictureBox6.Enabled = false;
                    label4.Text = "6. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }
            kontrolReel();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            label4.Text = "";
            int buton = 7;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "7. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\7.jpeg");
                Bitmap b = new Bitmap(pictureBox7.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox7.Enabled = false;
                    label4.Text = "7. KARE DOĞRU";

                }
                kontrol++;

            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox7.Image;
                pictureBox7.Image = tutucu;
                
                label1.Text = "7. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\7.jpeg");
                Bitmap b = new Bitmap(pictureBox7.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox7.Enabled = false;
                    label4.Text = "7. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }
            kontrolReel();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 8;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "8. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\8.jpeg");
                Bitmap b = new Bitmap(pictureBox8.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox8.Enabled = false;
                    label4.Text = "8. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox8.Image;
                pictureBox8.Image = tutucu;
                
                label1.Text = "8. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\8.jpeg");
                Bitmap b = new Bitmap(pictureBox8.Image);

                if (dogrulama(a, b))
                {
                   // pictureBox8.Enabled = false;
                    label4.Text = "8. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }
            kontrolReel();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 9;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "9. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\9.jpeg");
                Bitmap b = new Bitmap(pictureBox9.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox9.Enabled = false;
                    label4.Text = "9. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox9.Image;
                pictureBox9.Image = tutucu;
                
                label1.Text = "9. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\9.jpeg");
                Bitmap b = new Bitmap(pictureBox9.Image);

                if (dogrulama(a, b))
                {
                   // pictureBox9.Enabled = false;
                    label4.Text = "9. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }

            kontrolReel();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 10;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "10. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\10.jpeg");
                Bitmap b = new Bitmap(pictureBox10.Image);

                if (dogrulama(a, b))
                {
                    label4.Text = "10. KARE DOĞRU";
                   // pictureBox10.Enabled = false;

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox10.Image;
                pictureBox10.Image = tutucu;
                
                label1.Text = "10. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\10.jpeg");
                Bitmap b = new Bitmap(pictureBox10.Image);

                if (dogrulama(a, b))
                {
                    label4.Text = "10. KARE DOĞRU";
                    // pictureBox10.Enabled = false;

                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;
                }
                kontrol = 0;
            }
            kontrolReel();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 11;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "11. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\11.jpeg");
                Bitmap b = new Bitmap(pictureBox11.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox11.Enabled = false;
                    label4.Text = "11. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox11.Image;
                pictureBox11.Image = tutucu;
                
                label1.Text = "11. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\11.jpeg");
                Bitmap b = new Bitmap(pictureBox11.Image);

                if (dogrulama(a, b))
                {
                   // pictureBox11.Enabled = false;
                    label4.Text = "11. KARE DOĞRU";
                    
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;
                }
                kontrol = 0;
            }
            kontrolReel();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 12;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "12. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\12.jpeg");
                Bitmap b = new Bitmap(pictureBox12.Image);

                if (dogrulama(a, b))
                {
                    label4.Text = "12. KARE DOĞRU";
                   // pictureBox12.Enabled = false;

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox12.Image;
                pictureBox12.Image = tutucu;
                
                label1.Text = "12. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\12.jpeg");
                Bitmap b = new Bitmap(pictureBox12.Image);

                if (dogrulama(a, b))
                {
                    label4.Text = "12. KARE DOĞRU";
                    // pictureBox12.Enabled = false;
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;

                }
                kontrol = 0;
            }
            kontrolReel();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 14;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "14. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\14.jpeg");
                Bitmap b = new Bitmap(pictureBox14.Image);

                if (dogrulama(a, b))
                {
                   // pictureBox14.Enabled = false;
                    label4.Text = "14. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox14.Image;
                pictureBox14.Image = tutucu;
                
                label1.Text = "14. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\14.jpeg");
                Bitmap b = new Bitmap(pictureBox14.Image);

                if (dogrulama(a, b))
                {
                   // pictureBox14.Enabled = false;
                    label4.Text = "14. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;
                }
                kontrol = 0;
            }
            kontrolReel();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 15;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "15. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\15.jpeg");
                Bitmap b = new Bitmap(pictureBox15.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox15.Enabled = false;
                    label4.Text = "15. KARE DOĞRU";

                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox15.Image;
                pictureBox15.Image = tutucu;
                
                label1.Text = "15. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\15.jpeg");
                Bitmap b = new Bitmap(pictureBox15.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox15.Enabled = false;
                    label4.Text = "15. KARE DOĞRU";
                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;
                }
                kontrol = 0;
            }
            kontrolReel();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label4.Text = "";
            int buton = 16;
            if (kontrol == 0)
            {
                dd = buton;
                
                label1.Text = "16. buton 1. tıklama";

                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\16.jpeg");
                Bitmap b = new Bitmap(pictureBox16.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox16.Enabled = false;
                    label4.Text = "16. KARE DOĞRU";



                }
                kontrol++;
            }
            else if (kontrol == 1)
            {
                oyunpuan = oyunpuan - 4;
                if (oyunpuan < 0)
                    oyunpuan = 0;
                PictureBox pictureB = this.Controls.Find("pictureBox" + dd.ToString(), true).FirstOrDefault() as PictureBox;
                Image tutucu = pictureB.Image;
                pictureB.Image = pictureBox16.Image;
                pictureBox16.Image = tutucu;
                
                label1.Text = "16. buton 2. tıklama";
                Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\16.jpeg");
                Bitmap b = new Bitmap(pictureBox16.Image);

                if (dogrulama(a, b))
                {
                    //pictureBox16.Enabled = false;
                    label4.Text = "16. KARE DOĞRU";

                    oyunpuan = oyunpuan + 4;
                    if (oyunpuan > 100)
                        oyunpuan = 100;


                }
                kontrol = 0;
            }
            kontrolReel();
        }
      

        public String yol = "C:\\Users\\Hayrullah\\Desktop\\WindowsFormsApp1\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\";
        int kontrolSayac = 0;

        public int oyunpuan = 100;


        private void kontrolReel()
        {
            kontrolSayac = 0;
            for(int i =0 ; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    int index = 4 * i + j;
                    PictureBox pict = this.Controls.Find("pictureBox" + (index + 1).ToString(), true).FirstOrDefault() as PictureBox;
                    Bitmap resimYol = new Bitmap(yol+(index+1)+".jpeg");
                    Bitmap resim = new Bitmap(pict.Image);
                    if (dogrulama(resim,resimYol))
                    {
                        kontrolSayac++;
                    }
                }

            }

            label3.Text = kontrolSayac.ToString() + " PARÇA DOĞRU YERDE";

            if (kontrolSayac == 16)
            {
                pictureBox18.BringToFront();
               string nmo = label2.Text;
                if (nmo == null)
                {  
                    dosyayaYaz(oyunpuan.ToString());
                    System.Windows.Forms.MessageBox.Show("PUANININZ " + oyunpuan.ToString());
                    oku();
                    
                }
                else
                {
                   
                  int dosyapuan = int.Parse(nmo);
                    if (oyunpuan > dosyapuan)
                    {
                        
                        System.Windows.Forms.MessageBox.Show("PUANINIZ " + oyunpuan.ToString()+"\n"+ "EN YÜKSEK PUANI YAPTINIZ");

                        dosyayaYaz(oyunpuan.ToString());
                        label2.Text = oyunpuan.ToString();
                        oku();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("PUANININZ " + oyunpuan.ToString());
                    }
                }

                
                
                
            }



            /*
            Bitmap a = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\1.jpeg");
            Bitmap b = new Bitmap(pictureBox1.Image);
            Bitmap c = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\2.jpeg");
            Bitmap d = new Bitmap(pictureBox2.Image);
            Bitmap e = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\3.jpeg");
            Bitmap f = new Bitmap(pictureBox3.Image);
            Bitmap g = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\4.jpeg");
            Bitmap h = new Bitmap(pictureBox4.Image);
            Bitmap asd = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\5.jpeg");
            Bitmap j = new Bitmap(pictureBox5.Image);
            Bitmap k = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\6.jpeg");
            Bitmap l = new Bitmap(pictureBox6.Image);
            Bitmap m = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\7.jpeg");
            Bitmap n = new Bitmap(pictureBox7.Image);
            Bitmap o = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\8.jpeg");
            Bitmap p = new Bitmap(pictureBox8.Image);
            Bitmap r = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\9.jpeg");
            Bitmap s = new Bitmap(pictureBox9.Image);
            Bitmap t = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\10.jpeg");
            Bitmap u = new Bitmap(pictureBox10.Image);
            Bitmap v = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\11.jpeg");
            Bitmap y = new Bitmap(pictureBox11.Image);
            Bitmap z = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\12.jpeg");
            Bitmap aa = new Bitmap(pictureBox12.Image);
            Bitmap ab = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\13.jpeg");
            Bitmap ac = new Bitmap(pictureBox13.Image);
            Bitmap ad = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\14.jpeg");
            Bitmap ae = new Bitmap(pictureBox14.Image);
            Bitmap ah = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\15.jpeg");
            Bitmap ag = new Bitmap(pictureBox15.Image);
            Bitmap ai = new Bitmap(@"C:\Users\Hayrullah\Desktop\WindowsFormsApp1\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\16.jpeg");
            Bitmap aj = new Bitmap(pictureBox16.Image);

            */

            /*for(int i=0;i<4;i++)
            {
                for(int j=0; j< 4; j++)
                {
                    int index = 4 * i + j;
                    PictureBox pict = this.Controls.Find("pictureBox" + (index + 1).ToString(), true).FirstOrDefault() as PictureBox;
                    Bitmap sorgu;
                    if (pict.Image == btm[i, j])
                    {
                        
                        
                        label2.Text = "";
                        pictureBox18.BringToFront();
                        pictureBox18.BringToFront();
                        pictureBox18.BringToFront();
                        pictureBox18.BringToFront();
                        label3.Text = "";
                        pictureBox18.Enabled = false;
                    }
                    else
                        label2.Text = "";
                    

                }
                
                
                    


            }*/


        }

 

        

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
