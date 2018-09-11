using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CountdownClock
{
    public class File
    {
        static private File instance;
       private string path =Application.StartupPath + "\\ndc07.txt";
      
        public string[] readFile()
        {
            FileStream fs = new FileStream(path, FileMode.Open,FileAccess.ReadWrite);
            string[] result = new string[] { "ndc07", "ndc07" };
            StreamReader read = new StreamReader(fs, Encoding.Unicode);
                for (int i=0;i<2;i++)
                {
                    result[i] = read.ReadLine();
                }
            read.Close();
            fs.Close();
            return result;
        }
        public void writeFile(string[] text)
        {
            FileStream fs = new FileStream(path, FileMode.Create,FileAccess.ReadWrite);//Tạo file mới tên là test.txt       
            //mỗi lần ghi lại sẽ xóa toàn bộ dữ liệu
            StreamWriter write = new StreamWriter(fs,Encoding.Unicode);
           
                foreach (string item in text)
                {
                    write.WriteLine(item);
                }
            write.Flush();
            fs.Close();
        }
        public static File Instance { get { if (instance == null) instance = new File();  return instance; }
            private set => instance = value; }

        

    }
}
