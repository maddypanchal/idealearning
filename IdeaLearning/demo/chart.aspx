<%@ Page Language="C#" AutoEventWireup="true" CodeFile="chart.aspx.cs" Inherits="demo_chart" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <table>
    
    <tr>
    <td> select ChartType</td>
    <td>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td colspan="2">
    <asp:Chart ID="Chart1" runat="server" Width="350px">
        <Titles>
        <asp:Title Text="my frirt using chart"></asp:Title>
        </Titles>
            <Series>
                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Pie">
                <Points>
                <asp:DataPoint AxisLabel="s" YValues="300" />
                <asp:DataPoint AxisLabel="d" YValues="400" />
                <asp:DataPoint AxisLabel="f" YValues="700" />
                <asp:DataPoint AxisLabel="hg" YValues="200" />
                <asp:DataPoint AxisLabel="s" YValues="900" />
                </Points>
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">

                <AxisX Title="student name">
                </AxisX>
               <AxisY Title="total marks "> </AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td>
        </tr>
    </table>
        
    </div>
    </form>
</body>
</html>
