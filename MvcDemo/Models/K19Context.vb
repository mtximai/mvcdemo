Imports System.Data.Entity

Public Class K19
	Inherits DbContext

	Public Property Editoras() As DbSet(Of Editora)
	Public Property Livros() As DbSet(Of Livro)
End Class
