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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTGpa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButtonFStudent = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLStudent = New System.Windows.Forms.RadioButton()
        Me.txtSGpa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtINo = New System.Windows.Forms.TextBox()
        Me.txtFGpa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstbShowDetails = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(62, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name"
        '
        'txtSName
        '
        Me.txtSName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSName.Location = New System.Drawing.Point(235, 29)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(201, 30)
        Me.txtSName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTGpa)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.RadioButtonFStudent)
        Me.GroupBox1.Controls.Add(Me.RadioButtonLStudent)
        Me.GroupBox1.Controls.Add(Me.txtSGpa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtINo)
        Me.GroupBox1.Controls.Add(Me.txtFGpa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 322)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student"
        '
        'txtTGpa
        '
        Me.txtTGpa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTGpa.Location = New System.Drawing.Point(235, 286)
        Me.txtTGpa.Name = "txtTGpa"
        Me.txtTGpa.Size = New System.Drawing.Size(201, 30)
        Me.txtTGpa.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(62, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Third Year GPA"
        '
        'RadioButtonFStudent
        '
        Me.RadioButtonFStudent.AutoSize = True
        Me.RadioButtonFStudent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonFStudent.Location = New System.Drawing.Point(281, 135)
        Me.RadioButtonFStudent.Name = "RadioButtonFStudent"
        Me.RadioButtonFStudent.Size = New System.Drawing.Size(155, 26)
        Me.RadioButtonFStudent.TabIndex = 4
        Me.RadioButtonFStudent.TabStop = True
        Me.RadioButtonFStudent.Text = "Foreign Student"
        Me.RadioButtonFStudent.UseVisualStyleBackColor = True
        '
        'RadioButtonLStudent
        '
        Me.RadioButtonLStudent.AutoSize = True
        Me.RadioButtonLStudent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RadioButtonLStudent.Location = New System.Drawing.Point(110, 135)
        Me.RadioButtonLStudent.Name = "RadioButtonLStudent"
        Me.RadioButtonLStudent.Size = New System.Drawing.Size(139, 26)
        Me.RadioButtonLStudent.TabIndex = 3
        Me.RadioButtonLStudent.TabStop = True
        Me.RadioButtonLStudent.Text = "Local Student"
        Me.RadioButtonLStudent.UseVisualStyleBackColor = True
        '
        'txtSGpa
        '
        Me.txtSGpa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSGpa.Location = New System.Drawing.Point(235, 234)
        Me.txtSGpa.Name = "txtSGpa"
        Me.txtSGpa.Size = New System.Drawing.Size(201, 30)
        Me.txtSGpa.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(62, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Secound Year GPA"
        '
        'txtINo
        '
        Me.txtINo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtINo.Location = New System.Drawing.Point(235, 77)
        Me.txtINo.Name = "txtINo"
        Me.txtINo.Size = New System.Drawing.Size(201, 30)
        Me.txtINo.TabIndex = 2
        '
        'txtFGpa
        '
        Me.txtFGpa.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFGpa.Location = New System.Drawing.Point(235, 186)
        Me.txtFGpa.Name = "txtFGpa"
        Me.txtFGpa.Size = New System.Drawing.Size(201, 30)
        Me.txtFGpa.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(62, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Index No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(62, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "First Year GPA"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(403, 414)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 29)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstbShowDetails
        '
        Me.lstbShowDetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstbShowDetails.FormattingEnabled = True
        Me.lstbShowDetails.ItemHeight = 22
        Me.lstbShowDetails.Location = New System.Drawing.Point(42, 414)
        Me.lstbShowDetails.Name = "lstbShowDetails"
        Me.lstbShowDetails.Size = New System.Drawing.Size(336, 180)
        Me.lstbShowDetails.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(186, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Scholarship"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(403, 491)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(403, 565)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 662)
        Me.Controls.Add(Me.lstbShowDetails)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTGpa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButtonFStudent As RadioButton
    Friend WithEvents RadioButtonLStudent As RadioButton
    Friend WithEvents txtSGpa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtINo As TextBox
    Friend WithEvents txtFGpa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lstbShowDetails As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
