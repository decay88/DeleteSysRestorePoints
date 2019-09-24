namespace RestorePoints
{
    using System;
    using System.Runtime.InteropServices;

    internal static class NativeMethods
    {
       #region For Delete System Point

        [DllImport("Srclient.dll")]
        public static extern int SRRemoveRestorePoint(int index);

       #endregion
    }
}
