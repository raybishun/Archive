using System.Management;

namespace ShutdownComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Shutdown();
        }

        private static void Shutdown()
        {
            ManagementBaseObject shutdown = null;
            ManagementClass win32 = new ManagementClass("Win32_OperatingSystem");
            win32.Get();

            // Enable security privileges
            win32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject shutdownParams = win32.GetMethodParameters("Win32Shutdown");

            shutdownParams["Flags"] = "1"; // Flag 1 = shutdown
            shutdownParams["Reserved"] = "0";

            foreach (ManagementObject managedObj in win32.GetInstances())
            {
                shutdown = managedObj.InvokeMethod("Win32Shutdown", shutdownParams, null);
            }
        }
    }
}
