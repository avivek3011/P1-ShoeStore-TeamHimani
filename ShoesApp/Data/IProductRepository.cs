﻿using Data.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data
{
    interface IProductRepository
    {
        IEnumerable<tb_products> GetProducts();
        tb_products GetProductById(int? id);
        void AddProduct(tb_products product);
        tb_products UpdateProduct(int? id, tb_products product);
        void DeleteProduct(int id);
        void Save();
        string CheckUserRole(string username);
        bool CheckColorAvailability(int? selectedcolorid, int? productid);

        bool CheckSizeAvailability(int? selectedsizeid, int? productid);
    }
}
