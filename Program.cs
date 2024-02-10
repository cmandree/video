using System.Drawing;
using QRCoder;

class Program
{
    static void Main(string[] args)
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://cmandree.github.io/video/", QRCodeGenerator.ECCLevel.Q);
        
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.youtube.com/watch_popup?v=oKZSXAZWsP0", QRCodeGenerator.ECCLevel.Q);
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://youtu.be/oKZSXAZWsP0?si=0f9rXcFRlVbqfPQK", QRCodeGenerator.ECCLevel.Q);
        //QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://youtu.be/oKZSXAZWsP0", QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);
        qrCodeImage.Save("test.png");
    }
}