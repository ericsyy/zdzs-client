using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace zdzs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            Thread thread = new Thread(new ThreadStart(init_user));
            thread.Start();

            Thread thread1 = new Thread(new ThreadStart(init_a));
            thread1.Start();


        }

        public static string Get(string url, Dictionary<string, string> dic)
        {
            string result = "";
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            if (dic.Count > 0)
            {
                builder.Append("?");
                int i = 0;
                foreach (var item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
            }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(builder.ToString());
            req.UserAgent = "Dart/2.13 (dart:io)"; //添加头
            //添加参数
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }


        //Bitmap[] home_bmp = new Bitmap[6];

        Image[] home_bmp = new Image[6];
        string[] name = null;
        string[] price = null;
        string[] old_price = null;
        string[] goods_id = null;
        private void init_user()
        {

            button1.Enabled = false;

            string url = "https://www.zhengdianzisha.com/zhibo/live/hot-list";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Clear();

            Random ran = new Random();

            int n = ran.Next(1, 15);
            dic.Add("page",n.ToString());

            string get_ret = Get(url, dic);
            Root rt = JsonConvert.DeserializeObject<Root>(get_ret);


            

            name = new string[6];
            price = new string[6];
            old_price = new string[6];
            goods_id = new string[6];
            //GC.Collect();

            int i = 0;
            foreach (var val in rt.goods)
            {
                name[i] = val.name;
                price[i] = "¥" + val.now_price;
                old_price[i] = "¥" + val.old_price;
                goods_id[i] = val.id;


                var webC = new System.Net.WebClient();
                home_bmp[i] = (new Bitmap(webC.OpenRead(val.thumb+"?x-oss-process=image/resize" +
                    ",m_fill,h_300,w_300")));
                if (i == 5)
                {
                    break;
                }
                i++;
            }

            for (int j = 0; j < 6; j++)
            {
                switch (j + 1)
                {
                    case 1:
                        name1.Text = name[j];
                        price1.Text = price[j];
                        pictureBox1.Image = home_bmp[j];
                        break;
                    case 2:
                        name2.Text = name[j];
                        price2.Text = price[j];
                        pictureBox2.Image = home_bmp[j];
                        break;
                    case 3:
                        name3.Text = name[j];
                        price3.Text = price[j];
                        pictureBox3.Image = home_bmp[j];
                        break;
                    case 4:
                        name4.Text = name[j];
                        price4.Text = price[j];
                        pictureBox4.Image = home_bmp[j];
                        break;
                    case 5:
                        name5.Text = name[j];
                        price5.Text = price[j];
                        pictureBox5.Image = home_bmp[j];
                        break;
                    case 6:
                        name6.Text = name[j];
                        price6.Text = price[j];
                        pictureBox6.Image = home_bmp[j];
                        break;
                }


            }


            timer1.Enabled = true;
            pictureBox14.Visible = false;
            menuStrip1.Visible = true;
            panel32.Visible = true;


            button1.Enabled=true;

            button1.Text = "换一批";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "加载中";
            Thread thread = new Thread(new ThreadStart(init_user));
            thread.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {


        }

        //Bitmap[] bmp = new Bitmap[5];
        Image[] bmp = new Image[5];
        private void init_a()
        {
            int i = 0;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string url1 = "https://www.zhengdianzisha.com/zhibo/index/banner";
            dic.Clear();
            dic.Add("type", "1");

            string get_ret2 = Get(url1, dic);
            Root2 rt2 = JsonConvert.DeserializeObject<Root2>(get_ret2);


            var webC = new System.Net.WebClient();


            //bmp = new[] {(new Bitmap(webC.OpenRead(rt2.list[0].img))),
            //    (new Bitmap(webC.OpenRead(rt2.list[1].img))),
            //    (new Bitmap(webC.OpenRead(rt2.list[2].img))) };

            foreach (var val in rt2.list)
            {
                bmp[i] = (new Bitmap(webC.OpenRead(val.img+"?x-oss-process=image/resize" +
                    ",m_fill,h_128,w_288")));
                i++;
            }



        }


        int j = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox7.Image = bmp[j];

            if (j == 4)
            {
                j = 0;

            }
            else
            {
                j++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            pictureBox14.Visible = false;







            //init_user();
            //init_a();

            //timer2.Enabled = false;



        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            timer3.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int index_t = 0;
            Image newImage = pictureBox1.Image;
            Form2 form2 = new Form2(newImage, name[index_t], price[index_t], old_price[index_t], goods_id[index_t]);
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int index_t = 1;
            Image newImage = pictureBox2.Image;
            Form2 form2 = new Form2(newImage, name[index_t], price[index_t], old_price[index_t], goods_id[index_t]);
            form2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int index_t = 2;
            Image newImage = pictureBox3.Image;
            Form2 form2 = new Form2(newImage, name[index_t], price[index_t], old_price[index_t], goods_id[index_t]);
            form2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int index_t = 3;
            Image newImage = pictureBox4.Image;
            Form2 form2 = new Form2(newImage, name[index_t], price[index_t], old_price[index_t], goods_id[index_t]);
            form2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int index_t = 4;
            Image newImage = pictureBox5.Image;
            Form2 form2 = new Form2(newImage, name[index_t], price[index_t], old_price[index_t], goods_id[index_t]);
            form2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int index_t = 5;
            Image newImage = pictureBox6.Image;
            Form2 form2 = new Form2(newImage, name[index_t], price[index_t], old_price[index_t], goods_id[index_t]);
            form2.Show();
        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
