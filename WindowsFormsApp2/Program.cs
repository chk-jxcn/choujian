using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Award
    {
        public List<string[]> candidates;           // 0 name, 1 number
        public List<string[]> currentcandidates;
        public List<string> awardnames;
        public List<int> eachawardcount;
        public List<List<string[]>> luckers;
        public int currentawards;
        public int currentlucker;
        public int candidatenumber;
        public int allawardscount;
        public int alllucer;
        public string savefilename;
        Random rd = new Random();

        public Award()
        {
            currentawards = 0;
            currentlucker = 0;
            allawardscount = 0;
            alllucer = 0;
            savefilename = "lucker@" + (DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds.ToString() + ".txt";
            luckers = new List<List<string[]>>();

            var cans = System.IO.File.ReadAllLines(@".\alluser.txt");
            candidates = new List<string[]>();
            currentcandidates = new List<string[]>();
            foreach (string can in cans)
            {
                var a = can.Split();
                candidates.Add(a);
                currentcandidates.Add(a);
            }
            candidatenumber = currentcandidates.Count;

            var awards = System.IO.File.ReadAllLines(@".\awards.txt");
            awardnames = new List<string>();
            eachawardcount = new List<int>();

            foreach (string award in awards)
            {
                var a = award.Split();
                awardnames.Add(a[0]);
                eachawardcount.Add(Convert.ToInt32(a[1]));
                allawardscount += Convert.ToInt32(a[1]);
            }
        }

        // 0: 還有，1: 下一個獎，2: 全部完成
        public int nextaward()
        {
            if (currentlucker == eachawardcount[currentawards])
            {
                if (awardnames.Count <= currentawards + 1)
                    return 2;
                else
                    return 1;
            }
            return 0;
        }

        public void gonext()
        {
            currentawards += 1;
            currentlucker = 0;
        }

        public string currentawardname()
        {
            return awardnames[currentawards];
        }

        public string currentawardstate()
        {
            return string.Format("{0}/{1}", eachawardcount[currentawards] - currentlucker, eachawardcount[currentawards]);
        }

        public bool pickup(string[] lucker, bool deleteme)
        {
            alllucer += 1;
            currentlucker += 1;
            if (luckers.Count < currentawards + 1)
                luckers.Add(new List<string[]>());
            luckers[currentawards].Add(lucker);
            save();
            if (deleteme)
                currentcandidates.Remove(lucker);
            return true;
        }

        public string[] randomcandidate()
        {
            var i = rd.Next(0, currentcandidates.Count);
            return currentcandidates[i];
        }

        public string[] log()
        {
            var ret = new List<string>();
            int i = 0;
            foreach(var lucker in luckers)
            {
                var awardname = string.Format("====={0}\n======", awardnames[i]);
                ret.Add(awardname);
                foreach(var name in lucker)
                {
                    if (name.Length == 2)
                        ret.Add(string.Format("{0} ({1})", name[0], name[1]));
                    else
                        ret.Add(string.Format("{0}", name[0]));
                }
                i += 1;
            }
            return ret.ToArray<string>();
        }

        public void save()
        {
            System.IO.File.WriteAllLines(savefilename, log());
        }
    }
}
