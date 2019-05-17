﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="ObjectsHeatE.aspx.cs" Inherits="IIS.Product_51172.ObjectsHeatE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Объекты теплопотребления</h2>
        <div class="<%= Constants.FormToolbarCssClass  + " " +  Constants.EditFormToolbarCssClass + " " + Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlNameObjectsHeatLabel" runat="server" Text="Название объекта теплопотребления" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlNameObjectsHeat" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator ID="ctrlNameObjectsHeatRequiredFieldValidator" runat="server" ControlToValidate="ctrlNameObjectsHeat"
                            ErrorMessage="Не указано: NameObjectsHeat" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlDateRegLabel" runat="server" Text="Дата регистрации" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlDateReg" CssClass="descTxt" runat="server"/>
</div>
<ac:DatePickerValidator ID="ctrlDateRegDatePickerValidator" runat="server" ControlToValidate="ctrlDateReg" 
                        ErrorMessage="Введена некорректная дата: Дата регистрации." Text="*" 
                        EnableClientScript="true" ValidationGroup="savedoc" CssClass="validator-datePicker" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlAreaLabel" runat="server" Text="Площадь объекта" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox runat="server" CssClass="descTxt" ID="ctrlArea">
</ac:DecimalTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlBuildingsLabel" runat="server" Text="Адрес здания" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlBuildings" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlBuildingsRequiredFieldValidator" runat="server" ControlToValidate="ctrlBuildings"
                            ErrorMessage="Не указано: Buildings" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlClientsLabel" runat="server" Text="ФИО клиента" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlClients" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlClientsRequiredFieldValidator" runat="server" ControlToValidate="ctrlClients"
                            ErrorMessage="Не указано: Clients" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
