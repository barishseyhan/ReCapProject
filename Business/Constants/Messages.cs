using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi";
        public static string RentaCarPriceInvalid = "Kiralama bedeli sıfır olamaz";
        public static string MaintenanceTime = "Sistem bakımda olduğundan listeme yapılamadı.";
        public static string CarsListed = "Araçlar listelendi.";
        public static string CarDeleted = "Araç silindi";
        public static string CarsPriceListed = "Araç fiyatı listelendi";
        public static string CarsModelListed = "Araç modelleri listelendi";
        public static string CarByIdListed = "Id'ye göre listelendi";
        public static string CarDetailList = "Araç detayları";
        public static string CarUpdated = "Araç güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandNameInvalid = "Marka ismi en az iki karakter olmalıdır";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandUpdated = "Marka adı güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserUpdated = "Kullanıcılar güncellendi";
        public static string UserNameInvalid = "Kullanıcı adı ve soyadı en az iki karakter olmalıdır";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalAddInvalidOrUpdate = "Teslim edilmeyen araç kiralanamaz.";
        public static string ReturnRental = "Kiraladığınız araç teslim alındı";
        public static string FailedCarImageAdd = "Görsel ekleme başarısız oldu";
        public static string CarImageAdded = "Görsel başarıyla eklendi";
        public static string DeleteCarImage = "Görsel başarıyla silindi";
        public static string CarImagesListed = "Görseller listelendi";
        public static string AuthorizationDenied = "İzinsiz giris";
        public static string UserRegistered = "Kullanıcı kayıt edildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Giriş kaydı oluşturuldu";
    }
}
