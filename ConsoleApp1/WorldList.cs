using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WorldList
    {
        public List<string> worldList { get; set; }
        public WorldList(List<string> worldList)
        {
            this.worldList = worldList;
        }
        public int DeleteWords(int maxLen)
        {
            int count = 0;
            for (int i = 0; i < this.worldList.Count; i++)
            {
                if (worldList[i].Length>maxLen)
                {
                    count++;
                    worldList[i].Remove(maxLen);
                }
            }
            return count;
        }
    }
}
