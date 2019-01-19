using LW18_2_Web_Service_Backend.Models;
using LW18_2_Web_Service_Backend.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Repositories
{
    public class ShoeRepository
    {
        private static Database1Entities DB = DatabaseSingleton.GetSingletonInstance();

        //Insert Shoe
        public static void InsertShoe(Shoes newShoe)
        {
            DB.Shoes1.Add(newShoe);
            DB.SaveChanges();
        }

        //Update Shoes
        public static void UpdateShoe(Shoes targetShoe, Shoes updateShoe)
        {
            Shoes target = (from x in DB.Shoes1 where x.ShoeName == targetShoe.ShoeName && x.Price == targetShoe.Price select x).FirstOrDefault();
            target.ShoeName = updateShoe.ShoeName;
            target.Price = updateShoe.Price;
            //target = updateShoe;
            DB.SaveChanges();
        }

        //Delete Shoe
        public static void DeleteShoe(Shoes delShoe)
        {
            DB.Shoes1.Remove(delShoe);
            DB.SaveChanges();
        }

        //Find Shoe
        public static Shoes findShoe(Shoes shoe)
        {
            try{
                return DB.Shoes1.Where(x => x == shoe).FirstOrDefault();
            }
            catch (Exception){
                return null;
                throw;
            }
        }
        //Find Shoe by attributes
        public static Shoes findShoeByAttributes(string shoeName, int price)
        {
            return DB.Shoes1.Where(x => x.ShoeName == shoeName && x.Price == price).FirstOrDefault();
        }
        //Find Shoe by shoeName
        public static Shoes findShoeByName(string shoeName)
        {
            return DB.Shoes1.Where(x => x.ShoeName == shoeName).FirstOrDefault();
        }
        //Get All Shoes
        public static List<Shoes> getAll()
        {
            return DB.Shoes1.ToList();
        }

        public static List<Shoes> getBYID(int id)
        {
            return DB.Shoes1.Where(x => x.ShoeID == id).ToList();
        }

    }
}