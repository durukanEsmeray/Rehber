namespace BusinessLogicLayer
{
    public class Class1
    {
        // (BusinessLogicLayer) Bu katmanımız sunum katmanı ile DatabaseLogicLayer katmanı arasında duran ortadaki katmanımız.
        // Görevi şudur; sunum katmanından gelen datayı kontrol etmek, datanın içerisinde bizim koyduğumuz kurallara uyuyor mu uymuyor mu, veri tarafında sıkıntı var mı.. bunları DatabaseLogicLayer a göndermeden önce düzenlemek ya da veriyi biraz manipüle edeceksek bu katmanda yapıyoruz. 
        // Bu sunum katmanından database e olan görevi. 
        // tam tersinde ise database den gelen ham datayı işleyip bir generic class haline getirip sunum katmanına sunma işlemi veya gelen data içerisinde yine belli bir işlem yaparak sunum katmanına iletme vazifesi burdaki BLL ye yani iş katmanımıza düşüyor bunun görevi.
    }
}