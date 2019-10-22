using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSum
{
    class Program
    {
        private static List<int> n { get; set; } = new List<int>();
        private static int CheckSum = 0;
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>()
            {
                {"id","14472082"},{"name","ThienMa_NTC"},{"mate",""},{"mate_id","0"},{"lookface","1211301"},{"hair","13001"},{"money","4737024"},{"money_saved","26303592"},{"RMB","0"},{"level","22"},{"exp","106441"},{"storage_lv","2"},{"deed","0"},{"pk","0"},{"medal","0"},{"storage_stone_limit","0"},{"CreateTime","0"},{"recordmap_id","505"},{"recordx","253"},{"recordy","411"},{"account_id","2000046811"},{"last_login","1910182114"},{"task_mask","0"},{"home_id","0"},{"title","0"},{"storage_weight_limit","9999"},{"lock_key","0"},{"reborn_mapid","0"},{"newtype_lv","0"},{"Coach","400"},{"Coach_time","0"},{"Coach_date","0"},{"virtue","65535"},{"xp_beat","0"},{"camp","00"},{"pkenable","0"},{"militaryrank1","0"},{"militaryrank2","0"},{"militaryrank3","0"},{"militaryrank4","0"},{"marrytime","0"},{"robotstorage_lev","0"},{"accumulate","0"},{"Emoney","2211"},{"Emoney_chk","2029609932"},{"money_saved2","0"},{"ExpBallUsage","0"},{"status","119102613"},{"stratagem","0000"},{"online_time","90"},{"auto_exercise","0"},{"flower","0"},{"BagNum","1"},{"forbitdden_words","0"},{"CrystalPoint","0"},{"CrystalUsage0","0"},{"CrystalUsage1","0"},{"CrystalUsage2","0"},{"CrystalUsage3","0"},{"CrystalUsage4","0"},{"password_id","0"},{"locktime","0"},{"chk_sum","1415341764"},{"flower_w","0"},{"tutor_level","0"},{"Tutor_exp","0"},{"online_time2","0"},{"offine_time","0"},{"last_logout2","1910182114"},{"list1","2"},{"list2","20"},{"friend_share","4800000000000"},{"Battle_lev","3435"},{"Income","0"},{"business","255"},{"airborne","2019101808"},{"emoney2","0"},{"Emoney3","4341"},{"Emoney3_chk","2029616026"},{"donation","11410999998"},{"login_time","1910182114"},{"ip","123.23.104.20"},{"brother_team_id","10"}
            };

            foreach (var item in dic)
            {
                try
                {
                    if (item.Key.Equals("chk_sum")) continue;
                    var num = Convert.ToInt32(item.Value);
                    n.Add(num);
                }
                catch (Exception)
                {

                }
            }
            n = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            CheckSum = Convert.ToInt32(5);
            for (int j = 0; j < n.Count -1; j++)
            {
                for (int i = j + 1; i < n.Count; i++)
                {
                    var sum = n[j];
                    DQ(j, i,ref sum, n[i]);
                }
            }
            w.Close();
            Console.Read();
        }
        private static StreamWriter w = new StreamWriter("kq.txt");
        private static string s = "";
        private static void DQ(int j,int i,ref int sum,int item)
        {
            if (string.IsNullOrEmpty(s))
            {
                s += n[j] + " + ";
            }
            sum += item;
            s += $"{n[i]}";
            
            if(i >= n.Count -1)
            {
                s += " = " + sum;
                Console.WriteLine(s);
                if (s.StartsWith(1.ToString()))
                {
                    w.WriteLine(s);
                }
                s = "";
                if (sum == CheckSum)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(sum);
                    Console.ResetColor();
                }
                //w.WriteLine();
                return;
            }
            else
            {
                if (!string.IsNullOrEmpty(s))
                {
                    s += " + ";
                }
            }
            DQ(j, i + 1,ref sum, n[i + 1]);
            if(j + 1 < n.Count)
                DQ(j + 1, i, ref sum, n[i + 1]);
        }
    }
}
