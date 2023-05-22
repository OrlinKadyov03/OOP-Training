using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Course_Third_Documents
{
    public class HeadPhone
    {
        public double MaxVolume { get; set; }
        public List<HeadPhone> GetHeadPhonesWithMaxVolume(List<HeadPhone> headPhones)
        {
             List<HeadPhone> lists = new List<HeadPhone>();
             double maxVolume = headPhones.Max(hp => hp.MaxVolume);

            foreach (var hp in headPhones)
            {
                if (hp.MaxVolume== maxVolume)
                {
                    lists.Add(hp);    
                }
            }
            return lists;
        }
    }
}
