# Arena Mini Battle — Unity Prototype

Bu repository, üretici yapay zekâ dersi için hazırlanmış **basit Unity prototip** kaynaklarını içerir.
Library klasörü hariç tüm proje dosyalarını bu repoda tutabilirsiniz.

## İçerik
- Basit Player hareket ve ateş sistemi (PlayerController.cs)
- Bullet prefab script (Bullet.cs)
- Enemy placeholder script (Enemy.cs) — rakip şu aşamada AI içermez, sadece aksiyonlar için trigger'lar sağlar.
- Audio ayarları ve UI için örnek scriptler
- MainMenu ve GameScene için placeholder Unity sahne dosyaları (manuel olarak Unity içinde import edin veya yerlerine taşıyın)

## Nasıl kullanılır
1. Unity Hub ile yeni bir 2D Unity projesi oluşturun (ör. 2021.3 LTS veya 2020+).
2. Bu repodaki `Assets` klasörünü proje köküne kopyalayın.
3. Unity'de `Assets/Scripts` altındaki scriptleri GameObject'lere bağlayın:
   - Player prefab: Rigidbody2D, PlayerController, Collider2D
   - Bullet prefab: Collider2D (Trigger), Bullet script
   - Enemy prefab: Collider2D (isTrigger=false), Enemy script, Animator (opsiyonel)
4. `Scenes` klasöründeki sahneleri açıp düzenleyin veya kendi sahnelerinizi yaratın.
5. WebGL build ayarları ile build alıp itch.io'ya yükleyin.

## Oyun Kuralları - Ders Gereksinimleriyle Uyum
- Player ve Enemy objeleri var.
- Her iki karakter de en az 4 aksiyona uygun şekilde tasarlandı (player için çalışan aksiyonlar; enemy için animasyon/aksiyon trigger'ları).
- Ana menü, music/sfx slider ve yeni oyun butonu eklemeniz için hazır arayüz noktaları bulunmaktadır.

## License
Kendi çalışmalarınızda kullanabilirsiniz. Kopyalanan kod veya üçüncü parti içerikleri intihal kontrolünden geçiriniz.