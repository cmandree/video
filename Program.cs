using System.Drawing;
using QRCoder;

class Program
{
    static void Main(string[] args)
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://drive.google.com/file/d/1cvvHeCfOzSuMLXFt9IespWblsJ7uRkgG/view?usp=drive_link", QRCodeGenerator.ECCLevel.Q);
        
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.youtube.com/watch_popup?v=oKZSXAZWsP0", QRCodeGenerator.ECCLevel.Q);
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://youtu.be/oKZSXAZWsP0?si=0f9rXcFRlVbqfPQK", QRCodeGenerator.ECCLevel.Q);
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://youtu.be/oKZSXAZWsP0", QRCodeGenerator.ECCLevel.Q);
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("file:///C:/Users/cmand/Documents/Projects/qrcodecmd-main/index.html", QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);
        qrCodeImage.Save("test.png");

        //testing
        //<iframe width="560" height="315" src="https://www.youtube.com/embed/oKZSXAZWsP0?si=67ahqT1cxE5hFUTm&amp;controls=0" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>
    }
}