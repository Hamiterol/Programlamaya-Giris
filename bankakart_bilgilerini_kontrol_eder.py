## Girilen kart bilgisi sayesinde gerçekten banka kartı olup olmadığını sorgulayan kod bloğu

import math

sayilar = input("Sayi giriniz: ")# Kullanıcıdan kart bilgisi alınıyor
list=[]
for sayi in sayilar: #alınan kart bilgisi döngü ile listeleniyor
   list.append(sayi)
 

def rakam_toplami(sayi): # listenen sayı  çift olan sayıları örneğin 10 sayısını 1+0=1 şeklinde ekrana yazdıran kod bloğu 
    while sayi >= 10:  
        sayi = sum(int(x) for x in str(sayi))
    return sayi
yeni_liste = [rakam_toplami(int(x) * 2) for x in list]# sayıların *2 yapılıyor ve yukarıda bulunan kodu çalıştırılıyor
toplam = sum(yeni_liste) # 2 katı alınan yeni listeyi toplayan kod

print(toplam)

if  toplam==80:
    print("Geçerli  karttır")
else:
    print("Geçersiz karttır")



   
