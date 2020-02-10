@* <pendente> *@

@Imports DevExpress.Web.Mvc.UI

@If Model = MvcDemo.HomeController.HeaderViewRenderMode.Title Then
    @<div class="templateTitle"> 
        @Html.ActionLink("Project Title", "Index", "Home") 
    </div>
Else
	If Model = MvcDemo.HomeController.HeaderViewRenderMode.Full Then
        @<div class="headerTop">
            <div class="templateTitle">
                @Html.ActionLink("Project Title", "Index", "Home")
            </div>
        </div>
    End If

    @<div class="headerMenu"> 
            @* DXCOMMENT: Configure the header menu *@
    
	@Html.DevExpress().Menu(Sub(settings)
        settings.Name = "HeaderMenu"
        settings.ItemAutoWidth = False
        settings.ControlStyle.CssClass = "headerMenu"
        settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
    End Sub).BindToXML(HttpContext.Current.Server.MapPath("~/App_Data/TopMenu.xml"), "/items/*").GetHtml()
 
    </div>
End If