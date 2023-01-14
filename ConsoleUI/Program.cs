﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //OPEN CLOSED PRINCIPLE (YAZILIMA YENİ BİR ÖZELLİK EKLİYORSAN MEVCUTTAKİ HİÇBİR KODUNA DOKUNAMAZSIN)
    class Program
    {
        static void Main(string[] args)
        {
            //DTO -- Data Transformation Object
            //IoC
            //ProductTest();
            //CategoryTest();
            //DTOsTest();

        }

        private static void DTOsTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}