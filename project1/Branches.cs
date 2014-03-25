using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Branches
    {
        List<Branch> list = new List<Branch>();
        Branch brampton = new Branch("Brampton", "456 Brampton St", "K4F3R3", "905 455 7888", "");
        Branch oakville = new Branch("Oakville", "486 Oak St", "Y6UJ2K", "905 368 9987", "");
        Branch toronto = new Branch("Toronto", "123 Toronto St", "M3F4DR", "416 375 7894", "");
        Branch mississauga = new Branch("Mississauga", "789 Mississauga", "L4R5T7", "705 222 4897", "");
        Branch hamilton = new Branch("Hamilton", "951 Hamilton", "M2QP8X", "519 756 4844", "");
        public Branches()
        {
            list.Add(brampton);
            list.Add(oakville);
            list.Add(toronto);
            list.Add(mississauga);
            list.Add(hamilton);
        }
        public List<Branch> getCities()
        {
            return list;
        }
        public decimal getTotalPrice()
        {
            decimal totalPrice=0;
            foreach(Branch b in list)
            {
                totalPrice += b.Amount;
            }
            return totalPrice;
        }
    }

}
