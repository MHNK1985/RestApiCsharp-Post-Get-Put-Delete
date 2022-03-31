using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApiSample.Models
{
    public class Item
    {
        String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
    }
    public class ItemRegisterResult : Item
    {
        String RegisterStat;

        public String RegistrationStat
        {
            get { return RegisterStat; }
            set { RegisterStat = value; }
        }
    }

    public class ItemProcess
    {
        List<Item> ItemList;
        static ItemProcess itemregd = null;

        private ItemProcess()
        {
            ItemList = new List<Item>();
        }

        public static ItemProcess getInstance()
        {
            if (itemregd == null)
            {
                itemregd = new ItemProcess();
                return itemregd;
            }
            else
            {
                return itemregd;
            }
        }

        public void AddItem(Item item)
        {
            ItemList.Add(item);
        }

        public String DeleteItem(int Code)
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                Item itm = ItemList.ElementAt(i);
                if (itm.Code.Equals(Code))
                {
                    ItemList.RemoveAt(i);
                    return "Delete Done";
                }
            }

            return "Delete Failed";
        }

        public List<Item> GetAllItem()
        {
            return ItemList;
        }

        public String UpdateItem(Item model)
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                Item itm = ItemList.ElementAt(i);
                if (itm.Code.Equals(model.Code))
                {
                    ItemList[i] = model;//update the new record
                    return "Update Done";
                }
            }

            return "Update Failed";
        }

    }
}