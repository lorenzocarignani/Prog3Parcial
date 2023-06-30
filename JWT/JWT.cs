using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

//Es una cadena de caracteres que representa la informaci�n que se va a transmitir de forma segura
//codificado en formato Base64 y contiene tres partes: encabezado, carga �til (payload) y firma

//Encabezado (Header): Es la primera parte del token JWT y contiene metadatos sobre el tipo de token y el algoritmo de firma utilizado dos elementos:
//el tipo de token, que es "JWT", y el algoritmo de firma, como "HS256" o "RS256"

//Carga �til (Payload): Es la segunda parte del token JWT y contiene la informaci�n que se quiere transmitir de manera segura, como datos de usuario o cualquier otra informaci�n  El payload se divide en tres tipos de claims

//Claims registrados (Registered Claims): Son un conjunto de claims predefinidos que no son obligatorios, pero se recomienda su uso para mantener la interoperabilidad.
//Algunos ejemplos de claims registrados son "iss" (emisor), "sub" (sujeto), "exp" (fecha de expiraci�n) y "iat" (fecha de emisi�n).

//Claims privados (Private Claims): Son claims definidos por las partes que acuerdan utilizarlos. 
//Estos claims deben ser definidos de manera que no entren en conflicto con los claims registrados.

//Claims p�blicos (Public Claims): Son claims que se definen en est�ndares o son ampliamente utilizados por diferentes aplicaciones. 
//Estos claims deben ser registrados en el IANA (Internet Assigned Numbers Authority) para evitar conflictos.

//Firma (Signature): Es la tercera parte del token JWT y se utiliza para verificar la integridad del token y garantizar que no haya sido modificado durante la transmisi�n.
//La firma se crea utilizando la clave secreta o la clave p�blica/privada seg�n el algoritmo de firma utilizado.

//Generar y firmar un JWT
public string GenerateJwtToken(string secretKey, string userId)
{
    // Crear las claims para incluir en el token
    var claims = new[]
    {
        new Claim(ClaimTypes.NameIdentifier, userId)
        // Aqu� puedes agregar m�s claims seg�n tus necesidades, como roles, permisos, etc.
    };

    // Generar la clave secreta a partir del secretKey proporcionado
    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

    // Crear las credenciales de firma utilizando el algoritmo HmacSha256
    var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

    // Crear el token JWT
    var token = new JwtSecurityToken(
        issuer: "your_issuer",         // Qui�n emite el token
        audience: "your_audience",     // Qui�n puede utilizar el token
        claims: claims,                // Claims incluidas en el token
        expires: DateTime.UtcNow.AddHours(1), // Fecha y hora de expiraci�n del token
        signingCredentials: credentials  // Credenciales de firma
    );

    // Serializar el token a una cadena JWT
    var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

    return tokenString;
}

// Validar y decodificar un JWT
public ClaimsPrincipal ValidateAndDecodeJwtToken(string secretKey, string tokenString)
{
    try
    {
        // Validar y decodificar el token JWT utilizando la clave secreta
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var parameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = key,
            ValidateIssuer = true,
            ValidIssuer = "your_issuer",
            ValidateAudience = true,
            ValidAudience = "your_audience",
            ClockSkew = TimeSpan.Zero
        };

        // Obtener los claims del token
        var claimsPrincipal = tokenHandler.ValidateToken(tokenString, parameters, out var validatedToken);
        return claimsPrincipal;
    }
    catch (Exception ex)
    {
        // Manejar cualquier error en la validaci�n del token
        // Puedes registrar el error, lanzar una excepci�n o realizar alguna otra acci�n apropiada
        Console.WriteLine("Error al validar el token: " + ex.Message);
        return null;
    }
}