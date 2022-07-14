using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyUpdater
{
    public partial class AssemblyUpdater : Form
    {
        public AssemblyUpdater()
        {
            InitializeComponent();
        }

        #region Event
        private void AssemblyUpdater_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderOpen();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //뒤에서 부터 지워야함.
            for(int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if(checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btnUncheck_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnAssemblyUpdate_Click(object sender, EventArgs e)
        {
            AssemblyUpdate(dateTimePicker1.Value, richTextBox1.Text);
        }

        #endregion

        #region Method
        private void FolderOpen()
        {
            using (CommonOpenFileDialog FolderOpen = new CommonOpenFileDialog())
            {
                FolderOpen.Title = "Select Assembly Mother Folder for updating";
                FolderOpen.Multiselect = true; // 파일 다중 선택        
                FolderOpen.IsFolderPicker = true;
                FolderOpen.InitialDirectory = @"D:\Program_Source_VS2015\PackageApplication";

                if (FolderOpen.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    string[] folderList = FolderOpen.FileNames.ToArray();
                    for (int i = 0; i < folderList.Length; i++)
                    {
                        if (!checkedListBox1.Items.Contains(folderList[i]))
                        {
                            checkedListBox1.Items.Add(folderList[i], true);
                        }
                    }
                }
            }
        }

        private void AssemblyUpdate(DateTime dtDate, string strComment)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string FilePath = this.checkedListBox1.CheckedItems[i].ToString() + @"\Properties\AssemblyInfo.cs";
                List<string> strLines = File.ReadAllText(FilePath).Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
                #region 개뻘짓함 -> 시간나면 정규식으로 변경
                //var v = from str in strLines
                //              where (SqlMethods.Like(str, "[assembly: AssemblyVersion(\"_._._._\")]")
                //                 || SqlMethods.Like(str, "[assembly: AssemblyFileVersion(\"_._._._\")]"))
                //              select str;

                //string[] versions = v.ToArray();

                //for (int j = 0; j < versions.Length; j++)
                //{
                //    int Index = versions[j].IndexOf("\")]") - 1;
                //    string upVersion = ((int)versions[j][Index] + 1).ToString();
                //    versions[j].Remove(Index, 1);
                //    versions[j].Insert(Index, upVersion);
                //}


                #endregion
                if (strLines.Count > 0)
                {
                    int CommentLine = 0;
                    int verIndex = 0;
                    string VersionPlue= string.Empty;
                    string Version = string.Empty;

                    for( int j = 0; j < strLines.Count; j++)
                    {
                        if( (strLines[j].Contains("[assembly: AssemblyVersion(\"") || strLines[j].Contains("[assembly: AssemblyFileVersion(\""))
                            && !strLines[j].Trim().StartsWith("//"))
                        {
                            verIndex = strLines[j].IndexOf("\")]") - 1;
                            VersionPlue = ((int)char.GetNumericValue(strLines[j][verIndex]) + 1).ToString();
                            strLines[j] = strLines[j].Insert(verIndex + 1, ((int)char.GetNumericValue(strLines[j][verIndex]) + 1).ToString());
                            strLines[j] = strLines[j].Remove(verIndex, 1);
                            CommentLine = j;
                            Version = strLines[j].Substring(verIndex -7, 9).Replace("\"","");
                        }
                    }

                    if(CommentLine > 0)
                    {
                        strLines[CommentLine] += Environment.NewLine + Environment.NewLine + "// " + Version + " - 고찬윤 - " + dtDate.ToString("yyyy-MM-dd") + " : " + strComment;
                        //최초 버전 아닐 시 버전주석 공백제거
                        if (!Version.Equals("\"1.0.0.0\"") && CommentLine + 1 < strLines.Count && strLines[CommentLine + 1].Equals(""))
                        {
                            strLines.RemoveAt(CommentLine + 1);
                        }
                    }
                }

                string Result = string.Join(Environment.NewLine, strLines);
                File.WriteAllText(FilePath, Result);
            }
        }
        #endregion
    }
}
