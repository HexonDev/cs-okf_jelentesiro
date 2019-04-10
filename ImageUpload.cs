using Imgur.API.Authentication.Impl;
using Imgur.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imgur.API.Models;
using Imgur.API.Endpoints.Impl;
using System.Windows.Forms;

namespace OKF_Jelenetes
{

    public class ImageUpload
    {
        static string ClientID = "c1c2faa09eb27c2";
        static string ClientSecret = "fd9ed788d0dff771465a4d747b7c88d7d7858985";

        /*public static IImage UploadImage(string ImagePath)
        {
            try
            {
                var client = new ImgurClient(ClientID, ClientSecret);
                var endpoint = new ImageEndpoint(client);
                IImage image;
                using (var fs = new FileStream(@ImagePath, FileMode.Open))
                {
                    image = endpoint.UploadImageStreamAsync(fs).GetAwaiter().GetResult();
                }
                Debug.Write("Image uploaded. Image Url: " + image.Link);
                MessageBox.Show("Image uploaded. Image Url: " + image.Link);
                return image;
            }
            catch (ImgurException imgurEx)
            {
                MessageBox.Show("An error occurred uploading an image to Imgur.");
                MessageBox.Show(imgurEx.Message);
                return null;
            }
        }*/

        public static async Task<IImage> UploadImage(string ImagePath)
        {
            try
            {
                var client = new ImgurClient(ClientID, ClientSecret);
                var endpoint = new ImageEndpoint(client);
                IImage image;
                using (var fs = new FileStream(@ImagePath, FileMode.Open))
                {
                    image = await endpoint.UploadImageStreamAsync(fs);
                }
                Debug.Write("Image uploaded. Image Url: " + image.Link);
                return image;
            }
            catch (ImgurException imgurEx)
            {
                Debug.Write("An error occurred uploading an image to Imgur.");
                Debug.Write(imgurEx.Message);
                return null;
            }
        }



    }
}
