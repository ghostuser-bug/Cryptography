Dim publicKey as String = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC+0I7A1kBsJ+ovYeWZbULY1c7SzZ4b+eLPoPNaLjFtbQzNWZWTzxS+k4SpKyDXBCDAykNRgOjpniQcBYf+dwBpY36gW5J8bEvCoLYq4MpfZftnPW5jEOynnD0jnSuREzU0GDSSWpzkC71dIZDRvti97n3t2GmFl+GIfxx6ZqZ88wIDAQAB"
Dim publicKeyHeader as String = "-----BEGIN PUBLIC KEY-----"
Dim publicKeyFooter as String = "-----END PUBLIC KEY-----"

Dim chunks as Integer = Math.Ceiling(publicKey.Length / 64)
Dim publicKeyFormatted as String = publicKeyHeader & vbCrLf

For i as Integer = 0 To chunks - 1
    publicKeyFormatted &= Mid(publicKey, i*64+1, 64) & vbCrLf
Next

publicKeyFormatted &= publicKeyFooter & vbCrLf

Console.WriteLine(publicKeyFormatted)
