using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zdzs
{
    //如果好用，请收藏地址，帮忙分享。
    public class GoodsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string order_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string store_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string child_id { get; set; }
        /// <summary>
        /// 《四方菱花》汤竹军老师宜兴原矿早期文革泥全手工580cc 《四方菱花》汤竹军老师宜兴原矿早期文革泥全手工580cc
        /// </summary>
        public string keywords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string category_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string brand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string brand_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_flash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string flash_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string stock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_up { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_hot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_recommend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_love { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_seckill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string startTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string endTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_limit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string limit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string buy_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_del { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string goods_params { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commission { get; set; }
        /// <summary>
        /// 《四方菱花》汤竹军老师宜兴原矿早期文革泥全手工580cc
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 把
        /// </summary>
        public string unit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string thumb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tmimg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_attr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string now_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string old_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string love_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int freight_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int post_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int house_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string update_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string seckill_price { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public int errcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<GoodsItem> goods { get; set; }
    }

}
