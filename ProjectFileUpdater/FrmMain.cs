using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProjectFileUpdater
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<String> files = Directory.EnumerateFiles(txtDirectories.Text, "*.dproj", SearchOption.AllDirectories).ToList();
            // files = new List<string>() { @"D:\DevelopXE\Cobra\Apps\WebGate\Work\WebGate.dproj" };
            foreach (string file in files)
                updateProjectFile(file);

            MessageBox.Show("Success for " + files.Count + " files.");
        }

        private void updateProjectFile(String file)
        {
            String completeVersion = txtVersionMajor.Text + "." + txtVersionMinor.Text + "." + txtVersionRelase.Text + "." + txtVersionBuild.Text;
            String schema = "{http://schemas.microsoft.com/developer/msbuild/2003}";

            XDocument xmlDoc = XDocument.Load(file);

            xmlDoc.Descendants(schema + "VersionInfoKeys")
                .Where(x => x.HasAttributes && x.Attribute("Name") != null && ((string)x.Attribute("Name")).StartsWith("CFBundle"))
                .Remove();

            var versionInfoKeys = from AnyElement in xmlDoc.Descendants(schema + "VersionInfoKeys") where AnyElement.HasAttributes select AnyElement;
            String VerInfo_Keys = "";
            foreach (XElement versionNode in versionInfoKeys)
            {
                if (versionNode.Name.LocalName != "VersionInfoKeys")
                    throw new Exception("wrong name");

                if (versionNode.Attribute("Name") == null)
                    throw new Exception("attribute missing");

                String key = versionNode.Attribute("Name").Value;

                switch (key)
                {
                    case "CompanyName":
                        versionNode.SetValue(txtCompany.Text);
                        break;
                    case "FileVersion":
                    case "ProductVersion":
                        versionNode.SetValue(completeVersion);
                        break;
                    case "LegalCopyright":
                        versionNode.SetValue(txtCopyright.Text);
                        break;
                    case "InternalName":
                    case "LegalTrademarks":
                    case "OriginalFilename":
                    case "Comments":
                    case "ProductName":
                    case "FileDescription":
                    case "Privates Build":
                        break;
                    default:
                        throw new Exception("Unknown tag '" + key + "'");
                }

                VerInfo_Keys += key + "=" + versionNode.Value + ";";
            }

            var nodes = from AnyElement in xmlDoc.Descendants(schema + "PropertyGroup") select AnyElement;
            foreach (XElement node in nodes)
            {
                foreach (XNode childNode in node.DescendantNodes())
                {
                    if (!(childNode is XElement))
                        continue;

                    switch ((childNode as XElement).Name.LocalName)
                    {
                        case "ProjectVersion":
                            (childNode as XElement).SetValue(txtDelphiVersion.Text);
                            break;
                        case "VerInfo_MajorVer":
                            (childNode as XElement).SetValue(txtVersionMajor.Text);
                            break;
                        case "VerInfo_MinorVer":
                            (childNode as XElement).SetValue(txtVersionMinor.Text);
                            break;
                        case "VerInfo_Release":
                            (childNode as XElement).SetValue(txtVersionRelase.Text);
                            break;
                        case "VerInfo_Build":
                            (childNode as XElement).SetValue(txtVersionBuild.Text);
                            break;
                        case "VerInfo_IncludeVerInfo":
                            (childNode as XElement).SetValue(true);
                            break;
                        case "VerInfo_Keys":
                            if (VerInfo_Keys.Length > 0)
                                (childNode as XElement).SetValue(VerInfo_Keys.Substring(0, VerInfo_Keys.Length - 1));
                            break;
                        default:
                            break;
                    }
                }
            }

            using (XmlWriter writer = XmlWriter.Create(file, new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true, IndentChars = "    "}))
                xmlDoc.Save(writer);
        }
    }
}