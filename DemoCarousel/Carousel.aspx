<%@ Page Language="c#" AutoEventWireup="true" Inherits="Telerik.Web.Examples.Rotator.CarouselMode.DefaultCS"CodeFile="DefaultCS.aspx.cs"  %>
 
<%@ Register TagPrefix="qsf" Namespace="Telerik.QuickStart" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns='http://www.w3.org/1999/xhtml'>
<head runat="server">
    <title>Telerik ASP.NET Example</title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="scripts.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <telerik:RadScriptManager runat="server" ID="RadScriptManager1" />
    <telerik:RadSkinManager ID="RadSkinManager1" runat="server" ShowChooser="true" />
    <div class="demo-container no-bg">
        <telerik:RadRotator RenderMode="Lightweight" ID="RadRotator1" runat="server" Width="810px" ItemWidth="300"
                            Height="350px" ItemHeight="220" ScrollDuration="500" FrameDuration="2000" PauseOnMouseOver="false"
                            RotatorType="CarouselButtons" OnClientItemClicked="OnClientItemClicked">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server" ImageUrl='<%# Container.DataItem  %>' AlternateText="<%# VirtualPathUtility.GetFileName(Container.DataItem.ToString()) %>">
                </asp:Image>
            </ItemTemplate>
        </telerik:RadRotator>
    </div>
    <qsf:ConfiguratorPanel runat="server" ID="ConfigurationPanel1" Enabled="true" Title="Switch between two Carousel modes">
        <Views>
            <qsf:View runat="server">
                <asp:RadioButtonList ID="dblCarouselModes" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dblCarouselModes_SelectedIndexChanged">
                    <asp:ListItem Selected="True" Text="Carousel" Value="Carousel"></asp:ListItem>
                    <asp:ListItem Selected="False" Text="CarouselButtons" Value="CarouselButtons"></asp:ListItem>
                </asp:RadioButtonList>
            </qsf:View>
        </Views>
    </qsf:ConfiguratorPanel>
    </form>
</body>
</html>