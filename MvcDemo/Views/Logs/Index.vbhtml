@ModelType  PagedList.IPagedList(Of LogEntry)

@Imports Microsoft.AspNet.Identity
@imports TCMSP.Entidades.PortalProcessos
@Imports PagedList.Mvc



@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
    
    Dim jss = New System.Web.Script.Serialization.JavaScriptSerializer()
    Dim userInfoJson = jss.Serialize(ViewBag.CurrentFilter)
    
End Code
<link href="~/Content/PagedList.css" rel="stylesheet" type="text/css" />

<h2>Logs</h2>
<hr />
@Using (Html.BeginForm())
    @<text>

    <div class="row form-group">

        @Html.Hidden("sortOrder", "")
        @Html.Hidden("page", "")

        <input type="hidden" id="CurrentFiltersearchEndDateString" name="CurrentFiltersearchEndDateString" value="@ViewBag.CurrentFiltersearchEndDateString" />
        <input type="hidden" id="CurrentFiltersearchBeginDateString" name="CurrentFiltersearchBeginDateString" value="@ViewBag.CurrentFiltersearchBeginDateString" />
        <input type="hidden" id="CurrentFiltersearchString" name="CurrentFiltersearchString" value="@ViewBag.CurrentFiltersearchString" />
        <input type="hidden" id="CurrentFiltertipoLogStr" name="CurrentFiltertipoLogStr" value="@ViewBag.CurrentFiltertipoLogStr" />
        <input type="hidden" id="CurrentPageSize" name="CurrentPageSize" value="@ViewBag.CurrentPageSize" />

        <p>

            Busca: @Html.TextBox("SearchString")
            Data Inicio: @Html.TextBox("searchBeginDateString")
            Data Fim: @Html.TextBox("searchEndDateString")

            Tipo Contato: @Html.DropDownList("tipoLogStr", "Todos")

            <input type="submit" value="Filtrar" class="btn btn-primary" id="btnSubmit"/>
        </p>
    </div>
<hr />
      <div class="row text-center">
    Resultados por Página: @Html.DropDownList("pageSize")
</div>
<div class="row text-center">
    @Html.PagedListPager(Model, Function(page)

                                    Return "javascript:chamaSubmitPagina('" + ViewBag.DateSortParm + "'," + page.ToString + ")"
                                End Function)
</div>
</text>
End Using


<br />
<div class="row  text-center">
    Exibindo Página @If (Model.PageCount < Model.PageNumber) Then
        @<text>0</text>
    Else
        @Model.PageNumber
    End If

    de @Model.PageCount
</div>
<div class="table-responsive">
    <table class="table table-striped table-hover">
        <thead>
            <tr>
                <th>
                    @*@Html.DisplayNameFor(Function(model) model.Date)
                        @Html.ActionLink("Date", "Index", New With {.sortOrder = ViewBag.DateSortParm})*@

                    <a href="javascript:chamaSubmit('@ViewBag.DateSortParm')" tipo='linkAcesso'>
                        Date
                        @If (ViewBag.sortOrder = "date_asc") Then
                            @<span class="glyphicon glyphicon-triangle-bottom"></span>
                        ElseIf (String.IsNullOrEmpty(ViewBag.sortOrder)) Then
                            @<span class="glyphicon glyphicon-triangle-top"></span>
                        End If

                    </a>

                </th>
                <th>
                    @*@Html.DisplayNameFor(Function(model) model.Thread)*@
                    Thread
                </th>
                <th>
                    @*@Html.DisplayNameFor(Function(model) model.Level)*@
                    Level
                </th>
                <th>
                    @*@Html.DisplayNameFor(Function(model) model.Logger)*@
                    Logger
                </th>
                <th>
                    @*@Html.ActionLink("usuario", "Index", New With {.sortOrder = ViewBag.NameSortParm})*@
                    <a href="javascript:chamaSubmit('@ViewBag.NameSortParm')" tipo='linkAcesso'>
                        Name
                        @If (ViewBag.sortOrder = "name_desc") Then
                            @<span class="glyphicon glyphicon-triangle-bottom"></span>
                        ElseIf (ViewBag.sortOrder = "Name") Then
                            @<span class="glyphicon glyphicon-triangle-top"></span>
                        End If
                    </a>

                    @*@Html.DisplayNameFor(Function(model) model.User)*@
                </th>
                <th>
                    @*@Html.DisplayNameFor(Function(model) model.Message)*@
                    Message
                </th>
                <th>
                    @*@Html.DisplayNameFor(Function(model) model.Exception)*@
                    Exception
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Date)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Thread)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Level)
                    </td>
                    <td>

                        @If (item.Logger IsNot Nothing AndAlso item.Logger.Length > 20) Then
                            @<p title="@item.Logger">(...)@Strings.Right(item.Logger, 19)</p>
                        Else
                            @<p title="@item.Logger">@item.Logger</p>
                        End If

                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.User)
                    </td>
                    <td>

                        @If (item.Message IsNot Nothing AndAlso item.Message.Length > 20) Then
                            @<p title="@item.Message">(...)@item.Message.Substring(0, 19)</p>
                        Else
                            @<p title="@item.Message">@item.Message</p>
                        End If
                    </td>
                    <td>
                        @If (item.Exception IsNot Nothing AndAlso item.Exception.Length > 20) Then
                            @<p title="@item.Exception">(...)@item.Exception.Substring(0, 19) </p>
                        Else
                            @<p title="@item.Exception">@item.Exception</p>
                        End If

                    </td>
                    <td></td>
                </tr>
            Next
        </tbody>
    </table>


</div>

@section Scripts
    <script type="text/javascript">
        function chamaSubmit(item) {
            $("#sortOrder").val(item);

            $("form").submit();
        }
        function chamaSubmitPagina(item, page) {
            $("#sortOrder").val(item);
            $("#page").val(page);

            $("form").submit();
        }
        $(document).ready(function () {
            //$('[data-toggle="popover"]').popover();
            $('[data-toggle="tooltip"]').tooltip();

            $("#pageSize").change(function () {
                mostrarTelaCarregamento();
                $("#btnSubmit").click();
            })

            $("ul.pagination li").click(function (e) {
                if (!$(this).hasClass('active') && !$(this).hasClass('disabled')) {
                    mostrarTelaCarregamento();
                }

            })
        });


    </script>

End Section

