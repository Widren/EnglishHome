using EnglishHome.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace EnglishHome.ViewModels
{
    public class ProductViewModel
    {
        public ObservableCollection<Urunler> Products { get; set; }
        public ProductViewModel()
        {
            Products = new ObservableCollection<Urunler>();

            Products.Add(new Urunler { urun = "Softy Wellsoft Tv Battaniye 120x170 Cm Çikolata", fiyat = 149.99, image = "battaniye.jpg", renk = "Çikolata", rating = 0.0, CategoryID = 1, SubCategoryID = 1 });
            Products.Add(new Urunler { urun = "Liberty Bloom Pamuklu Çift Kişilik Nevresim Seti 200x220 Cm Tarçın", fiyat = 499.99, image = "nevresim.jpg", renk = "Pembe", rating = 0.0, CategoryID = 1, SubCategoryID = 2 });
            Products.Add(new Urunler { urun = "Silikonlu Yastık 50X70 Cm Ekru", fiyat = 99.99, image = "yastik.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 1, SubCategoryID = 3 });
            Products.Add(new Urunler { urun = "Siesta Mikrofiber Çift Kişilik Yorgan 195x215 Cm Beyaz", fiyat = 499.99, image = "yorgan.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 1, SubCategoryID = 4 });

            Products.Add(new Urunler { urun = "Icy Alüminyum Döküm Tencere Seti 7 Parça Siyah", fiyat = 2449.99, image = "tencere.jpg", renk = "Siyah", rating = 0.0, CategoryID = 2, SubCategoryID = 5 });
            Products.Add(new Urunler { urun = "Cassidy Cam Kavanoz 1100 Ml Şeffaf", fiyat = 109.99, image = "kavanoz.jpg", renk = "Kahverengi", rating = 0.0, CategoryID = 2, SubCategoryID = 6 });
            Products.Add(new Urunler { urun = "Pamira Porselen 6 Kişilik Kahve Fincan Takımı 80 Ml Mavi", fiyat = 249.99, image = "fincan.jpg", renk = "Mavi", rating = 0.0, CategoryID = 2, SubCategoryID = 7 });
            Products.Add(new Urunler { urun = "Galia Butterfly Bone Porselen 12 Parça Yemek Takımı 25 - 20 - 15 Cm Pembe", fiyat = 1199.99, image = "tabak.jpg", renk = "Beyaz-Altın", rating = 0.0, CategoryID = 2, SubCategoryID = 8 });

            Products.Add(new Urunler { urun = "Quadro Pamuklu 4'lü Set Havlu Seti 30x40 Cm Beyaz - Bordo", fiyat = 119.99, image = "havlu.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 3, SubCategoryID = 9 });
            Products.Add(new Urunler { urun = "Casa Cam Banyo Sıvı Sabunluk 8x14 Cm Gold", fiyat = 29.99, image = "sabunluk.jpg", renk = "Beyaz", rating = 0.0, CategoryID = 3, SubCategoryID = 10 });
            Products.Add(new Urunler { urun = "Plain Pamuklu Bornoz L-xl Kiremit", fiyat = 349.99, image = "bornoz.jpg", renk = "Kiremit", rating = 0.0, CategoryID = 3, SubCategoryID = 11 });
            Products.Add(new Urunler { urun = "Evelyn 3'lü Banyo Seti Bej", fiyat = 299.99, image = "banyoSeti.jpg", renk = "Bej", rating = 0.0, CategoryID = 3, SubCategoryID = 12 });

            Products.Add(new Urunler { urun = "Vera Şönil Halı Gri", fiyat = 999.99, image = "hali.jpg", renk = "Gri", rating = 0.0, CategoryID = 4, SubCategoryID = 13 });
            Products.Add(new Urunler { urun = "Fluffy Peluş Kırlent Kılıfı 45x45 cm Mürdüm", fiyat = 119.99, image = "kirlent.jpg", renk = "Mürdüm", rating = 0.0, CategoryID = 4, SubCategoryID = 14 });
            Products.Add(new Urunler { urun = "Mace Polyester Masa Örtüsü 150x200 Cm Antrasit", fiyat = 149.99, image = "masaOrtusu.jpg", renk = "Mavi", rating = 0.0, CategoryID = 4, SubCategoryID = 15 });
            Products.Add(new Urunler { urun = "Marcel Sehpa 30x30x30 Cm Krem", fiyat = 249.99, image = "sehpa.jpg", renk = "Krem", rating = 0.0, CategoryID = 4, SubCategoryID = 16 });
        }
        public ProductViewModel(int categoryID, int subCategoryID)
        {
            Products = new ObservableCollection<Urunler>();
            #region c
            if (categoryID == 1)
            {
                if (subCategoryID == 1)
                {
                    Products.Add(new Urunler { urun = "English Home Pamuklu Çift Kişilik Battaniye", fiyat = 89.99, image = "battaniye.jpg", renk = "mavi", rating = 4.2, CategoryID = 1, SubCategoryID = 1 });
                }
                else if (subCategoryID == 2)
                {
                    Products.Add(new Urunler { urun = "Paradise FlowersPamuklu Çift Kişilik Nevresim Seti", fiyat = 149.99, image = "nevresim.jpg", renk = "kırmızı", rating = 3.6, CategoryID = 1, SubCategoryID = 2 });
                }
                else if (subCategoryID == 3)
                {
                    Products.Add(new Urunler { urun = "Cozy Sherpa Yastık", fiyat = 99.99, image = "yastik.jpg", renk = "sarı", rating = 2.8, CategoryID = 1, SubCategoryID = 3 }); 
                }
                else if (subCategoryID == 4)
                {
                    Products.Add(new Urunler { urun = "Cozy Sherpa Çift Kişilik Yorgan", fiyat = 299.99, image = "yorgan.jpg", renk = "yeşil", rating = 4.8, CategoryID = 1, SubCategoryID = 4 });
                }
            }
            else if (categoryID == 2)
            {
                if (subCategoryID == 5)
                {
                    Products.Add(new Urunler { urun = "Emma Granit Cam Kapaklı Derin Tencere", fiyat = 119.99, image = "tencere.jpg", renk = "mavi", rating = 4.2, CategoryID = 2, SubCategoryID = 5 });
                    
                }
                else if (subCategoryID == 6)
                {
                    Products.Add(new Urunler { urun = "Urban Diamond Cam Kavanoz", fiyat = 23.99, image = "kavanoz.jpg", renk = "kırmızı", rating = 3.6, CategoryID = 2, SubCategoryID = 6 });
                   
                }
                else if (subCategoryID == 7)
                {
                    Products.Add(new Urunler { urun = "Bella Porselen 12 Parça Kahve Fincan Takımı", fiyat = 49.99, image = "fincan.jpg", renk = "sarı", rating = 2.8, CategoryID = 2, SubCategoryID = 7 });
                    
                }
                else if (subCategoryID == 8)
                {
                    Products.Add(new Urunler { urun = "Roseanne Porselen 24 Parça Yemek Takımı", fiyat = 279.99, image = "tabak.jpg", renk = "yeşil", rating = 4.8, CategoryID = 2, SubCategoryID = 8 });
                }
            }
                
            else if (categoryID == 3)
            {
                if (subCategoryID == 9)
                {
                    Products.Add(new Urunler { urun = "Romantic Stripe Floşlu Banyo Havlusu Takımı", fiyat = 129.99, image = "havlu.jpg", renk = "mavi", rating = 4.2, CategoryID = 3, SubCategoryID = 9 });
                    
                }
                else if (subCategoryID == 10)
                {
                    Products.Add(new Urunler { urun = "Adela Akrilik Banyo Sıvı Sabunluk", fiyat = 19.99, image = "sabunluk.jpg", renk = "kırmızı", rating = 3.6, CategoryID = 3, SubCategoryID = 10 });
                    
                }
                else if (subCategoryID == 11)
                {
                    Products.Add(new Urunler { urun = "Space Pamuk Çocuk Bornoz", fiyat = 99.99, image = "bornoz.jpg", renk = "sarı", rating = 2.8, CategoryID = 3, SubCategoryID = 11 });
                    
                }
                else if (subCategoryID == 12)
                {
                    Products.Add(new Urunler { urun = "Elegance 3'lü Banyo Seti", fiyat = 299.99, image = "banyoSeti.jpg", renk = "yeşil", rating = 4.8, CategoryID = 3, SubCategoryID = 12 });
                }
            }
            else if (categoryID == 4)
            {
                if (subCategoryID == 13)
                {
                    Products.Add(new Urunler { urun = "Vera Şönil Halı", fiyat = 179.99, image = "hali.jpg", renk = "mavi", rating = 4.2, CategoryID = 4, SubCategoryID = 13 });
                    
                }
                else if (subCategoryID == 14)
                {
                    Products.Add(new Urunler { urun = "Rabbit Peluş Kırlent Kılıfı", fiyat = 69.99, image = "kirlent.jpg", renk = "kırmızı", rating = 3.6, CategoryID = 4, SubCategoryID = 14 });
                   
                }
                else if (subCategoryID == 15)
                {
                    Products.Add(new Urunler { urun = "Carla Polyester Masa Örtüsü", fiyat = 99.99, image = "masaOrtusu.jpg", renk = "sarı", rating = 2.8, CategoryID = 4, SubCategoryID = 15 });
                   
                }
                else if (subCategoryID == 16)
                {
                    Products.Add(new Urunler { urun = "Karmen Metal Katlanabilir Sehpa", fiyat = 399.99, image = "sehpa.jpg", renk = "yeşil", rating = 4.8, CategoryID = 4, SubCategoryID = 16 }); ;
                }
            }
            #endregion
            AddToCartCommand = new Command(() => AddToCart());
            ViewCartCommand = new Command(() => ViewCart());
        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQlite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    ProductID = SelectedProduct.UrunID,
                    ProductName = SelectedProduct.urun,
                    Price = SelectedProduct.fiyat,
                    
                    
                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault(c => c.ProductID == SelectedProduct.UrunID);
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Sepet", "Ürün Sepete Eklendi", "OK");
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                cn.Close();
            }
        }

        private void ViewCart()
        {
            throw new NotImplementedException();
        }

        private Urunler _SelectedProduct;
        public Urunler SelectedProduct;
      

        public Command AddToCartCommand { get; set; }
        public Command ViewCartCommand { get; set; }
    }

}

