Public Class Partidos

    Public Property equipo1 As Integer
    Public Property equipo2 As Integer
    Public Property cancha As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal e1 As String, ByVal e2 As String, ByVal c As String)
        equipo1 = e1
        equipo2 = e2
        cancha = c

    End Sub
End Class
