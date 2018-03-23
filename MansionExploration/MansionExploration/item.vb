Public Class item
    Dim name As String
    Dim description As String
    Dim imageName As String

    Public Property myName() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property myDescription() As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property
    Public Property myImageName() As String
        Get
            Return imageName
        End Get
        Set(value As String)
            imageName = value
        End Set
    End Property

    Sub New(thisName As String, thisDesc As String, thisImageName As String)
        name = thisName
        description = thisDesc
        imageName = thisImageName
    End Sub
End Class
