<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <asp:Calendar ID="Calendar1" runat="server" SelectedDate="2023-09-07" 
        SelectionMode="DayWeek" ShowGridLines="True" ShowNextPrevMonth="False" 
        TabIndex="1" TitleFormat="Month">
        <TitleStyle BackColor="#CCFF99" BorderColor="#003300" BorderStyle="Dashed" 
            Font-Bold="True" Font-Names="Cooper Black" Font-Overline="False" 
            Font-Size="Large" Font-Strikeout="False" Font-Underline="True" 
            ForeColor="#FF6699" HorizontalAlign="Center" VerticalAlign="Middle" 
            Wrap="True" />
        <TodayDayStyle BackColor="#FF66FF" BorderColor="#003399" BorderStyle="Dotted" 
            Font-Bold="True" Font-Names="Arial Narrow" ForeColor="#663300" />
        <WeekendDayStyle BackColor="#00CC99" BorderColor="Black" BorderStyle="None" />
    </asp:Calendar>
    
</asp:Content>
