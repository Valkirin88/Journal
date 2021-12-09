using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml.Serialization;
using XmlSerializer= System.Xml.Serialization.XmlSerializer;


namespace Journal
{
    public class JobDatabase
    {
        

        //Имя работника
        public string worker { get; set; }
        
       
        //Цех
        public string plant { get; set; }

        //Дата выполнения работы
       
        //public DateTime date { get; set; }

        //Время выполнения работы
      
       // public DateTime time;

        //Описание работы
        public string descriptionJob { get; set; }

       
        public string equipment { get; set; }
      

        public int index { get; set; }  // порядковый номер работы


        public static List<JobDatabase> list = new List<JobDatabase>();

        public static void SaveJobs(JobDatabase job)
        {

            if (list.Count > 0)
            {

                
                List<JobDatabase> listTemp = LoadJobs();
                JobDatabase jobtemp = listTemp.Last();

                job.index = jobtemp.index + 1;
                list.Clear();
                listTemp.Clear();

                list.Add(job);
            }
            else
            { job.index = 0;
              list.Add(job);
            }

            var xmlSerializer = new XmlSerializer(typeof(List<JobDatabase>));
            FileStream filestream = new FileStream("C:\\Users\\User\\Desktop\\Всякое\\Journal", FileMode.Append, FileAccess.Write);
            

            xmlSerializer.Serialize(filestream, list);
            using (StreamWriter streamWriter = new StreamWriter(filestream))
            {
                streamWriter.Write("\n");
            }
            filestream.Close();
           
        }

        public static List<JobDatabase> LoadJobs()
        {
                        
                var xmlSerializer = new XmlSerializer(typeof(List<JobDatabase>));
                FileStream filestream = new FileStream("C:\\Users\\User\\Desktop\\Всякое\\Journal", FileMode.Open, FileAccess.Read);
                list = (List<JobDatabase>)xmlSerializer.Deserialize(filestream);
                filestream.Close();
                return list;
                
            
        }

        





        
    }
}
