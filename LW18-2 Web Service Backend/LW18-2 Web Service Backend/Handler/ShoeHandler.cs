using LW18_2_Web_Service_Backend.Factory;
using LW18_2_Web_Service_Backend.Models;
using LW18_2_Web_Service_Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Handler
{
    public class ShoeHandler
    {

        public static Response doInsert(string shoeName, int price)
        {
            if (ShoeRepository.findShoe(ShoeFactory.createShoe(shoeName, price)) != null)
                return ResponseFactory.createResponse(500, "Shoe Already Exists", "Fail");
            ShoeRepository.InsertShoe(ShoeFactory.createShoe(shoeName, price));
            return ResponseFactory.createResponse(200, "Success in Inserting a shoe", ShoeFactory.createShoe(shoeName, price));
        }

        public static Response doUpdate(string oldShoeName, int oldPrice, string updateName, int updatePrice)
        {
            if (ShoeRepository.findShoeByAttributes(oldShoeName, oldPrice) == null)
                return ResponseFactory.createResponse(500, "Shoe does not exist", "Fail");
            ShoeRepository.UpdateShoe(ShoeFactory.createShoe(oldShoeName, oldPrice), ShoeFactory.createShoe(updateName, updatePrice));
            return ResponseFactory.createResponse(200, "Shoe Updated Successfully", ShoeFactory.createShoe(updateName, updatePrice));
        }

        public static Response doDelete(string shoeName)
        {
            if (ShoeRepository.findShoeByName(shoeName) == null)
                return ResponseFactory.createResponse(500, "Shoe does not exist", "Fail");
            ShoeRepository.DeleteShoe(ShoeRepository.findShoeByName(shoeName));
            return ResponseFactory.createResponse(200, "Shoe Deleted", "Delete");
        }

        public static List<Shoes> doGet()
        {
            if (ShoeRepository.getAll() == null)
                return null;
            List<Shoes> shoeList =  ShoeRepository.getAll();
            return shoeList;
        }

        public static List<Shoes> getByID(int id) {
            if (ShoeRepository.getAll() == null)
                return null;
            return ShoeRepository.getBYID(id);
        }


    }

}