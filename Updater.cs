using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Entity;
using System.Management;
using Updater.Resources;
using System.Net.Mail;
using CSSPEnumsDLL.Enums;
using DHI.PFS;

namespace Updater
{
    public partial class Updater : Form
    {
        #region Variables
        private string FromEmail = "Charles.LeBlanc2@Canada.ca";
        private int AppTaskID;
        private int MikeScenarioTVItemID;
        private string FileNameM21_3fm;
        private string LogFileName;
        private string HydroFileName;
        private string TransFileName;
        private long EstimatedHydroFileSize;
        private long EstimatedTransFileSize;
        private int ContactTVItemID;
        private CSSPWebToolsDBEntities db = new CSSPWebToolsDBEntities();
        #endregion Variables

        #region Properties
        #endregion Properties

        #region Constructors
        public Updater()
        {
            InitializeComponent();
            timerUpdater.Enabled = false;
        }
        #endregion Constructors

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.To.Clear();
            richTextBoxStatus.AppendText("ToEmail = " + "sleifjlsijfjlsijflsiejf" + "\r\n");
            richTextBoxStatus.AppendText("FromEmail = " + FromEmail + "\r\n");
            richTextBoxStatus.AppendText("Subject = " + "sleifjlisejflsijfilej" + "\r\n");
            richTextBoxStatus.AppendText("Body = " + "sleifjlsifeij" + "\r\n");
            mail.To.Add(FromEmail);
            mail.From = new MailAddress(FromEmail);
            mail.Subject = "sleifjlsijflisjeflisjefli ";
            mail.Body = "sliefjsilejfsleijf";
            mail.IsBodyHtml = false;
            SmtpClient smtpClient = new SmtpClient("atlantic-exgate.Atlantic.int.ec.gc.ca", 25);
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception)
            {
                // nothing
            }
        }
        private void timerUpdater_Tick(object sender, EventArgs e)
        {
            timerUpdater.Stop();
            DoUpdate();
            timerUpdater.Start();
        }
        private void Updater_Load(object sender, EventArgs e)
        {
            DoNext();
        }
        #endregion Events

        #region Functions
        // functions
        private void DoNext()
        {
            string retStr = Setup();
            if (!string.IsNullOrWhiteSpace(retStr))
            {
                return;
            }

            retStr = StartProcess();
            if (!string.IsNullOrWhiteSpace(retStr))
            {
                return;
            }
        }
        private bool DongleIsPlugged()
        {
            bool Mike21DonglePlugged = false;

            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_USBControllerDevice");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["Dependent"].ToString().Contains("VID_04B9&PID_0300"))
                    {
                        Mike21DonglePlugged = true;
                        break;
                    }
                }

                if (!Mike21DonglePlugged)
                {
                    return false;
                }
            }
            catch (ManagementException)
            {
                return false;
            }

            return true;
        }
        private void DoUpdate()
        {
            if (IsProcessRunning())
            {
                richTextBoxStatus.AppendText("Running ...\r\n");
                if (HydroFileName != "")
                {
                    FileInfo fiHydro = new FileInfo(HydroFileName);

                    if (EstimatedHydroFileSize > 0)
                    {
                        UpdateTaskStatusText(AppTaskID, string.Format(UpdaterRes.Running_Completed_fr, (100.0 * (float)fiHydro.Length / (float)EstimatedHydroFileSize)));
                        UpdateTaskPercent(AppTaskID, (int)(100.0 * (float)fiHydro.Length / (float)EstimatedHydroFileSize));
                        richTextBoxStatus.AppendText(string.Format("Running ... {0:F0} % completed ...\r\n", (100.0 * (float)fiHydro.Length / (float)EstimatedHydroFileSize)));
                    }
                }
                else
                {
                    FileInfo fiTrans = new FileInfo(TransFileName);

                    if (EstimatedTransFileSize > 0)
                    {
                        UpdateTaskStatusText(AppTaskID, string.Format(UpdaterRes.Running_Completed_fr, (100.0 * (float)fiTrans.Length / (float)EstimatedTransFileSize)));
                        UpdateTaskPercent(AppTaskID, (int)(100.0 * (float)fiTrans.Length / (float)EstimatedTransFileSize));
                        richTextBoxStatus.AppendText(string.Format("Running ... {0:F0} % completed ...\r\n", (100.0 * (float)fiTrans.Length / (float)EstimatedTransFileSize)));
                    }
                }
            }
            else
            {
                timerUpdater.Stop();

                richTextBoxStatus.AppendText("Not currently working\r\n");

                // should be changing MikeScenario status
                MikeScenario mikeScenarioToChange = (from ms in db.MikeScenarios
                                                     where ms.MikeScenarioTVItemID == MikeScenarioTVItemID
                                                     select ms).FirstOrDefault<MikeScenario>();

                if (mikeScenarioToChange == null)
                {
                    UpdateTaskError(AppTaskID, "Could not find MikeScenario to update. Looking for MikeScenarioID = [" + MikeScenarioTVItemID + "] ...");
                    richTextBoxStatus.AppendText("Could not find MikeScenario to update. Looking for MikeScenarioID = [" + MikeScenarioTVItemID + "] ... \r\n");
                    return;
                }

                FileInfo fiLog = new FileInfo(LogFileName);

                if (!fiLog.Exists)
                {
                    UpdateTaskError(AppTaskID, "Could not find file [" + LogFileName + "] on the server ... ");
                    richTextBoxStatus.AppendText("Could not find file [" + LogFileName + "] on the server ... \r\n");
                    return;
                }

                StringBuilder sb = new StringBuilder();
                StreamReader sr2 = fiLog.OpenText();
                sb.Append(sr2.ReadToEnd());
                sr2.Close();

                if (sb.ToString().Contains("Normal run completion"))
                {
                    mikeScenarioToChange.MikeScenarioStatus = (int)ScenarioStatusEnum.Completed;
                }
                else
                {
                    mikeScenarioToChange.MikeScenarioStatus = (int)ScenarioStatusEnum.Changed;
                }

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    UpdateTaskError(AppTaskID, "Could not update MikeScenario with .log file info. Error Message: " + ex.Message);
                    richTextBoxStatus.AppendText("Could not update MikeScenario with .log file info. Error Message: " + ex.Message + "\r\n");
                    return;
                }

                UpdateAllFileInfoAndAppTask();

                AppTask appTaskToDelete = (from c in db.AppTasks
                                           where c.AppTaskID == AppTaskID
                                           select c).FirstOrDefault();

                if (appTaskToDelete != null)
                {
                    db.AppTasks.Remove(appTaskToDelete);
                }

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    string retStr = "Could not delete AppTask with AppTaskID [" + AppTaskID + " Error: " + ex.Message;
                    UpdateTaskError(AppTaskID, retStr);
                    richTextBoxStatus.AppendText(retStr + "\r\n");
                    return;
                }

                timerUpdater.Start();

                DoNext();
            }
        }
        private string GetFileNameText(PFSFile pfsFile, string Path, string Keyword)
        {
            string FileName = "";

            PFSSection pfsSectionFileName = pfsFile.GetSectionFromHandle(Path);

            if (pfsSectionFileName != null)
            {
                PFSKeyword keyword = null;
                try
                {
                    keyword = pfsSectionFileName.GetKeyword(Keyword);
                }
                catch (Exception ex)
                {
                    UpdateTaskError(AppTaskID, "PFS GetKeyword. Error [" + ex.Message + (ex.InnerException != null ? " Inner: " + ex.InnerException.Message : "") + "]");
                    richTextBoxStatus.AppendText("PFS GetKeyword. Error [" + ex.Message + (ex.InnerException != null ? " Inner: " + ex.InnerException.Message : "") + "]\r\n");
                    return FileName;
                }

                if (keyword != null)
                {
                    try
                    {
                        FileName = keyword.GetParameter(1).ToString();
                    }
                    catch (Exception ex)
                    {
                        UpdateTaskError(AppTaskID, "PFS GetParameter. Error [" + ex.Message + (ex.InnerException != null ? " Inner: " + ex.InnerException.Message : "") + "]");
                        richTextBoxStatus.AppendText("PFS GetParameter. Error [" + ex.Message + (ex.InnerException != null ? " Inner: " + ex.InnerException.Message : "") + "]\r\n");
                        return FileName;
                    }
                }
            }

            return FileName;
        }
        private bool IsProcessRunning()
        {
            StringBuilder sb = new StringBuilder();
            bool Found = false;
            string ScenarioFileName = FileNameM21_3fm.Substring(FileNameM21_3fm.LastIndexOf(@"\") + 1);
            Process[] processList = Process.GetProcesses();
            foreach (Process p in processList)
            {
                if (p.MainWindowTitle.StartsWith("MzLaunch - [" + ScenarioFileName + "]"))
                {
                    Found = true;
                    break;
                }
                else
                {
                    Found = false;
                }
            }
            return Found;
        }
        private string StartProcess()
        {
            // starting MzLaunch.exe application
            ProcessStartInfo pInfoMz = new ProcessStartInfo();
            pInfoMz.Arguments = " \"" + FileNameM21_3fm + "\" " + "-x";
            pInfoMz.WindowStyle = ProcessWindowStyle.Minimized;
            pInfoMz.UseShellExecute = true;

            Process processMike = new Process();
            processMike.StartInfo = pInfoMz;
            try
            {
                pInfoMz.FileName = @"C:\Program Files (x86)\DHI\2016\bin\x64\MzLaunch.exe";
                processMike.Start();
            }
            catch (Exception ex)
            {
                string ErrorText = "File [" + pInfoMz.FileName + "] could not run. Error Message: [" + ex.Message + "]";
                richTextBoxStatus.Text = ErrorText + "\r\n";
                UpdateTaskError(AppTaskID, "");
                return ErrorText;
            }

            UpdateTaskError(AppTaskID, "");
            UpdateTaskPercent(AppTaskID, 5);

            MikeScenario mikeScenario = (from c in db.MikeScenarios
                                         where c.MikeScenarioTVItemID == MikeScenarioTVItemID
                                         select c).FirstOrDefault();

            if (mikeScenario != null)
            {
                mikeScenario.MikeScenarioStatus = (int)ScenarioStatusEnum.Running;
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                UpdateTaskError(AppTaskID, ex.Message + (ex.InnerException != null ? " Inner: " + ex.InnerException.Message : ""));
            }

            processMike.WaitForInputIdle(2000);

            timerUpdater.Enabled = true;
            timerUpdater.Interval = 3000;
            timerUpdater.Start();

            return "";
        }
        private string Setup()
        {
            string retStr = "";
            lblAppTaskIDValue.Text = "...";
            lblMikeScenarioIDValue.Text = "...";

            AppTask appTask = (from c in db.AppTasks
                               from t in db.TVItems
                               from m in db.MikeScenarios
                               where c.TVItemID == t.TVItemID
                               && t.TVItemID == m.MikeScenarioTVItemID
                               && c.Command == (int)AppTaskCommandEnum.MikeScenarioWaitingToRun
                               && c.Status == (int)AppTaskStatusEnum.Running
                               && t.TVType == (int)TVTypeEnum.MikeScenario
                               && m.MikeScenarioStatus == (int)ScenarioStatusEnum.AskToRun
                               select c).FirstOrDefault();

            if (appTask == null)
            {
                this.Close();
            }

            AppTaskID = appTask.AppTaskID;
            MikeScenarioTVItemID = appTask.TVItemID;
            ContactTVItemID = appTask.LastUpdateContactTVItemID;

            lblAppTaskIDValue.Text = AppTaskID.ToString();
            lblMikeScenarioIDValue.Text = MikeScenarioTVItemID.ToString();

            if (!DongleIsPlugged())
            {
                UpdateTaskError(AppTaskID, UpdaterRes.Mike21_3DongleNotFound);
                return UpdaterRes.Mike21_3DongleNotFound;
            }

            this.Text = "Mike Scenario Updater " + MikeScenarioTVItemID;

            Contact contact = (from c in db.Contacts
                               where c.ContactTVItemID == ContactTVItemID
                               select c).FirstOrDefault();

            if (contact == null)
            {
                retStr = "Could not find Contact with ContactTVItemID [" + ContactTVItemID + "]";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }
            lblContactValue.Text = contact.FirstName + (string.IsNullOrWhiteSpace(contact.Initial) ? "" : " " + contact.Initial) + " " + contact.LastName;

            MikeScenario mikeScenario = (from c in db.MikeScenarios
                                         where c.MikeScenarioTVItemID == MikeScenarioTVItemID
                                         select c).FirstOrDefault();

            if (mikeScenario == null)
            {
                retStr = "Could not find MikeScenario with MikeScenarioTVItemID [" + MikeScenarioTVItemID + "]";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }

            EstimatedHydroFileSize = (long)mikeScenario.EstimatedHydroFileSize;
            EstimatedTransFileSize = (long)mikeScenario.EstimatedTransFileSize;

            lblEstimatedHydroFileSizeValue.Text = EstimatedHydroFileSize.ToString();
            lblEstimatedTransFileSizeValue.Text = EstimatedTransFileSize.ToString();


            // should get m21fm or m3fm file name

            TVFile tvFilem21_3fm = (from c in db.TVItems
                                    from ms in db.MikeScenarios
                                    from f in db.TVFiles
                                    from cc in db.TVItems
                                    where c.TVItemID == ms.MikeScenarioTVItemID
                                    && f.TVFileTVItemID == cc.TVItemID
                                    && cc.ParentID == c.TVItemID
                                    && (f.FileType == (int)FileTypeEnum.M21FM || f.FileType == (int)FileTypeEnum.M3FM)
                                    && ms.MikeScenarioTVItemID == MikeScenarioTVItemID
                                    select f).FirstOrDefault<TVFile>();

            if (tvFilem21_3fm == null)
            {
                retStr = "Error: Could not find CSSPFile of type .m21fm or .m3fm and MikeScenarioID [" + MikeScenarioTVItemID + "]";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }
            FileNameM21_3fm = tvFilem21_3fm.ServerFilePath + tvFilem21_3fm.ServerFileName;

            FileInfo fim21_3fm = new FileInfo(FileNameM21_3fm);
            if (!fim21_3fm.Exists)
            {
                retStr = "Error: Could not find file [" + fim21_3fm.FullName + " with MikeScenarioID [" + MikeScenarioTVItemID + "]";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }

            lblCurrentFileValue.Text = @"...\" + MikeScenarioTVItemID + @"\" + fim21_3fm.Name;

            LogFileName = fim21_3fm.FullName.Replace(".m21fm", ".log").Replace(".m21fm", ".log");

            PFSFile pfsFile = new PFSFile(FileNameM21_3fm);
            if (pfsFile == null)
            {
                retStr = "File [" + FileNameM21_3fm + "] could not be parsed properly";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }

            HydroFileName = GetFileNameText(pfsFile, "FemEngineHD/HYDRODYNAMIC_MODULE/OUTPUTS/OUTPUT_1", "file_name");
            if (string.IsNullOrWhiteSpace(HydroFileName))
            {
                retStr = "HydroFileName could not be found";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }

            FileInfo fileHydro = new FileInfo(tvFilem21_3fm.ServerFilePath + HydroFileName);
            if (!fileHydro.Exists)
            {
                retStr = "Error: Could not find file [" + fileHydro.FullName + "]";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }

            HydroFileName = fileHydro.FullName;

            lblHydroFileNameValue.Text = @"...\" + MikeScenarioTVItemID + @"\" + fileHydro.Name;

            TransFileName = GetFileNameText(pfsFile, "FemEngineHD/TRANSPORT_MODULE/OUTPUTS/OUTPUT_1", "file_name");
            if (string.IsNullOrWhiteSpace(TransFileName))
            {
                retStr = "TransFileName could not be found";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }

            FileInfo fileTrans = new FileInfo(tvFilem21_3fm.ServerFilePath + TransFileName);
            if (!fileTrans.Exists)
            {
                retStr = "Error: Could not find file [" + fileTrans.FullName + "]";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return retStr;
            }

            TransFileName = fileTrans.FullName;

            lblTransFileNameValue.Text = @"...\" + MikeScenarioTVItemID + @"\" + fileTrans.Name;

            return "";
        }
        private void UpdateAllFileInfoAndAppTask()
        {
            StringBuilder sbBody = new StringBuilder();
            StringBuilder sbSubject = new StringBuilder();

            TVFile tvFilem21_3fm = (from c in db.TVItems
                                    from ms in db.MikeScenarios
                                    from f in db.TVFiles
                                    from cc in db.TVItems
                                    where c.TVItemID == ms.MikeScenarioTVItemID
                                    && f.TVFileTVItemID == cc.TVItemID
                                    && cc.ParentID == c.TVItemID
                                    && (f.FileType == (int)FileTypeEnum.M21FM || f.FileType == (int)FileTypeEnum.M3FM)
                                    && ms.MikeScenarioTVItemID == MikeScenarioTVItemID
                                    select f).FirstOrDefault<TVFile>();

            if (tvFilem21_3fm == null)
            {
                UpdateTaskError(AppTaskID, "Error: Could not find CSSPFile of type .m21fm or .m3fm and MikeScenarioID [" + MikeScenarioTVItemID + "]");
                richTextBoxStatus.AppendText("Error: Could not find CSSPFile of type .m21fm or .m3fm and MikeScenarioID [" + MikeScenarioTVItemID + "]\r\n");
                return;
            }

            FileInfo fiServer = new FileInfo(tvFilem21_3fm.ServerFilePath + tvFilem21_3fm.ServerFileName);
            if (!fiServer.Exists)
            {
                UpdateTaskError(AppTaskID, "File [" + fiServer.FullName + "] could not be found on the server.");
                richTextBoxStatus.AppendText("File [" + fiServer.FullName + "] could not be found on the server.\r\n");
                return;
            }

            PFSFile pfsFile = new PFSFile(tvFilem21_3fm.ServerFilePath + tvFilem21_3fm.ServerFileName);

            if (pfsFile == null)
            {
                UpdateTaskError(AppTaskID, "File [" + fiServer.FullName + "] could not be parsed properly");
                richTextBoxStatus.AppendText("File [" + fiServer.FullName + "] could not be parsed properly\r\n");
                return;
            }

            LogFileName = fiServer.FullName.Replace(".m21fm", ".log").Replace(".m3fm", ".log");

            FileInfo fiLog = new FileInfo(LogFileName);
            if (!fiLog.Exists)
            {
                UpdateTaskError(AppTaskID, "File [" + fiLog.FullName + "] could not be found on the server.");
                richTextBoxStatus.AppendText("File [" + fiLog.FullName + "] could not be found on the server.\r\n");
                return;
            }

            List<int> TVItemIDToDeleteList = new List<int>();

            // doing the log file

            TVFile tvFileLog = (from c in db.TVItems
                                from ms in db.MikeScenarios
                                from f in db.TVFiles
                                from cc in db.TVItems
                                where c.TVItemID == ms.MikeScenarioTVItemID
                                && f.TVFileTVItemID == cc.TVItemID
                                && cc.ParentID == c.TVItemID
                                && f.FileType == (int)FileTypeEnum.LOG
                                && f.ServerFileName == fiLog.Name
                                && ms.MikeScenarioTVItemID == MikeScenarioTVItemID
                                select f).FirstOrDefault<TVFile>();

            if (tvFileLog == null)
            {
                string retStr = "Error: Could not find log result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "].";
                UpdateTaskError(AppTaskID, retStr);
                richTextBoxStatus.AppendText(retStr + "\r\n");
                return;
            }

            fiLog = new FileInfo(LogFileName);

            tvFileLog.FileSize_kb = (int)(fiLog.Length / 1024);
            tvFileLog.FileCreatedDate_UTC = DateTime.UtcNow;
            tvFileLog.LastUpdateDate_UTC = DateTime.UtcNow;
            tvFileLog.LastUpdateContactTVItemID = ContactTVItemID;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                UpdateTaskError(AppTaskID, "Error: Could not save modified log file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n Error Message: [" + ex.Message + "]");
                richTextBoxStatus.AppendText("Error: Could not save modified log file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n Error Message: [" + ex.Message + "]\r\n");
                return;
            }

            // doing the hydro file .dfsu

            FileInfo fiHydro = new FileInfo(HydroFileName);

            TVFile tvFileHydro = (from c in db.TVItems
                                  from ms in db.MikeScenarios
                                  from f in db.TVFiles
                                  from cc in db.TVItems
                                  where c.TVItemID == ms.MikeScenarioTVItemID
                                  && f.TVFileTVItemID == cc.TVItemID
                                  && cc.ParentID == c.TVItemID
                                  && f.FileType == (int)FileTypeEnum.DFSU
                                  && f.ServerFileName == fiHydro.Name
                                  && ms.MikeScenarioTVItemID == MikeScenarioTVItemID
                                  select f).FirstOrDefault<TVFile>();

            if (tvFileHydro == null)
            {
                UpdateTaskError(AppTaskID, "Error: Could not find one hydrodynamic result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n");
                richTextBoxStatus.AppendText("Error: Could not find one hydrodynamic result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n");
                return;
            }

            fiHydro = new FileInfo(HydroFileName);

            tvFileHydro.FileSize_kb = (int)(fiHydro.Length / 1024);
            tvFileHydro.FileCreatedDate_UTC = DateTime.UtcNow;
            tvFileHydro.LastUpdateDate_UTC = DateTime.UtcNow;
            tvFileHydro.LastUpdateContactTVItemID = ContactTVItemID;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                UpdateTaskError(AppTaskID, "Error: Could not save modified hydrodynamic result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n Error Message: [" + ex.Message + "]");
                richTextBoxStatus.AppendText("Error: Could not save hydrodynamic result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n Error Message: [" + ex.Message + "]\r\n");
                return;
            }

            // doing the hydro file .dfsu
            FileInfo fiTrans = new FileInfo(TransFileName);

            TVFile tvFileTrans = (from c in db.TVItems
                                  from ms in db.MikeScenarios
                                  from f in db.TVFiles
                                  from cc in db.TVItems
                                  where c.TVItemID == ms.MikeScenarioTVItemID
                                  && f.TVFileTVItemID == cc.TVItemID
                                  && cc.ParentID == c.TVItemID
                                  && f.FileType == (int)FileTypeEnum.DFSU
                                  && f.ServerFileName == fiTrans.Name
                                  && ms.MikeScenarioTVItemID == MikeScenarioTVItemID
                                  select f).FirstOrDefault<TVFile>();

            if (tvFileTrans == null)
            {
                UpdateTaskError(AppTaskID, "Error: Could not find one transport result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n");
                richTextBoxStatus.AppendText("Error: Could not find one transport result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n");
                return;
            }

            fiTrans = new FileInfo(TransFileName);

            tvFileTrans.FileSize_kb = (int)(fiTrans.Length / 1024);
            tvFileTrans.FileCreatedDate_UTC = DateTime.UtcNow;
            tvFileTrans.LastUpdateDate_UTC = DateTime.UtcNow;
            tvFileTrans.LastUpdateContactTVItemID = ContactTVItemID;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                UpdateTaskError(AppTaskID, "Error: Could not save modified transport result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n Error Message: [" + ex.Message + "]");
                richTextBoxStatus.AppendText("Error: Could not save transport result file belonging to the excecuted MikeScenarioID [" + MikeScenarioTVItemID + "]. \r\n Error Message: [" + ex.Message + "]\r\n");
                return;
            }
        }
        private void UpdateTaskError(int AppTaskID, string AppTaskError)
        {
            AppTaskLanguage AppTaskLanguageToUpdate = (from c in db.AppTaskLanguages
                                                       where c.AppTaskID == AppTaskID
                                                       select c).FirstOrDefault<AppTaskLanguage>();

            if (AppTaskLanguageToUpdate == null)
            {
                return;
            }

            AppTaskLanguageToUpdate.ErrorText = AppTaskError;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                richTextBoxStatus.AppendText(string.Format("AppTaskLanguage could not be updated for AppTask [{0}]", AppTaskID) + " Error Message: " + ex.Message + "\r\n");
                return;
            }
        }
        private void UpdateTaskStatusText(int AppTaskID, string AppTaskStatus)
        {
            AppTaskLanguage AppTaskLanguageToUpdate = (from c in db.AppTaskLanguages
                                                       where c.AppTaskID == AppTaskID
                                                       select c).FirstOrDefault<AppTaskLanguage>();

            if (AppTaskLanguageToUpdate == null)
            {
                return;
            }

            AppTaskLanguageToUpdate.StatusText = AppTaskStatus;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                richTextBoxStatus.AppendText(string.Format("AppTaskLanguage could not be updated for AppTask [{0}]", AppTaskID) + " Error Message: " + ex.Message + "\r\n");
                return;
            }
        }
        private void UpdateTaskPercent(int AppTaskID, int Percent)
        {
            AppTask AppTaskToUpdate = (from c in db.AppTasks
                                       where c.AppTaskID == AppTaskID
                                       select c).FirstOrDefault<AppTask>();

            if (AppTaskToUpdate == null)
            {
                return;
            }

            AppTaskToUpdate.PercentCompleted = Percent;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                richTextBoxStatus.AppendText(string.Format("AppTask percent could not be updated for AppTask [{0}]", AppTaskID) + " Error Message: " + ex.Message + "\r\n");
                return;
            }
        }
        #endregion Functions

    }
}
