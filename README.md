# RSA-Public-Key-Cryptosystem

Cryptosystem mean encoding and decoding confidential messages.

RSA is a public key cryptosystem algorithm. Public key cryptosystem requires two separate keys,
one of which is secret (or private) and one of which is public. 
Although different, the two parts of this key pair are mathematically linked. 
The public key is used to encrypt plaintext; whereas the private key is used to decrypt cipher text. 
Only the one having the private key can decrypt the cipher text and get the original message.

 The RSA (Rivest-Shamir-Adleman) cryptosystem is widely used for secure communication in browsers,
 bank ATM machines, credit card machines, mobile phones, smart cards, and the Windows operating system.
 It works by manipulating integers. To prevent listeners, the RSA cryptosystem must manipulate huge integers (hundreds of digits). 
 The built-in C type int is only capable of dealing with 16 or 32 bit integers, providing little or no security.
 
 So, we  Design, implement, and analyze an extended precision arithmetic data type (big integer),
 that is capable of manipulating much larger integers. 
