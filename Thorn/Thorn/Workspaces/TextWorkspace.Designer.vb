﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextWorkspace
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMain.Location = New System.Drawing.Point(0, 0)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMain.Size = New System.Drawing.Size(387, 309)
        Me.txtMain.TabIndex = 0
        '
        'TextWorkspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtMain)
        Me.Name = "TextWorkspace"
        Me.Size = New System.Drawing.Size(387, 309)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMain As System.Windows.Forms.TextBox

End Class
