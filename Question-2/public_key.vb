Dim publicKey as String = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAjGaPCO3po3jfhWz0iBZPPqIgz5rxF58HuxzW3KDvYrQ7nMUNjTKyBp0cFOquyNxToBAOEfkeg56mnyhvtmLPpaxZn1KUpVG7TPUmWBgN8E46nPgQCr/cFxd1LQB9dmOfiIuRTFpkWoqQHWQhacDALI/YXkqimhTc9fRY9teZyqXRvJVqFUbvLTUsOyZzKFAx+k7kTRkCVpO0vJovmCU4X+e/8cOl5vrn9V3kwNRpmIC/jNqtUOHemfsyb8VImXRyijuXfN4/v2Ot9cGJ0DGkwCrqJqyffhdXExqGKmlTENQ2YsIN/H5jAt/TqAFss3X28bynpIG1KJbQCqgT4dNiLQIDAQAB"
Dim publicKeyHeader as String = "-----BEGIN PUBLIC KEY-----"
Dim publicKeyFooter as String = "-----END PUBLIC KEY-----"
Dim chunks as Integer = Math.Ceiling(publicKey.Length / 64)
Dim publicKeyFormatted as String = publicKeyHeader & vbCrLf 
For i as Integer = 0 To chunks - 1 
    publicKeyFormatted &= Mid(publicKey, i*64+1, 64) & vbCrLf
Next 
publicKeyFormatted &= publicKeyFooter & vbCrLf 
Console.WriteLine(publicKeyFormatted)
