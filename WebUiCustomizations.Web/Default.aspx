<%@ Page Language="C#" AutoEventWireup="true" Inherits="Default" EnableViewState="false"
    ValidateRequest="false" CodeBehind="Default.aspx.cs" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v20.1, Version=20.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.ExpressApp.Web.Templates" TagPrefix="cc3" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v20.1, Version=20.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.ExpressApp.Web.Controls" TagPrefix="cc4" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Main Page</title>
    <meta http-equiv="Expires" content="0" />
  <style type="text/css">
      .ToggleNavigationImage {
    background-position: 0px 0px;
    background-size: 538px auto;
    width: 48px;
    height: 48px;
    visibility: hidden;
}
.ToggleNavigationActiveImage, .ToggleNavigationImage {
    margin-left: -15px;
    cursor: pointer;
    visibility: hidden;
}
.ToggleNavigationImage {
    background-position: 0px 0px;
    background-size: 538px auto;
    width: 48px;
    height: 48px;
    visibility: hidden;
}
.dxm-hovered .dxWeb_mHorizontalPopOut_XafTheme, .dxm-scrollBtnHovered .dxWeb_mScrollDown_XafTheme, .dxm-scrollBtnHovered .dxWeb_mScrollUp_XafTheme, .dxtv-ndSel .dxtv-xafNavBt .dxWeb_tvColBtn_XafTheme, .dxtv-ndSel .dxtv-xafNavBt .dxWeb_tvColBtnRtl_XafTheme, .dxtv-ndSel .dxtv-xafNavBt .dxWeb_tvExpBtn_XafTheme, .dxtv-ndSel .dxtv-xafNavBt .dxWeb_tvExpBtnRtl_XafTheme, .dxtv-xafNavBt .dxWeb_tvColBtn_XafTheme, .dxtv-xafNavBt .dxWeb_tvColBtnRtl_XafTheme, .dxtv-xafNavBt .dxWeb_tvExpBtn_XafTheme, .dxtv-xafNavBt .dxWeb_tvExpBtnRtl_XafTheme, .dxWeb_edtCheckBoxChecked_XafTheme, .dxWeb_edtCheckBoxCheckedDisabled_XafTheme, .dxWeb_edtCheckBoxGrayed_XafTheme, .dxWeb_edtCheckBoxGrayedDisabled_XafTheme, .dxWeb_edtCheckBoxUnchecked_XafTheme, .dxWeb_edtCheckBoxUncheckedDisabled_XafTheme, .dxWeb_fabCloseActions_XafTheme, .dxWeb_fabCreate_XafTheme, .dxWeb_fabExpandActions_XafTheme, .dxWeb_mAdaptiveMenu_XafTheme, .dxWeb_mHorizontalPopOut_XafTheme, .dxWeb_mScrollDown_XafTheme, .dxWeb_mScrollUp_XafTheme, .Layout .BCC td.dxichCellSys .dxWeb_edtCheckBoxChecked_XafTheme, .Layout .BCC td.dxichCellSys .dxWeb_edtCheckBoxCheckedDisabled_XafTheme, .Layout .BCC td.dxichCellSys .dxWeb_edtCheckBoxGrayed_XafTheme, .Layout .BCC td.dxichCellSys .dxWeb_edtCheckBoxGrayedDisabled_XafTheme, .Layout .BCC td.dxichCellSys .dxWeb_edtCheckBoxUnchecked_XafTheme, .Layout .BCC td.dxichCellSys .dxWeb_edtCheckBoxUncheckedDisabled_XafTheme, .ToggleNavigationActiveImage, .ToggleNavigationImage {
    background-image: url('/DXR.axd?r=0_6086-GjjSk');
    background-repeat: no-repeat;
    background-color: transparent;
}
table {
    border-collapse: separate !important;
}
table {
    border-collapse: collapse;
    border-spacing: 0;
}
body {
    font: 14px 'Segoe UI','Helvetica Neue','Droid Sans',Arial,Tahoma,Geneva,Sans-serif;
}
  </style>
</head>
<body class="VerticalTemplate">
    <form id="form2" runat="server">
    <cc4:ASPxProgressControl ID="ProgressControl" runat="server" />
    <div runat="server" id="Content" />
    </form>
</body>
</html>