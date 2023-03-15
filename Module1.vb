Module Module1

    Sub Main()

        ' Ejemplo de arreglo unidimensional
        Dim arreglo1D As Integer() = {1, 2, 3, 4, 5}
            Console.WriteLine("Elementos del arreglo unidimensional:")
            For i As Integer = 0 To arreglo1D.Length - 1
                Console.Write("{0} ", arreglo1D(i))
            Next
            Console.WriteLine()
            ' Ejemplo de arreglo bidimensional
            Dim arreglo2D As Integer(,) = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    }
            Console.WriteLine("Elementos del arreglo bidimensional:")
            For i As Integer = 0 To arreglo2D.GetLength(0) - 1
                For j As Integer = 0 To arreglo2D.GetLength(1) - 1
                    Console.Write("{0} ", arreglo2D(i, j))
                Next
                Console.WriteLine()
            Next

            ' Ejemplo de arreglo tridimensional
            Dim arreglo3D As Integer(,,) = New Integer(1, 1, 1) {
        {{1, 2}, {3, 4}},
        {{5, 6}, {7, 8}}
    }
            Console.WriteLine("Elementos del arreglo tridimensional:")
            For i As Integer = 0 To arreglo3D.GetLength(0) - 1
                For j As Integer = 0 To arreglo3D.GetLength(1) - 1
                    For k As Integer = 0 To arreglo3D.GetLength(2) - 1
                        Console.Write("{0} ", arreglo3D(i, j, k))
                    Next
                    Console.WriteLine()
                Next
                Console.WriteLine()
            Next

            Console.ReadLine()

    End Sub

End Module
