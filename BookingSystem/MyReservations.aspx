<%@ Page Title="Reservations" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyReservations.aspx.cs" Inherits="BookingSystem.MyReservations" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div>
            <h1>Fawlty Bookings</h1>
            <br />
            <h2>Your reservations</h2>
            <asp:Label runat="server" ID="lblMessage" CssClass="message" />

            <asp:GridView ID="gridReservations" runat="server" AutoGenerateColumns="false" OnRowDeleting="gridReservations_RowDeleting" DataKeyNames="ReservationId" CssClass="my-grid">
              <Columns>
                <asp:BoundField DataField="ReservationId" HeaderText="Reservation Id_" ReadOnly="True" />
                <asp:BoundField DataField="RoomNumber" HeaderText="Room Number_" />
                <asp:BoundField DataField="StartDate" HeaderText="Check-In Date_" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="EndDate" HeaderText="Check-Out Date" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:CommandField ShowDeleteButton="True" />
              </Columns>
            </asp:GridView>
        </div>
        <div><a href="Home.aspx">Go back to home page</a></div>
        <div>
            <asp:Button ID="logoutButton" runat="server" Text="Logout" OnClick="logoutButton_Click" />
        </div>
    </main>

</asp:Content>
