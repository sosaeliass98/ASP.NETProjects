<%@ Page Title="Telefonica" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Telefonica._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="row">
        <div class="col-12">
            <asp:ListView runat="server" ID="lstTerritorios">
                <LayoutTemplate>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Numero") %></h5>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>

    <%--<div class="form-group">
        <label>Numero</label>
        <asp:TextBox runat="server" ID="txtNumero1" CssClass="form-control"></asp:TextBox>

    </div>

    <div class="form-group">
        <label>Numero</label>
        <asp:TextBox runat="server" ID="xtNumero2" CssClass="form-control"></asp:TextBox>

    </div>--%>

</asp:Content>
