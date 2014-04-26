using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GS.Solution.VsExtensions.Project
{
    using EnvDTE100;

    /// <summary>
    /// 
    /// </summary>
    public class ProjectOperator
    {
        /// <summary>
        /// 
        /// </summary>
        public void Add(Solution4 solution, string templateProjectName, string projectName)
        {
            try
            {
                var templatePath = solution.GetProjectTemplate("ClassLibrary.zip", "CSharp");
                var solutionFileInfo = new FileInfo(solution.FullName);
                var solutionName = solutionFileInfo.Name.Replace(".sln", string.Empty);
                projectName = String.Concat(solutionName, ".", projectName);
                var solutionDirectoryName = string.Format("{0}/{1}", solutionFileInfo.DirectoryName, projectName);

                var project = solution.AddFromTemplate(templatePath, solutionDirectoryName, projectName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
