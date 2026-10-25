<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImagingDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImagingDetails))
        imagingtitlelbl = New Label()
        dandtlbl = New Label()
        statuslbl = New Label()
        patientinfolbl = New Label()
        namelbl = New Label()
        agengenderlbl = New Label()
        visittimelbl = New Label()
        visittypelbl = New Label()
        pnamelbl = New Label()
        pagegenderlbl = New Label()
        pdatentimelbl = New Label()
        pvisittypelbl = New Label()
        imagingdetailslbl = New Label()
        procedurelbl = New Label()
        bodypartlbl = New Label()
        techniquelbl = New Label()
        imagelbl = New Label()
        resultlbl = New Label()
        pprocedurelbl = New Label()
        pbodypartlbl = New Label()
        ptechniquelbl = New Label()
        presultlbl = New Label()
        viewimagelnk = New LinkLabel()
        resultsummartlbl = New Label()
        resulttextlbl = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' imagingtitlelbl
        ' 
        imagingtitlelbl.AutoSize = True
        imagingtitlelbl.Font = New Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        imagingtitlelbl.Location = New Point(140, 60)
        imagingtitlelbl.Name = "imagingtitlelbl"
        imagingtitlelbl.Size = New Size(193, 28)
        imagingtitlelbl.TabIndex = 0
        imagingtitlelbl.Text = "Imaging Details"
        ' 
        ' dandtlbl
        ' 
        dandtlbl.AutoSize = True
        dandtlbl.Font = New Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dandtlbl.Location = New Point(149, 96)
        dandtlbl.Name = "dandtlbl"
        dandtlbl.Size = New Size(129, 18)
        dandtlbl.TabIndex = 1
        dandtlbl.Text = "DATE AND  TIME"
        ' 
        ' statuslbl
        ' 
        statuslbl.AutoSize = True
        statuslbl.Font = New Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statuslbl.Location = New Point(756, 96)
        statuslbl.Name = "statuslbl"
        statuslbl.Size = New Size(98, 18)
        statuslbl.TabIndex = 2
        statuslbl.Text = "COMPLETED"
        ' 
        ' patientinfolbl
        ' 
        patientinfolbl.BorderStyle = BorderStyle.FixedSingle
        patientinfolbl.Font = New Font("Lucida Sans Unicode", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        patientinfolbl.Location = New Point(36, 167)
        patientinfolbl.Name = "patientinfolbl"
        patientinfolbl.Size = New Size(818, 29)
        patientinfolbl.TabIndex = 3
        patientinfolbl.Text = "PATIENT INFORMATION"
        ' 
        ' namelbl
        ' 
        namelbl.BorderStyle = BorderStyle.FixedSingle
        namelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        namelbl.Location = New Point(36, 196)
        namelbl.Name = "namelbl"
        namelbl.Size = New Size(144, 26)
        namelbl.TabIndex = 4
        namelbl.Text = "NAME"
        ' 
        ' agengenderlbl
        ' 
        agengenderlbl.BorderStyle = BorderStyle.FixedSingle
        agengenderlbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        agengenderlbl.Location = New Point(36, 222)
        agengenderlbl.Name = "agengenderlbl"
        agengenderlbl.Size = New Size(144, 26)
        agengenderlbl.TabIndex = 5
        agengenderlbl.Text = "AGE / GENDER"
        ' 
        ' visittimelbl
        ' 
        visittimelbl.BorderStyle = BorderStyle.FixedSingle
        visittimelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        visittimelbl.Location = New Point(36, 248)
        visittimelbl.Name = "visittimelbl"
        visittimelbl.Size = New Size(144, 26)
        visittimelbl.TabIndex = 6
        visittimelbl.Text = "VISIT DATE"
        ' 
        ' visittypelbl
        ' 
        visittypelbl.BorderStyle = BorderStyle.FixedSingle
        visittypelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        visittypelbl.Location = New Point(36, 274)
        visittypelbl.Name = "visittypelbl"
        visittypelbl.Size = New Size(144, 26)
        visittypelbl.TabIndex = 7
        visittypelbl.Text = "VISIT TYPE"
        ' 
        ' pnamelbl
        ' 
        pnamelbl.BorderStyle = BorderStyle.FixedSingle
        pnamelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnamelbl.Location = New Point(179, 196)
        pnamelbl.Name = "pnamelbl"
        pnamelbl.Size = New Size(675, 26)
        pnamelbl.TabIndex = 8
        pnamelbl.Text = "JEREMY GIDABA"
        ' 
        ' pagegenderlbl
        ' 
        pagegenderlbl.BorderStyle = BorderStyle.FixedSingle
        pagegenderlbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pagegenderlbl.Location = New Point(179, 222)
        pagegenderlbl.Name = "pagegenderlbl"
        pagegenderlbl.Size = New Size(675, 26)
        pagegenderlbl.TabIndex = 9
        pagegenderlbl.Text = "67 yrs old MALE"
        ' 
        ' pdatentimelbl
        ' 
        pdatentimelbl.BorderStyle = BorderStyle.FixedSingle
        pdatentimelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pdatentimelbl.Location = New Point(179, 248)
        pdatentimelbl.Name = "pdatentimelbl"
        pdatentimelbl.Size = New Size(675, 26)
        pdatentimelbl.TabIndex = 10
        pdatentimelbl.Text = "date & time"
        ' 
        ' pvisittypelbl
        ' 
        pvisittypelbl.BorderStyle = BorderStyle.FixedSingle
        pvisittypelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pvisittypelbl.Location = New Point(179, 274)
        pvisittypelbl.Name = "pvisittypelbl"
        pvisittypelbl.Size = New Size(675, 26)
        pvisittypelbl.TabIndex = 11
        pvisittypelbl.Text = "consultation"
        ' 
        ' imagingdetailslbl
        ' 
        imagingdetailslbl.BorderStyle = BorderStyle.FixedSingle
        imagingdetailslbl.Font = New Font("Lucida Sans Unicode", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        imagingdetailslbl.Location = New Point(36, 313)
        imagingdetailslbl.Name = "imagingdetailslbl"
        imagingdetailslbl.Size = New Size(392, 29)
        imagingdetailslbl.TabIndex = 12
        imagingdetailslbl.Text = "IMAGING DETAILS"
        ' 
        ' procedurelbl
        ' 
        procedurelbl.BorderStyle = BorderStyle.FixedSingle
        procedurelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        procedurelbl.ImageAlign = ContentAlignment.MiddleLeft
        procedurelbl.Location = New Point(36, 342)
        procedurelbl.Name = "procedurelbl"
        procedurelbl.Size = New Size(116, 40)
        procedurelbl.TabIndex = 13
        procedurelbl.Text = "PROCEDURE"
        ' 
        ' bodypartlbl
        ' 
        bodypartlbl.BorderStyle = BorderStyle.FixedSingle
        bodypartlbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bodypartlbl.ImageAlign = ContentAlignment.MiddleLeft
        bodypartlbl.Location = New Point(36, 382)
        bodypartlbl.Name = "bodypartlbl"
        bodypartlbl.Size = New Size(116, 40)
        bodypartlbl.TabIndex = 14
        bodypartlbl.Text = "BODYPART"
        ' 
        ' techniquelbl
        ' 
        techniquelbl.BorderStyle = BorderStyle.FixedSingle
        techniquelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        techniquelbl.ImageAlign = ContentAlignment.MiddleLeft
        techniquelbl.Location = New Point(36, 422)
        techniquelbl.Name = "techniquelbl"
        techniquelbl.Size = New Size(116, 40)
        techniquelbl.TabIndex = 15
        techniquelbl.Text = "TECHNIQUE"
        ' 
        ' imagelbl
        ' 
        imagelbl.BorderStyle = BorderStyle.FixedSingle
        imagelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        imagelbl.ImageAlign = ContentAlignment.MiddleLeft
        imagelbl.Location = New Point(36, 502)
        imagelbl.Name = "imagelbl"
        imagelbl.Size = New Size(116, 40)
        imagelbl.TabIndex = 16
        imagelbl.Text = "IMAGES"
        ' 
        ' resultlbl
        ' 
        resultlbl.BorderStyle = BorderStyle.FixedSingle
        resultlbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resultlbl.ImageAlign = ContentAlignment.MiddleLeft
        resultlbl.Location = New Point(36, 462)
        resultlbl.Name = "resultlbl"
        resultlbl.Size = New Size(116, 40)
        resultlbl.TabIndex = 17
        resultlbl.Text = "RESULT"
        ' 
        ' pprocedurelbl
        ' 
        pprocedurelbl.BorderStyle = BorderStyle.FixedSingle
        pprocedurelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pprocedurelbl.Location = New Point(149, 342)
        pprocedurelbl.Name = "pprocedurelbl"
        pprocedurelbl.Size = New Size(279, 40)
        pprocedurelbl.TabIndex = 18
        ' 
        ' pbodypartlbl
        ' 
        pbodypartlbl.BorderStyle = BorderStyle.FixedSingle
        pbodypartlbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pbodypartlbl.Location = New Point(149, 382)
        pbodypartlbl.Name = "pbodypartlbl"
        pbodypartlbl.Size = New Size(279, 40)
        pbodypartlbl.TabIndex = 19
        ' 
        ' ptechniquelbl
        ' 
        ptechniquelbl.BorderStyle = BorderStyle.FixedSingle
        ptechniquelbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ptechniquelbl.Location = New Point(149, 422)
        ptechniquelbl.Name = "ptechniquelbl"
        ptechniquelbl.Size = New Size(279, 40)
        ptechniquelbl.TabIndex = 20
        ' 
        ' presultlbl
        ' 
        presultlbl.BorderStyle = BorderStyle.FixedSingle
        presultlbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        presultlbl.Location = New Point(149, 462)
        presultlbl.Name = "presultlbl"
        presultlbl.Size = New Size(279, 40)
        presultlbl.TabIndex = 21
        ' 
        ' viewimagelnk
        ' 
        viewimagelnk.BorderStyle = BorderStyle.FixedSingle
        viewimagelnk.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        viewimagelnk.Location = New Point(149, 502)
        viewimagelnk.Name = "viewimagelnk"
        viewimagelnk.Size = New Size(279, 41)
        viewimagelnk.TabIndex = 22
        viewimagelnk.TabStop = True
        viewimagelnk.Text = "VIEW IMAGE >"
        ' 
        ' resultsummartlbl
        ' 
        resultsummartlbl.BorderStyle = BorderStyle.FixedSingle
        resultsummartlbl.Font = New Font("Lucida Sans Unicode", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resultsummartlbl.Location = New Point(462, 313)
        resultsummartlbl.Name = "resultsummartlbl"
        resultsummartlbl.Size = New Size(392, 29)
        resultsummartlbl.TabIndex = 23
        resultsummartlbl.Text = "result summary"
        ' 
        ' resulttextlbl
        ' 
        resulttextlbl.BorderStyle = BorderStyle.FixedSingle
        resulttextlbl.Font = New Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resulttextlbl.Location = New Point(462, 342)
        resulttextlbl.Name = "resulttextlbl"
        resulttextlbl.Size = New Size(392, 201)
        resulttextlbl.TabIndex = 24
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(34, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' ImagingDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBox1)
        Controls.Add(resulttextlbl)
        Controls.Add(resultsummartlbl)
        Controls.Add(viewimagelnk)
        Controls.Add(presultlbl)
        Controls.Add(ptechniquelbl)
        Controls.Add(pbodypartlbl)
        Controls.Add(pprocedurelbl)
        Controls.Add(resultlbl)
        Controls.Add(imagelbl)
        Controls.Add(techniquelbl)
        Controls.Add(bodypartlbl)
        Controls.Add(procedurelbl)
        Controls.Add(imagingdetailslbl)
        Controls.Add(pvisittypelbl)
        Controls.Add(pdatentimelbl)
        Controls.Add(pagegenderlbl)
        Controls.Add(pnamelbl)
        Controls.Add(visittypelbl)
        Controls.Add(visittimelbl)
        Controls.Add(agengenderlbl)
        Controls.Add(namelbl)
        Controls.Add(patientinfolbl)
        Controls.Add(statuslbl)
        Controls.Add(dandtlbl)
        Controls.Add(imagingtitlelbl)
        Name = "ImagingDetails"
        Size = New Size(871, 736)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents imagingtitlelbl As Label
    Friend WithEvents dandtlbl As Label
    Friend WithEvents statuslbl As Label
    Friend WithEvents patientinfolbl As Label
    Friend WithEvents namelbl As Label
    Friend WithEvents agengenderlbl As Label
    Friend WithEvents visittimelbl As Label
    Friend WithEvents visittypelbl As Label
    Friend WithEvents pnamelbl As Label
    Friend WithEvents pagegenderlbl As Label
    Friend WithEvents pdatentimelbl As Label
    Friend WithEvents pvisittypelbl As Label
    Friend WithEvents imagingdetailslbl As Label
    Friend WithEvents procedurelbl As Label
    Friend WithEvents bodypartlbl As Label
    Friend WithEvents techniquelbl As Label
    Friend WithEvents imagelbl As Label
    Friend WithEvents resultlbl As Label
    Friend WithEvents pprocedurelbl As Label
    Friend WithEvents pbodypartlbl As Label
    Friend WithEvents ptechniquelbl As Label
    Friend WithEvents presultlbl As Label
    Friend WithEvents viewimagelnk As LinkLabel
    Friend WithEvents resultsummartlbl As Label
    Friend WithEvents resulttextlbl As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
