 Oynanış (Web Build)

 Oyunun itch.io veya simmer.io bağlantısını buraya ekleyeceksin:
https://...

 Proje Reposu

Bu repo Unity projesinin tüm dosyalarını içerir.
Library klasörü dahil değildir.

 Projenin Özeti

2D arena şeklinde küçük bir savaş sahası.

Oyuncu:

Hareket eder

Mermi ateşler

Dash yapar

Kendini iyileştirir
(4 adet aksiyon sağlanır)

Rakip:

Hasar alır

Stun olur

Roar animasyonu oynatır

Shield animasyonu oynatır
(4 adet aksiyon sağlanır, AI yoktur)

Oyuncunun aksiyonları rakibi, rakibin aksiyonları oyuncuyu etkileyebilir niteliktedir.

Ana menü:

Yeni oyun başlat

Müzik ses ayarı

Efekt ses ayarı

 Kurallara Uygunluk Kontrol Listesi
Kural	Durum	Açıklama
Oyuncu + Rakip karakter	✔️	Player ve Enemy prefabları mevcut
Player min. 4 aksiyon	✔️	Hareket, Ateş, Dash, Heal
Enemy min. 4 aksiyon	✔️	Damage alma, Stun, Roar, Shield
Aksiyonların karşılıklı etkisi	✔️	Mermiler sadece rakibi etkiler; enemy hasar verir
Fizik dışı aksiyonda farklı sonuç	✔️	Heal / Dash / Shoot farklı etkiler
Ana menü + müzik & ses ayarı	✔️	Slider + butonlar hazır
Rakipte AI / IF-ELSE yok	✔️	Sadece dummy aksiyon tetikleyici mevcut
Web Build & bağlantı	⬜	(itch.io linki eklenecek)

🕹️ Oynanış Kontrolleri
Eylem	Tuş
Hareket	WASD
Ateş	Sol Mouse
Dash	Space
Heal	Q
Pause Menü	ESC
