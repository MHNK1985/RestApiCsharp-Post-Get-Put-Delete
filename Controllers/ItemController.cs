using RestApiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApiSample
{
    public class ItemController : ApiController
    {
        [HttpGet]
        public List<Item> GetAllItems()
        {
            return ItemProcess.getInstance().GetAllItem();
        }


        [HttpPost]
        public ItemRegisterResult RegisterItem(Item model)
        {
            ItemRegisterResult ItemResult = new ItemRegisterResult();
            ItemProcess.getInstance().AddItem(model);
            ItemResult.Name = model.Name;
            ItemResult.Code = model.Code;
            ItemResult.RegistrationStat = "Done";

            return ItemResult;
        }


        [HttpPut]
        public String UpdateItem(Item model)
        {
            return ItemProcess.getInstance().UpdateItem(model);
        }


        [HttpDelete]
        public String DeleteItem(int Code)
        {
            return ItemProcess.getInstance().DeleteItem(Code);
        }


    }
}