using SB_Prime; // Requires reference to SBPlugins.dll
using System;
using System.Drawing;
using System.Reflection;

namespace SBSamplePlugin
{
    // A simple plugin example
    // Once it is complied copy just the resulting dll (SBSamplePlugin.dll) to a folder called plugins (sub folder to where SB-Prime.exe is located)

    // More than one plugin calss (button) may be added in the one plugin dll (group)
    [SBplugin]
    public static class Plugin1
    {
        // This will be the ribbon group name for all the plugins in this dll
        // It only needs to be set once - i.e. in one of the possible plugin classes
        // OPTIONAL - plugin name (dll name)
        public static string GetGroupName()
        {
            return "Sample Plugin";
        }

        // Set the name for the plugin
        // REQUIRED
        public static string GetName()
        {
            return "Sample";
        }

        // Set a bitmap image for the plugin
        // OPTIONAL - a default bitmap
        public static Bitmap GetBitmap()
        {
            return Properties.Resources.plugin;
        }

        // Set the button size as large (otherwise small)
        // OPTIONAL - default true
        public static bool LargeButton()
        {
            return true;
        }

        // Set a tooltip description for the plugin
        // OPTIONAL = deafult none
        public static string GetToolTip()
        {
            return "My Sample Plugin";
        }

        // Choose one the methods below as an action when the plugin button is clicked

        // Perform an action for the plugin (text will be the current Small Basic document text)
        // This method only requires reference to SBPlugins.dll and should remain usable for any future version of SB-Prime
        // ONE RUN METHOD REQUIRED
        public static bool Run(string text)
        {
            // In this case a simple form displaying the document text
            Form1 form1 = new Form1(text);
            form1.ShowDialog();
            return true;
        }

        // Perform an action for the plugin (text will be the current Small Basic document text)
        // This method requires references to SBPlugins.dll, SB-Prime.exe and ScintillaNET.dll.  It may require rebuilding for future versions of SB-Prime
        // While more powerful interaction is possible using this, it can also break SB-Prime - and is generally unsupported
        // ONE RUN METHOD REQUIRED
        //public static bool Run(MainWindow mainwindow)
        //{
        //    // In this case a simple form displaying the document text
        //    Form1 form1 = new Form1(mainwindow.GetActiveDocument().TextArea.Text);
        //    form1.ShowDialog();
        //    return true;
        //}
    }
}
