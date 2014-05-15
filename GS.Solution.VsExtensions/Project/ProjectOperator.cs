using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GS.Solution.VsExtensions.Project
{
    using EnvDTE100;

    public class ProjectOperator
    {
        public void Add(Solution4 solution, string projectType, string templateProjectName, string projectName)
        {
            try
            {
                var solutionFileInfo = new FileInfo(solution.FullName);
                var solutionName = solutionFileInfo.Name.Replace(".sln", string.Empty);
                projectName = String.Format("{0}.{1}", solutionName, projectName);
                var projectDirectoryName = string.Format("{0}/{1}", solutionFileInfo.DirectoryName, projectName);

                var templateProjectPath = solution.GetProjectTemplate(projectType, Constants.Language);

                //Add a project
                var project = solution.AddFromTemplate(templateProjectPath, projectDirectoryName, projectName);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
