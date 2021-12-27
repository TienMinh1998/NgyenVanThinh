<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_active
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
        Me.btn_ve = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SuspendLayout()
        '
        'btn_ve
        '
        Me.btn_ve.CheckedState.Parent = Me.btn_ve
        Me.btn_ve.CustomImages.Parent = Me.btn_ve
        Me.btn_ve.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_ve.ForeColor = System.Drawing.Color.White
        Me.btn_ve.HoverState.Parent = Me.btn_ve
        Me.btn_ve.Location = New System.Drawing.Point(345, 164)
        Me.btn_ve.Name = "btn_ve"
        Me.btn_ve.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_ve.ShadowDecoration.Parent = Me.btn_ve
        Me.btn_ve.Size = New System.Drawing.Size(148, 148)
        Me.btn_ve.TabIndex = 0
        Me.btn_ve.Text = "Vẽ"
        '
        'frm_active
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_ve)
        Me.Name = "frm_active"
        Me.Text = "frm_active"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ve As Guna.UI2.WinForms.Guna2CircleButton
End Class
