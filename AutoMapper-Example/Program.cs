/* AutoMapper, farklı tipteki nesneleri birbirlerine otomatik olarak dönüştürmeyi sağlayan bir kütüphanedir.
 * Bu kütüphane, 2 nesneyi birbirine eşleyen karmaşık koddan kurtulmak için oluşturulmuştur.
 * Projelerde zaman kazandırır ve kod karmaşıklığını azaltır.
 * Kurulumu oldukça basittir ve NuGet paketi olarak indirilebilir. 
*/
using AutoMapper;
using AutoMapper_Example;

var config = new MapperConfiguration(cfg => { // Bu yöntem ile Book sınıfı BookDTO sınıfı ile eşleyen
    cfg.CreateMap<Book, BookDTO>(); // config isminde bir nesne oluşturulur.
});

IMapper mapper = config.CreateMapper(); // Nesneleri dönüştürmek için config nesnesi kullanılarak
                                        // CreateMapper yöntemi ile mapper isminde bir nesne oluşturulur.

var book = new Book
{
    Id = 1,
    Title = "Kutadgu Bilig",
    Price = 120,
    Author = "Yusuf Has Hacib"
};

var bookDTO = mapper.Map<BookDTO>(book); // Nesneler dönüştürülürür.


Console.WriteLine("Kitap ID: " + bookDTO.Id);
Console.WriteLine("Kitap Adı: " + bookDTO.Title);
Console.WriteLine($"Kitap Fiyat: {bookDTO.Price} TL");
Console.WriteLine("Kitap Yazarı: " + bookDTO.Author);