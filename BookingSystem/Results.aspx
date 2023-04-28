<%@ Page Title="Available rooms" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="BookingSystem.Results" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div>
            <h1>Fawlty Bookings</h1>
            <br />
            <h2>Available rooms</h2>
        </div>
        <asp:Label runat="server" ID="lblMessage" CssClass="message" />

        <asp:GridView runat="server" ID="gridResults" AutoGenerateColumns="false" OnRowCommand="gridResults_RowCommand" CssClass="my-grid">
            <Columns>
                <asp:BoundField DataField="RoomNumber" HeaderText="Room Number_" />
                <asp:BoundField DataField="Beds" HeaderText="Beds_" />
                <asp:BoundField DataField="Quality" HeaderText="Quality" />
            <asp:TemplateField HeaderText="">
            <ItemTemplate>
                <asp:Button runat="server" Text="Book" CommandName="BookRoom" CommandArgument='<%# Eval("RoomNumber") %>' />
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <a href="MyReservations.aspx">View your bookings</a>
    </main>
</asp:Content>
