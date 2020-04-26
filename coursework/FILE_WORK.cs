using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace coursework
{
    class FILE_WORK
    {
        public static string adr_file;

        public static List<string> ReadLines()
        {
            return File.ReadAllLines(adr_file).ToList();
        }
        public static void Save(List<string> list)
        {
            File.WriteAllLines(adr_file, list.ToArray());
        }
        public static string ReadLine(int id)
        {
            List<string> list = ReadLines();
            string st = "";
            foreach (string s in list)
            {
                if (s.StartsWith(id.ToString() + ";"))
                {
                    st = s;
                    break;
                }
            }
            return st;
        }
        public static void UpDate(int id, string nazv, string vid, string opisanie)
        {
            List<string> list = ReadLines();
            if (id == 0)
            {
                foreach (string s in list)
                {
                    string[] ss = s.Split(';');
                    if ((Convert.ToInt32(ss[0]) > id))
                    {
                        id = Convert.ToInt32(ss[0]);
                    }
                }
                id++;
                string st = id.ToString() + ";"
                            + nazv + ";"
                            + vid + ";"
                            + opisanie;
                list.Add(st);
            }
            else
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    if (list[i].StartsWith(id.ToString() + ";"))
                    {
                        list[i] = id.ToString() + ";"
                            + nazv + ";"
                            + vid + ";"
                            + opisanie;
                        break;
                    }
                }
            }
            Save(list);
        }
        public static void Delete(int id)
        {
            List<string> list = ReadLines();
            string st = ReadLine(id);
            list.Remove(st);
            Save(list);
        }
        public static DataView ReadTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Название");
            dt.Columns.Add("Вид");
            dt.Columns.Add("Описание");
            List<string> list = ReadLines();
            foreach (string s in list)
            {
                string[] ss = s.Split(';');
                dt.Rows.Add(ss[0], ss[1], ss[2], ss[3]);
            }
            return dt.DefaultView;
        }
    }
}
