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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblSpeedtestSurvey = New System.Windows.Forms.Label()
        Me.BtnSpeed = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblSpeedtestSurvey
        '
        Me.LblSpeedtestSurvey.AutoSize = True
        Me.LblSpeedtestSurvey.BackColor = System.Drawing.Color.White
        Me.LblSpeedtestSurvey.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpeedtestSurvey.Location = New System.Drawing.Point(329, 21)
        Me.LblSpeedtestSurvey.Name = "LblSpeedtestSurvey"
        Me.LblSpeedtestSurvey.Size = New System.Drawing.Size(384, 32)
        Me.LblSpeedtestSurvey.TabIndex = 2
        Me.LblSpeedtestSurvey.Text = "Internet Speed Test Survey"
        '
        'BtnSpeed
        '
        Me.BtnSpeed.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnSpeed.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSpeed.ForeColor = System.Drawing.Color.White
        Me.BtnSpeed.Location = New System.Drawing.Point(417, 71)
        Me.BtnSpeed.Name = "BtnSpeed"
        Me.BtnSpeed.Size = New System.Drawing.Size(200, 56)
        Me.BtnSpeed.TabIndex = 3
        Me.BtnSpeed.Text = "Enter Internet Speed"
        Me.BtnSpeed.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClear.Location = New System.Drawing.Point(474, 146)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(84, 23)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(692, 71)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(136, 224)
        Me.ListBox1.TabIndex = 5
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.BackColor = System.Drawing.Color.White
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(424, 385)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(141, 20)
        Me.lblAverage.TabIndex = 6
        Me.lblAverage.Text = "XXXXXXXXXXX"
        Me.lblAverage.Visible = False
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnSpeed
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnClear
        Me.ClientSize = New System.Drawing.Size(874, 450)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSpeed)
        Me.Controls.Add(Me.LblSpeedtestSurvey)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblSpeedtestSurvey As Label
    Friend WithEvents BtnSpeed As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblAverage As Label
End Class
