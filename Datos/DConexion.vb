﻿Imports System.Data
Imports System.Data.OleDb

Public Class DConexion
    Public conectado As String
    Public Function getConnection() As OleDbConnection
        Dim connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\Supermercado.accdb;Persist Security Info=False"
        getConnection = New OleDbConnection(connString)
    End Function
End Class
