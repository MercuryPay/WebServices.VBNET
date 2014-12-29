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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtWebServicesURL = New System.Windows.Forms.TextBox()
        Me.txtSOAPAction = New System.Windows.Forms.TextBox()
        Me.btnProcessTransaction = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnLoadXml = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 108)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(678, 440)
        Me.TextBox1.TabIndex = 0
        '
        'txtWebServicesURL
        '
        Me.txtWebServicesURL.Location = New System.Drawing.Point(130, 12)
        Me.txtWebServicesURL.Name = "txtWebServicesURL"
        Me.txtWebServicesURL.Size = New System.Drawing.Size(294, 20)
        Me.txtWebServicesURL.TabIndex = 1
        Me.txtWebServicesURL.Text = "https://w1.mercurydev.net/ws/ws.asmx"
        '
        'txtSOAPAction
        '
        Me.txtSOAPAction.Location = New System.Drawing.Point(130, 38)
        Me.txtSOAPAction.Name = "txtSOAPAction"
        Me.txtSOAPAction.Size = New System.Drawing.Size(294, 20)
        Me.txtSOAPAction.TabIndex = 2
        Me.txtSOAPAction.Text = "http://www.mercurypay.com/CreditTransaction"
        '
        'btnProcessTransaction
        '
        Me.btnProcessTransaction.Location = New System.Drawing.Point(276, 64)
        Me.btnProcessTransaction.Name = "btnProcessTransaction"
        Me.btnProcessTransaction.Size = New System.Drawing.Size(121, 38)
        Me.btnProcessTransaction.TabIndex = 3
        Me.btnProcessTransaction.Text = "Process Txn"
        Me.btnProcessTransaction.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(979, 64)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 38)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(696, 108)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(678, 440)
        Me.TextBox4.TabIndex = 5
        '
        'btnLoadXml
        '
        Me.btnLoadXml.Location = New System.Drawing.Point(102, 64)
        Me.btnLoadXml.Name = "btnLoadXml"
        Me.btnLoadXml.Size = New System.Drawing.Size(121, 38)
        Me.btnLoadXml.TabIndex = 6
        Me.btnLoadXml.Text = "LOAD XML"
        Me.btnLoadXml.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "WebServices URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SOAP Action"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 560)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLoadXml)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcessTransaction)
        Me.Controls.Add(Me.txtSOAPAction)
        Me.Controls.Add(Me.txtWebServicesURL)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB.NET WS Project - BN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtWebServicesURL As System.Windows.Forms.TextBox
    Friend WithEvents txtSOAPAction As System.Windows.Forms.TextBox
    Friend WithEvents btnProcessTransaction As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadXml As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
