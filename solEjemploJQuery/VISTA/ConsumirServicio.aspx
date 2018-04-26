<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsumirServicio.aspx.cs" Inherits="ConsumirServicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   <script src ="Scripts/jquery-1.8.2.min.js" type="text/javascript"></script>
    <link href="Scripts/datatables.css" rel="stylesheet" />
    <script src="Scripts/datatables.js"></script>
<head runat="server">

    <script type="text/javascript">
        $(document).ready(function () {
            alert("EXELENTE");
            WSComputadoras.getAll(onComplete_cargarLista);
            alert("MISION COMPLETE");
        });
        function onComplete_cargarLista(response) {
            alert("DATOS MANDADOS"+ response);
            var dataSet = JSON.parse(response)
            alert(dataSet);
            $('#example').DataTable({
                data: dataSet,
                columns: [

                    { title: "Title", data: "clave", render: $.fn.dataTable.render.text() },
                    { title: "Application Area", data: "modelo", render: $.fn.dataTable.render.text() },
                    { title: "Capture Status", data: "memoria", render: $.fn.dataTable.render.text() }

                ]
            });

            $(document).ready(function () {
            /*$('#example').DataTable({
                "paging": false,
                "ordering": false,
                "info": false
                */
            });
            
         
        };
    </script>
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WebService/WSComputadoras.asmx" />
            </Services>
        </asp:ScriptManager>
        <table id="example" class="display" style="width:100%">
        
        </table>
    
    </div>
    </form>
</body>
</html>
