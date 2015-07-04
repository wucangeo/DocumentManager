using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Threading;
using System.Windows.Media.Imaging;
using System.Collections;

namespace DocumentManager
{
    public partial class Form1 : Form
    {
        private static Regex r = new Regex(":");

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_RenameSubmit_Click(object sender, EventArgs e)
        {
            string path = this.txt_RenameFolder.Text.Trim();
            if(!Directory.Exists(path))
            {
                MessageBox.Show("文件夹不存在。");
                return;
            }
            DirectoryInfo di = new DirectoryInfo(path);
            int id = 0;
            ListFiles(di, ref id);
            
        }

        //递归遍历路径中的所有文件夹及文件
        public void ListFiles(FileSystemInfo info, ref int id)
        {
            try
            {
                //目录信息不存在
                if (!info.Exists)
                {
                    return;
                }                    
                DirectoryInfo dir = info as DirectoryInfo;
                //不是目录
                if (dir == null)
                {
                    return;
                }                    
                int pid = id;       //记录当前id，作为pid
                
                FileSystemInfo[] files = dir.GetFileSystemInfos();
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo file = files[i] as FileInfo;
                    id++;
                    //是文件
                    if (file != null)
                    {
                        string path = file.FullName;
                        //判断文件格式
                        string ext = Path.GetExtension(path);
                        if (ext.ToLower() != ".jpg" && ext.ToLower() != ".jpeg" && ext.ToLower() != ".png" && ext.ToLower() != ".mov")
                        {
                            continue;
                        }

                        //取得文件日期
                        DateTime date = GetDateTakenFromImage(path);
                        if (date == null)
                        {
                            continue;
                        }
                        if (date.DayOfYear == DateTime.Now.DayOfYear && date.Hour == DateTime.Now.Hour)
                        {
                            continue;
                        }

                        //日期格式设置
                        string dateStr = "";
                        if (this.radio_dateShort.Checked)
                        {
                            dateStr = date.ToString("yyyy-MM-dd");
                        }
                        else if (this.radio_Date_Full.Checked)
                        {
                            dateStr = date.ToString("yyyy-MM-dd HH-mm-ss");
                        }
                        else if (this.radio_DateFull.Checked)
                        {
                            dateStr = date.ToString("yyyy-MM-dd HHmmss");
                        }

                        //文件名格式
                        string parentDir = Path.GetDirectoryName(path);
                        string fileName = Path.GetFileName(path);
                        

                        string pathRename = "";
                        if (this.radio_radom.Checked)
                        {
                            //System.IO.File.Move("oldfilename", "newfilename");
                        }
                        else if (this.radio_AsDateFormat.Checked)
                        {
                            pathRename = parentDir + "\\" + dateStr + ext;
                        }
                        else if (this.radio_AddDateAhead.Checked)
                        {
                            pathRename = parentDir + "\\" + dateStr + " " + ext;
                        }
                        else if (this.radio_ReplaceStrAsDate.Checked)
                        {
                            string name = fileName.Replace(this.txt_AheadStr.Text, dateStr + " ");
                            //parentDir+"//"+this.txt_AheadStr.Text.Trim()+ext;
                            pathRename = parentDir + "\\" + name;
                        }
                        if (!File.Exists(path))
                        {
                            continue;
                        }
                        if(path == pathRename)
                        {
                            continue;
                        }
                        if (File.Exists(pathRename))
                        {
                            continue;
                            //string directoryPath = Path.GetDirectoryName(pathRename);
                            //string name = Path.GetFileNameWithoutExtension(pathRename);
                            //string extension = Path.GetExtension(pathRename);
                            //pathRename = directoryPath + "\\" + name + "_2" + extension;
                        }

                        System.IO.File.Move(path, pathRename);
                    }
                    ////对于子目录，进行递归调用
                    //else
                    //{
                    //    DirectoryInfo di = files[i] as DirectoryInfo;

                    //    string path = di.FullName;                        

                    //    ListFiles(files[i], ref id);
                    //}
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //retrieves the datetime WITHOUT loading the whole image
        public static DateTime GetDateTakenFromImage(string path)
        {
            DateTime date = DateTime.Now;
            string ext = Path.GetExtension(path);
            try
            {
                if (ext.ToLower() == ".jpg" || ext.ToLower() == ".jpeg")
                {
                    using (ExifLib.ExifReader reader = new ExifLib.ExifReader(path))
                    {
                        // Extract the tag data using the ExifTags enumeration                
                        reader.GetTagValue<DateTime>(ExifLib.ExifTags.DateTimeDigitized, out date);
                    }
                    if (date.Year > DateTime.Now.Year || date.Year < 1980)
                    {
                        date = File.GetLastWriteTime(path);
                    }
                }
                else if (ext.ToLower() == ".png" || ext.ToLower() == ".mov")
                {
                    date = File.GetLastWriteTime(path);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return date;
        }

        public static UInt32 PullPiece(UInt32 buffer, int startbit, int endbit)
        {
            UInt32 retval = 0;
            BitArray ender = new BitArray(32);
            BitArray ba = new BitArray(new Int32[] { (Int32)buffer });
            int counter = 0;
            for (int i = startbit; i <= endbit; i++)
            {
                ender[counter] = ba[i];
                counter++;
            }
            byte[] interm = new byte[4];
            ender.CopyTo(interm, 0);
            retval = BitConverter.ToUInt32(interm, 0);
            return retval;
        }

        public static DateTime DateTaken(Image getImage)
        {
            int DateTakenValue = 0x9003; //36867;

            
            if (getImage.PropertyIdList[DateTakenValue] == 0)
                return DateTime.Now;

            string dateTakenTag = System.Text.Encoding.ASCII.GetString(getImage.GetPropertyItem(DateTakenValue).Value);
            string[] parts = dateTakenTag.Split(':', ' ');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);
            int hour = int.Parse(parts[3]);
            int minute = int.Parse(parts[4]);
            int second = int.Parse(parts[5]);

            return new DateTime(year, month, day, hour, minute, second);
        }


        private void btn_SetRenameFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                this.txt_RenameFolder.Text = path;
            }
        }
    }
}
