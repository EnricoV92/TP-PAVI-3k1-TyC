Imports System.Data.SqlClient

Public Class BDHelper
    Private string_conexion As String
    Private Shared instance As BDHelper 'Unica instancia de la clase

    Private Sub New()
        'string_conexion = "Data Source=MARTIN-PC\SQLEXPRESS;Initial Catalog=DB_Bugs;Integrated Security=True"

        string_conexion = "Data Source=localhost\SQLEXPRESS;Initial Catalog='PAV I - Torneos';Persist Security Info=True;User ID=sa;Password=vagomania92"
    End Sub

    Public Shared Function getDBHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion
            ' Abre la conexión
            conexion.Open()

            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar el comando
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
    End Function

    Public Function ConsultarSQLConParametros(ByVal sqlStr As String, ByVal params As Object()) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ' La función recibe por valor una sentencia sql como string y un arreglo de parámetros, devuelve un objeto de tipo DataTable

        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Dim n_param As String
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sqlStr

            'Agregamos a la colección de parámetros del comando los filtros recibidos
            'IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
            For i = 0 To params.Length - 1
                If Not IsNothing(params(i)) Then
                    n_param = "param" + Convert.ToString(i + 1)
                    cmd.Parameters.AddWithValue(n_param, params(i))
                End If
            Next

            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
    End Function

    Shared Sub guardarFechaTorneoYPartidos(ByVal nroFecha As String, ByVal id_torneo As String, ByVal diaFecha As String, ByRef miListaPartidos As List(Of Partidos))
        Dim conexion As New SqlConnection
        Dim cmdFecha As New SqlCommand
        Dim cmdPartido As New SqlCommand
        Dim miTransaccion As SqlTransaction

        conexion.ConnectionString = BDHelper.getDBHelper.string_conexion
        conexion.Open()

        miTransaccion = conexion.BeginTransaction
        Try
            cmdFecha = New SqlCommand("INSERT INTO FechasTorneo(nroFecha, diaFecha, id_torneo) VALUES(@nroFecha, @diaFecha, @id_torneo)", conexion, miTransaccion)
            cmdFecha.Connection = conexion
            cmdFecha.Parameters.Add("@nroFecha", SqlDbType.Int).Value = nroFecha
            cmdFecha.Parameters.Add("@diaFecha", SqlDbType.Date).Value = diaFecha
            cmdFecha.Parameters.Add("@id_torneo", SqlDbType.Int).Value = id_torneo
            cmdFecha.ExecuteNonQuery()
            MsgBox("INSERT de Fecha")

            Dim scriptInsertPartidos As String = "INSERT INTO Partidos(id_fecha, " &
                    "id_equipo1, id_equipo2, cancha) VALUES "

            For p = 0 To miListaPartidos.Count - 1
                scriptInsertPartidos += "(@@IDENTITY, '" &
                    miListaPartidos(p).equipo1.ToString + "', '" &
                    miListaPartidos(p).equipo2.ToString + "', '" &
                    miListaPartidos(p).cancha.ToString + "') ,"
            Next

            Dim script As String = scriptInsertPartidos.Remove(scriptInsertPartidos.Length - 1)
            script += ";"
            cmdPartido = New SqlCommand(script, conexion, miTransaccion)
            cmdPartido.Connection = conexion
            cmdPartido.ExecuteNonQuery()
            MsgBox("INSERT de Partidos")

            miTransaccion.Commit()
            MsgBox("EJECUTANDO COMMIT")

        Catch ex As Exception
            miTransaccion.Rollback()
            MsgBox("EJECUTANDO ROLLBACK")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub
End Class
