using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dersleri_1
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya!");

            label28.Text = "toplam eleman sayısı="+checkedListBox1.Items.Count.ToString();
            bool aranilan = checkedListBox1.Items.Contains("ankara");
            if (aranilan==true)
            {
                label30.Text = "aranilan eleman bulundu";
            }
            else
            {
                label30.Text = "aranilan eleman bulunamadı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2 fr2 = new frm2(); //bu sınıfta yeni bir nesne üretiyorum
            fr2.Show(); //showdialog dersek yeni açılan sayfayı kapatmadan öncekinde işlem yapamıyorum, yalnızca show yazsaydım yenipencere açılsa da öncekilerde işlem yapabilirdim
            Hide(); //yeni pencere çıktığında bu gizlenecek demek oluyor
            //this.Hide(); desem de olurdu 
            //Close(); //yeni pencere çıktığında bu kapanacak demek oluyor
            //hide ve close u kullanmak için showdialog yerine show yazmak gerekiyor

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3 fr3 = new frm3();
            fr3.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //ya da bu kullanılabilir Environment.Exit(0);
            // Close(); anasayfaysa bunu yazarsak direk kapatır, anasayfa değilse sadece bulunduğu formu kapatır.
            // üst köşede kapatma tuşu var zaten öylesine gösteriyoruz bunu fnsdknfdkös

        }

        /*Tam Sayı Değişkenleri
         * 
         * byte:0-255
         * sbyte:-128 +127
         * short: -32768 +32767
         * int: -2.147.483.648 +2.147.483.647
         * long -9.... 49.... 19 basamaklı
         * ushort işaretsiz 0 ile 65535
         * uint 0 ile 4milyon
         * ulong 0 ile 18.446.. 20 basamaklı
         * 
         * 
         * Ondalıklı Sayı Değşkenleri
         * 
         * float 7 basamklı virgülden sonra ondalık yazacaksan sonuna f yazman gerek, virgülden sonrası yoksa f yazmana gerek yok
         * double 15-16 basamak
         * decimal 28-29 basm. sonuna m yazarsan
         * 
         * 
         * string
         * char
         * bool
         * const int
        */

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 15;
            string metin;
            metin = textBox1.Text;

            //textboxa string yazarsak
            string ay = textBox1.Text;

            //textboxa int yazmak istersek alttaki gibi yapacağız
            //int.parse stringi inte dönüştürüyor
            //int.parse yerine convert.toint32 yazsak da aynısı olur
            //convert herkesi dönüştürüyor toint32 diyoruz çünkü int 32 bitlik bir veri türü, short olsasydı 16 olurdu, long olsa 64
            int sayi = int.Parse(textBox1.Text);
            label2.Text = sayi.ToString(); //ya da convert.tostring(sayi); yazabilirm

            //textboxa ne yazarsam göster butonuna basınca label2 de yazdığım çıkar

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(15);  //bunu yazarsak, ekleye yani button5 e basınca listbox a bu yazdıklarımız gelecek
            listBox1.Items.Add(20);
            listBox1.Items.Add("Ankara");
            listBox1.Items.Add("İstanbul");

            listBox1.Items.Add(textBox2.Text); //textbox2 ye ne girersen ekleye basınca listboxda gösterecek

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //propotiesdeki sorted ı true yaparsan harf ya da rakam sırasına göre sıralıyor ya da şu kodu yazabilirsin
            listBox1.Sorted = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem); //seçilen elemanı silliyor
            //listBox1.Items.Remove(listBox1.SelectedIndex); //index numarasına göre sil demek oluyor, elemanların index numarası 0dan başlıyor
            //listBox1.Items.RemoveAt(2); //index numarası 2 olanı siliyor
            //listBox1.Items.Clear();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = listBox1.Items.Count.ToString(); //kaç eleman yazdıysak ya da varsa onu labelda gösterecek
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = listBox1.Items.Contains(textBox2.Text).ToString(); //textboxa yazdığımız listboxda varsa true yoksa false yazdıracak label4e
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label5.Text = listBox1.Items.IndexOf(textBox2.Text).ToString(); //textbox2ye yazılanın kaçıncı indexte old söylüyo 2 kere varsa aynı eleman saymıyo, yoksa -1 diyor

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //iç içe switch kullanımı

            switch (textBox3.Text)
            {
                case "Kış":
                    label8.Text = "Kış mevsimi";
                    break;
                case "İlkbahar":
                    label8.Text = "İlkbahar mevsimi";
                    switch (textBox4.Text)
                    {
                        case "Mart":
                            label8.Text += " " + textBox4.Text;
                            break;
                        case "Nisan":
                            label8.Text += " " + textBox4.Text;
                            break;
                        case "Mayıs":
                            label8.Text += " " + textBox4.Text;
                            break;
                        default:
                            label8.Text += " " + "mevsiminde böyle bir ay yoktur";
                            break;
                    }
                    break;
                case "Yaz":
                    label8.Text = "Yaz mevsimi";
                    break;
                case "Sonbahar":
                    label8.Text = "Sonbahar mevsimi";
                    break;
                default:
                    label8.Text = "Böyle bir mevsim yok.";
                    break;

            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            //if else kullanımı

            label10.Text = "";
            int sayi = int.Parse(textBox5.Text);
            if (sayi>0)
            {
                label10.Text += "Sayı pozitif";
            }
            else if (sayi < 0)
            {
                label10.Text += "Sayı negatif";
            }
            else
            {
                label10.Text += "Sayı sıfır";
            }
        }
        double sonuc;
        private void button12_Click(object sender, EventArgs e)
        {
            sonuc = double.Parse(textBox6.Text) + double.Parse(textBox7.Text);
            label13.Text = sonuc.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sonuc = double.Parse(textBox6.Text) * double.Parse(textBox7.Text);
            label13.Text = sonuc.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //listboxdan diğer listboxa aktarma

            listBox3.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) //.
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox3.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //listbox2deki tüm elemanları listbox3 e aktarmak için

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox3.Items.Add(listBox2.Items[i].ToString());
            }

            listBox2.Items.Clear(); //hepsini diğer boxa attığımız için burdan da silmek lazım
        }

        private void button17_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                listBox2.Items.Add(listBox3.Items[i].ToString());
            }
            listBox3.Items.Clear();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //textbox içerisinde seçilen elemannnı bulma

            textBox8.Text = textBox8.Text.ToUpper(); //yazılanlar büyük olsa da büyüğe dönüştürmek lazım
            textBox8.SelectionStart = textBox8.Text.Length; //texboxa girdiğimiz her karakterden sonra büyük harfe dönüştürecek
            for (int i = 0; i < listBox4.Items.Count ; i++)
            {
                //aranacakyer.contains(aranılacak);
                if (listBox4.Items[i].ToString().Contains(textBox8.Text))
                {
                    listBox4.SetSelected(i, true); //seçtiğimiz elemanı seçecek yani gösterecek, hangi indexse seçimini true yapacak
                    if (textBox8.Text=="")
                    {
                        listBox4.SetSelected(i, false);
                    }
                }
                else
                {
                    listBox4.SetSelected(i, false); //true yaptığımızda elemanı seşiyor false yaptığımızda seçmiyor
                }

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int tektoplam = 0, cifttoplam = 0, toplam = 0;
            for (int  i=1;  i<=10 ; i++)
            {
                toplam = toplam + i;
                label15.Text += " " + i;
                if (i%2==1)
                {
                    tektoplam = tektoplam + i;
                    label16.Text += i + " "; 
                }
                else
                {
                    cifttoplam = cifttoplam + i;
                    label17.Text += i + " ";
                }
            }

            label20.Text += toplam.ToString();
            label19.Text += tektoplam.ToString();
            label18.Text += cifttoplam.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label22.Text = "";
            label22.Font = new Font("Arial", 10);
            //for (int i = 1; i <= 6; i++) //0 ya da 1 le başlasa bir fark yok sanırım
            //{
            //    for (int j=1; j<=i; j++)
            //    {
            //        label22.Text += "*";

            //    }
            //    label22.Text += "\n";
            //}
            //for (int i = 5; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        label22.Text += "*";

            //    }
            //    label22.Text += "\n";
            //}


            for (int i = 0; i < textBox9.Text.Length; i++) //1le başlamazsan sorun çıkıyor, 1le başlarsan textteki ilk harfi kabul etmiyor
            {
                for (int j = 0; j <= i; j++)
                {
                    label22.Text += textBox9.Text[j];
                }
                label22.Text += "\n";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //in this.Controls şeklinde de kullanılabilir ama bir fark ya da sorun yok
            foreach (Control nesne in Controls) //var yerine veri türü yazılır, item verilere verilecek isim ör nesne diyebiliriz,in collection ise nerede uygulayacağımız ör form diyebiliriz, controller dersem formdaki tüm kontroller üzerinde dolaşır
            {
                // nesne.BackColor = Color.Red; //tüm controllere yapıyor panelin içindeki controllere yapmıyor ama panele de yapıyor
                if (nesne is TextBox) //textbox ya da label diyebilirsin
                {
                    nesne.BackColor = Color.Red;
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {

            //while döngüsü

            label27.Text = "";
            listBox5.Items.Clear();
            int i = 0;
            while (i < int.Parse(textBox15.Text))
            {
                listBox5.Items.Add(textBox14.Text);
                label27.Text += textBox14.Text + "\n";
                i++;
            }

            //do while döngüsü

            //döngüyü yanlış yazsak bile en az 1 defa çalışıyor, do başta olduğu için
            //int i = 0;
            //listBox5.Items.Clear();
            //int say = int.Parse(textBox15.Text);
            //do
            //{
            //    listBox5.Items.Add(textBox14.Text);
            //    i++;
            //} 
            //while (i<say);


        }

        private void button22_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i,true); //i yerine hangi elemanı istiyorsan onun indexi yazılır true da o elemanı seçtiğimizi gösterir
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Insert(3, "eskisehir"); //kaçıncı yere hang elemanı eklemek istiyorsan onu yazıyorsun
        }

        private void button25_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox1.CheckedItems) // checkedboxdaki check edilen yani seçilenlerden string türünde olan itemları listboxa ekle
            {
                listBox6.Items.Add(item); //label28 ve label30u frmanasayfa içine yazdık
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label29.Text = "";
            label29.Text = "seçili eleman sayısı=" + checkedListBox1.CheckedItems.Count; //ne seçersem ona göre değişecek labelda yazan
        }
    }
}
