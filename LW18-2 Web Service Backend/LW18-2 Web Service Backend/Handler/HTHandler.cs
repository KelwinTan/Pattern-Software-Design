using LW18_2_Web_Service_Backend.Factory;
using LW18_2_Web_Service_Backend.Models;
using LW18_2_Web_Service_Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LW18_2_Web_Service_Backend.Handler
{
    public class HTHandler
    {
        public static Response doInsert(int headerID, int userID)
        {
            if (HTRepository.getHT(userID) != null)
                return ResponseFactory.createResponse(500, "HT Already Exists", HTRepository.getHT(userID));
            HTRepository.insertHT(HTFactory.createHT(headerID, userID));
            return ResponseFactory.createResponse(200, "Success in Inserting Header transaction", HTFactory.createHT(headerID, userID));
        }

        public static int getLastID()
        {
            return HTRepository.getLastHTID();
        }

        public static Response getHT(int userID)
        {
            return ResponseFactory.createResponse(200, "Success in getting HT", HTRepository.getHT(userID));
        }

        public static Response getAllHT()
        {
            return ResponseFactory.createResponse(200, "Success in getting all HT", HTRepository.getAllHT());
        }

        public static List<Header_Transaction> getLISTHT()
        {
            return HTRepository.getAllHT();
        }


    }
}