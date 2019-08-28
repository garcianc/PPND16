Module NormSInv_Wichura

'The following function is based on FORTRAN code published in: Michael J. Wichura, Applied Statistics, vol. 37, 1988, pp. 477-484
'Adapted to VB.NET by Nelson Garcia (NCG Consulting Inc).
    'Code is written for readability. Feel free to abbreviate or combine lines.
    Public Function PPND16(ByVal P As Double) As Double
        Dim ZERO, ONE, HALF, SPLIT1, SPLIT2, CONST1, CONST2, A0, A1, A2, A3, A4, A5, A6, A7 As Double
        Dim B1, B2, B3, B4, B5, B6, B7 As Double
        Dim C0, C1, C2, C3, C4, C5, C6, C7 As Double
        Dim D1, D2, D3, D4, D5, D6, D7 As Double
        Dim E0, E1, E2, E3, E4, E5, E6, E7 As Double
        Dim F1, F2, F3, F4, F5, F6, F7, Q, R As Double
        ZERO = 0.0
        ONE = 1.0
        HALF = 0.5
        SPLIT1 = 0.425
        SPLIT2 = 5.0
        CONST1 = 0.180625
        CONST2 = 1.6

        'Coefficients for P close to 0.5
        A0 = 3.3871328727963665
        A1 = 133.14166789178438
        A2 = 1971.5909503065514
        A3 = 13731.693765509461
        A4 = 45921.95393154987
        A5 = 67265.7709270087
        A6 = 33430.575583588128
        A7 = 2509.0809287301227
        B1 = 42.313330701600911
        B2 = 687.18700749205789
        B3 = 5394.1960214247511
        B4 = 21213.794301586597
        B5 = 39307.895800092709
        B6 = 28729.085735721943
        B7 = 5226.4952788528544

        'Coefficients for P not close to 0, 0.5 or 1
        C0 = 1.4234371107496835
        C1 = 4.6303378461565456
        C2 = 5.769497221460691
        C3 = 3.6478483247632045
        C4 = 1.2704582524523684
        C5 = 0.24178072517745061
        C6 = 0.022723844989269184
        C7 = 0.00077454501427834139
        D1 = 2.053191626637759
        D2 = 1.6763848301838038
        D3 = 0.6897673349851
        D4 = 0.14810397642748008
        D5 = 0.015198666563616457
        D6 = 0.00054759380849953455
        D7 = 0.0000000010507500716444169

        'Coefficients for P near 0 or 1
        E0 = 6.6579046435011033
        E1 = 5.4637849111641144
        E2 = 1.7848265399172913
        E3 = 0.29656057182850487
        E4 = 0.026532189526576124
        E5 = 0.0012426609473880784
        E6 = 0.000027115555687434876
        E7 = 0.00000020103343992922882
        F1 = 0.599832206555888
        F2 = 0.13692988092273581
        F3 = 0.014875361290850615
        F4 = 0.00078686913114561329
        F5 = 0.000018463183175100548
        F6 = 0.0000001421511758316446
        F7 = 0.0000000000000020442631033899397

        Q = P - HALF
        If (Math.Abs(Q) <= SPLIT1) Then
            R = CONST1 - Q * Q
            PPND16 = Q * (((((((A7 * R + A6) * R + A5) * R + A4) * R + A3) * R + A2) * R + A1) * R + A0) / (((((((B7 * R + B6) * R + B5) * R + B4) * R + B3) * R + B2) * R + B1) * R + ONE)
            Return PPND16
        Else
            If (Q < ZERO) Then
                R = P
            Else
                R = ONE - P
            End If
            If (R <= ZERO) Then
                PPND16 = ZERO
                Return PPND16
            End If
            R = Math.Sqrt(-Math.Log(R))
            If (R <= SPLIT2) Then
                R = R - CONST2
                PPND16 = (((((((C7 * R + C6) * R + C5) * R + C4) * R + C3) * R + C2) * R + C1) * R + C0) / (((((((D7 * R + D6) * R + D5) * R + D4) * R + D3) * R + D2) * R + D1) * R + ONE)
            Else
                R = R - SPLIT2
                PPND16 = (((((((E7 * R + E6) * R + E5) * R + E4) * R + E3) * R + E2) * R + E1) * R + E0) / (((((((F7 * R + F6) * R + F5) * R + F4) * R + F3) * R + F2) * R + F1) * R + ONE)
            End If
            If (Q < ZERO) Then PPND16 = -PPND16
            Return PPND16
        End If
    End Function
    
   End Module
