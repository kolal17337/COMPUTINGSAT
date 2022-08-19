<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblRead = New System.Windows.Forms.Label()
        Me.chkGenreList = New System.Windows.Forms.CheckedListBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.btnUpvote = New System.Windows.Forms.Button()
        Me.btnDownvote = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblWrite = New System.Windows.Forms.Label()
        Me.lblUpvotes = New System.Windows.Forms.Label()
        Me.lblDownvotes = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(40, 255)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(272, 103)
        Me.btnRandom.TabIndex = 0
        Me.btnRandom.Text = "Generate Song"
        Me.btnRandom.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(45, 114)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(80, 20)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Song Title"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblArtist.Location = New System.Drawing.Point(45, 155)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(46, 20)
        Me.lblArtist.TabIndex = 3
        Me.lblArtist.Text = "Artist"
        '
        'lblRead
        '
        Me.lblRead.AutoSize = True
        Me.lblRead.ForeColor = System.Drawing.Color.Snow
        Me.lblRead.Location = New System.Drawing.Point(255, 155)
        Me.lblRead.Name = "lblRead"
        Me.lblRead.Size = New System.Drawing.Size(57, 20)
        Me.lblRead.TabIndex = 1
        Me.lblRead.Text = "Label1"
        Me.lblRead.Visible = False
        '
        'chkGenreList
        '
        Me.chkGenreList.FormattingEnabled = True
        Me.chkGenreList.Location = New System.Drawing.Point(400, 82)
        Me.chkGenreList.Name = "chkGenreList"
        Me.chkGenreList.Size = New System.Drawing.Size(331, 510)
        Me.chkGenreList.TabIndex = 9
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.ForeColor = System.Drawing.Color.Snow
        Me.lblGenre.Location = New System.Drawing.Point(45, 200)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(54, 20)
        Me.lblGenre.TabIndex = 10
        Me.lblGenre.Text = "Genre"
        '
        'btnUpvote
        '
        Me.btnUpvote.Location = New System.Drawing.Point(40, 385)
        Me.btnUpvote.Name = "btnUpvote"
        Me.btnUpvote.Size = New System.Drawing.Size(128, 98)
        Me.btnUpvote.TabIndex = 11
        Me.btnUpvote.Text = "Upvote"
        Me.btnUpvote.UseVisualStyleBackColor = True
        '
        'btnDownvote
        '
        Me.btnDownvote.Location = New System.Drawing.Point(184, 385)
        Me.btnDownvote.Name = "btnDownvote"
        Me.btnDownvote.Size = New System.Drawing.Size(128, 98)
        Me.btnDownvote.TabIndex = 12
        Me.btnDownvote.Text = "Downvote"
        Me.btnDownvote.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1044, 17)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 62)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Save + Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblWrite
        '
        Me.lblWrite.AutoSize = True
        Me.lblWrite.Location = New System.Drawing.Point(255, 200)
        Me.lblWrite.Name = "lblWrite"
        Me.lblWrite.Size = New System.Drawing.Size(57, 20)
        Me.lblWrite.TabIndex = 14
        Me.lblWrite.Text = "Label3"
        Me.lblWrite.Visible = False
        '
        'lblUpvotes
        '
        Me.lblUpvotes.AutoSize = True
        Me.lblUpvotes.BackColor = System.Drawing.Color.ForestGreen
        Me.lblUpvotes.ForeColor = System.Drawing.Color.Snow
        Me.lblUpvotes.Location = New System.Drawing.Point(45, 506)
        Me.lblUpvotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUpvotes.Name = "lblUpvotes"
        Me.lblUpvotes.Size = New System.Drawing.Size(0, 20)
        Me.lblUpvotes.TabIndex = 15
        '
        'lblDownvotes
        '
        Me.lblDownvotes.AutoSize = True
        Me.lblDownvotes.BackColor = System.Drawing.Color.Crimson
        Me.lblDownvotes.ForeColor = System.Drawing.Color.Snow
        Me.lblDownvotes.Location = New System.Drawing.Point(191, 506)
        Me.lblDownvotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDownvotes.Name = "lblDownvotes"
        Me.lblDownvotes.Size = New System.Drawing.Size(0, 20)
        Me.lblDownvotes.TabIndex = 16
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.ForeColor = System.Drawing.Color.Snow
        Me.lblPercentage.Location = New System.Drawing.Point(45, 568)
        Me.lblPercentage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(175, 20)
        Me.lblPercentage.TabIndex = 17
        Me.lblPercentage.Text = "Percentage Of Upvotes"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(774, 108)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 26)
        Me.txtSearch.TabIndex = 18
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(774, 155)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(276, 114)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(774, 292)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(276, 114)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add Song"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(774, 423)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(276, 48)
        Me.btnUndo.TabIndex = 21
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.ForeColor = System.Drawing.Color.Snow
        Me.lblHeading.Location = New System.Drawing.Point(45, 59)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(320, 20)
        Me.lblHeading.TabIndex = 22
        Me.lblHeading.Text = "SONG RECOMMENDATION GENERATOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(770, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "SONG SEARCH"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1167, 683)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblDownvotes)
        Me.Controls.Add(Me.lblUpvotes)
        Me.Controls.Add(Me.lblWrite)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDownvote)
        Me.Controls.Add(Me.btnUpvote)
        Me.Controls.Add(Me.lblGenre)
        Me.Controls.Add(Me.chkGenreList)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblRead)
        Me.Controls.Add(Me.btnRandom)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRandom As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblRead As Label
    Friend WithEvents chkGenreList As CheckedListBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents btnUpvote As Button
    Friend WithEvents btnDownvote As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWrite As Label
    Friend WithEvents lblUpvotes As Label
    Friend WithEvents lblDownvotes As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents Label1 As Label
End Class
