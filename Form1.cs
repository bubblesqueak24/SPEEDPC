using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SPEEDPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Button click event to kill all Chrome tasks
        private void button1_Click(object sender, EventArgs e)
        {
            KillAllChromeTasks();
        }

        // Button click event to disable Cortana
        private void button2_Click(object sender, EventArgs e)
        {
            DisableCortana();
            MessageBox.Show("Cortana disabled successfully!");
        }

        // Button click event to clear temporary files
        private void button3_Click(object sender, EventArgs e)
        {
            ClearTemporaryFiles();
            MessageBox.Show("Temporary files cleared successfully!");
        }

        // Button click event to empty the Recycle Bin
        private void button4_Click(object sender, EventArgs e)
        {
            RecycleBinHelper.EmptyRecycleBin();
            MessageBox.Show("Recycle Bin emptied successfully!");
        }

        // Button click event to kill all Microsoft Edge tasks
        private void button5_Click(object sender, EventArgs e)
        {
            KillAllEdgeTasks();
        }

        // Button click event to force restart the PC
        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Start a new process to execute the system shutdown command
                Process.Start("shutdown", "/r /f /t 0");
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the system restart process
                MessageBox.Show("Error restarting the system: " + ex.Message);
            }
        }

        // Button click event to open defragmentation window
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // Start a new process to open the defragmentation window
                Process.Start("dfrgui.exe");
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the process
                MessageBox.Show("Error opening defragmentation window: " + ex.Message);
            }
        }

        // Button click event to restart Windows Explorer
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Start a new process to execute the command to restart Windows Explorer
                Process.Start("taskkill", "/f /im explorer.exe");
                Process.Start("explorer.exe");
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the process
                MessageBox.Show("Error restarting Windows Explorer: " + ex.Message);
            }
        }

        // Method to kill all Chrome processes
        private void KillAllChromeTasks()
        {
            try
            {
                // Retrieve all processes with name "chrome" and kill them
                foreach (Process process in Process.GetProcessesByName("chrome"))
                {
                    process.Kill();
                }

                // Notify the user about the successful termination of Chrome tasks
                MessageBox.Show("All Chrome tasks killed successfully!");
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the process termination
                MessageBox.Show("Error killing Chrome tasks: " + ex.Message);
            }
        }

        // Method to kill all Microsoft Edge processes
        private void KillAllEdgeTasks()
        {
            try
            {
                // Retrieve all processes with name "msedge" and kill them
                foreach (var process in Process.GetProcessesByName("msedge"))
                {
                    process.Kill();
                }

                // Notify the user about the successful termination of Microsoft Edge tasks
                MessageBox.Show("All Microsoft Edge tasks killed successfully!");
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the process termination
                MessageBox.Show("Error killing Microsoft Edge tasks: " + ex.Message);
            }
        }

        // Method to clear temporary files
        private void ClearTemporaryFiles()
        {
            try
            {
                // Get the path of the system's temporary folder
                string tempFolderPath = Path.GetTempPath();
                // Create a DirectoryInfo object for the temporary folder
                DirectoryInfo tempDirectory = new DirectoryInfo(tempFolderPath);

                // Delete all files in the temporary folder
                foreach (FileInfo file in tempDirectory.GetFiles())
                {
                    file.Delete();
                }

                // Delete all directories in the temporary folder along with their contents
                foreach (DirectoryInfo dir in tempDirectory.GetDirectories())
                {
                    dir.Delete(true);
                }
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the temporary files deletion
                MessageBox.Show("Error clearing temporary files: " + ex.Message);
            }
        }

        // Method to disable Cortana
        private void DisableCortana()
        {
            try
            {
                // Start a new process to execute the command to kill Cortana
                Process.Start("cmd.exe", "/c taskkill /F /IM Cortana.exe");
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the Cortana disabling process
                MessageBox.Show("Error disabling Cortana: " + ex.Message);
            }
        }
    }

    // Class providing helper methods related to the Recycle Bin
    public class RecycleBinHelper
    {
        // Import the SHEmptyRecycleBin function from shell32.dll
        [System.Runtime.InteropServices.DllImport("shell32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        // Enumeration representing flags for Recycle Bin operations
        [Flags]
        public enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }

        // Method to empty the Recycle Bin
        public static void EmptyRecycleBin()
        {
            try
            {
                // Call the SHEmptyRecycleBin function to empty the Recycle Bin
                int result = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOCONFIRMATION);
                // Check if the operation was successful
                if (result != 0)
                {
                    // If not successful, throw an exception
                    throw new Exception("Failed to empty Recycle Bin.");
                }
            }
            catch (Exception ex)
            {
                // Notify the user if an error occurs during the Recycle Bin emptying process
                MessageBox.Show("Error emptying Recycle Bin: " + ex.Message);
            }
        }
    }
}
