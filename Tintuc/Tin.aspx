﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tin.aspx.cs" Inherits="Tintuc.Tin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
         <div>
         <hgroup>
         <h2><%: Page.Title %></h2>
         </hgroup>
         <asp:ListView ID="tinList" runat="server" DataKeyNames="Chude_ID"
        GroupItemCount="4"
         ItemType="Tintuc.Models.Tin" SelectMethod="GetTins">
         <EmptyDataTemplate>
         <table >
         <tr>
         <td>No data was returned.</td>
         </tr>
         </table>
         </EmptyDataTemplate>
         <EmptyItemTemplate>
         <td/>
         </EmptyItemTemplate>
         <GroupTemplate>
         <tr id="itemPlaceholderContainer" runat="server">
         <td id="itemPlaceholder" runat="server"></td>
         </tr>
         </GroupTemplate>
         <ItemTemplate>
         <td runat="server">
         <table>
         <tr>
         <td>
         <a href="Noidybg.aspx?tinID=<%#:Item.Tin_ID%>">
         <img src ="/Images/<%#:Item.Hinhanh%>"
         width="150" height="225" style="border:solid" /></a>
         </td>
         </tr>
         <tr>
         <td>
         <a href="Noidung.aspx?tinID=<%#:Item.Tin_ID%>">
         <span>
         <%#:Item.Tieude%>
         </span>
         </a>
         <br />
         
         
             <a href="AddToCart.aspx?bookID=<%#:Item.Tin_ID%>">
             </a>
         </td>
         </tr>
         <tr>
         <td>&nbsp;</td>
         </tr>
         </table>
         </p>
         </td>
         </ItemTemplate>
         <LayoutTemplate>
         <table style="width:100%;">
         <tbody>
         <tr>
         <td>
         <table id="groupPlaceholderContainer" runat="server"
        style="width:100%">
         <tr id="groupPlaceholder"></tr>
         </table>
         </td>
         </tr>
         <tr>
         <td></td>
         </tr>
         <tr></tr>
         </tbody>
         </table>
         </LayoutTemplate>
         </asp:ListView>
         </div>
         </section>
</asp:Content>
