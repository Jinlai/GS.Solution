/*
 *  created by zhangjinlai@ctrip.com
 *  date 4/23/2014 10:53:23 AM
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GS.Solution.VsExtensions
{
    using EnvDTE;
    using EnvDTE80;

    public static class OutputWindowPaneProvider
    {
        private const string OutputWindowPaneName = "GS.Solution.Templates.OutputWindowPane";

        public static OutputWindowPane GetOutputWindowPane(DTE2 dte2)
        {
            var outputWindow = dte2.Windows.Item(Constants.vsWindowKindOutput).Object as OutputWindow;

            //return outputWindow.OutputWindowPanes.Item(OutputWindowPaneName) ?? outputWindow.OutputWindowPanes.Add(OutputWindowPaneName);

            return outputWindow.OutputWindowPanes.Add(OutputWindowPaneName);
        }
    }
}