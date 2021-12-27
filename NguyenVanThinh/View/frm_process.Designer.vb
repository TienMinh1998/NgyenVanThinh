<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_process
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_process))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.prc = New DevExpress.XtraEditors.ProgressBarControl()
        CType(Me.prc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(155, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bạn Muốn Load làm mới dữ liệu không?"
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(331, 115)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(149, 43)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "OK"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(486, 115)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(136, 43)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "No"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'prc
        '
        Me.prc.Location = New System.Drawing.Point(12, 65)
        Me.prc.Name = "prc"
        Me.prc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.prc.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.prc.Size = New System.Drawing.Size(610, 33)
        Me.prc.TabIndex = 3
        Me.prc.Visible = False
        '
        'frm_process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 179)
        Me.Controls.Add(Me.prc)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(652, 226)
        Me.MinimumSize = New System.Drawing.Size(652, 226)
        Me.Name = "frm_process"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process...."
        CType(Me.prc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents prc As DevExpress.XtraEditors.ProgressBarControl
End Class
