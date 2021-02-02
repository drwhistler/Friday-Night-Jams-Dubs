Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt")
        ListBox1.Items.Clear()
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            ListBox1.Items.Add(line)
        End While
        rdr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt")
        ListBox1.Items.Clear()
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            ListBox1.Items.Add(line)
        End While
        rdr.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear Challenger and Opponent Text Boxes
        Challenger1.Text = ""
        Challenger2.Text = ""
        R1Opp1.Text = ""
        R1Opp2.Text = ""
        R2Opp1.Text = ""
        R2Opp2.Text = ""
        R3Opp1.Text = ""
        R3Opp2.Text = ""

        'Clear Challenger Preferred Court Label
        'Label4.Text = "Court:"

        'Clear Challengers and Opponents Preferred Region Labels
        'Label5.Text = "Region: "
        'Label6.Text = "Region: "
        'Label7.Text = "Region: "
        'Label8.Text = "Region: "

        'Refresh participatns list
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\participants_in.txt")
        ListBox1.Items.Clear()
        While Not rdr.EndOfStream
            Dim line As String = rdr.ReadLine()
            ListBox1.Items.Add(line)
        End While
        rdr.Close()

        'Reset Round, Challenger, TowerMaster, and Oppent text files
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\round.txt", "1")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\challenger1Name.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\challenger2Name.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\challengerPoints.txt", "0")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\towermaster.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r1opponent1.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r1opponent2.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r2opponent1.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r2opponent2.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r3opponent1.txt", "")
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r3opponent2.txt", "")

        'Remove any Challenger Splatter images
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenger1B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenger1B.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenger2B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenger2B.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenger3B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenger3B.png")
        End If

        'Remove any Challenger1 images
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r1.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r2.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r3.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r3.png")
        End If

        'Remove any Challenger2 images
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r1.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r2.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r3.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r3.png")
        End If

        'Remove any Opponentr Splatter images
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenged1B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenged1B.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenged2B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenged2B.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenged3B.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\splatterChallenged3B.png")
        End If

        'Remove any Opponent images
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent1.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent2.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent1.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent2.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent1.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent2.png")
        End If

        'Remove any Challenger frames
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\ChallengerFrame1.png") Then

        Else
            My.Computer.FileSystem.CopyFile(
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\ChallengerFrame.png",
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\ChallengerFrame1.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\ChallengerFrame2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\ChallengerFrame2.png")
        End If
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\ChallengerFrame3.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesTower\ChallengerFrame3.png")
        End If

    End Sub
    Private Sub Listbox1_Mousedown(ByVal Sender As Object,
                                ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown

        ListBox1.DoDragDrop(ListBox1.SelectedItem, DragDropEffects.Copy Or DragDropEffects.Move)

    End Sub

    Private Sub Challenger1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Challenger1.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub Challenger1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Challenger1.DragDrop

        Challenger1.Text = e.Data.GetData(DataFormats.Text).ToString
        ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        'Set Challenger1s name
        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\challenger1Name.txt", inputString)

        'Read Challenger1s profile
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        'Set Challengers Main and Skin
        Dim profile As String() = line.Split(","c)
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r1.png")
        End If
        My.Computer.FileSystem.CopyFile(
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\" + profile(2) + "-" + profile(3) + ".png",
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenger\challenger1r1.png")

        'Read and set Challenger1s Session Score
        'Dim score As String
        'If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\scoreSession\" + e.Data.GetData(DataFormats.Text) + ".txt") Then
        'rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\scoreSession\" + e.Data.GetData(DataFormats.Text) + ".txt")
        'score = rdr.ReadLine()
        'rdr.Close()
        'Else
        'score = "0"
        'End If
        'File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\challenger1Points.txt", score)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\introductions\" + e.Data.GetData(DataFormats.Text) + ".mp3") Then
            Dim Wave2 As New NAudio.Wave.WaveOut
            Dim soundFile2 As String = "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\introductions\" + e.Data.GetData(DataFormats.Text) + ".mp3"
            Dim data2 As New NAudio.Wave.Mp3FileReader(soundFile2)
            Wave2.Init(data2)
            Wave2.Volume = 0.5 'Sets the Volume to 50%
            Wave2.Play()
            'Wave2.Dispose()
        Else
            Dim Wave1 As New NAudio.Wave.WaveOut
            Dim soundFile As String = "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\introductions\newchallenger.mp3"
            Dim data As New NAudio.Wave.Mp3FileReader(soundFile)
            Wave1.Init(data)
            Wave1.Volume = 0.3 'Sets the Volume to 50%
            Wave1.Play()
            'Wave1.Dispose()
        End If

    End Sub

    Private Sub Challenger2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Challenger2.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub Challenger2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Challenger2.DragDrop

        Challenger2.Text = e.Data.GetData(DataFormats.Text).ToString
        'ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        'Set Challenger2s name
        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\challenger2Name.txt", inputString)

        'Read Challenger2s profile
        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        'Set Challenger2s Main and Skin
        Dim profile As String() = line.Split(","c)
        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r1.png")
        End If
        My.Computer.FileSystem.CopyFile(
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\" + profile(2) + "-" + profile(3) + ".png",
            "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\challenger2r1.png")

        'Read and set Challenger2s Session Score
        'Dim score As String
        'If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\scoreSession\" + e.Data.GetData(DataFormats.Text) + ".txt") Then
        'rdr = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\scoreSession\" + e.Data.GetData(DataFormats.Text) + ".txt")
        'score = rdr.ReadLine()
        'rdr.Close()
        'Else
        'score = "0"
        'End If
        'File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\challenger2Points.txt", score)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\introductions\" + e.Data.GetData(DataFormats.Text) + ".mp3") Then
            Dim Wave2 As New NAudio.Wave.WaveOut
            Dim soundFile2 As String = "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\introductions\" + e.Data.GetData(DataFormats.Text) + ".mp3"
            Dim data2 As New NAudio.Wave.Mp3FileReader(soundFile2)
            Wave2.Init(data2)
            Wave2.Volume = 0.5 'Sets the Volume to 50%
            Wave2.Play()
            'Wave2.Dispose()
        Else
            Dim Wave1 As New NAudio.Wave.WaveOut
            Dim soundFile As String = "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\introductions\newchallenger.mp3"
            Dim data As New NAudio.Wave.Mp3FileReader(soundFile)
            Wave1.Init(data)
            Wave1.Volume = 0.3 'Sets the Volume to 50%
            Wave1.Play()
            'Wave1.Dispose()
        End If

    End Sub

    Private Sub R1Opp1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R1Opp1.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub R1Opp1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R1Opp1.DragDrop
        R1Opp1.Text = e.Data.GetData(DataFormats.Text).ToString
        ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r1opponent1.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        'Set Opponents Preferred Region
        'Label6.Text = "Region: " + profile(0)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent1.png")
        End If

        My.Computer.FileSystem.CopyFile(
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\" + profile(2) + "-" + profile(3) + ".png",
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent1.png")

    End Sub

    Private Sub R1Opp2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R1Opp2.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub R1Opp2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R1Opp2.DragDrop
        R1Opp2.Text = e.Data.GetData(DataFormats.Text).ToString
        ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r1opponent2.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent2.png")
        End If

        My.Computer.FileSystem.CopyFile(
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\" + profile(2) + "-" + profile(3) + ".png",
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r1opponent2.png")

    End Sub

    Private Sub R2Opp1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R2Opp1.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub R2Opp1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R2Opp1.DragDrop
        R2Opp1.Text = e.Data.GetData(DataFormats.Text).ToString
        ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r2opponent1.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        'Set Opponents Preferred Region
        'Label6.Text = "Region: " + profile(0)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent1.png")
        End If

        My.Computer.FileSystem.CopyFile(
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\" + profile(2) + "-" + profile(3) + ".png",
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent1.png")

    End Sub

    Private Sub R2Opp2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R2Opp2.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub R2Opp2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R2Opp2.DragDrop
        R2Opp2.Text = e.Data.GetData(DataFormats.Text).ToString
        ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r2opponent2.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent2.png")
        End If

        My.Computer.FileSystem.CopyFile(
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\" + profile(2) + "-" + profile(3) + ".png",
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r2opponent2.png")

    End Sub

    Private Sub R3Opp1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R3Opp1.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub R3Opp1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R3Opp1.DragDrop
        R3Opp1.Text = e.Data.GetData(DataFormats.Text).ToString
        ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r3opponent1.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        'Set Opponents Preferred Region
        'Label6.Text = "Region: " + profile(0)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent1.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent1.png")
        End If

        My.Computer.FileSystem.CopyFile(
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\" + profile(2) + "-" + profile(3) + ".png",
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent1.png")

    End Sub

    Private Sub R3Opp2_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R3Opp2.DragEnter
        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub R3Opp2_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles R3Opp2.DragDrop
        R3Opp2.Text = e.Data.GetData(DataFormats.Text).ToString
        ListBox1.Items.Remove(e.Data.GetData(DataFormats.Text).ToString)

        Dim inputString As String = e.Data.GetData(DataFormats.Text).ToString
        File.WriteAllText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\r3opponent2.txt", inputString)

        Dim rdr As StreamReader = File.OpenText("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamArena\profiles\" + e.Data.GetData(DataFormats.Text) + ".txt")
        Dim line As String = rdr.ReadLine()
        rdr.Close()

        Dim profile As String() = line.Split(","c)

        If System.IO.File.Exists("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent2.png") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent2.png")
        End If

        My.Computer.FileSystem.CopyFile(
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\" + profile(2) + "-" + profile(3) + ".png",
          "C:\Users\Jason\AppData\Roaming\AnkhHeart\AnkhBotR2\Services\Scripts\DiscJamMortalJamDubs\imagesChallenged\r3opponent2.png")

    End Sub
End Class
