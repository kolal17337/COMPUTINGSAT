Public Class Form1
    ' This program uses camelCase naming notation.
    Dim strPath As String = My.Application.Info.DirectoryPath
    Dim strSongsPath As String = IO.Path.Combine(strPath, "top10s.csv")
    Dim strSongDatabase As New System.IO.StreamReader(strSongsPath)
    Dim strTop10s(1000, 1000) ' Use of a two-dimensional array to store data.
    Dim strGenreCheck(1000) ' One dimensional array to store data.
    Dim intGenreCount As Integer = 0
    Dim strSongSuggest(1000, 1000)
    Dim intSongCount As Integer

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Dim bGenreCheck As Boolean = False
        While bGenreCheck = False
            Dim intRand = Int((intSongCount - 0 + 1) * Rnd() + 0) ' Generates a random value.
            lblRead.Text = intRand
            lblUpvotes.Text = strTop10s(intRand, 4)
            lblDownvotes.Text = strTop10s(intRand, 5)
            If chkGenreList.CheckedItems.Contains(strTop10s(intRand, 1)) Or chkGenreList.CheckedItems.Contains("all") Then
                ' Displays a song from the array with the value generated. While loop loops until a song of the selected genre is found.
                lblGenre.Text = strTop10s(intRand, 1)
                lblTitle.Text = strTop10s(intRand, 2)
                lblArtist.Text = strTop10s(intRand, 3)
                bGenreCheck = True
            ElseIf chkGenreList.CheckedItems.Count = 0 Then
                ' A type of data validation - if the number of checked items = 0, an error message is outputted.
                MsgBox("Please Select A Genre")
                bGenreCheck = True
            End If
        End While
        getPercentLiked()
        btnUpvote.Enabled = True
        btnDownvote.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkGenreList.Items.Add("all")
        chkGenreList.SetItemChecked(0, True) ' Automatically selects "all" for increased user efficiency.
        chkGenreList.Items.Remove(1)
        Dim intSongNumber As Integer = 0
        ' Reads the .csv file and adds it to an array.
        Do Until strSongDatabase.EndOfStream = True
            lblRead.Text = strSongDatabase.ReadLine & vbNewLine
            Dim lstSongs() As String = Split(lblRead.Text, Delimiter:=",")
            strTop10s(intSongNumber, 1) = lstSongs(2)
            strTop10s(intSongNumber, 2) = lstSongs(0)
            strTop10s(intSongNumber, 3) = lstSongs(1)
            strTop10s(intSongNumber, 4) = lstSongs(3)
            strTop10s(intSongNumber, 5) = lstSongs(4)
            ' Adds items from the "top genre" row of the array to a list box if it is not already there.
            If strGenreCheck.Contains(strTop10s(intSongNumber, 1)) Then
            Else
                strGenreCheck(intGenreCount) = strTop10s(intSongNumber, 1)
                chkGenreList.Items.Add(strGenreCheck(intGenreCount))
                intGenreCount += 1
            End If
            intSongNumber += 1
        Loop
        intSongCount = intSongNumber '

        btnUpvote.Enabled = False
        btnDownvote.Enabled = False
        btnUndo.Enabled = False
    End Sub

    Private Sub btnUpvote_Click(sender As Object, e As EventArgs) Handles btnUpvote.Click
        ' Allows a user to upvote a song.
        Dim intEntry As Integer = Val(lblRead.Text)
        strTop10s(intEntry, 4) = Val(lblUpvotes.Text) + 1
        lblUpvotes.Text += 1
        getPercentLiked()
        btnDownvote.Enabled = False
        btnUpvote.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        strSongDatabase.Close()
        IO.File.Delete(strSongsPath)
        Dim intAddCount As Integer = 0
        While intAddCount < intSongCount
            ' Writes the new values in the array to the .csv.
            lblUpvotes.Text = strTop10s(intAddCount, 4)
            lblDownvotes.Text = strTop10s(intAddCount, 5)
            lblWrite.Text = strTop10s(intAddCount, 2) & "," & strTop10s(intAddCount, 3) & "," & strTop10s(intAddCount, 1) & "," & Val(lblUpvotes.Text) & "," & Val(lblDownvotes.Text) & vbCrLf
            IO.File.AppendAllText(strSongsPath, lblWrite.Text)
            intAddCount += 1
        End While
        End
    End Sub

    Private Sub btnDownvote_Click(sender As Object, e As EventArgs) Handles btnDownvote.Click
        ' Allows a user to downvote a song.
        Dim intEntry As Integer = Val(lblRead.Text)
        strTop10s(intEntry, 5) = Val(lblDownvotes.Text) + 1
        getPercentLiked()
        lblDownvotes.Text += 1
        btnDownvote.Enabled = False
        btnUpvote.Enabled = False
    End Sub

    Function getPercentLiked()
        ' Determines the percentage of people that upvoted vs downvoted the song.
        If lblUpvotes.Text = "0" Then
            lblPercentage.Text = "100% DISLIKE"
        ElseIf lblDownvotes.Text = "0" Then
            lblPercentage.Text = "100% LIKE"
        Else
            Dim intLikes As Integer = (Val(lblUpvotes.Text) / (Val(lblDownvotes.Text) + Val(lblUpvotes.Text))) * 100
            lblPercentage.Text = intLikes & "% LIKE"
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Allows a user to search for a song. 
        Dim bSongFound = False
        Dim intNameCount As Integer = 0
        Dim strSongName As String = txtSearch.Text
        If strSongName.Length = 0 Then
            MsgBox("This Entry Is Empty") ' Data validation for existence. 
            bSongFound = True
        End If

        While bSongFound = False
            ' Searches array.
            If strTop10s(intNameCount, 2) = strSongName Then
                lblGenre.Text = strTop10s(intNameCount, 1)
                lblTitle.Text = strTop10s(intNameCount, 2)
                lblArtist.Text = strTop10s(intNameCount, 3)
                lblDownvotes.Text = strTop10s(intNameCount, 5)
                lblUpvotes.Text = strTop10s(intNameCount, 4)
                getPercentLiked()
                bSongFound = True
            ElseIf intNameCount = intSongCount Then
                MsgBox("Song Not Found")
                bSongFound = True
            End If
            intNameCount += 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Allows a user to add a song to the database. AKA writes to a .csv.
        If txtSearch.TextLength > 30 Then
            ' Range check. 
            MsgBox("This Entry Seems Incorrect")
        ElseIf txtSearch.TextLength = 0 Then
            MsgBox("This Entry Is Empty") ' Data validation for existence. 
        Else
            strTop10s(intSongCount, 2) = txtSearch.Text
            Dim bArtistCheck As Boolean = False
            While bArtistCheck = False
                Dim strArtist As String = InputBox("Who is the song by?")
                If strArtist.Length > 30 Or strArtist.Length = 0 Then ' Data validation
                    MsgBox("This Entry Seems Incorrect")
                    bArtistCheck = False
                Else
                    strTop10s(intSongCount, 3) = strArtist
                    bArtistCheck = True
                End If
            End While
            Dim bGenreCheck As Boolean = False
            ' Type validation - ensures genre is not a number.
            While bGenreCheck = False
                strTop10s(intSongCount, 1) = InputBox("What is the genre of the song?")
                If IsNumeric(strTop10s(intSongCount, 1)) Or Len(strTop10s(intSongCount, 1)) = 0 Then
                    MsgBox("That is not a valid genre.")
                    bGenreCheck = False
                Else
                    bGenreCheck = True
                End If
            End While
        End If
        intSongCount += 1
        btnUndo.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ' Allows a user to undo their added song. AKA deletes from the .csv.
        strTop10s(intSongCount, 1) = ""
        strTop10s(intSongCount, 2) = ""
        strTop10s(intSongCount, 3) = ""
        intSongCount = intSongCount - 1
        btnUndo.Enabled = False
    End Sub
End Class