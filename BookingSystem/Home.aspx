<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BookingSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div>
            <h1>Fawlty Bookings</h1>
            <br />
            <h2>Availability</h2>

            <table>
            <tr>
                <td><asp:label runat="server" for="checkin-date">Check-in date:</asp:label></td>
                <td><asp:label runat="server" for="checkout-date">Check-out date:</asp:label></td>
                <td><asp:label runat="server" for="guests-number">Number of guests:</asp:label></td>
                <td><asp:label runat="server" for="room-type">Room type:</asp:label></td>
            </tr>
            <form action="/" method="post" id="search">
            <tr>
                <td><asp:TextBox ID="checkinDate" runat="server" TextMode="Date"></asp:TextBox></td>
                <td><asp:TextBox ID="checkoutDate" runat="server" TextMode="Date"></asp:TextBox></td>
                <td><asp:TextBox ID="numberOfGuests" runat="server"></asp:TextBox></td>
                <td>
                    <asp:DropDownList ID="selectRoomType" runat="server">
                    <asp:ListItem Text="Basic" Value="basic"></asp:ListItem>
                    <asp:ListItem Text="Superior" Value="superior"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td><asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
            </tr>
            </form>
            </table> 
            <a href="MyReservations.aspx">View your bookings</a>
        </div>
    </main>

</asp:Content>
