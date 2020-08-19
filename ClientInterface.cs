using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;

namespace WPM2000
{
    class WinPackage
    {
        public string name, dl, description, source, os, verbosity;

        // Builds a WinPackage out of a XML node.
        /* Example:

        <package
            name="Example Package XML"
            dl="/packages/example.7z"
            description="Description Description Description"
            source="http://example.org"
            os="Hannah Montana Linux"
            verbosity="blabbermouth" />

         */
        public WinPackage(XmlNode xmlPkg)
        {
            // This seems REALLY nasty... Is there a better way to do this?
            XmlAttributeCollection attrColl = xmlPkg.Attributes;

            name = ((XmlAttribute)attrColl.GetNamedItem("name")).Value;
            dl = ((XmlAttribute)attrColl.GetNamedItem("dl")).Value;
            description = ((XmlAttribute)attrColl.GetNamedItem("description")).Value;
            source = ((XmlAttribute)attrColl.GetNamedItem("source")).Value;
            os = ((XmlAttribute)attrColl.GetNamedItem("os")).Value;
            verbosity = ((XmlAttribute)attrColl.GetNamedItem("verbosity")).Value;
        }
    }

    // This class is an abstraction for parsing XML, installing, downloading, and listing packages.
    class ClientInterface
    {
        private WebClient wc = new WebClient();
        private List<WinPackage> pkg_availibleOnServer = new List<WinPackage>();
        private List<WinPackage> pkg_installationQueue = new List<WinPackage>();
        private string serverAddress;

        public ClientInterface(string server)
        {
            serverAddress = server;

            // Get availible packages
            XmlDocument pkgIndex = new XmlDocument();
            pkgIndex.LoadXml(wc.DownloadString(serverAddress + "/index.xml"));

            // Build list
            pkg_availibleOnServer.Clear();
            foreach (XmlNode xmlPkg in pkgIndex.GetElementsByTagName("package"))
                pkg_availibleOnServer.Add(new WinPackage(xmlPkg));

            // TODO
        }
    }
}
