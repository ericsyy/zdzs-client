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
    public partial class Form2 : Form
    {

        string p_goods_id = "";

        public Form2(Image img, string name, string price, string old_price, string goods_id)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            pictureBox1.Image = img;
            label2.Text = price;
            label3.Text = old_price;
            label4.Text = name;
            p_goods_id = goods_id;
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

        Image img = null;
        //获取图像尺寸动态调整pic_box
        private (int wsize, int hsize) getpic_size(string image_url)
        {

            string image = image_url;
            byte[] imageData = new WebClient().DownloadData(image);
            MemoryStream imgStream = new MemoryStream(imageData);
            img = Image.FromStream(imgStream);



            int wSize = img.Width;
            int hSize = img.Height;

            return (wSize, hSize);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //创建加载图片线程，防止主线程UI卡死
        private void thread_pic(object obj)
        {
            progressBar1.Value = 4;
             (int wsize, int hsize) = getpic_size((string)obj);
            //长=373x(y/x)
            progressBar1.Value = 7;
            int height = pictureBox2.Size.Width * (hsize / wsize);
            pictureBox2.Height = height;
            progressBar1.Value = 8;
            pictureBox2.Image = img;
            progressBar1.Value = 10;
            label10.Visible = false;
            progressBar1.Visible = false;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string url = "https://www.zhengdianzisha.com/zhibo/goods/detail";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Clear();
            dic.Add("id", p_goods_id);

            string get_ret = Get(url, dic);

            Root3 rt = JsonConvert.DeserializeObject<Root3>(get_ret);

            label8.Text = rt.store.store_name;
            pictureBox6.LoadAsync(rt.store.store_headimg + "?x-oss-process=image/resize" +
                    ",m_fill,h_50,w_50");




            



            Thread thread = new Thread(new ParameterizedThreadStart(thread_pic));

            object obj; 

            try
            {
                obj = rt.detail_img[0].img;
            }
            catch (Exception ex)
            {
                label10.Text = "该商品没有图";
                progressBar1.Visible=false;
                return;
            }

            thread.Start(obj);






            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就不给你买");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
