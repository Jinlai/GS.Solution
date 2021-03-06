﻿/*
 *  created by zhangjinlai@ctrip.com
 *  date 4/23/2014 10:53:23 AM
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.Solution.VsExtensions.OutputWindowPane
{
    using EnvDTE;
    using EnvDTE80;

    public static class OutputWindowPaneProvider
    {
        private const string OutputWindowPaneName = "GS.Solution.Templates.OutputWindowPane";

        public static OutputWindowPane GetOutputWindowPane(DTE2 dte2)
        {
            var outputWindow = dte2.Windows.Item(Constants.vsWindowKindOutput).Object as OutputWindow;

            for (var i = 1; i <= outputWindow.OutputWindowPanes.Count; i++)
            {
                var outputWindowPane = outputWindow.OutputWindowPanes.Item(i);
                if (outputWindowPane.Name.Equals(OutputWindowPaneName, StringComparison.OrdinalIgnoreCase))
                {
                    return outputWindowPane;
                }
            }

            return outputWindow.OutputWindowPanes.Add(OutputWindowPaneName);
        }
    }
}