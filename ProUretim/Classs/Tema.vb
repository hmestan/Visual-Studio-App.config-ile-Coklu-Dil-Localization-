Public Class Tema
    Public Shared ReadOnly Property Font As Font
        Get
            Return New Font("Arial", 14, FontStyle.Bold)
        End Get
    End Property
    Public Shared ReadOnly Property Color As Color
        Get
            Return Color.Green
        End Get
    End Property
    Public Class Yazi
        Public Shared ReadOnly Property Font As Font
            Get
                Return New Font("Arial", 12, FontStyle.Regular)
            End Get
        End Property
        Public Shared ReadOnly Property Color As Color
            Get
                Return Color.Black
            End Get
        End Property

    End Class
End Class
