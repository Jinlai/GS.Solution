using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GS.Solution.TfsExtensions
{
    using Microsoft.TeamFoundation.Client;
    using Microsoft.TeamFoundation.Framework.Common;

    public static class Program
    {
        static void Main(string[] args)
        {
            var tfsUri = new Uri("http://server/tfs");
            var tfsConfigurationServer = TfsConfigurationServerFactory.GetConfigurationServer(tfsUri);

            //Travelinfo
            var tfsTeamProjectCollection = tfsConfigurationServer.GetTeamProjectCollection(new Guid("021e652d-e567-4bde-bfbf-dd2a632233be"));

            // Print the name of the team project collection
            Console.WriteLine("Collection: " + tfsTeamProjectCollection.Name);

            // Get a catalog of team projects for the collection
            var projectNodes = tfsTeamProjectCollection.CatalogNode.QueryChildren(new[] { CatalogResourceTypes.TeamProject }, false, CatalogQueryOptions.None);

            // List the team projects in the collection
            foreach (var projectNode in projectNodes)
            {
                Console.WriteLine(" Team Project: " + projectNode.Resource.DisplayName);
            }

            Console.ReadKey();
        }
    }
}
