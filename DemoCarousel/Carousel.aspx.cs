using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
 
namespace Telerik.Web.Examples.Rotator.CarouselMode
{
    /// <summary>
    /// Summary description for DefaultCS.
    /// </summary>
    public partial class DefaultCS : System.Web.UI.Page
    {
        // Path to images folder
        string virtualPath = "~/Rotator/Examples/CarouselMode/images";
        private void Page_Load(object sender, System.EventArgs e)
        {
            if (!IsPostBack)
            {// First load
                ConfigureRadRotator(RotatorType.Carousel);//  By default, use the RotatorType.Carousel mode
            }
 
        }
 
        protected void dblCarouselModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadRotator1.RotatorType = RotatorType.Carousel;
            if (dblCarouselModes.SelectedValue.Equals("Carousel"))
            {// Enable Carousel mode
                ConfigureRadRotator(RotatorType.Carousel);
            }
            else
            {// Enable CarouselButtons mode
                ConfigureRadRotator(RotatorType.CarouselButtons);
            }
        }
 
        private void ConfigureRadRotator(RotatorType rotatorType)
        {
            RadRotator1.RotatorType = rotatorType;// Change rotator's type
 
            if (rotatorType.Equals(RotatorType.CarouselButtons))
            {
                RadRotator1.Width = Unit.Pixel(810 + RadRotatorSizeConfigurator.GetButtonsSize(RadRotator1));
            }
            else
            {
                RadRotator1.Width = Unit.Pixel(810);
            }
 
            RadRotator1.DataSource = GetFilesInFolder(virtualPath);// Set datasource
            RadRotator1.DataBind();
        }
 
        /// <summary>
        /// Returns all virtual paths to files located in the given virtual directory
        /// </summary>
        /// <param name="folderVirtualPath">A virtual directory</param>
        /// <returns>The virtual paths</returns>
        protected List<string> GetFilesInFolder(string folderVirtualPath)
        {
            string physicalPathToFolder = Server.MapPath(folderVirtualPath);// Get the physical path
 
            string filterExpression = string.Empty;
            if (IsIe6)
                filterExpression = "*.gif";
            else
                filterExpression = "*.png";
 
            string[] physicalPathsCollection = System.IO.Directory.GetFiles(physicalPathToFolder, filterExpression);// Get all child files of the given folder
            List<string> virtualPathsCollection = new List<string>();// Contains the result
 
            foreach (String path in physicalPathsCollection)
            {
                // The value of virtualPath will be similar to '~/PathToFolder/Image1.jpg
                string virtualPath = VirtualPathUtility.AppendTrailingSlash(folderVirtualPath) + System.IO.Path.GetFileName(path);
                virtualPathsCollection.Add(virtualPath);
            }
            return virtualPathsCollection;
        }
 
        private bool IsIe6
        {
            get
            {
                bool ie6 = Context.Request.Browser.IsBrowser("IE") && Context.Request.Browser.MajorVersion < 7;// Is IE 6
                return ie6;
            }
        }
    }
}