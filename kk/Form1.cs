using System;
using System.Drawing;
using System.Windows.Forms;

namespace kk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            //Список изображений которые ввожу 
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(256, 256);//Пиксели
            imageList.Images.Add(new Bitmap("images/1.jpg")); imageList.Images.Add(new Bitmap("images/2.jpg"));
            imageList.Images.Add(new Bitmap("images/3.jpg")); imageList.Images.Add(new Bitmap("images/4.jpg")); imageList.Images.Add(new Bitmap("images/5.jpg"));
            
            Bitmap emptyImage = new Bitmap(256, 256);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }
            imageList.Images.Add(emptyImage);
            list1.SmallImageList = imageList;
            string[] firstName = { "1899", "1999", "2000", "1978", "1979"};//текст
            string[] lastName = { "МЯУ!", "КОРТОФЕЛЬНЫЙ-КОТ", "ДОГИ", "ЗЛОЙ1", "ЗЛОЙ2"};//текст

            for (int i = 0; i < firstName.Length; i++)//вывод данных в listview (огр на кол-во "итераций"
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { "", firstName[i], lastName[i] });//вывод картинок, текста, текста
                listViewItem.ImageIndex = i;//будеть браться из списка изображений
                list1.Items.Add(listViewItem);
            }
        }
        private void list1_SelectedIndexChanged(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
    }
}
