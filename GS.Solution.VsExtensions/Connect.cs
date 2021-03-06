using System;
using System.Globalization;
using System.IO;

namespace GS.Solution.VsExtensions
{
    using Initialization;
    using Extensibility;
    using EnvDTE;
    using EnvDTE80;

    /// <summary>
    /// The object for implementing an Add-in.
    /// </summary>
    public class Connect : IDTExtensibility2
    {
        private DTE2 _applicationObject;
        private AddIn _addInInstance;

        /// <summary>
        /// Implements the constructor for the Add-in object. Place your initialization code within this method.
        /// </summary>
        public Connect()
        {

        }

        /// <summary>
        /// Implements the OnConnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being loaded.
        /// </summary>
        /// <param name="application">Root object of the host application.</param>
        /// <param name="connectMode">Describes how the Add-in is being loaded.</param>
        /// <param name="addInInst">Object representing this Add-in.</param>
        /// <param name="custom"></param>
        public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
        {
            _applicationObject = (DTE2)application;
            _addInInstance = (AddIn)addInInst;

            var bootstrap = new Bootstrap(_applicationObject, _addInInstance);
            bootstrap.Run();
        }

        /// <summary>
        /// Implements the OnDisconnection method of the IDTExtensibility2 interface. Receives notification that the Add-in is being unloaded.
        /// </summary>
        /// <param name="disconnectMode">Describes how the Add-in is being unloaded.</param>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        public void OnDisconnection(ext_DisconnectMode disconnectMode, ref Array custom)
        {

        }

        /// <summary>
        /// Implements the OnAddInsUpdate method of the IDTExtensibility2 interface. Receives notification when the collection of Add-ins has changed.
        /// </summary>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        public void OnAddInsUpdate(ref Array custom)
        {

        }

        /// <summary>
        /// Implements the OnStartupComplete method of the IDTExtensibility2 interface. Receives notification that the host application has completed loading.
        /// </summary>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        public void OnStartupComplete(ref Array custom)
        {

        }

        /// <summary>
        /// Implements the OnBeginShutdown method of the IDTExtensibility2 interface. Receives notification that the host application is being unloaded.
        /// </summary>
        /// <param name="custom">Array of parameters that are host application specific.</param>
        public void OnBeginShutdown(ref Array custom)
        {

        }
    }
}