﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvMaint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(12, 11)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(325, 160)
        Me.lstItems.TabIndex = 14
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(353, 96)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 24)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(353, 68)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 24)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete Item..."
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(353, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 24)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add Item..."
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(353, 40)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(104, 24)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update Item..."
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 182)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 13)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Tyler Hattan"
        '
        'frmInvMaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(472, 207)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInvMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lstItems As System.Windows.Forms.ListBox
    Private WithEvents btnExit As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblName As Label
End Class
