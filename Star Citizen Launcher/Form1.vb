Imports System.IO
Imports System.Collections
Public Class Form1




    Public lDir As String   'launcher path
    Public gDir As String   'game directory path
    Public bDir As String   'backup directory path
    Public cFile As String = "F:\VIsual Studio Stuff\Star Citizen Launcher\config.txt"    '"C:\Program Files (x86)\Easy SC Launch\config.txt"   'config directory
    Public tFile As String = "F:\VIsual Studio Stuff\Star Citizen Launcher\temp0.txt"




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        VerifyConfig() 'verifys file exists and stores data to public variables
        VerifyBackupDir()   'verify/create backup directory

        'write data from temp0.txt to config.txt
        'delete temp0.txt




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_GetLaunchPath.Click

        If FolderBrowserL.ShowDialog() = DialogResult.OK Then
            lDir = FolderBrowserL.SelectedPath
            Lbl_LaunchPath.Text = lDir
            UpdateConfig()
        End If

    End Sub
    Private Sub Btn_GetGamePath_Click(sender As Object, e As EventArgs) Handles Btn_GetGamePath.Click

        If FolderBrowserL.ShowDialog() = DialogResult.OK Then
            gDir = FolderBrowserL.SelectedPath
            Lbl_GamePath.Text = gDir
            UpdateConfig()
        End If

    End Sub
    Private Sub Btn_Backup_Click(sender As Object, e As EventArgs) Handles Btn_Backup.Click

        If FolderBrowserL.ShowDialog() = DialogResult.OK Then
            bDir = FolderBrowserL.SelectedPath
            Lbl_BackupPath.Text = bDir
            UpdateConfig()
        End If

    End Sub
    Private Sub Btn_Launch_Click(sender As Object, e As EventArgs) Handles Btn_Launch.Click
        BackupFiles()
    End Sub
    Private Sub VerifyConfig()
        If File.Exists(cFile) Then
            'make sure files exist and read the saved data into the path variables
            ReadConfig() 'Gets data from stored file
        Else
            'create the config file and set default paths
            Dim stp As New StreamWriter(cFile, True)
            stp.WriteLine("D:\Program Files\Roberts Space Industries\RSI Launcher") 'Launcher Path
            stp.WriteLine("D:\Program Files\Roberts Space Industries\Star Citizen") 'Game Folder Path
            stp.WriteLine("D:\Program Files\Roberts Space Industries\SC-Backups") 'backup path
            stp.Close()
            ReadConfig()
        End If
    End Sub
    Private Sub ReadConfig()    'reads config file into memory and to array, writes to temp0 file
        Dim lineArray() As String = System.IO.File.ReadAllLines(cFile) 'pull lines into array
        'write lines to public variables
        lDir = lineArray(0)
        gDir = lineArray(1)
        bDir = lineArray(2)


        'write data to the temp0 config file
        If System.IO.File.Exists(tFile) Then 'check if file exists and delete it if its already there
            File.Delete(tFile)
        Else
            'create the config file
            File.WriteAllLines(tFile, lineArray)

        End If

        'write the path data to the readout box
        Lbl_LaunchPath.Text = lDir
        Lbl_GamePath.Text = gDir
        Lbl_BackupPath.Text = bDir

    End Sub

    Private Sub UpdateConfig()
        Dim lineArray(3) As String
        lineArray(0) = lDir
        lineArray(1) = gDir
        lineArray(2) = bDir

        If File.Exists(tFile) Then 'check if file exists and delete it if its already there
            File.Delete(tFile)
        End If

        'create the config file
        File.WriteAllLines(tFile, lineArray)
    End Sub

    Private Sub VerifyBackupDir()
        If Directory.Exists(bDir) Then
            'dont worry about it just move on
        Else
            Directory.CreateDirectory(bDir)
        End If


    End Sub

    Private Sub BackupFiles()
        Dim PtuMap As String = "\PTU\USER\Controls\Mappings"
        Dim LiveMap As String = "\LIVE\USER\Controls\Mappings"

        Dim PtuShade As String = "\PTU\USER\shaders"
        Dim LiveShade As String = "\LIVE\USER\shaders"

        Dim PtuMap313 As String = "\PTU\USER\Client\0\Controls\Mappings"
        Dim LiveMap313 As String = "\LIVE\USER\Client\0\Controls\Mappings"

        Dim PtuShade313 As String = "\PTU\USER\Client\0\shaders"
        Dim LiveShade313 As String = "\LIVE\USER\Client\0\shaders"

        Dim SrcPath As String
        Dim DestPath As String

        'backkup mapping files from live
        SrcPath = gDir + LiveMap
        DestPath = bDir + LiveMap
        If System.IO.Directory.Exists(SrcPath) Then
            CopyDirectory(SrcPath, DestPath) 'copy mapping files from live to backup
            DeleteFiles(SrcPath) 'delete old files from live
            CopyDirectory(DestPath, SrcPath) 'copy mapping files from backup to live
        End If

        'delete shaders from live
        SrcPath = gDir + LiveShade
        If System.IO.Directory.Exists(SrcPath) Then
            DeleteShaders(SrcPath) 'delete Shader Directory
        End If

        'backup mapping files from PTU
        SrcPath = gDir + PtuMap
        DestPath = bDir + PtuMap
        If System.IO.Directory.Exists(SrcPath) Then
            CopyDirectory(SrcPath, DestPath) 'copy mapping files from PTU to backup
            DeleteFiles(SrcPath) 'delete old files from PTU
            CopyDirectory(DestPath, SrcPath) 'copy mapping files from backup to PTU
        End If

        'delete shaders from PTU
        SrcPath = gDir + PtuShade
        If System.IO.Directory.Exists(SrcPath) Then
            DeleteShaders(SrcPath) 'delete Shader Directory
        End If


        'Backup Live mapping for Assumed live post 3.13+ directory structure
        SrcPath = gDir + LiveMap313
        DestPath = bDir + LiveMap313
        If System.IO.Directory.Exists(SrcPath) Then
            CopyDirectory(SrcPath, DestPath) 'copy mapping files from 3.13+ Live
            DeleteFiles(SrcPath) 'delete old files from 3.13+ Live
            CopyDirectory(DestPath, SrcPath) 'copy mapping files from backup to 3.13 Live
        End If

        'delete shaders from live 3.13+ Directory Structure
        SrcPath = gDir + LiveShade313
        If System.IO.Directory.Exists(SrcPath) Then
            DeleteShaders(SrcPath) 'delete Shader Directory
        End If

        'Backup PTU Mapping for assumed post 3.13+ Directory Structure 
        SrcPath = gDir + PtuMap313
        DestPath = bDir + PtuMap313
        If System.IO.Directory.Exists(SrcPath) Then
            CopyDirectory(SrcPath, DestPath) 'copy mapping files from 3.13+ PTU
            DeleteFiles(SrcPath) 'delete old files from 3.13+ PTU
            CopyDirectory(DestPath, SrcPath) 'copy mapping files from backup to 3.13 PTU
        End If

        'delete shaders from PTU 3.13+
        SrcPath = gDir + PtuShade313
        If System.IO.Directory.Exists(SrcPath) Then
            DeleteShaders(SrcPath) 'delete Shader Directory
        End If



    End Sub
    Public Function DeleteFiles(ByVal path As String)
        If Directory.Exists(path) Then
            'Delete all files from the Directory
            For Each filepath As String In Directory.GetFiles(path)
                File.Delete(filepath)
            Next
        End If
    End Function

    Public Function DeleteShaders(ByVal path As String)
        If Directory.Exists(path) Then
            'Delete all files from the Directory
            Directory.Delete(path, True)
        End If
    End Function


    Public Function CopyDirectory(ByVal SrcPath As String, ByVal DestPath As String, Optional _
ByVal bQuiet As Boolean = False) As Boolean
        If Not System.IO.Directory.Exists(SrcPath) Then
            Exit Function
            'Throw New System.IO.DirectoryNotFoundException("The directory " & SrcPath & " does not exists")
        End If
        'If System.IO.Directory.Exists(DestPath) AndAlso Not bQuiet Then
        '    If MessageBox.Show("directory " & DestPath & " already exists." & vbCrLf &
        '    "If you continue, any files with the same name will be overwritten",
        '    "Continue?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
        '    MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Cancel Then Exit Function
        'End If

        'add Directory Seperator Character (\) for the string concatenation shown later
        If DestPath.Substring(DestPath.Length - 1, 1) <> System.IO.Path.DirectorySeparatorChar Then
            DestPath += Path.DirectorySeparatorChar
        End If
        If Not System.IO.Directory.Exists(DestPath) Then System.IO.Directory.CreateDirectory(DestPath)
        Dim Files As String()
        Files = System.IO.Directory.GetFileSystemEntries(SrcPath)
        Dim element As String
        For Each element In Files
            If System.IO.Directory.Exists(element) Then
                'if the current FileSystemEntry is a directory,
                'call this function recursively
                CopyDirectory(element, DestPath & System.IO.Path.GetFileName(element), True)
            Else
                'the current FileSystemEntry is a file so just copy it
                System.IO.File.Copy(element, DestPath & System.IO.Path.GetFileName(element), True)
            End If
        Next
        Return True
    End Function


End Class
