using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zdzs
{
    public class Goods
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int child_id { get; set; }
        /// <summary>
        /// 《四方菱花》汤竹军老师宜兴原矿早期文革泥全手工580cc 《四方菱花》汤竹军老师宜兴原矿早期文革泥全手工580cc
        /// </summary>
        public string keywords { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int brand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int brand_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_love { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int category_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int store_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int stock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_up { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_flash { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int flash_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_hot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_recommend { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_limit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int limit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int buy_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_del { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int order_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_seckill { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int startTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int endTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string goods_params { get; set; }
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
        public string img { get; set; }
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
        public string seckill_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string commission { get; set; }
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
        public string yongjin { get; set; }
        /// <summary>
        /// 璟泰苑紫砂艺术
        /// </summary>
        public string store_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int goods_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> rule { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_collect { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cart_num { get; set; }
    }

    public class Sale
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 昨日特卖1
        /// </summary>
        public string desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string start_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_del { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_at { get; set; }
    }

    public class BannerItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string goods_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img { get; set; }
    }

    public class Detail_imgItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string goods_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img { get; set; }
    }

    public class Store
    {
        /// <summary>
        /// 
        /// </summary>
        public int store_id { get; set; }
        /// <summary>
        /// 璟泰苑紫砂艺术
        /// </summary>
        public string store_name { get; set; }
        /// <summary>
        /// 百年紫砂茶具经营
        /// </summary>
        public string store_desc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string store_headimg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string store_img { get; set; }
    }

    public class Appraisal
    {
        /// <summary>
        /// 
        /// </summary>
        public string is_open { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int appraisal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int certificate { get; set; }
    }

    public class Root3
    {
        /// <summary>
        /// 
        /// </summary>
        public int errcode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Goods goods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Sale sale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<BannerItem> banner { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> specs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Detail_imgItem> detail_img { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string kf_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Store store { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Appraisal appraisal { get; set; }
    }

}
