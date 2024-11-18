### Ödev 1: Şirket Departmanları ve Çalışanlar
Bir şirketin farklı departmanları ve her departmanda çalışanlar olduğunu düşün.

**Veriler:**
- Departman listesi (`DepartmanId` ve `DepartmanAdı` içerir).
- Çalışan listesi (`ÇalışanId`, `ÇalışanAdı` ve `DepartmanId` içerir).

**Görev:**
1. `GroupJoin` kullanarak her departmanda çalışanların listesini gruplandır.
2. Sonuçları departman adına göre `OrderBy` ile sırala.
3. Çıktıyı departman adıyla birlikte çalışanların isimlerini alt alta listele.

### Ödev 2: Kitaplar ve Yazarlar
Bir kütüphanede bulunan kitapların ve kitapların yazarlarının listesini düşün.

**Veriler:**
- Yazar listesi (`YazarId` ve `YazarAdı` içerir).
- Kitap listesi (`KitapId`, `KitapAdı` ve `YazarId` içerir).

**Görev:**
1. `GroupJoin` kullanarak her yazarın yazdığı kitapları listele.
2. Sonuçları yazar adına göre `OrderBy` ile sırala.
3. Çıktıyı her yazarın kitaplarıyla birlikte listele.

### Ödev 3: Öğrenciler, Dersler ve Notlar
Bir okulda öğrenciler, dersler ve bu derslerde aldıkları notlar olduğunu düşün.

**Veriler:**
- Öğrenci listesi (`ÖğrenciId` ve `ÖğrenciAdı` içerir).
- Ders listesi (`DersId` ve `DersAdı` içerir).
- Notlar listesi (`ÖğrenciId`, `DersId` ve `Not` içerir).

**Görev:**
1. `GroupJoin` kullanarak her öğrencinin aldığı dersleri ve notlarını gruplandır.
2. Her öğrenciyi adına göre `OrderBy` ile sırala.
3. Her öğrenci için aldığı ders ve notları listele.

