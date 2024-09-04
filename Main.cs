using PatikaLibrary;

Library library1 = new Library() // new: Creates a new object in memory using the properties contained in a class.
{
    BookName = "Bir Kitap",
    WriterName = "Ahmet",
    WriterSurname = "Yılmaz",
    PageCount = 320,
    Publisher = "Alfa Yayınları"
};

Console.WriteLine($"Kitap Adı: {library1.BookName} Yazar Adı: {library1.WriterName} Yazar Soyadı: {library1.WriterSurname} Sayfa Sayısı: {library1.PageCount} Yayınevi: {library1.Publisher} Kayıt Tarihi: {library1.RegistrationDate.ToString("yyyy-MM-dd")}"); // We print first object created with default constructor

Console.WriteLine("Kitabın adını giriniz");
string bookName = Console.ReadLine();
Console.WriteLine("Yazarın adını giriniz");
string writerName = Console.ReadLine();
Console.WriteLine("Yazarın soyadını giriniz");
string writerSurname = Console.ReadLine();
Console.WriteLine("Sayfa sayısını giriniz");
int pageCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yayınevini giriniz");
string publisher = Console.ReadLine();

Library library2 = new Library(bookName, writerName, writerSurname, pageCount, publisher);
Console.WriteLine($"Kitap Adı: {library2.BookName} Yazar Adı: {library2.WriterName} Yazar Soyadı: {library2.WriterSurname} Sayfa Sayısı: {library2.PageCount} Yayınevi: {library2.Publisher} Kayıt Tarihi: {library2.RegistrationDate.ToString("yyyy-MM-dd")}"); // We print second object created with alternative constructor
