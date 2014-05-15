/*
 *  created by zhangjinlai@ctrip.com
 *  date 4/23/2014 2:04:02 PM
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.Solution.VsExtensions.OutputWindowPane
{
    using EnvDTE;

    public static class OutputWindowPaneExtensions
    {
        public static void OutputLine(this OutputWindowPane outputWindowPane, string text)
        {
            outputWindowPane.OutputString(String.Format("{0}\r\n", text));
        }
    }
}