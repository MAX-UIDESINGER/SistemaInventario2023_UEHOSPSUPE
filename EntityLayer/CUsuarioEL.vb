Public Class CUsuarioEL
    Private ID_USUARIO As String
    Private NOMB_USU As String
    Private APELL_USU As String
    Private CORREO_USU As String
    Private PASS_USU As String
    Private ACCESO_USU As String
    Private FECHA_REC_USU As Date

    Public Property ID_USUARIO1 As String
        Get
            Return ID_USUARIO
        End Get
        Set(value As String)
            ID_USUARIO = value
        End Set
    End Property

    Public Property NOMB_USU1 As String
        Get
            Return NOMB_USU
        End Get
        Set(value As String)
            NOMB_USU = value
        End Set
    End Property

    Public Property APELL_USU1 As String
        Get
            Return APELL_USU
        End Get
        Set(value As String)
            APELL_USU = value
        End Set
    End Property

    Public Property CORREO_USU1 As String
        Get
            Return CORREO_USU
        End Get
        Set(value As String)
            CORREO_USU = value
        End Set
    End Property

    Public Property PASS_USU1 As String
        Get
            Return PASS_USU
        End Get
        Set(value As String)
            PASS_USU = value
        End Set
    End Property

    Public Property ACCESO_USU1 As String
        Get
            Return ACCESO_USU
        End Get
        Set(value As String)
            ACCESO_USU = value
        End Set
    End Property

    Public Property FECHA_REC_USU1 As Date
        Get
            Return FECHA_REC_USU
        End Get
        Set(value As Date)
            FECHA_REC_USU = value
        End Set
    End Property
End Class
