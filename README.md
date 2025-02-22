    ----------ENG--------
    Caesar and Affine Ciphers:
The Caesar Cipher is one of the oldest encryption methods and works by shifting each letter of the plaintext by a certain number.
For instance, if the letters are shifted 3 positions to the right, 'A' becomes 'D'.
This method is very simple, and to decrypt the message, you need the same shift value (key).
It typically works with alphabetical letters and is commonly used for small text encryption.
The Affine Cipher is a more complex encryption method that uses two keys: a and b. The encryption formula works as follows:
E(x)=(a×x+b)mod26
Here, x is the numerical value of the letter, and a and b are the keys.
This method encrypts letters in a more complicated way, making it a more secure alternative.
However, the a key must be coprime with 26; otherwise, encryption cannot be performed.
Decryption is similar but requires the modular inverse of a.

Both ciphers rely on basic arithmetic and modular mathematics. While the Caesar Cipher is straightforward, the Affine Cipher is more robust and secure because the encryption process involves more complex mathematical operations. This is why the Affine Cipher is preferred for larger texts and more secure communications.
    ----------TR---------
Sezar Şifrelemesi, en eski şifreleme yöntemlerinden biridir ve şifreleme, her harfi belirli bir sayı kadar kaydırarak yapılır.
Örneğin, harfler 3 pozisyon sağa kaydırılacaksa, 'A' harfi 'D' olur. Bu yöntem çok basittir ve şifrelenmiş metni çözmek için aynı kaydırma değeri (anahtar) gereklidir.
Sezar şifrelemesi, sadece alfabetik harflerle çalışır ve genellikle küçük metinler için kullanılır.
Affine Şifrelemesi, daha karmaşık bir şifreleme yöntemidir ve iki anahtar kullanır: a ve b. Şifreleme formülü şu şekilde çalışır:
E(x)=(a×x+b)mod26
Burada, x harfin sayısal değeri, a ve b ise anahtarlardır.
Bu yöntem, harfleri daha karmaşık bir şekilde şifreler, bu nedenle daha güvenli bir alternatiftir. 
Ancak, a değeri, 26 ile asal olmalıdır, yoksa şifreleme yapılmaz. Şifre çözme işlemi de benzer şekilde yapılır,ancak a anahtarının modüler tersi gereklidir.
Her iki şifreleme yöntemi de temel aritmetik ve modüler matematik kullanır. Sezar şifrelemesi basitken, 
Affine şifrelemesi daha güçlü ve güvenilirdir, çünkü şifreleme işlemi daha karmaşık matematiksel hesaplamalarla yapılır.
Bu yüzden Affine şifrelemesi daha büyük metinler ve daha güvenli iletişimler için tercih edilir.
