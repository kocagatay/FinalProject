using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();  
    }
}

//DEĞİŞTİRMELER YAPTIK ÖNCEKİ KODLARIMIZI DAHA İYİ BİR HALE GETİRDİK
//BUNA DA CODE REFACTORİNG DENİYOR...