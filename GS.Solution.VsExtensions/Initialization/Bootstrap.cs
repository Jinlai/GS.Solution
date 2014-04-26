using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GS.Solution.VsExtensions.Initialization
{
    using OutputWindowPane;
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio.CommandBars;

    /// <summary>
    /// 
    /// </summary>
    public class Bootstrap
    {
        private readonly DTE2 _dte2;
        private readonly AddIn _addIn;
        private OutputWindowPane _outputWindowPane;

        /// <summary>
        /// 
        /// </summary>        
        public Bootstrap(DTE2 dte2, AddIn addIn)
        {
            _dte2 = dte2;
            _addIn = addIn;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            _outputWindowPane = OutputWindowPaneProvider.GetOutputWindowPane(_dte2);
        }
    }
}
