using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using XmlSerializer= System.Xml.Serialization.XmlSerializer;
using System.Xml;

namespace Journal
{
    public class JobDatabase
    {
        public string worker;
        public string plant;
        public string descriptionJob;
        public string equipment;
        public int index;  // порядковый номер работы
        public static List<JobDatabase> list = new List<JobDatabase>();
        public List<JobDatabase> lastJob;
        

        public void SaveJobs(JobDatabase job)
        {
            list.Add(job);

            var xmlSerializer = new XmlSerializer(typeof(List<JobDatabase>));

            FileStream filestream = new FileStream("C:\\Users\\User\\Desktop\\Rubbish\\Journal", FileMode.OpenOrCreate, FileAccess.Write); 
            xmlSerializer.Serialize(filestream, list);
            filestream.Close();

            //list.Clear();
            List<JobDatabase> lastJobList = LoadJobs();
        }

        public List<JobDatabase> LoadJobs()
        {
            if (lastJob!=null)
            {
                lastJob.Clear();
            }
            var xmlSerializer = new XmlSerializer(typeof(List<JobDatabase>));
            FileStream filestream = new FileStream("C:\\Users\\User\\Desktop\\Rubbish\\Journal", FileMode.OpenOrCreate, FileAccess.Read);
            lastJob = xmlSerializer.Deserialize(filestream) as List<JobDatabase>;
            filestream.Close();
            return lastJob;
        }
    }
}
