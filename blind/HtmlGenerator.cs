using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace Blind
{
    public class HtmlGenerator
    {
        private string img_prefix = "<img src='data:image/png;base64,";
        private string img_suffix = "' />";

        private string template;
        private string html = "";

        public string Units { get; set; } = "meters";

        public HtmlGenerator()
        {
            using (var template = File.OpenRead("../../template.html"))
            {
                using (var reader = new StreamReader(template))
                {
                    this.template = reader.ReadToEnd();
                    Console.Write(this.template);
                }
            }
        }

        public HtmlGenerator SetImage(Bitmap[] bitmaps)
        {
            StringBuilder builder = new StringBuilder();
            foreach(Bitmap bitmap in bitmaps)
            {
                builder.Append(img_prefix)
                    .Append(ToBase64(bitmap))
                    .Append(img_suffix);
            }
            string html = this.html.Equals("") ? template : this.html;
            this.html = html
                .Replace("@imgs@", builder.ToString());
            // Console.Write(this.html);
            return this;
        }

        public HtmlGenerator SetImage(Bitmap bitmap)
        {
            return SetImage(new Bitmap[] { bitmap });
        }


        public HtmlGenerator SetImage(Bitmap front, Bitmap left, Bitmap top, Bitmap iso)
        {
            return this.SetImage(new Bitmap[] { front, left, top, iso });
        }

        public HtmlGenerator SetTable(int entities, int vertices, int triangles, double area, double volume)
        {
            string html = this.html.Equals("") ? template : this.html;
            this.html = html
                .Replace("@entity@", entities.ToString())
                .Replace("@vertices@", vertices.ToString())
                .Replace("@triangle@", triangles.ToString())
                .Replace("@area@", area.ToString() + " squire " + Units)
                .Replace("@volume@", volume.ToString() + " cubic " + Units);
            return this;
        }

        public void Generate(string path = "")
        {
            using (var fs = File.Create(path + $"{DateTime.Now:MMddHHmmss}" + ".html" + path))
            {
                using (var streamWriter = new StreamWriter(fs))
                {
                    streamWriter.Write(html);
                    streamWriter.Flush();
                }
            }
        }

        private string ToBase64(Bitmap bmp)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(arr, 0, (int)ms.Length);
            ms.Close();
            String strbaser64 = Convert.ToBase64String(arr);
            return strbaser64;
        }
    }
}