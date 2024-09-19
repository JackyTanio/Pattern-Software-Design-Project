using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public static class CartHandler
    {
        
        public static List<Cart> GetAllCarts()
        {
            return CartRepo.getCart();
        }

        
        public static Cart GetCartByUserId(int userId, int stationeryId)
        {
            return CartRepo.getCartByUserId(userId, stationeryId);
        }

        
        public static void CreateCart(int userId, int stationeryId, int quantity)
        {
            
            CartRepo.createCart(userId, stationeryId, quantity);
        }

        
        public static void UpdateCart(int userId, int stationeryId, int quantity)
        {
            
            CartRepo.updateCart(userId, stationeryId, quantity);
        }


        public static void DeleteCart(int userId, int stationeryId)
        {
            
            CartRepo.deleteCart(userId, stationeryId);
        }
    }
}