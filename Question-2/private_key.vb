Dim privateKey as String = "MIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCuX...l5KsfyBYkFySZc/U6tcNzywNwOolO08o6z/qUk/9TxEiUNoUBaAGieKjQ=="

Dim privateKeyHeader as String = "-----BEGIN PRIVATE KEY-----"
Dim privateKeyFooter as String = "-----END PRIVATE KEY-----"

Dim chunks as Integer = Math.Ceiling(privateKey.Length / 64)
Dim privateKeyFormatted as String = privateKeyHeader & vbCrLf

For i as Integer = 0 To chunks - 1
    privateKeyFormatted &= Mid(privateKey, i*64+1, 64) & vbCrLf
Next

privateKeyFormatted &= privateKeyFooter & vbCrLf

Console.WriteLine(privateKeyFormatted)
