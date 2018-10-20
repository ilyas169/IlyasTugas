<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.TBUnit = New System.Windows.Forms.TextBox()
        Me.TBReqId = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TbInstruction = New System.Windows.Forms.TextBox()
        Me.TbAcREGIS = New System.Windows.Forms.TextBox()
        Me.TbUniDestination = New System.Windows.Forms.TextBox()
        Me.TbPhone = New System.Windows.Forms.TextBox()
        Me.CBTransportation = New System.Windows.Forms.ComboBox()
        Me.BtSend = New System.Windows.Forms.Button()
        Me.TBTransport = New System.Windows.Forms.TextBox()
        Me.LVrequest = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name Of Requestor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date Of Issue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "to Unit?Destination"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Instruction"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(309, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "A/CReg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Ext.Phone/HP"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(309, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Transportation"
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(117, 49)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(100, 20)
        Me.TBName.TabIndex = 9
        '
        'TBUnit
        '
        Me.TBUnit.Location = New System.Drawing.Point(117, 119)
        Me.TBUnit.Name = "TBUnit"
        Me.TBUnit.Size = New System.Drawing.Size(100, 20)
        Me.TBUnit.TabIndex = 10
        '
        'TBReqId
        '
        Me.TBReqId.Location = New System.Drawing.Point(117, 82)
        Me.TBReqId.Name = "TBReqId"
        Me.TBReqId.Size = New System.Drawing.Size(100, 20)
        Me.TBReqId.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'TbInstruction
        '
        Me.TbInstruction.Location = New System.Drawing.Point(107, 208)
        Me.TbInstruction.Multiline = True
        Me.TbInstruction.Name = "TbInstruction"
        Me.TbInstruction.Size = New System.Drawing.Size(504, 123)
        Me.TbInstruction.TabIndex = 13
        '
        'TbAcREGIS
        '
        Me.TbAcREGIS.Location = New System.Drawing.Point(412, 86)
        Me.TbAcREGIS.Name = "TbAcREGIS"
        Me.TbAcREGIS.Size = New System.Drawing.Size(100, 20)
        Me.TbAcREGIS.TabIndex = 14
        '
        'TbUniDestination
        '
        Me.TbUniDestination.Location = New System.Drawing.Point(412, 49)
        Me.TbUniDestination.Name = "TbUniDestination"
        Me.TbUniDestination.Size = New System.Drawing.Size(100, 20)
        Me.TbUniDestination.TabIndex = 15
        '
        'TbPhone
        '
        Me.TbPhone.Location = New System.Drawing.Point(412, 177)
        Me.TbPhone.Name = "TbPhone"
        Me.TbPhone.Size = New System.Drawing.Size(100, 20)
        Me.TbPhone.TabIndex = 16
        '
        'CBTransportation
        '
        Me.CBTransportation.FormattingEnabled = True
        Me.CBTransportation.Location = New System.Drawing.Point(412, 126)
        Me.CBTransportation.Name = "CBTransportation"
        Me.CBTransportation.Size = New System.Drawing.Size(100, 21)
        Me.CBTransportation.TabIndex = 17
        '
        'BtSend
        '
        Me.BtSend.Location = New System.Drawing.Point(117, 350)
        Me.BtSend.Name = "BtSend"
        Me.BtSend.Size = New System.Drawing.Size(100, 23)
        Me.BtSend.TabIndex = 18
        Me.BtSend.Text = "Send Request "
        Me.BtSend.UseVisualStyleBackColor = True
        '
        'TBTransport
        '
        Me.TBTransport.Location = New System.Drawing.Point(412, 150)
        Me.TBTransport.Name = "TBTransport"
        Me.TBTransport.Size = New System.Drawing.Size(100, 20)
        Me.TBTransport.TabIndex = 19
        '
        'LVrequest
        '
        Me.LVrequest.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LVrequest.Location = New System.Drawing.Point(668, 49)
        Me.LVrequest.Name = "LVrequest"
        Me.LVrequest.Size = New System.Drawing.Size(355, 294)
        Me.LVrequest.TabIndex = 20
        Me.LVrequest.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(244, 350)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(100, 23)
        Me.btupdate.TabIndex = 21
        Me.btupdate.Text = "Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(544, 102)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(100, 20)
        Me.tid.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 418)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.LVrequest)
        Me.Controls.Add(Me.TBTransport)
        Me.Controls.Add(Me.BtSend)
        Me.Controls.Add(Me.CBTransportation)
        Me.Controls.Add(Me.TbPhone)
        Me.Controls.Add(Me.TbUniDestination)
        Me.Controls.Add(Me.TbAcREGIS)
        Me.Controls.Add(Me.TbInstruction)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TBReqId)
        Me.Controls.Add(Me.TBUnit)
        Me.Controls.Add(Me.TBName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBName As System.Windows.Forms.TextBox
    Friend WithEvents TBUnit As System.Windows.Forms.TextBox
    Friend WithEvents TBReqId As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TbInstruction As System.Windows.Forms.TextBox
    Friend WithEvents TbAcREGIS As System.Windows.Forms.TextBox
    Friend WithEvents TbUniDestination As System.Windows.Forms.TextBox
    Friend WithEvents TbPhone As System.Windows.Forms.TextBox
    Friend WithEvents CBTransportation As System.Windows.Forms.ComboBox
    Friend WithEvents BtSend As System.Windows.Forms.Button
    Friend WithEvents TBTransport As System.Windows.Forms.TextBox
    Friend WithEvents LVrequest As System.Windows.Forms.ListView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btupdate As System.Windows.Forms.Button
    Friend WithEvents tid As System.Windows.Forms.TextBox

End Class
