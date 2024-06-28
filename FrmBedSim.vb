Imports System.Data
Imports System.Data.Odbc
Public Class FrmBedSim
    Dim cn As Odbc
    Private Sub FrmBedSim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strcns As String
        BtnSave.Visible = False
        DGV1.Visible = False
        Me.WindowState = FormWindowState.Maximized

        strcns = "DRIVER=Microsoft Access Driver (*.mdb, *.accdb);dbq=" +
            Application.StartupPath + "BedSimulation.accdb;driverid=25;fil=MS Access;maxbuffersize=2048;pagetimeout=5;uid=admin"
]
        If cn.State = 1 Then cn.Close()
        With cn
            .ConnectionString = strcns
            .Open()
        End With
    End Sub
End Class
