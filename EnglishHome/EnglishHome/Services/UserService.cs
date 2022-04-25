using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using System.Linq;
using EnglishHome.Models;
using Firebase.Database.Query;

namespace EnglishHome.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://englishhome-3e792-default-rtdb.firebaseio.com/");

      
        }

        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await client.Child("Users")
                .OnceAsync<Kullanici>()).Where(u => u.Object.KUllaniciMail == uname).FirstOrDefault();
            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname, string password, string ad, string soyad, int telno)
        {
            if(await IsUserExists(uname)==false)
            {
                await client.Child("Users")
                    .PostAsync(new Kullanici()
                    {
                        KUllaniciMail = uname,
                        KUllaniciSifre=password,
                        KUllaniciAd=ad,
                        KUllaniciSoyad=soyad,
                        KUllaniciTelNo=telno
                        
                        
                    });
                return true;
                
            }
            else
            { return false; }
        }

        public async Task<bool> LoginUser(string uname, string password)
        {
            var user = (await client.Child("Users")
                .OnceAsync<Kullanici>()).Where(u => u.Object.KUllaniciMail == uname)
                .Where(u => u.Object.KUllaniciSifre == password).FirstOrDefault();
            return (user != null);
        }
    }
}
