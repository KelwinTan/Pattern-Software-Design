using LW18_2_Web_Service_Backend.Factory;
using LW18_2_Web_Service_Backend.Models;
using LW18_2_Web_Service_Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Handler
{
    public class DTHandler
    {
        public static Response doInsert(int headerID, int qty, int shoeID)
        {
            if (DTRepository.getUsersDT(headerID) != null)
                return ResponseFactory.createResponse(500, "DT Already Exists", DTRepository.getUsersDT(headerID));
            DTRepository.insertDT(DTFactory.createDT(headerID, qty, shoeID));
            return ResponseFactory.createResponse(200, "Success in Inserting Detail transaction", DTFactory.createDT(headerID, qty, shoeID));
        }

        public static Response getALLDT()
        {
            return ResponseFactory.createResponse(200, "Success in getting all DTs", DTRepository.getAll());
        }

        public static List<Detail_Transaction> getallDTList(int headerID)
        {
            return DTRepository.getUsersDT(headerID);
        }

        public static Response getDTbyID(int headerID)
        {
            return ResponseFactory.createResponse(200, "Success in getting DT", DTRepository.getUsersDT(headerID));
        }



    }
}