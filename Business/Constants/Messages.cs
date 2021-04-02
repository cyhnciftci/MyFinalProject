using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "bakım var birader";
        public  static string ProductsListed="listelendi";
        public  static object ProductCountError = "Limiti aştınız";
        public static string ProductNameAlreadyExists="aynı isimle kayıtlı ürün var";
        public static string CategoryLimitExceded="limit aşıldı";
        public static string AuthorizationDenied="yetkin yok";
        public static string UserRegistered="kayıt oldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError="hatalı parola";
        public static string SuccessfulLogin="başarılı giriş";
        public static string UserAlreadyExists="kullanıcı mevcut";
        public static string ProductCountOfCategoryError="error update";
    }
}
