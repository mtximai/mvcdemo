Public Class Livro
	Public Property LivroId As Integer
	Public Property Titulo As String
	Public Property Preço As Double
	Public Property EditoraId As Integer
	Public Overridable Property Editora() As Editora

End Class
