﻿using Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace ShoesWeb.Models
{
    public class Mapper
    {
        public static Product Map(tb_products product)
        {

            return new Product()
            {
                Product_Id = product.product_id,
                Product_Name = product.product_name,
                Store_Id = product.store_id,
                Store_Name = product.tb_store.store_name,
                Category_Id = product.category_id,
                Category_Name = product.tb_category.category_name,
                Product_Price = product.product_price,
                Product_Quantity = product.product_quantity,
                Product_Image = product.product_image,
            };
        }

        public static tb_products Maps(ShoesWeb.Models.Product product)
        {
            return new tb_products()
            {
                product_id = product.Product_Id,
                product_name = product.Product_Name,
                store_id = product.Store_Id,
                category_id = product.Category_Id,
                product_price = product.Product_Price,
                product_quantity = product.Product_Quantity,
                product_image = product.Product_Image,

            };
        }

        public static tb_users Mapuser(User user)
        {
            return new tb_users()
            {
                user_id = user.User_Id,
                username = user.User_Name,
                password = user.Password,
                role = user.Role,

            };
        }
        public static tb_customers Mapcust(User user)
        {
            return new tb_customers()
            {
                user_id = user.User_Id,
                customer_id = user.Customer_Id,
                customer_name = user.Customer_Name,
                customer_contact = user.Customer_Contact,
                customer_email=user.Customer_Email,

            };
        }
        public static tb_cart Mapcart(Cart cart)
        {
            return new tb_cart()
            {
                cart_id = cart.Cart_Id,
                customer_id=cart.Customer_Id,
                store_id=cart.Store_Id,
                total_bill=cart.TotalBill,
            };
                
        }
        public static tb_cartdetails Mapcartdetails(Cart cart)
        {
            return new tb_cartdetails()
            {
                cart_id=cart.Cart_Id,
                quantity=cart.Quantity,
                product_id=cart.Product_Id,
            };
        }

        //To write data from view into database
        public static tb_cartitem MapCartItem(CartItem cart)
        {
            return new tb_cartitem()
            {
                cart_id = cart.Cart_Id,
                customer_id = cart.Customer_Id,
                store_id = cart.Store_Id,
                product_id = cart.Product_Id,
                color=cart.Color,
                size=cart.Size,
                product_price = cart.Product_Price
            };

        }

        public static CartItem MapViewCart(tb_cartitem cart)
        {

            return new CartItem()
            {
                Cart_Id = cart.cart_id,
                Color = cart.color,
                Customer_Id = cart.customer_id,
                Size = cart.size,
                Store_Id = cart.store_id,
                Product_Id = cart.product_id,
                Product_Image = cart.tb_products.product_image,
                Product_Name = cart.tb_products.product_name,
                Product_Price = cart.product_price,
            };
        }

        public static tb_order MapOrder(Order order)
        {
            return new tb_order()
            {
                
                order_id = order.Order_Id,
                total_bill = order.TotalBill,
                date = order.Date,
                customer_id = order.Customer_Id,
                store_id = order.Store_Id,                
            };
        }

        public static tb_orderdetails MapOrderDetails(Order order)
        {
            return new tb_orderdetails()
            {
                order_id = order.Order_IdF,
                product_id = order.Product_Id,
            };
        }

        //Display
        public static Order MapViewOrder(tb_order order)
        {
            return new Order()
            {
                Order_Id = order.order_id,
                TotalBill = order.total_bill,
                Date = order.date,
                Customer_Id = order.customer_id,
                //Product_Name = order.tb_orderdetails.tb_products.product_name,
                //Product_Price = order.tb_orderdetails.tb_products.product_price,
                Store_Id = order.store_id,
                //Product_Id = order.tb_orderdetails.product_id,
                //Order_IdF = order.tb_orderdetails.order_id,
            };
        }

        //nikita

        public static User MapCustomer(tb_customers customer)
        {

            return new User()
            {
                Customer_Id = customer.customer_id,
                Customer_Name = customer.customer_name,
                Customer_Contact = customer.customer_contact,
                Customer_Email = customer.customer_email,

            };
        }

    }
}