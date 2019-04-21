<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="deneme.aspx.cs" Inherits="deneme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/style.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            konu:
            <asp:Label ID="konuLabel" runat="server" Text='<%# Eval("konu") %>' />
            <br />
<br />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:teknobitConnectionString %>" SelectCommand="SELECT [konu] FROM [iletisim_tbl]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>


    <br /> <br /> <br />



    <div id="resimler" style="width:250px; height:300px; margin-left:30px; background-color:#fff; border-bottom:solid 1px #333;">



        



        <asp:DataList ID="DataList2" runat="server" DataSourceID="SqlDataSource2">
            <ItemTemplate>
                resim:
                <asp:Label ID="resimLabel" runat="server" Text='<%# Eval("resim") %>' />
                <br />
                <br />
            </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:teknobitConnectionString %>" SelectCommand="SELECT [resim] FROM [deneme_tbl]"></asp:SqlDataSource>
    </div>



    <div id="isim" style="width:250px; height:40px; margin-left:30px; background-color:#fff;"></div>

    </asp:Content>

