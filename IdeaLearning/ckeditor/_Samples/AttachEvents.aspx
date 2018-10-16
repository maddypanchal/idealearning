<%@ Page Language="C#" AutoEventWireup="true" %>

<script language="C#" runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        CKEditor1.CKEditorInstanceEventHandler = new System.Collections.Generic.List<object>();
        CKEditor1.CKEditorInstanceEventHandler.Add(new object[] { "instanceReady", "function (evt) { alert('Event Handler attached on CKEditorInstanceEventHandler to editor: ' + evt.editor.name);}" });
    }
</script>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<!--
Copyright (c) 2003-2012, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attaching Events &mdash; CKEditor for ASP.NET Sample</title>
    <link href="sample.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <CKEditor:CKEditorControl ID="CKEditor1" runat="server" Height="200">

    </CKEditor:CKEditorControl>
    </form>
</body>
</html>
