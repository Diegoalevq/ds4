<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
        <div class="row">
           <div>
               <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
                    AllowSorting="true" AllowPaging="true"
                    DataKeyNames="ProductID"
                    AutoGenerateEditButton="true"
                   runat="Server" />

               <asp:SqlDataSource ID="MyDataSource1" runat="server" ConnectionString="data source=DIEGOALEVQ\SQLEXPRESS;initial catalog=northwind;persist security info=True;Integrated Security=SSPI;"
                   ProviderName="System.Data.SqlClient"
                   SelectCommand="SELECT ProductId, ProductName, Unitprice From Products"
                   UpdateCommand="Update Products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice Where [ProductId]=@ProductId"></asp:SqlDataSource>

           </div>
        </div>
   

</asp:Content>
