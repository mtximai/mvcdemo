<div class="leftPanel">
        @* DXCOMMENT: Configure the left panel's menu *@
    @Html.DevExpress().NavBar(Sub(settings)
        settings.Name = "LeftNavBar"
        settings.AutoCollapse = True
        settings.EnableAnimation = True
        settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
        settings.ControlStyle.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(0)
        settings.ControlStyle.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
    End Sub).BindToXML(HttpContext.Current.Server.MapPath("~/App_Data/SideMenu.xml"), "/menu/*").GetHtml()
</div>