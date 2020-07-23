Module Module1
    Dim Character As String
    Public Class Num2Words
        Public Function NUMMM(ByVal A As Double) As String
            On Error Resume Next
            Dim MM
            Dim IM
            MM = Microsoft.VisualBasic.Len(A)
            IM = Microsoft.VisualBasic.Left(A, Microsoft.VisualBasic.Len(A))
            If Microsoft.VisualBasic.Len(IM) = 9 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, 2), " Crore ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 4), 2), " Lakh ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 6), 2), " Thousand ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 7), 1), " Hundred ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 9), 2), "")
            ElseIf Microsoft.VisualBasic.Len(IM) = 8 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, 1), " Crore ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 3), 2), " Lakh ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 5), 2), " Thousand ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 6), 1), " Hundred ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 8), 2), "")
            ElseIf Microsoft.VisualBasic.Len(IM) = 7 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, 2), " Lakh ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 4), 2), " Thousand ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 5), 1), " Hundred ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 7), 2), "")
            ElseIf Microsoft.VisualBasic.Len(IM) = 6 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, 1), " Lakh ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 3), 2), " Thousand ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 4), 1), " Hundred ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 6), 2), "")
            ElseIf Microsoft.VisualBasic.Len(IM) = 5 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, 2), " Thousand ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 3), 1), " Hundred ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 5), 2), "")
            ElseIf Microsoft.VisualBasic.Len(IM) = 4 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, 1), " Thousand ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 2), 1), " Hundred ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 4), 2), "")
            ElseIf Microsoft.VisualBasic.Len(IM) = 3 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, 1), " Hundred ") & conv(Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(IM, 3), 2), "")
            ElseIf Microsoft.VisualBasic.Len(IM) <= 2 Then
                NUMMM = conv(Microsoft.VisualBasic.Left(IM, Microsoft.VisualBasic.Len(IM)), "")
            End If
        End Function

        Public Function conv(ByVal co As Integer, ByVal sSTR As String) As String
            On Error Resume Next
            Dim Am As Integer
            Character = ""
            'If co = 0 Then Character = " Zero" & sSTR
            If co = 1 Then Character = " One" & sSTR
            If co = 2 Then Character = " Two" & sSTR
            If co = 3 Then Character = " Three" & sSTR
            If co = 4 Then Character = " Four" & sSTR
            If co = 5 Then Character = " Five" & sSTR
            If co = 6 Then Character = " Six" & sSTR
            If co = 7 Then Character = " Seven" & sSTR
            If co = 8 Then Character = " Eight" & sSTR
            If co = 9 Then Character = " Nine" & sSTR
            If co = 10 Then Character = " Ten" & sSTR
            If co = 11 Then Character = " Eleven" & sSTR
            If co = 12 Then Character = " Twelve" & sSTR
            If co = 13 Then Character = " Thirteen" & sSTR
            If co = 14 Then Character = " Fourteen" & sSTR
            If co = 15 Then Character = " Fifteen" & sSTR
            If co = 16 Then Character = " Sixteen" & sSTR
            If co = 17 Then Character = " Seventeen" & sSTR
            If co = 18 Then Character = " Eighteen" & sSTR
            If co = 19 Then Character = " Nineteen" & sSTR
            If Character <> "" Then
                GoTo 10
            End If
            If Microsoft.VisualBasic.Len(CStr(co)) = 2 Then
                Am = Left(co, 1)
                If Am = 2 Then
                    Character = "Twenty"
                    Am = Right(co, 1)
                    nUMM(Am, sSTR)
                    GoTo 10
                End If

                If Am = 3 Then
                    Character = "Thirty"
                    Am = Right(co, 1)
                    nUMM(Am, sSTR)
                    GoTo 10
                End If

                If Am = 4 Then
                    Character = "Forty"
                    Am = Right(co, 1)
                    nUMM(Am, sSTR)
                    GoTo 10
                End If

                If Am = 5 Then
                    Character = "Fifty"
                    Am = Right(co, 1)
                    nUMM(Am, sSTR)
                    GoTo 10
                End If

                If Am = 6 Then
                    Character = "Sixty"
                    Am = Right(co, 1)
                    nUMM(Am, sSTR)
                    GoTo 10
                End If

                If Am = 7 Then
                    Character = "Seventy"
                    Am = Right(co, 1)
                    nUMM(Am, sSTR)
                    GoTo 10
                End If

                If Am = 8 Then
                    Character = "Eighty"
                    Am = Right(co, 1)
                    nUMM(Am, sSTR)
                    GoTo 10
                End If

                If Am = 9 Then
                    Character = "Ninty"
                    Am = Right(co, 1)
                    'If Am = 1 Then Character = Character & " One" & sSTR
                    'If Am = 2 Then Character = Character & " Two" & sSTR
                    'If Am = 3 Then Character = Character & " Three" & sSTR
                    'If Am = 4 Then Character = Character & " Four" & sSTR
                    'If Am = 5 Then Character = Character & " Five" & sSTR
                    'If Am = 6 Then Character = Character & " Six" & sSTR
                    'If Am = 7 Then Character = Character & " Seven" & sSTR
                    'If Am = 8 Then Character = Character & " Eight" & sSTR
                    'If Am = 9 Then Character = Character & " Nine" & sSTR
                    nUMM(Am, sSTR)
                    GoTo 10
                End If
            End If
10:         conv = Character
        End Function

        Private Sub nUMM(ByVal AM As Integer, ByVal sSTR As String)
            If AM = 0 Then Character = Character & sSTR
            If AM = 1 Then Character = Character & " One" & sSTR
            If AM = 2 Then Character = Character & " Two" & sSTR
            If AM = 3 Then Character = Character & " Three" & sSTR
            If AM = 4 Then Character = Character & " Four" & sSTR
            If AM = 5 Then Character = Character & " Five" & sSTR
            If AM = 6 Then Character = Character & " Six" & sSTR
            If AM = 7 Then Character = Character & " Seven" & sSTR
            If AM = 8 Then Character = Character & " Eight" & sSTR
            If AM = 9 Then Character = Character & " Nine" & sSTR
        End Sub
    End Class
End Module
