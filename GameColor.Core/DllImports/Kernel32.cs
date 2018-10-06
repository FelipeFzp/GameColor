﻿using System.Runtime.InteropServices;

namespace GameColor.Core.DllImports
{
    public class Kernel32
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();
    }
}
