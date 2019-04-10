using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Imgur.API.Models;
using System.Windows.Forms;

namespace OKF_Jelenetes
{
    class ReportGenerator
    {
        /*static string ReportString = @"[center][img] https://i.imgur.com/RCyidnw.png [/img][/center]

[center][font=century gothic][size=18pt][color=darkred] Országos Katasztrófavédelmi Főigazgatóság [/color][/size][/font][/center]
[center][font=century gothic][size=18pt][color=darkred] Jelentés [/color][/size][/font][/center]

[hr]

[center][font=century gothic][size=16pt][color=darkred][b] Név: [/b][/color][/size][/font][/center]
[center][font=century gothic][size=12pt][color=white] - {0} - [/color][/size][/font][/center]

[center][font=century gothic][size=16pt][color=darkred][b] Rendfokozat: [/b][/color][/size][/font][/center]
[center][font=century gothic][size=12pt][color=white] - {1} - [/color][/size][/font][/center]

[center][font=century gothic][size=16pt][color=darkred][b] Káreset leírása: [/b][/color][/size][/font][/center]
[center][font=century gothic][size=12pt][color=white] - {2} - [/color][/size][/font][/center]

[center][font=century gothic][size=16pt][color=darkred][b] Kép: [/b][/color][/size][/font][/center]
[center][font=century gothic][size=12pt][color=white] - {3} - [/color][/size][/font][/center]

[center][font=century gothic][size=16pt][color=darkred][b] Kelt: [/b][/color][/size][/font][/center]
[center][font=century gothic][size=12pt][color=white] - {4} - [/color][/size][/font][/center]";*/

        static string ReportString = @"[center][img]http://kepmegosztas.hu/images/ed226489557f6acaea6b27dfdc448595.png  [/img][/center]

[center][color=#B8312F][size=22]Országos Katasztrófavédelmi Főigazgatóság [/size][/color][/center]

[center][color=#FFFFFF][size=18]Jelentés[/size][/color][/center]


[center][color=#B8312F] Név: [/color][/center]
[center][color=#FFFFFF] - {0} - [/color][/center]

[center][color=#B8312F] Rendfokozat: [/color][/center]
[center][color=#FFFFFF] - {1} - [/color][/center]

[center][color=#B8312F] Káreset leírása: [/color][/center]
[center][color=#FFFFFF] - {2} - [/color][/center]

[center][color=#B8312F] Kép: [/color][/center]
[center][color=#FFFFFF] - {3} - [/color][/center]

[center][color=#B8312F] Kelt: [/color][/center]
[center][color=#FFFFFF] - {4} - [/color][/center]";

        public static async Task GenerateReport(string Name, string Rank, string Desc, string ImagePath, string FilePath)
        {
            IImage ImageDetails = await ImageUpload.UploadImage(ImagePath);
            
            string Image = ImageDetails.Link;
            string Date = DateTime.Now.ToString("yyyy. MM. dd.");
            string Date2 = DateTime.Now.ToString("yyyy_MM_ddTHH'_'mm'_'sszzz");
            string Output = String.Format(ReportString, Name, Rank, Desc, Image, Date);

            ImageDetails.Title = "SeeMTA v2 OKF Jelentés";
            ImageDetails.Name = Name + " " + Rank + " jelentése (" + Date + ")";

            string fileName = "\\jelentes_" + Date2.Replace(':', '_') + ".txt";

            try
            {
                StreamWriter sw = new StreamWriter(FilePath + fileName);
                sw.Write(Output);
                sw.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
                
        }
    }
}
