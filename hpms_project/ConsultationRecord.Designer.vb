<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultationRecord
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        titlelbl = New Label()
        PictureBox1 = New PictureBox()
        patientInformationgrp = New GroupBox()
        visittypenamelbl = New Label()
        visitTypelbl = New Label()
        visitdtlbl = New Label()
        visitDatelbl = New Label()
        genderagelbl = New Label()
        agegenderlbl = New Label()
        patientNamelbl = New Label()
        namelbl = New Label()
        currentcomplainlbl = New Label()
        RichTextBox1 = New RichTextBox()
        vitalsignlbl = New Label()
        temperaturelbl = New Label()
        bludplbl = New Label()
        heartratelbl = New Label()
        bmilbl = New Label()
        weightlbl = New Label()
        heightlbl = New Label()
        medicalhistorylbl = New Label()
        historylbl = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        patientInformationgrp.SuspendLayout()
        SuspendLayout()
        ' 
        ' titlelbl
        ' 
        titlelbl.AutoSize = True
        titlelbl.Font = New Font("Lucida Sans Unicode", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        titlelbl.Location = New Point(204, 63)
        titlelbl.Margin = New Padding(4, 0, 4, 0)
        titlelbl.Name = "titlelbl"
        titlelbl.Size = New Size(268, 28)
        titlelbl.TabIndex = 0
        titlelbl.Text = "Consultation Record"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(35, 63)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 117)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' patientInformationgrp
        ' 
        patientInformationgrp.BackColor = SystemColors.Control
        patientInformationgrp.Controls.Add(visittypenamelbl)
        patientInformationgrp.Controls.Add(visitTypelbl)
        patientInformationgrp.Controls.Add(visitdtlbl)
        patientInformationgrp.Controls.Add(visitDatelbl)
        patientInformationgrp.Controls.Add(genderagelbl)
        patientInformationgrp.Controls.Add(agegenderlbl)
        patientInformationgrp.Controls.Add(patientNamelbl)
        patientInformationgrp.Controls.Add(namelbl)
        patientInformationgrp.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        patientInformationgrp.ForeColor = SystemColors.ControlText
        patientInformationgrp.Location = New Point(34, 197)
        patientInformationgrp.Margin = New Padding(14, 13, 14, 13)
        patientInformationgrp.Name = "patientInformationgrp"
        patientInformationgrp.Padding = New Padding(4)
        patientInformationgrp.Size = New Size(1446, 180)
        patientInformationgrp.TabIndex = 2
        patientInformationgrp.TabStop = False
        patientInformationgrp.Text = "Patient Information"
        patientInformationgrp.Visible = False
        ' 
        ' visittypenamelbl
        ' 
        visittypenamelbl.BorderStyle = BorderStyle.FixedSingle
        visittypenamelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        visittypenamelbl.Location = New Point(204, 147)
        visittypenamelbl.Margin = New Padding(4)
        visittypenamelbl.Name = "visittypenamelbl"
        visittypenamelbl.Size = New Size(714, 30)
        visittypenamelbl.TabIndex = 7
        visittypenamelbl.Text = "Label1"
        ' 
        ' visitTypelbl
        ' 
        visitTypelbl.BorderStyle = BorderStyle.FixedSingle
        visitTypelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        visitTypelbl.Location = New Point(0, 147)
        visitTypelbl.Margin = New Padding(4, 0, 4, 0)
        visitTypelbl.Name = "visitTypelbl"
        visitTypelbl.Size = New Size(209, 30)
        visitTypelbl.TabIndex = 6
        visitTypelbl.Text = "VISIT TYPE"
        ' 
        ' visitdtlbl
        ' 
        visitdtlbl.BorderStyle = BorderStyle.FixedSingle
        visitdtlbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        visitdtlbl.Location = New Point(204, 116)
        visitdtlbl.Margin = New Padding(4, 0, 4, 0)
        visitdtlbl.Name = "visitdtlbl"
        visitdtlbl.Size = New Size(714, 30)
        visitdtlbl.TabIndex = 5
        visitdtlbl.Text = "Label2"
        ' 
        ' visitDatelbl
        ' 
        visitDatelbl.BorderStyle = BorderStyle.FixedSingle
        visitDatelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        visitDatelbl.Location = New Point(0, 116)
        visitDatelbl.Margin = New Padding(4, 0, 4, 0)
        visitDatelbl.Name = "visitDatelbl"
        visitDatelbl.Size = New Size(209, 30)
        visitDatelbl.TabIndex = 4
        visitDatelbl.Text = "VISIT DATE:"
        ' 
        ' genderagelbl
        ' 
        genderagelbl.BorderStyle = BorderStyle.FixedSingle
        genderagelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        genderagelbl.Location = New Point(204, 87)
        genderagelbl.Margin = New Padding(4, 0, 4, 0)
        genderagelbl.Name = "genderagelbl"
        genderagelbl.Size = New Size(714, 30)
        genderagelbl.TabIndex = 3
        genderagelbl.Text = "3232 years old / Femboy"
        ' 
        ' agegenderlbl
        ' 
        agegenderlbl.BorderStyle = BorderStyle.FixedSingle
        agegenderlbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        agegenderlbl.Location = New Point(0, 87)
        agegenderlbl.Margin = New Padding(4, 0, 4, 0)
        agegenderlbl.Name = "agegenderlbl"
        agegenderlbl.Size = New Size(209, 30)
        agegenderlbl.TabIndex = 2
        agegenderlbl.Text = "AGE/GENDER"
        ' 
        ' patientNamelbl
        ' 
        patientNamelbl.BorderStyle = BorderStyle.FixedSingle
        patientNamelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        patientNamelbl.Location = New Point(204, 56)
        patientNamelbl.Margin = New Padding(4, 0, 4, 0)
        patientNamelbl.Name = "patientNamelbl"
        patientNamelbl.Size = New Size(714, 30)
        patientNamelbl.TabIndex = 1
        patientNamelbl.Text = "Jemery Gibada"
        ' 
        ' namelbl
        ' 
        namelbl.BorderStyle = BorderStyle.FixedSingle
        namelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        namelbl.Location = New Point(0, 56)
        namelbl.Margin = New Padding(4, 0, 4, 0)
        namelbl.Name = "namelbl"
        namelbl.Size = New Size(209, 30)
        namelbl.TabIndex = 0
        namelbl.Text = "Name:"
        ' 
        ' currentcomplainlbl
        ' 
        currentcomplainlbl.BorderStyle = BorderStyle.FixedSingle
        currentcomplainlbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        currentcomplainlbl.Location = New Point(34, 392)
        currentcomplainlbl.Margin = New Padding(4, 0, 4, 0)
        currentcomplainlbl.Name = "currentcomplainlbl"
        currentcomplainlbl.Size = New Size(387, 39)
        currentcomplainlbl.TabIndex = 3
        currentcomplainlbl.Text = "CURRENT COMPLAIN"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Location = New Point(34, 432)
        RichTextBox1.Margin = New Padding(4)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(387, 127)
        RichTextBox1.TabIndex = 5
        RichTextBox1.Text = ""
        ' 
        ' vitalsignlbl
        ' 
        vitalsignlbl.BorderStyle = BorderStyle.FixedSingle
        vitalsignlbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        vitalsignlbl.Location = New Point(34, 595)
        vitalsignlbl.Margin = New Padding(4, 0, 4, 0)
        vitalsignlbl.Name = "vitalsignlbl"
        vitalsignlbl.Size = New Size(387, 30)
        vitalsignlbl.TabIndex = 6
        vitalsignlbl.Text = "VITAL SIGN"
        ' 
        ' temperaturelbl
        ' 
        temperaturelbl.BorderStyle = BorderStyle.FixedSingle
        temperaturelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        temperaturelbl.Location = New Point(34, 625)
        temperaturelbl.Margin = New Padding(4, 0, 4, 0)
        temperaturelbl.Name = "temperaturelbl"
        temperaturelbl.Size = New Size(129, 95)
        temperaturelbl.TabIndex = 7
        temperaturelbl.Text = "TEMPERATURE"
        temperaturelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' bludplbl
        ' 
        bludplbl.BorderStyle = BorderStyle.FixedSingle
        bludplbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bludplbl.Location = New Point(163, 625)
        bludplbl.Margin = New Padding(4, 0, 4, 0)
        bludplbl.Name = "bludplbl"
        bludplbl.Size = New Size(129, 95)
        bludplbl.TabIndex = 8
        bludplbl.Text = "BLOOD PRESSURE"
        bludplbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' heartratelbl
        ' 
        heartratelbl.BorderStyle = BorderStyle.FixedSingle
        heartratelbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        heartratelbl.Location = New Point(292, 625)
        heartratelbl.Margin = New Padding(4, 0, 4, 0)
        heartratelbl.Name = "heartratelbl"
        heartratelbl.Size = New Size(129, 95)
        heartratelbl.TabIndex = 9
        heartratelbl.Text = "PULSE"
        heartratelbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' bmilbl
        ' 
        bmilbl.BorderStyle = BorderStyle.FixedSingle
        bmilbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bmilbl.Location = New Point(292, 720)
        bmilbl.Margin = New Padding(4, 0, 4, 0)
        bmilbl.Name = "bmilbl"
        bmilbl.Size = New Size(129, 95)
        bmilbl.TabIndex = 10
        bmilbl.Text = "BMI"
        bmilbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' weightlbl
        ' 
        weightlbl.BorderStyle = BorderStyle.FixedSingle
        weightlbl.Font = New Font("Lucida Sans Unicode", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        weightlbl.Location = New Point(163, 720)
        weightlbl.Margin = New Padding(4, 0, 4, 0)
        weightlbl.Name = "weightlbl"
        weightlbl.Size = New Size(129, 95)
        weightlbl.TabIndex = 11
        weightlbl.Text = "WEIGHT"
        weightlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' heightlbl
        ' 
        heightlbl.BorderStyle = BorderStyle.FixedSingle
        heightlbl.Font = New Font("Lucida Sans Unicode", 12.0F)
        heightlbl.Location = New Point(34, 720)
        heightlbl.Margin = New Padding(4, 0, 4, 0)
        heightlbl.Name = "heightlbl"
        heightlbl.Size = New Size(129, 95)
        heightlbl.TabIndex = 12
        heightlbl.Text = "HEIGHT"
        heightlbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' medicalhistorylbl
        ' 
        medicalhistorylbl.BorderStyle = BorderStyle.FixedSingle
        medicalhistorylbl.Location = New Point(468, 390)
        medicalhistorylbl.Name = "medicalhistorylbl"
        medicalhistorylbl.Size = New Size(484, 41)
        medicalhistorylbl.TabIndex = 13
        medicalhistorylbl.Text = "MEDICAL HISTORY"
        ' 
        ' historylbl
        ' 
        historylbl.BorderStyle = BorderStyle.FixedSingle
        historylbl.Location = New Point(468, 432)
        historylbl.Name = "historylbl"
        historylbl.Size = New Size(484, 383)
        historylbl.TabIndex = 14
        historylbl.Text = "HIV" & vbCrLf & "TIGDAS" & vbCrLf & "POLIO" & vbCrLf & "BANLAG" & vbCrLf & vbCrLf
        ' 
        ' ConsultationRecord
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(historylbl)
        Controls.Add(medicalhistorylbl)
        Controls.Add(heightlbl)
        Controls.Add(weightlbl)
        Controls.Add(bmilbl)
        Controls.Add(heartratelbl)
        Controls.Add(bludplbl)
        Controls.Add(temperaturelbl)
        Controls.Add(vitalsignlbl)
        Controls.Add(RichTextBox1)
        Controls.Add(currentcomplainlbl)
        Controls.Add(patientInformationgrp)
        Controls.Add(PictureBox1)
        Controls.Add(titlelbl)
        Font = New Font("Lucida Sans Unicode", 12.0F)
        Margin = New Padding(4)
        Name = "ConsultationRecord"
        Size = New Size(987, 833)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        patientInformationgrp.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents patientInformationgrp As GroupBox
    Friend WithEvents namelbl As Label
    Friend WithEvents patientNamelbl As Label
    Friend WithEvents agegenderlbl As Label
    Friend WithEvents genderagelbl As Label
    Friend WithEvents visitDatelbl As Label
    Friend WithEvents visitdtlbl As Label
    Friend WithEvents visitTypelbl As Label
    Friend WithEvents visittypenamelbl As Label
    Friend WithEvents currentcomplainlbl As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents vitalsignlbl As Label
    Friend WithEvents temperaturelbl As Label
    Friend WithEvents bludplbl As Label
    Friend WithEvents heartratelbl As Label
    Friend WithEvents bmilbl As Label
    Friend WithEvents weightlbl As Label
    Friend WithEvents heightlbl As Label
    Friend WithEvents medicalhistorylbl As Label
    Friend WithEvents historylbl As Label

End Class