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

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;



namespace Journal
{
    public class JobDatabase
    {


        //Имя работника
        public string worker;


        //Цех
        public string plant;

        //Дата выполнения работы

        //public DateTime date { get; set; }

        //Время выполнения работы

        // public DateTime time;

        //Описание работы
        public string descriptionJob;


        public string equipment;


        public int index;  // порядковый номер работы


        public static List<JobDatabase> list = new List<JobDatabase>();

        public static void SaveJobs(JobDatabase job)
        {
            list.Add(job);

           
            //JobDatabase lastJob = lastJobList.Last();

            //if (lastJobList.Count > 0)
            //{



            //    if (job != lastJob)
            //    { list.Add(job); }
            //    else if (job == lastJob)
            //    { MessageBox.Show("Попытка сохранить одну работу дважды", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            //}
            //else
            //{
            //    list.Add(job);
            //}

            var xmlSerializer = new XmlSerializer(typeof(List<JobDatabase>));
            FileStream filestream = new FileStream("C:\\Users\\User\\Desktop\\Всякое\\Journal", FileMode.Append, FileAccess.Write);

            xmlSerializer.Serialize(filestream, list);

            filestream.Close();

            list.Clear();
            List<JobDatabase> lastJobList = LoadJobs();
        }

        public static List<JobDatabase> LoadJobs()
        {

            var xmlSerializer = new XmlSerializer(typeof(List<JobDatabase>));
            FileStream filestream = new FileStream("C:\\Users\\User\\Desktop\\Всякое\\Journal", FileMode.Open, FileAccess.Read);
            List<JobDatabase> lastJob = xmlSerializer.Deserialize(filestream) as List<JobDatabase>;
            filestream.Close();
            return lastJob;


        }



    }
            
    }
