# Multi-Threading Task Uygulaması

Bu proje, C#'ta paralel ve sıralı işlem çalıştırmayı gösteren bir örnektir. 50 adet görev (task) simülasyonu yapılarak hem sıralı hem de paralel çalıştırma yöntemleri karşılaştırılır. Bu uygulama, zamanlayıcıları kullanarak her görev için geçen süreyi ölçer.

## Özellikler

- **Paralel Çalıştırma**: 50 adet görev paralel olarak çalıştırılır ve tüm görevlerin bitmesi beklenir.
- **Sıralı Çalıştırma**: 50 adet görev sırasıyla çalıştırılır, her görev tamamlanmadan bir sonraki başlatılmaz.
- **Zamanlama**: Her görev için geçen süre ölçülür ve konsola yazdırılır.
- **Simülasyon Gecikmesi**: Her görevde rastgele bir gecikme (1-3 saniye arasında) simüle edilerek gerçek dünya uygulamaları taklit edilir.

## Kullanım

1. **MultiThreadingTask** sınıfını projenize dahil edin.
2. `ParalelCalistir` ve `SiraliCalistir` metodlarını kullanarak paralel ve sıralı işlem simülasyonlarını çalıştırabilirsiniz.
3. Her iki işlem türü de görevlerin tamamlanma sürelerini konsola yazdırır.

### Örnek Kullanım

```csharp
using MultiThreadingTask;

class Program
{
    static void Main()
    {
        // Paralel çalıştırma
        SiraliCalistir();

        // Paralel çalıştırma
        ParalelCalistir();
    }
}


Sıralı çalıştırma başladı...
Task 0 başladı: 12:00:00.000
Task 0 bitti: 12:00:03.500, Süre: 3500 ms
Task 1 başladı: 12:00:03.500
Task 1 bitti: 12:00:07.000, Süre: 3500 ms
...
Sıralı çalıştırma tamamlandı. Toplam Süre: 175000 ms

Paralel çalıştırma başladı...
Task 0 başladı: 12:00:10.000
Task 0 bitti: 12:00:12.000, Süre: 2000 ms
Task 1 başladı: 12:00:10.000
Task 1 bitti: 12:00:13.000, Süre: 3000 ms
...
Tüm tasklar tamamlandı.
