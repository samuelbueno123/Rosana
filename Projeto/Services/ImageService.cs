namespace Projeto.Services;

public static class ImageService
{
    public static Bitmap? LoadResizedBitmap(string? filePath, Size targetSize)
    {
        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath)) return null;

        // load into memory stream to avoid file locks from Image.FromFile
        byte[] bytes = File.ReadAllBytes(filePath);
        using var ms = new MemoryStream(bytes);
        using var src = Image.FromStream(ms);

        // if target is zero, return a clone of source (caller must dispose)
        if (targetSize.Width <= 0 || targetSize.Height <= 0)
            return new Bitmap(src);

        var dest = new Bitmap(targetSize.Width, targetSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        using (var grafico = Graphics.FromImage(dest))
        {
            grafico.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            grafico.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            grafico.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            grafico.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            grafico.DrawImage(src, new Rectangle(0, 0, targetSize.Width, targetSize.Height));
        }

        return dest;
    }
}
